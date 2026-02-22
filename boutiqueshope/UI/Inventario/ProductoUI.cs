using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using boutiqueshope.UI.Inventario;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Domain.Inventario;

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
            InitializeComponent();

            _productoService = new ProductoService();
            _proveedorService = new ProveedorService();
            _categoria_service = new CategoriaService();
            _marcaService = new MarcaService();
        }

        private async void ProductoUI_Load_1(object sender, EventArgs e)
        {
            await CargarCombosAsync();
            CleanProductoForm();
            BotonesNoAccion(false);
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
                ProveedorId = proveedorId > 0 ? proveedorId : 0,
                CategoriaId = categoriaId,
                MarcaId = marcaId > 0 ? marcaId : 0,
                Activo = checkBoxActive.Checked,
                CodigoSku = txtCodigoProducto.Text?.Trim(),
                Tipo = comboBoxTipo.Text?.Trim()
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

        private void BotonesNoAccion(bool accion)
        {
            btnAgregar.Enabled = !accion;
            btnActualizar.Visible = accion;
            btnEliminar.Visible = accion;
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
            comboBoxTipo.SelectedIndex = 1;
        }

        private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var producto = MapearProducto();
                producto.Id = 0;

                var response = await _productoService.CrearAsync(producto);
                UIHelper.MostrarRespuesta(response);
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
                BotonesNoAccion(false);
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError($"Error inesperado al actualizar: {ex.Message}");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await EliminarProductoSeleccionadoAsync();
            BotonesNoAccion(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanProductoForm();
            BotonesNoAccion(false);
        }

        private void getNombreSku()
        {
            string nombre = txtNombreProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                txtCodigoProducto.Text = string.Empty;
                return;
            }

            string[] palabras = nombre.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // 1. Prefijo: 3 letras de la primera palabra (ej. CAM para Camisa)
            string prefijo = palabras[0].Length >= 3
                ? palabras[0].Substring(0, 3).ToUpper()
                : palabras[0].ToUpper().PadRight(3, 'X');

            // 2. Sufijo: Iniciales de las demás palabras (ej. BN para Blanco Niño)
            string sufijo = string.Concat(palabras.Skip(1).Select(p => p[0])).ToUpper();

            txtCodigoProducto.Text = $"{prefijo}-{sufijo}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchProductUI formSearch = new SearchProductUI();
            formSearch.SearchProduct += (productoRecibido) =>
            {
                txtNombreProducto.Text = productoRecibido.Nombre.Trim();
                txtDescripcionProducto.Text = productoRecibido.Descripcion.ToString();
                SeleccionarValorEnCombo(comboBoxCategoria, productoRecibido.CategoriaId);
                SeleccionarValorEnCombo(comboBoxMarca, productoRecibido.MarcaId);
                SeleccionarValorEnCombo(comboBoxProveedor, productoRecibido.ProveedorId);
                txtCodigoProducto.Text = productoRecibido.CodigoSku.ToString();
                comboBoxTipo.Text = productoRecibido.Tipo.ToLower().Trim();
                checkBoxActive.Checked = productoRecibido.Activo;
                lblCreadoFecha.Text = productoRecibido.FechaCreacion.ToString();
                txtNombreProducto.Text = productoRecibido.Nombre;
                lblProductoId.Text = productoRecibido.Id.ToString();
                BotonesNoAccion(true);
            };
            formSearch.ShowDialog();
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

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            getNombreSku();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }
    }
}
