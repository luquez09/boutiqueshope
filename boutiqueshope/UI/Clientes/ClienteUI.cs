using System;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class ClienteUI : Form
    {
        private ClienteService _clienteService;

        public ClienteUI(Cliente infoCLiente, bool isUpdate)
        {
            _clienteService = new ClienteService();
            InitializeComponent();
            SetClienteDataGrid(infoCLiente);
            AccionBotones(isUpdate);
        }

        private void AccionBotones(bool isUpdate)
        {
            btnAgregar.Visible = !isUpdate;
            btnCancelar.Visible = isUpdate;
            btnActualizar.Visible = isUpdate;
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _clienteService.CrearAsync(MapearCliente());
            UIHelper.MostrarRespuesta(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            bool confirmacion = UIHelper.Confirmar("¿Está seguro de actualizar este cliente?");
            if (!confirmacion)
                return;

            var response = await _clienteService.EditarAsync(MapearCliente());
            UIHelper.MostrarRespuesta(response);
            Close();
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

        private void SetClienteDataGrid(Cliente cliente)
        {
            lblClienteId.Text = cliente.Id.ToString();
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtCedula.Text = cliente.Cedula;
            txtEmail.Text = cliente.Email;
            cmbGenero.SelectedIndex = string.IsNullOrEmpty(cliente.Genero) ? -1 : cmbGenero.FindStringExact(cliente.Genero);
            txtTotalCompras.Text = cliente.TotalCompras.ToString("F2");
            txtUltimaCompra.Text = cliente.UltimaCompra.HasValue ? cliente.UltimaCompra.Value.ToString("yyyy-MM-dd") : string.Empty;
            txtEmail.Text = cliente.Email;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.SoloNumeros(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
