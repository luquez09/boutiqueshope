using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class ClienteUI : Form
    {
        private ClienteService _clienteService;

        public ClienteUI()
        {
            _clienteService = new ClienteService();
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _clienteService.CrearAsync(MapearCliente());
            UIHelper.MostrarRespuesta(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var response = await _clienteService.EditarAsync(MapearCliente());
            UIHelper.MostrarRespuesta(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var clienteId = string.IsNullOrEmpty(lblClienteId.Text) ? 0 :
                              Convert.ToInt32(lblClienteId.Text);
            var response = await _clienteService.EliminarAsync(clienteId);
            UIHelper.MostrarRespuesta(response);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }


        private void CleanForm()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbGenero.SelectedIndex = -1;
            txtTotalCompras.Text = string.Empty;
            txtUltimaCompra.Text = string.Empty;
            dataGridCliente.ClearSelection();
            dataGridCliente.CurrentCell = null;
            txtNombre.Focus();
        }

        private Cliente MapearCliente()
        {
            return new Cliente
            {
                Id = string.IsNullOrEmpty(lblClienteId.Text) ? 0 : Convert.ToInt32(lblClienteId.Text),
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Genero = cmbGenero.SelectedItem == null ? string.Empty : cmbGenero.SelectedItem.ToString(),
                TotalCompras = string.IsNullOrEmpty(txtTotalCompras.Text) ? 0m : Convert.ToDecimal(txtTotalCompras.Text),
                UltimaCompra = string.IsNullOrEmpty(txtUltimaCompra.Text) ? (DateTime?)null : Convert.ToDateTime(txtUltimaCompra.Text)
            };
        }

        private void CargarDatosDesdeGrid()
        {
            if (dataGridCliente.SelectedRows == null)
                return;

            if (dataGridCliente.SelectedRows.Count > 0)
            {
                var fila = dataGridCliente.SelectedRows[0];

                lblClienteId.Text = fila.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtCedula.Text = fila.Cells["Cedula"].Value?.ToString() ?? string.Empty;
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = fila.Cells["Email"].Value?.ToString() ?? string.Empty;

                var generoVal = fila.Cells["Genero"].Value?.ToString() ?? string.Empty;
                cmbGenero.SelectedIndex = string.IsNullOrEmpty(generoVal) ? -1 : cmbGenero.FindStringExact(generoVal);

                txtTotalCompras.Text = fila.Cells["TotalCompras"].Value?.ToString() ?? "0";
                txtUltimaCompra.Text = fila.Cells["UltimaCompra"].Value?.ToString() ?? string.Empty;
            }
        }

        private async void ClienteUI_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.SoloLetras(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.SoloNumeros(e);
        }

        private void dataGridCliente_SelectionChanged_1(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.SoloNumeros(e);
        }
    }
}
