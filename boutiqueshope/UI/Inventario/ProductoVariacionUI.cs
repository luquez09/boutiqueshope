using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using boutiqueshope.UI.Inventario;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class ProductoVariacionUI : Form
    {
        private VariacionProductoService _productoVariacion;
        private TallasServicios _tallasServicios;
        private ColoresServicios _coloresServicios;

        private BindingList<ProductoVariacion> listaVariaciones;

        private Producto _productoSearch;
        public ProductoVariacionUI()
        {
            _productoVariacion = new VariacionProductoService();
            _tallasServicios = new TallasServicios();
            _coloresServicios = new ColoresServicios();
            listaVariaciones = new BindingList<ProductoVariacion>();
            _productoSearch = new Producto();
            InitializeComponent();
        }

        #region Gestion de procesos del producto.
        private async void ProductoVariacionUI_Load(object sender, EventArgs e)
        {
            await CargarTallas();
            await CargarColores();
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

        private void LimpiarGridVariacion()
        {
            dataGridViewVariacion.ClearSelection();
            dataGridViewVariacion.DataSource = null;
            dataGridViewVariacion.CurrentCell = null;

            listaVariaciones.Clear();
            lblCodigoSku.Text = "- - - - - - - - -";
            lblPrecioVenta.Text = "- - - - - - - - -";
            lblCosto.Text = "- - - - - - - - -";
            lblCodigoBarra.Text = "- - - - - - - - -";
            lblFechaCreacion.Text = "- - - - - - - - -";
            lblIva.Text = "- - - - - - - - -";
            txtProductoNombre.Text = string.Empty;
            LimpiarCheckBox(checkedListBoxTallas);
            LimpiarCheckBox(checkedListBoxColores);
        }

        private void LimpiarCheckBox(CheckedListBox checkedListBox)
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
                if (_productoSearch is null)
                {
                    lblInformacion.Text = "No se ha seleccionado algún producto.";
                    dataGridViewVariacion.DataSource = null;
                    return;
                }

                dataGridViewVariacion.AutoGenerateColumns = false;

                var respuesta = await _productoVariacion.ObtenerPorIdProductoAsync(_productoSearch.Id);

                if (!respuesta.Exitoso || respuesta.Listado == null || respuesta.Listado.Count == 0)
                {
                    lblInformacion.Text = "No hay variaciones registradas.";
                    dataGridViewVariacion.DataSource = null;
                    return;
                }

                lblInformacion.Text = $"Existen {respuesta.Listado.Count} registros de variaciones.";
                listaVariaciones = new BindingList<ProductoVariacion>(respuesta.Listado);
                dataGridViewVariacion.DataSource = listaVariaciones;

                dataGridViewVariacion.ClearSelection();
                if (dataGridViewVariacion.CurrentCell != null)
                    dataGridViewVariacion.CurrentCell = null;
            }
            catch (Exception ex)
            {
                lblInformacion.Text = "Error al cargar datos: " + ex.Message;
            }
            finally
            {
                dataGridViewVariacion.SelectionChanged += dataGridViewVariacion_SelectionChanged;
            }
        }


        private void CargarDatosFilaSeleccionada(DataGridViewRow row)
        {
            lblFechaCreacion.Text = row.Cells["FechaCreacion"].Value?.ToString();
            lblCodigoBarra.Text = row.Cells["CodigoBarras"].Value?.ToString();
            lblCodigoSku.Text = row.Cells["CodigoSku"].Value?.ToString();
            lblPrecioVenta.Text = row.Cells["PrecioVenta"].Value?.ToString();
            lblCosto.Text = row.Cells["Costo"].Value?.ToString();
            lblIva.Text = row.Cells["Impuesto"].Value?.ToString();
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
            string unico = DateTime.Now.ToString("ssfff");
            return $"{codigoProducto}-{talla}-{color}-{unico}".ToUpper();
        }

        public string GenerarCodigoBarras(int productoId, string talla, string color)
        {
            string raw = $"{productoId:D6}{talla.ToUpperInvariant()}{color.ToUpperInvariant()}";
            string numeric = ConvertToNumericHash(raw);
            string base12 = numeric.Substring(0, 12);
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

        private void CrearVariacionProducto()
        {
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
                    ProductoId = _productoSearch.Id,
                    Talla = talla,
                    Color = color,
                    CodigoSku = GenerarCodigoSKU(_productoSearch.CodigoSku, talla, color),
                    CodigoBarras = GenerarCodigoBarras(_productoSearch.Id, talla, color),
                    PrecioVenta = 0.00m,
                    Costo = 0.00m,
                    Activo = true,
                    FechaCreacion = DateTime.Now,
                    Impuesto = 0
                };

            foreach (var variacion in nuevasVariaciones)
            {
                listaVariaciones.Add(variacion);
            }

            dataGridViewVariacion.ClearSelection();
            dataGridViewVariacion.CurrentCell = null;
            listaVariaciones = new BindingList<ProductoVariacion>(listaVariaciones);
            dataGridViewVariacion.DataSource = listaVariaciones;
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
            CrearVariacionProducto();
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

            if ((col == "PrecioVenta" || col == "Costo" || col == "Activo" || col == "Impuesto") &&
                (id > 0))
            {
                dataGridViewVariacion.Rows[e.RowIndex].Cells["modificado"].Value = "1";
                dataGridViewVariacion.Rows[e.RowIndex].DefaultCellStyle.BackColor = colorUpdate;
                CargarDatosFilaSeleccionada(dataGridViewVariacion.CurrentRow);
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
                Activo = Convert.ToBoolean(row.Cells["Activo"].Value),
                Impuesto = Convert.ToInt32(row.Cells["Impuesto"].Value)
            };
        }

        #endregion
        private async void btnGestionarProducto_Click(object sender, EventArgs e)
        {
            List<ProductoVariacion> listUpdate = ObtenerVariacionesModificadas();
            if (listUpdate.Count > 0)
            {
                var respuesta = await _productoVariacion.SaveVariacionesAsync(listUpdate);
                UIHelper.MostrarRespuesta(respuesta);
                if (respuesta.Exitoso) LimpiarFormulario();
            }
            else
            {
                UIHelper.MostrarAdvertencia("No hay cambios para guardar.");
            }
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
            dataGridViewVariacion.CurrentCell = null;
            dataGridViewVariacion.ClearSelection();
            LimpiarCheckBox(checkedListBoxTallas);
            LimpiarCheckBox(checkedListBoxColores);
            LimpiarGridVariacion();
        }

        private async Task EliminarVariacionDataBase(int rowIndex)
        {
            var fila = dataGridViewVariacion.CurrentRow;
            if (fila == null) return;
            int idVariacion = Convert.ToInt32(fila.Cells["Id"].Value);
            if (idVariacion <= 0) return;
            var confirmar = UIHelper.Confirmar("¿ Esta seguro de eliminar la variación del producto ?");
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

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SearchProductUI formSearch = new SearchProductUI();
            formSearch.SearchProduct += (productoRecibido) =>
            {
                txtProductoNombre.Text = productoRecibido.Nombre.Trim();
                _productoSearch = productoRecibido;
                cargarVariaciones();
            };
            formSearch.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private async void dataGridViewVariacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewVariacion.Columns[e.ColumnIndex].Name == "btnEliminar")
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
        }
    }
}
