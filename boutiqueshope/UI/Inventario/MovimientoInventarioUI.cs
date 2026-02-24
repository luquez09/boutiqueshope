using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.Application.Servicios.Ventas;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Domain.Inventarios;

namespace boutiqueshope.UI.Inventario
{
    public partial class MovimientoInventarioUI : Form
    {
        private AlmacenService _almacenService;
        private VariacionProductoService _variacionProductoService;
        private UsuarioService _usuarioService;
        private Producto _productoSearch;

        private MovimientoInventarioService _movimientoInventarioService;
        public MovimientoInventarioUI()
        {
            InitializeComponent();
            _almacenService = new AlmacenService();
            _variacionProductoService = new VariacionProductoService();
            _usuarioService = new UsuarioService();
            _productoSearch = new Producto();

            _movimientoInventarioService = new MovimientoInventarioService();

            CallInformationComboBox();
        }

        private async void CallInformationComboBox()
        {
            try
            {
                var almacenResult = await _almacenService.ListarAsync();
                var usuarioResult = await _usuarioService.ListarAsync();

                if (almacenResult.Exitoso)
                {
                    comboAlmacen.DataSource = almacenResult.Listado;
                    comboAlmacen.DisplayMember = "Nombre";
                    comboAlmacen.ValueMember = "Id";
                }

                if (usuarioResult.Exitoso)
                {
                    comboUsuario.DataSource = usuarioResult.Listado;
                    comboUsuario.DisplayMember = "Nombre";
                    comboUsuario.ValueMember = "Id";
                }

            }
            catch (Exception ex)
            {
                UIHelper.MostrarError($"Error al cargar datos: {ex.Message}");
            }
        }

        private string ObtenerTipoMovimientoSeleccionado()
        {
            if (rdEntradaTipoMov.Checked) return "entrada";
            if (rdSalidaTipoMov.Checked) return "salida";
            if (rdTodosTipoMov.Checked) return null;

            return null;
        }

        private string ObtenerDocumentoOrigen()
        {
            if (rdVentaDocuOrigen.Checked) return "venta";
            if (rdCompraDocuOrigen.Checked) return "compra";
            if (rdAjusteDocuOrigen.Checked) return "ajuste";
            if (rdTrasladoDocuOrigen.Checked) return "traslado";
            if (rdTodosDocuOrigen.Checked) return null;

            return null;
        }

        private FiltorInventario CapturarFiltro()
        {
            if (!ValidacionesFiltros()) return null;

            return new FiltorInventario
            {
                productoId = _productoSearch.Id,
                almacenId = (int)comboAlmacen.SelectedValue,
                variacionId = (int)comboVariacion.SelectedValue,
                usuarioId = (int)comboUsuario.SelectedValue,
                tipoMovimiento = ObtenerTipoMovimientoSeleccionado(),
                documentoOrigen = ObtenerDocumentoOrigen(),
                fechaInicio = dtDateDesde.Value.Date,
                fechaFin = dtDateHasta.Value.Date.AddDays(1).AddSeconds(-1)
            };
        }

        private bool ValidacionesFiltros()
        {
            DateTime fechaHasta = dtDateHasta.Value.Date.AddDays(1).AddSeconds(-1);

            if (_productoSearch.Id <= 0)
            {
                UIHelper.MostrarError("Buscar y seleccionar producto, para continuar.");
                return false;
            }

            if (comboVariacion.SelectedItem == null)
            {
                UIHelper.MostrarError("Seleccionar variacion para continuar.");
                return false;
            }
            if (comboUsuario.SelectedItem == null)
            {
                UIHelper.MostrarError("Seleccione un usuario.");
                return false;
            }

            if (comboAlmacen.SelectedItem == null)
            {
                UIHelper.MostrarError("Seleccione un almacen para continuar.");
                return false;
            }
            if (dtDateDesde.Value.Date > fechaHasta)
            {
                UIHelper.MostrarError("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.");
                return false;
            }
            return true;
        }

        private async Task CargarDataHistorial()
        {
            var resultado = await _movimientoInventarioService.GetAllMovimientoForIds(CapturarFiltro());

            if (resultado.Exitoso)
            {
                dataGridViewMovimientos.DataSource = null;
                dataGridViewMovimientos.DataSource = resultado.Listado;

                if (dataGridViewMovimientos.Rows.Count > 0)
                {
                    dataGridViewMovimientos.CurrentCell = null;
                    dataGridViewMovimientos.ClearSelection();
                }
            }
            else
            {
                UIHelper.MostrarError($"Error al cargar historial: {resultado.Mensaje}");
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await CargarDataHistorial();
        }

        private void MovimientoInventarioUI_Load(object sender, EventArgs e)
        {
            dtDateDesde.Value = DateTime.Now.AddDays(-30);
        }

        private async void CargarComboVariaciones()
        {
            var variacionProductoResult = await _variacionProductoService.ObtenerPorIdProductoAsync(_productoSearch.Id);
            if (variacionProductoResult.Exitoso)
            {
                comboVariacion.DataSource = null;
                comboVariacion.DataSource = variacionProductoResult.Listado;
                comboVariacion.DisplayMember = "NombreVariacion";
                comboVariacion.ValueMember = "Id";
            }
            else
            {
                UIHelper.MostrarError($"Error al cargar variaciones: {variacionProductoResult.Mensaje}");
            }
        }
      

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SearchProductUI formSearch = new SearchProductUI();
            formSearch.SearchProduct += (productoRecibido) =>
            {
               if (productoRecibido != null)
                {
                    _productoSearch = productoRecibido;
                    txtProductoBuscar.Text = productoRecibido.Nombre;
                    CargarComboVariaciones();
                }
            };
            formSearch.ShowDialog();
        }
    }
}
