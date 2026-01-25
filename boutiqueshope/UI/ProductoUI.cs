using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class ProductoUI : Form
    {
        private ProductoService _productoService;
        private ProveedorService _proveedorService;
        private CategoriaService _categoria_service;
        private MarcaService _marcaService;

        public ProductoUI()
        {
            _productoService = new ProductoService();
            _proveedorService = new ProveedorService();
            _categoria_service = new CategoriaService();
            _marcaService = new MarcaService();

            InitializeComponent();
        }

        private async void ProductoUI_Load_1(object sender, EventArgs e)
        {
            await CargarProductosAsync();
            await CargarCombosAsync();
            CleanProductoForm();

        }

        private async Task CargarCombosAsync()
        {
            try
            {
                var respProv = await _proveedorService.ListarAsync();
                if (respProv != null && respProv.Exitoso)
                {
                    comboBoxProveedor.DisplayMember = "Nombre";
                    comboBoxProveedor.ValueMember = "Id";
                    comboBoxProveedor.DataSource = respProv.Listado;
                }

                var respCat = await _categoria_service.ListarAsync();
                if (respCat != null && respCat.Exitoso)
                {
                    comboBoxCategoria.DisplayMember = "Nombre";
                    comboBoxCategoria.ValueMember = "Id";
                    comboBoxCategoria.DataSource = respCat.Listado;
                }

                var respMarca = await _marcaService.ListarAsync();
                if (respMarca != null && respMarca.Exitoso)
                {
                    comboBoxMarca.DisplayMember = "Nombre";
                    comboBoxMarca.ValueMember = "Id";
                    comboBoxMarca.DataSource = respMarca.Listado;
                }
            }
            catch
            {
                UIHelper.MostrarError("Error al cargar los datos de los combos.");
            }
        }

        // -------------------------------
        // Lógica existente para mapear y DataGrid
        // -------------------------------

        private Producto MapearProducto()
        {
            int.TryParse(lblProductoId.Text, out var id);

            int proveedorId = ObtenerIdDesdeCombo(comboBoxProveedor);
            int categoriaId = ObtenerIdDesdeCombo(comboBoxCategoria);
            int marcaId = ObtenerIdDesdeCombo(comboBoxMarca);

            return new Producto
            {
                Id = id,
                Nombre = txtNombreProducto.Text?.Trim(),
                Descripcion = txtDescripcionProducto.Text?.Trim(),
                ProveedorId = proveedorId > 0 ? (int?)proveedorId : null,
                CategoriaId = categoriaId,
                MarcaId = marcaId > 0 ? (int?)marcaId : null,
                Activo = checkBoxActive.Checked,
                codigoSku = txtCodigoProducto.Text?.Trim()
            };
        }

        private int ObtenerIdDesdeCombo(ComboBox cb)
        {
            if (cb == null) return 0;

            if (cb.SelectedValue != null && int.TryParse(cb.SelectedValue.ToString(), out var val))
                return val;

            var item = cb.SelectedItem;
            if (item != null)
            {
                var prop = item.GetType().GetProperty("Id");
                if (prop != null)
                {
                    var v = prop.GetValue(item);
                    if (v != null && int.TryParse(v.ToString(), out val))
                        return val;
                }
            }

            return 0;
        }

        private void ConfigurarColumnasProductos()
        {
            if (dataGridViewProductos.Columns.Count == 0) return;

            dataGridViewProductos.Columns["Id"].HeaderText = "Id";
            dataGridViewProductos.Columns["Id"].Visible = false;
            dataGridViewProductos.Columns["Costo"].Visible = false;
            dataGridViewProductos.Columns["PorcentajeGanancia"].Visible = false;
            dataGridViewProductos.Columns["PrecioVenta"].Visible = false;
            dataGridViewProductos.Columns["StockMinimo"].Visible = false;
            dataGridViewProductos.Columns["ProveedorId"].Visible = false;
            dataGridViewProductos.Columns["MarcaId"].Visible = false;
            dataGridViewProductos.Columns["CategoriaId"].Visible = false;
            dataGridViewProductos.Columns["CodigoBarras"].Visible = false;
            dataGridViewProductos.Columns["CodigoQr"].Visible = false;
            dataGridViewProductos.Columns["Nombre"].HeaderText = "Nombre";
            dataGridViewProductos.Columns["Descripcion"].HeaderText = "Descripción";
            dataGridViewProductos.Columns["Activo"].HeaderText = "Activo";
            dataGridViewProductos.Columns["FechaCreacion"].HeaderText = "Creado el";
            dataGridViewProductos.Columns["CodigoSku"].HeaderText = "Codigo";
            dataGridViewProductos.Columns["FechaCreacion"].Visible = false;
        }

        private async Task CargarProductosAsync()
        {
            var respuesta = await _productoService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarRespuesta(respuesta);
                return;
            }

            dataGridViewProductos.DataSource = respuesta.Listado;
            dataGridViewProductos.CurrentCell = null;
            dataGridViewProductos.ClearSelection();
            ConfigurarColumnasProductos();
            CleanProductoForm();
        }

        private void CargarDatosDesdeGridProducto()
        {
            Console.WriteLine("CargarDatosDesdeGridProducto called");

            if (dataGridViewProductos == null) return;

            DataGridViewRow fila = null;

            if (dataGridViewProductos.SelectedRows != null && dataGridViewProductos.SelectedRows.Count > 0)
            {
                fila = dataGridViewProductos.SelectedRows[0];
            }
            else if (dataGridViewProductos.CurrentRow != null)
            {
                fila = dataGridViewProductos.CurrentRow;
            }
            else if (dataGridViewProductos.CurrentCell != null)
            {
                var idx = dataGridViewProductos.CurrentCell.RowIndex;
                if (idx >= 0 && idx < dataGridViewProductos.Rows.Count)
                    fila = dataGridViewProductos.Rows[idx];
            }

            if (fila == null) return;

            object val;

            val = fila.Cells["Id"].Value;
            lblProductoId.Text = val != null && val != DBNull.Value ? val.ToString() : string.Empty;

            val = fila.Cells["Nombre"].Value;
            txtNombreProducto.Text = val != null && val != DBNull.Value ? val.ToString() : string.Empty;

            val = fila.Cells["Descripcion"].Value;
            txtDescripcionProducto.Text = val != null && val != DBNull.Value ? val.ToString() : string.Empty;

            val = fila.Cells["CodigoSku"].Value;
            txtCodigoProducto.Text = val != null && val != DBNull.Value ? val.ToString() : string.Empty;

            val = fila.Cells["Activo"].Value;
            checkBoxActive.Checked = val != null && val != DBNull.Value && Convert.ToBoolean(val);

            val = fila.Cells["FechaCreacion"].Value;
            lblCreadoFecha.Text = val != null && val != DBNull.Value ? Convert.ToDateTime(val).ToString("g") : "-/-/-";

            var respVal = fila.Cells["ProveedorId"].Value;
            if (respVal != null && respVal != DBNull.Value && int.TryParse(respVal.ToString(), out var provId))
                SeleccionarValorEnCombo(comboBoxProveedor, provId);
            else
                comboBoxProveedor.SelectedIndex = -1;

            var respMarc = fila.Cells["MarcaId"].Value;
            if (respMarc != null && respMarc != DBNull.Value && int.TryParse(respMarc.ToString(), out var marcId))
                SeleccionarValorEnCombo(comboBoxMarca, marcId);
            else
                comboBoxMarca.SelectedIndex = -1;

            var respCate = fila.Cells["CategoriaId"].Value;
            if (respCate != null && respCate != DBNull.Value && int.TryParse(respCate.ToString(), out var cateId))
                SeleccionarValorEnCombo(comboBoxCategoria, cateId);
            else
                comboBoxCategoria.SelectedIndex = -1;
        }

        private void SeleccionarValorEnCombo(ComboBox cb, int id)
        {
            if (cb == null) return;

            if (cb.Items.Count == 0) return;

            for (int i = 0; i < cb.Items.Count; i++)
            {
                var item = cb.Items[i];
                var prop = item.GetType().GetProperty("Id");
                if (prop != null)
                {
                    var v = prop.GetValue(item);
                    if (v != null && int.TryParse(v.ToString(), out var val) && val == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
                else
                {
                    if (cb.Items[i].ToString() == id.ToString())
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            }

            cb.SelectedIndex = -1;
        }

        public async Task<bool> EliminarProductoSeleccionadoAsync()
        {
            if (string.IsNullOrWhiteSpace(lblProductoId.Text) ||
                !int.TryParse(lblProductoId.Text, out var id) ||
                id <= 0)
            {
                UIHelper.MostrarError("Seleccione un producto válido para eliminar.");
                return false;
            }

            if (!UIHelper.Confirmar("¿Seguro de eliminar este producto?")) return false;

            var response = await _productoService.EliminarAsync(id);
            UIHelper.MostrarRespuesta(response);

            if (response != null && response.Exitoso)
            {
                await CargarProductosAsync();
                CleanProductoForm();
                return true;
            }

            return false;
        }

        private void CleanProductoForm()
        {
            lblProductoId.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtDescripcionProducto.Text = string.Empty;
            checkBoxActive.Checked = false;
            lblCreadoFecha.Text = "-/-/-";
            txtNombreProducto.Focus();
        }

        private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var producto = MapearProducto();
                producto.Id = 0;

                var response = await _productoService.CrearAsync(producto);
                UIHelper.MostrarRespuesta(response);
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al agregar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var producto = MapearProducto();
                if (producto.Id <= 0)
                {
                    UIHelper.MostrarError("Seleccione un producto válido para actualizar.");
                    return;
                }

                var response = await _productoService.EditarAsync(producto);
                UIHelper.MostrarRespuesta(response);
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError($"Error inesperado al actualizar: {ex.Message}");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await EliminarProductoSeleccionadoAsync();
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosDesdeGridProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanProductoForm();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNombreProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                txtCodigoProducto.Text = string.Empty;
                return;
            }

            // Dividir por espacios, ignorando vacíos
            string[] palabras = texto
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            string codigo = string.Concat(
                palabras.Select(p => p[0].ToString().ToUpper())
            );

            txtCodigoProducto.Text = codigo;
        }
    }
}
