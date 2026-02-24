using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.Application.Servicios.Inventario;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Domain.Inventario;

namespace boutiqueshope.UI.Inventario
{
    public partial class AjusteInventarioUI : Form
    {
        private VariacionProductoService _productoVariacion;
        private AlmacenService _almacenService;
        private InventariosServices _inventarioService;
        private AjusteInventarioService _ajusteInventarioService;
        private Producto _productoSearch;
        private BindingList<ProductoVariacion> listaVariaciones;

        public AjusteInventarioUI()
        {
            InitializeComponent();
            _productoVariacion = new VariacionProductoService();
            listaVariaciones = new BindingList<ProductoVariacion>();

            _almacenService = new AlmacenService();
            _inventarioService = new InventariosServices();
            _ajusteInventarioService = new AjusteInventarioService();

            _productoSearch = new Producto();
        }

        private void AjusteInventarioUI_Load(object sender, EventArgs e)
        {
            CargarComboBodega();
        }

        private async void CargarComboBodega()
        {
            var respMarca = await _almacenService.ListarAsync();
            if (respMarca != null && respMarca.Exitoso)
            {
                comboBoxAlmacen.DisplayMember = "Nombre";
                comboBoxAlmacen.ValueMember = "Id";
                comboBoxAlmacen.DataSource = respMarca.Listado;
            }
        }


        private async void cargarVariaciones(int idProducto)
        {
            var respuesta = await _productoVariacion.ObtenerPorIdProductoAsync(idProducto);

            if (!respuesta.Exitoso || respuesta.Listado == null || respuesta.Listado.Count == 0)
            {
                lblInformacion.Text = "No hay variaciones registradas para el producto seleccionado.";
                dataGridViewVariacion.DataSource = null;
                return;
            }

            lblInformacion.Text = $"Existen {respuesta.Listado.Count} registros de variaciones.";

            dataGridViewVariacion.AutoGenerateColumns = false;
            listaVariaciones = new BindingList<ProductoVariacion>(respuesta.Listado);
            dataGridViewVariacion.DataSource = listaVariaciones;
            dataGridViewVariacion.ClearSelection();
            dataGridViewVariacion.CurrentCell = null;
        }

        private void limpiarGridVariacion()
        {
            dataGridViewVariacion.DataSource = null;
            dataGridViewVariacion.ClearSelection();
            dataGridViewVariacion.CurrentCell = null;
            listaVariaciones.Clear();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SearchProductUI formSearch = new SearchProductUI();
            formSearch.SearchProduct += (productoRecibido) =>
            {
                txtProducto.Text = productoRecibido.Nombre.Trim();
                _productoSearch = productoRecibido;
                limpiarGridVariacion();
                cargarVariaciones(_productoSearch.Id);
            };
            formSearch.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {|
            txtProducto.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            lblCostoPromedio.Text = "0.00";
            lblInformacion.Text = string.Empty;
            lblStockActual.Text = "0";
            limpiarGridVariacion();
        }

        private int ObtenerALmacenComboBox()
        {
            if (comboBoxAlmacen.SelectedItem == null)
            {
                return 0;
            }
            var almacenSeleccionado = (Almacen)comboBoxAlmacen.SelectedItem;
            return almacenSeleccionado.Id;
            
        }

        private string ObtenerTipoMovimiento()
        {
            if (radioButtonEntrada.Checked)
            {
                return "entrada";
            }
            else if (radioButtonSalida.Checked)
            {
                return "salida";
            }
            else
            {
                return string.Empty;
            }
        }

        private int ObtenerIdVariacionSeleccionada()
        {
            if (dataGridViewVariacion.CurrentRow == null && dataGridViewVariacion.SelectedRows.Count <= 0)
            {
                return 0;
            }
            var variacionSeleccionada = (ProductoVariacion)dataGridViewVariacion.CurrentRow.DataBoundItem;
            return variacionSeleccionada.Id;
        }

        private string ObtenerTipoDocumento()
        {
            if (comboBoxTipoAjuste.SelectedItem != null)
            {

                string seleccionAjuste = comboBoxTipoAjuste.SelectedItem.ToString();
                return seleccionAjuste.ToLower().Replace(" ", "_");
            }
            return string.Empty;
        }

        private AjusteInventario ObtenerAjusteInventario()
        {
            AjusteInventario ajuste = new AjusteInventario
            {
                ProductoId = _productoSearch.Id,
                VariacionId = ObtenerIdVariacionSeleccionada(),
                AlmacenId = ObtenerALmacenComboBox(),
                DocumentoTipo =  ObtenerTipoDocumento(),
                TipoMovimiento = ObtenerTipoMovimiento(),
                Cantidad = Convert.ToInt32(numericCantidad.Value),
                CostoUnitario = Convert.ToInt32(numericCostoUnitario.Value),
                Motivo = txtMotivo.Text,
                idUsuario = 1
            };

            return ajuste;
        }

        private async Task GetInventarioForIds()
        {
            if (_productoSearch.Id == 0 || ObtenerALmacenComboBox() == 0 || ObtenerIdVariacionSeleccionada() == 0)
            {
                return;
            }

            var respuesta = await _inventarioService.GetInventarioForIds(
                _productoSearch.Id,
                ObtenerALmacenComboBox(),
                ObtenerIdVariacionSeleccionada()
            );

            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarError("Error al consultar el inventario: " + respuesta.Mensaje);
                return;
            }

            lblCostoPromedio.Text = respuesta.Data.CostoPromedio.ToString("N2");
            lblStockActual.Text = respuesta.Data.stockActual.ToString();
        }

        private async void callGetInventarioForIds()
        {
            await GetInventarioForIds();
        }
        private void btnGuardarAjuste_Click(object sender, EventArgs e)
        {
            GuardarAjusteDataBase();
            
        }

        private async void GuardarAjusteDataBase()
        {
            var respuesta = await _ajusteInventarioService.RealizarAjusteAsync(ObtenerAjusteInventario());
            if (respuesta.Exitoso)
            {
                UIHelper.MostrarExito(respuesta.Mensaje);
                callGetInventarioForIds();
            }
            else
            {
                UIHelper.MostrarError("Error al registrar el ajuste: " + respuesta.Mensaje);
            }
        }

        private void dataGridViewVariacion_SelectionChanged(object sender, EventArgs e)
        {
            callGetInventarioForIds();
        }

        private async void comboBoxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetInventarioForIds();
        }

        private async void txtProducto_TextChanged(object sender, EventArgs e)
        {
            await GetInventarioForIds();
        }
    }
}
