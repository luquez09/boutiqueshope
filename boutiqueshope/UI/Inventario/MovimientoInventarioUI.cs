using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.Application.Servicios.Ventas;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventarios;

namespace boutiqueshope.UI.Inventario
{
    public partial class MovimientoInventarioUI : Form
    {

        private ProductoService _productoService;
        private AlmacenService _almacenService;
        private VariacionProductoService _variacionProductoService;
        private UsuarioService _usuarioService;

        private MovimientoInventarioService _movimientoInventarioService;
        public MovimientoInventarioUI()
        {
            InitializeComponent();
            _productoService = new ProductoService();
            _almacenService = new AlmacenService();
            _variacionProductoService = new VariacionProductoService();
            _usuarioService = new UsuarioService();

            _movimientoInventarioService = new MovimientoInventarioService();

            CallInformationComboBox();
        }

        private async void CallInformationComboBox()
        {
            try
            {
                var productoResult = await _productoService.ListarAsync();
                var almacenResult = await _almacenService.ListarAsync();
                var usuarioResult = await _usuarioService.ListarAsync();

                if (productoResult.Exitoso)
                {
                    comboProducto.DataSource = productoResult.Listado;
                    comboProducto.DisplayMember = "Nombre";
                    comboProducto.ValueMember = "Id";
                }

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
            return new FiltorInventario
            {
                productoId = (int)comboProducto.SelectedValue,
                almacenId = (int)comboAlmacen.SelectedValue,
                variacionId = (int)comboVariacion.SelectedValue,
                usuarioId = (int)comboUsuario.SelectedValue,
                tipoMovimiento = ObtenerTipoMovimientoSeleccionado(),
                documentoOrigen = ObtenerDocumentoOrigen()
            };
        }

        private async Task CargarDataHistorial()
        {
            var listadoMovimientos = await _movimientoInventarioService.GetAllMovimientoForIds(CapturarFiltro());

            if (listadoMovimientos.Exitoso)
            {
                dataGridViewMovimientos.DataSource = listadoMovimientos.Listado;
                dataGridViewMovimientos.CurrentCell = null;
                dataGridViewMovimientos.ClearSelection();
            }
            else
            {
                UIHelper.MostrarError($"Error al cargar historial: {listadoMovimientos.Mensaje}");
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


        private async void GetAllProductoVariacion()
        {
            int idProducto = (int)comboProducto.SelectedValue;
            var variacionProductoResult = await _variacionProductoService.ObtenerPorIdProductoAsync(idProducto);

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
        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProducto.SelectedValue != null && int.TryParse(comboProducto.SelectedValue.ToString(), out int idProducto))
            {
                GetAllProductoVariacion();
            }
        }
    }
}
