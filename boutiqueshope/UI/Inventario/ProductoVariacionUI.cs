using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class ProductoVariacionUI : Form
    {
        private ProductoService _productoService;
        private VariacionProductoService _productoVariacion;
        private TallasServicios _tallasServicios;
        private ColoresServicios _coloresServicios;


        private BindingList<ProductoVariacion> listaVariaciones;
        private BindingList<Producto> _listProductos;
        public ProductoVariacionUI()
        {
            _productoService = new ProductoService();
            _productoVariacion = new VariacionProductoService();
            _tallasServicios = new TallasServicios();
            _coloresServicios = new ColoresServicios();
            listaVariaciones = new BindingList<ProductoVariacion>();

            InitializeComponent();
            configurationDataGridViewProducto();
        }

        #region Gestion de procesos del producto.
        private void configurationDataGridViewProducto()
        {
            dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducto.MultiSelect = false;
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.AllowUserToAddRows = false;
            dataGridViewProducto.AllowUserToDeleteRows = false;
            dataGridViewProducto.AllowUserToResizeRows = false;
            dataGridViewProducto.AutoGenerateColumns = false;
        }
        private async void ProductoVariacionUI_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
            await CargarTallas();
            await CargarColores();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            searchProducto();
        }

        private void txtCodigoSku_TextChanged(object sender, EventArgs e)
        {
            searchProducto();
        }

        private async Task CargarTallas()
        {
            var respuesta = await _tallasServicios.listarAsync();
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarRespuesta(respuesta);
                return;
            }
            checkedListBoxTallas.Items.Clear();
            foreach (var talla in respuesta.Listado)
            {
                checkedListBoxTallas.Items.Add(talla.Nombre);
            }
        }

        private async Task CargarColores()
        {
            var respuesta = await _coloresServicios.listarAsync();
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarRespuesta(respuesta);
                return;
            }
            checkedListBoxColores.Items.Clear();
            foreach (var color in respuesta.Listado)
            {
                checkedListBoxColores.Items.Add(color.Nombre);
            }
        }

        private async Task CargarProductosAsync()
        {
            var respuesta = await _productoService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarRespuesta(respuesta);
                return;
            }

            dataGridViewProducto.AutoGenerateColumns = true;
            _listProductos = new BindingList<Producto>(respuesta.Listado);
            dataGridViewProducto.DataSource = _listProductos;
            dataGridViewProducto.ClearSelection();
        }

        private void searchProducto()
        {
            string criterioProducto = txtProducto.Text.Trim().ToLower();
            string criterioCodigo = txtCodigoSku.Text.Trim().ToLower();

            bool buscarPorNombre = !string.IsNullOrWhiteSpace(criterioProducto);
            bool buscarPorCodigo = !string.IsNullOrWhiteSpace(criterioCodigo);

            var searchProducto = _listProductos.Where(p =>
                (!buscarPorNombre || p.Nombre.ToLower().Contains(criterioProducto)) &&
                (!buscarPorCodigo || p.CodigoSku.ToLower().Contains(criterioCodigo))
            ).ToList();

            dataGridViewProducto.DataSource = null;
            dataGridViewProducto.DataSource = new BindingSource { DataSource = searchProducto };
            dataGridViewProducto.ClearSelection();
        }

        private void SeleccionProductoDataGrid()
        {
            var grid = dataGridViewProducto;
            if (grid?.CurrentRow == null) return;

            var fila = grid.CurrentRow;

            lblProductoId.Text = ObtenerValor(fila, "Id");
            lblCodProdut.Text = ObtenerValor(fila, "CodigoSku");
        }

        private string ObtenerValor(DataGridViewRow fila, string columna)
        {
            if (!fila.DataGridView.Columns.Contains(columna))
                return string.Empty;

            var val = fila.Cells[columna].Value;
            return val == null || val == DBNull.Value ? string.Empty : val.ToString();
        }
        private void dataGridViewProducto_SelectionChanged(object sender, EventArgs e)
        {
            SeleccionProductoDataGrid();
            limpiarGridVariacion();
            cargarVariaciones();
        }

        private void limpiarGridVariacion()
        {
            dataGridViewVariacion.DataSource = null;
            dataGridViewVariacion.ClearSelection();
            dataGridViewVariacion.CurrentCell = null;

            listaVariaciones.Clear();
            lblCodigoSku.Text = "--";
            lblPrecioVenta.Text = "--";
            lblCosto.Text = "--";
            lblCodigoBarra.Text = "--";
            lblFechaCreacion.Text = "--";
            limpiarCheckBox(checkedListBoxTallas);
            limpiarCheckBox(checkedListBoxColores);
        }

        private void limpiarCheckBox(CheckedListBox checkedListBox)
        {
            checkedListBox.ClearSelected();

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        #endregion

        #region Gestion de procesos de variaciones del producto.

        private async void cargarVariaciones()
        {
            dataGridViewVariacion.SelectionChanged -= dataGridViewVariacion_SelectionChanged;

            try
            {
                if (!int.TryParse(lblProductoId.Text, out int idProducto) || idProducto <= 0)
                {
                    lblInformacion.Text = "Seleccione un producto válido.";
                    dataGridViewVariacion.DataSource = null;
                    return;
                }

                var respuesta = await _productoVariacion.ObtenerPorIdProductoAsync(idProducto);

                if (!respuesta.Exitoso || respuesta.Listado == null || respuesta.Listado.Count == 0)
                {
                    lblInformacion.Text = "No hay variaciones registradas para el producto seleccionado.";
                    dataGridViewVariacion.DataSource = null;
                    return;
                }

                lblInformacion.Text = $"Existen {respuesta.Listado.Count} registros de variaciones.";

                listaVariaciones = new BindingList<ProductoVariacion>(respuesta.Listado);
                dataGridViewVariacion.DataSource = listaVariaciones;

                configurarDatagridVariacion();
                dataGridViewVariacion.ClearSelection();
                dataGridViewVariacion.CurrentCell = null;
            }
            finally
            {
                dataGridViewVariacion.SelectionChanged += dataGridViewVariacion_SelectionChanged;
            }
        }

        private void configurarDatagridVariacion()
        {
            if (dataGridViewVariacion.Columns.Count == 0) return;

            dataGridViewVariacion.Columns["Id"].Visible = false;
            dataGridViewVariacion.Columns["ProductoId"].Visible = false;
            dataGridViewVariacion.Columns["FechaCreacion"].Visible = false;
            dataGridViewVariacion.Columns["CodigoBarras"].Visible = false;
            dataGridViewVariacion.Columns["CodigoSku"].Visible = false;


            dataGridViewVariacion.Columns["ProductoId"].HeaderText = "Producto Id";
            dataGridViewVariacion.Columns["FechaCreacion"].HeaderText = "Fecha registrado";
            dataGridViewVariacion.Columns["CodigoBarras"].HeaderText = "Cod. Barra";
            dataGridViewVariacion.Columns["CodigoSku"].HeaderText = "Cod. Sku";
            dataGridViewVariacion.Columns["Talla"].HeaderText = "Talla";
            dataGridViewVariacion.Columns["Color"].HeaderText = "Color";
            dataGridViewVariacion.Columns["PrecioVenta"].HeaderText = "Precio de Venta";
            dataGridViewVariacion.Columns["Costo"].HeaderText = "Costo";
            dataGridViewVariacion.Columns["Activo"].HeaderText = "Activo";

            //No editables
            dataGridViewVariacion.Columns["Talla"].ReadOnly = true;
            dataGridViewVariacion.Columns["Color"].ReadOnly = true;

            //Evita filas manuelas.
            dataGridViewVariacion.AllowUserToAddRows = false;
            dataGridViewVariacion.AllowUserToDeleteRows = false;
            dataGridViewVariacion.AllowUserToResizeRows = false;

            dataGridViewVariacion.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            dataGridViewVariacion.Columns["Costo"].DefaultCellStyle.Format = "N2";

        }

        private void CargarDatosFilaSeleccionada(DataGridViewRow row)
        {
            lblProductoId.Text = row.Cells["ProductoId"].Value?.ToString();
            lblFechaCreacion.Text = row.Cells["FechaCreacion"].Value?.ToString();
            lblCodigoBarra.Text = row.Cells["CodigoBarras"].Value?.ToString();
            lblCodigoSku.Text = row.Cells["CodigoSku"].Value?.ToString();
            lblPrecioVenta.Text = row.Cells["PrecioVenta"].Value?.ToString();
            lblCosto.Text = row.Cells["Costo"].Value?.ToString();
        }


        private void dataGridViewVariacion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewVariacion.CurrentCell.ColumnIndex == dataGridViewVariacion.Columns["PrecioVenta"].Index ||
                dataGridViewVariacion.CurrentCell.ColumnIndex == dataGridViewVariacion.Columns["Costo"].Index)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= InputValidatorHelper.SoloNumeros_KeyPress;
                    txt.KeyPress += InputValidatorHelper.SoloNumeros_KeyPress;
                }
            }

        }

        private List<string> ObtenerCheckListBox(CheckedListBox checkedListBox)
        {
            var itemsSeleccionados = new List<string>();

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    itemsSeleccionados.Add(checkedListBox.Items[i].ToString().ToUpper());
                }
            }

            return itemsSeleccionados;
        }

        private string GenerarCodigoSKU(string codigoProducto, string talla, string color)
        {
            return $"{codigoProducto}-{talla}-{color}".ToUpper();
        }

        public string GenerarCodigoBarras(int productoId, string talla, string color)
        {
            // Crear una cadena base única y estable
            string raw = $"{productoId:D6}{talla.ToUpperInvariant()}{color.ToUpperInvariant()}";

            // Convertir a números usando un hash SHA-256 (estable y sin colisiones prácticas)
            string numeric = ConvertToNumericHash(raw);

            // Tomar los primeros 12 dígitos
            string base12 = numeric.Substring(0, 12);

            // Calcular checksum EAN-13
            int checksum = CalcularChecksumEAN13(base12);

            return base12 + checksum.ToString();
        }

        private string ConvertToNumericHash(string input)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                return string.Concat(hash.Select(b => (b % 10).ToString()));
            }
        }

        private int CalcularChecksumEAN13(string base12)
        {
            int suma = 0;

            for (int i = 0; i < base12.Length; i++)
            {
                int digito = int.Parse(base12[i].ToString());
                if ((i % 2) == 1)
                    suma += digito * 3;
                else
                    suma += digito;
            }

            int modulo = suma % 10;
            return modulo == 0 ? 0 : 10 - modulo;
        }

        private void crearVariacionProducto()
        {
            int productoId = int.Parse(lblProductoId.Text);
            string codigoProducto = lblCodigoSku.Text.Trim().ToUpper();

            var tallas = ObtenerCheckListBox(checkedListBoxTallas);
            var colores = ObtenerCheckListBox(checkedListBoxColores);

            if (!tallas.Any() || !colores.Any())
            {
                UIHelper.MostrarAdvertencia("Debe seleccionar al menos una talla y un color para crear variaciones.");
                return;
            }

            if (ExisteVariacion(tallas, colores))
            {
                UIHelper.MostrarAdvertencia("Existen variaciónes con estos valores. Verificar");
                return;
            }

            var nuevasVariaciones =
                from talla in tallas
                from color in colores
                select new ProductoVariacion
                {
                    Id = 0,
                    ProductoId = productoId,
                    Talla = talla,
                    Color = color,
                    CodigoSku = GenerarCodigoSKU(lblCodProdut.Text, talla, color),
                    CodigoBarras = GenerarCodigoBarras(productoId, talla, color),
                    PrecioVenta = 0.00m,
                    Costo = 0.00m,
                    Activo = true
                };

            foreach (var variacion in nuevasVariaciones)
            {
                listaVariaciones.Add(variacion);
            }
            
            dataGridViewVariacion.DataSource = listaVariaciones;
            configurarDatagridVariacion();
        }

        private bool ExisteVariacion(List<string> tallas, List<string> colores)
        {
            var existentes =
                dataGridViewVariacion.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .Select(r => (
                        Talla: r.Cells["Talla"].Value?.ToString().ToUpper(),
                        Color: r.Cells["Color"].Value?.ToString().ToUpper()
                    ))
                    .ToHashSet();

            return tallas
                .SelectMany(t => colores, (t, c) => (Talla: t.ToUpper(), Color: c.ToUpper()))
                .Any(existentes.Contains);
        }


        private void btnAgregarVariacion_Click(object sender, EventArgs e)
        {
            crearVariacionProducto();
            ColorearFilas();
        }

        private void ColorearFilas()
        {
            Color colornNew = ColorTranslator.FromHtml("#8FFADD");
            foreach (DataGridViewRow row in dataGridViewVariacion.Rows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                if (id == 0) row.DefaultCellStyle.BackColor = colornNew;
            }
        }

        private void dataGridViewVariacion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Color colorUpdate = ColorTranslator.FromHtml("#FAEA8F");
            if (e.RowIndex < 0) return;

            string col = dataGridViewVariacion.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dataGridViewVariacion.Rows[e.RowIndex].Cells["Id"].Value);

            if ((col == "PrecioVenta" || col == "Costo" || col == "Activo") &&
                (id > 0))
            {
                dataGridViewVariacion.Rows[e.RowIndex].Cells["modificado"].Value = "1";
                dataGridViewVariacion.Rows[e.RowIndex].DefaultCellStyle.BackColor = colorUpdate;
            }

        }

        private void dataGridViewVariacion_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewVariacion.IsCurrentCellDirty)
            {
                dataGridViewVariacion.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        public List<ProductoVariacion> ObtenerVariacionesModificadas()
        {
            var lista = new List<ProductoVariacion>();

            foreach (DataGridViewRow row in dataGridViewVariacion.Rows)
            {
                if (row.Cells["modificado"].Value?.ToString() == "1" || row.Cells["Id"].Value?.ToString() == "0")
                {
                    lista.Add(MapRowToVariacion(row));
                }
            }

            return lista;
        }

        private ProductoVariacion MapRowToVariacion(DataGridViewRow row)
        {
            return new ProductoVariacion
            {
                Id = Convert.ToInt32(row.Cells["Id"].Value) == 0 ? 0 : Convert.ToInt32(row.Cells["Id"].Value),
                ProductoId = Convert.ToInt32(row.Cells["ProductoId"].Value),
                Talla = row.Cells["Talla"].Value?.ToString(),
                Color = row.Cells["Color"].Value?.ToString(),
                CodigoBarras = row.Cells["CodigoBarras"].Value?.ToString(),
                CodigoSku = row.Cells["CodigoSKU"].Value?.ToString(),
                PrecioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                Costo = Convert.ToDecimal(row.Cells["Costo"].Value),
                Activo = Convert.ToBoolean(row.Cells["Activo"].Value)
            };
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = string.Empty;
            txtCodigoSku.Text = string.Empty;
            lblProductoId.Text = string.Empty;
            txtProducto.Focus();
            dataGridViewProducto.Enabled = false;
        }

      
        #endregion

        private async Task ResponseAction(Response<ProductoVariacion> response)
        {
            UIHelper.MostrarRespuesta(response);
            if (response.Exitoso) LimpiarFormulario();
        }

        private async void btnGestionarProducto_Click(object sender, EventArgs e)
        {
            List<ProductoVariacion> listUpdate = ObtenerVariacionesModificadas();
            if (listUpdate.Count > 0)
            {
                var respuesta = await _productoVariacion.SaveVariacionesAsync(listUpdate);
                await ResponseAction(respuesta);
            }

            limpiarCheckBox(checkedListBoxTallas);
            limpiarCheckBox(checkedListBoxColores);
            limpiarGridVariacion();
            LimpiarFormulario();
        }

        private void dataGridViewVariacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVariacion.CurrentRow != null)
            {
                CargarDatosFilaSeleccionada(dataGridViewVariacion.CurrentRow);
            }
        }
        private void LimpiarFormulario()
        {
            txtProducto.Clear();
            txtCodigoSku.Clear();
            txtProducto.Focus();
            dataGridViewVariacion.CurrentCell = null;
            dataGridViewVariacion.ClearSelection();
            lblProductoId.Text = string.Empty;
            lblInformacion.Text = string.Empty;
        }

        private async void dataGridViewVariacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridViewVariacion.Columns[e.ColumnIndex].Name != "Acciones")
                return;

            dataGridViewVariacion.CellClick -= dataGridViewVariacion_CellClick;

            try
            {
                var fila = dataGridViewVariacion.Rows[e.RowIndex];
                int idVariacion = Convert.ToInt32(fila.Cells["Id"].Value);

                if (idVariacion > 0)
                {
                    await EliminarVariacionDataBase(e.RowIndex);
                }
                else
                {
                    EliminarVariacionDataGrid(e.RowIndex);
                }
            }
            finally
            {
                dataGridViewVariacion.CellClick += dataGridViewVariacion_CellClick;
            }
        }

        private async Task EliminarVariacionDataBase(int rowIndex)
        {
            var fila = dataGridViewVariacion.CurrentRow;
            if (fila == null) return;
            int idVariacion = Convert.ToInt32(fila.Cells["Id"].Value);
            if (idVariacion <= 0) return;
            var confirmar = UIHelper.Confirmar($"¿ Esta seguro de eliminar la variación del producto ?");
            if (!confirmar) return;
            var respuesta = await _productoVariacion.EliminarAsync(idVariacion);
            listaVariaciones.RemoveAt(rowIndex);
            UIHelper.MostrarRespuesta(respuesta);
        }

        private void EliminarVariacionDataGrid(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= listaVariaciones.Count) return;

            var variacion = listaVariaciones[rowIndex];
            var confirmar = UIHelper.Confirmar($"¿ Esta seguro de eliminar la variación ?");

            if (!confirmar) return;

            listaVariaciones.RemoveAt(rowIndex);
        }
    }
}
