using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventarios;

namespace boutiqueshope.UI.UsusuarioController.UCInventario
{
    public partial class UserControlProducto : UserControl
    {
        public event EventHandler<ProductoVariacionFilter> ProductoVariacionPadre;

        private VariacionProductoService _variacionProducto;
        private ProductoVariacionFilter productoVariacionFilter;

        private StringBuilder barcodeBuffer = new StringBuilder();

        public UserControlProducto()
        {
            _variacionProducto = new VariacionProductoService();


            InitializeComponent();
        }

        private async void UserControlProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string busquedaProducto = txtBuscarProducto.Text.Trim();
                
                if (!string.IsNullOrEmpty(busquedaProducto))
                {
                    BuscarProducto(busquedaProducto);
                    txtBuscarProducto.Clear();
                    txtBuscarProducto.Focus();
                }
            }

            e.SuppressKeyPress = true;
        }

        private async void BuscarProducto(String producto)
        {
            var respuesta = await _variacionProducto.GetVariacionProductoFilter(producto);
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarRespuesta(respuesta);
                return;
            }

            if (respuesta.Listado.Count >= 2)
            {
                dataGridViewProductos.DataSource = respuesta.Listado;
            } else
            {
                productoVariacionFilter = respuesta.Listado[0];
            }

        }

        private void SeleccionarDataGrid()
        {

        }

        private void UserControlProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string codigoBarra = barcodeBuffer.ToString().Trim();
                BuscarProducto(codigoBarra);

                barcodeBuffer.Clear();
                e.Handled = true;
            }
        }

        private void UserControlProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                barcodeBuffer.Append(e.KeyChar);

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProductoVariacionPadre?.Invoke(this, productoVariacionFilter);
        }
    }
}
