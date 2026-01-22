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
            await ResponseAction(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var response = await _clienteService.EditarAsync(MapearCliente());
            await ResponseAction(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var clienteId = string.IsNullOrEmpty(lblClienteId.Text) ? 0 :
                              Convert.ToInt32(lblClienteId.Text);
            var response = await _clienteService.EliminarAsync(clienteId);
            await ResponseAction(response);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void ConfigurarColumnasClientes()
        {
            if (dataGridCliente.Columns.Count == 0) return;

            dataGridCliente.Columns["Id"].Visible = false;
            dataGridCliente.Columns["Direccion"].Visible = false;
            dataGridCliente.Columns["FechaCreacion"].HeaderText = "Creado el";
            dataGridCliente.Columns["Nombre"].HeaderText = "Cliente";
            dataGridCliente.Columns["Cedula"].HeaderText = "Cédula";
            dataGridCliente.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridCliente.Columns["Email"].HeaderText = "Mail";
            dataGridCliente.Columns["FechaNacimiento"].HeaderText = "F. Nac.";
            dataGridCliente.Columns["Genero"].HeaderText = "Género";
            dataGridCliente.Columns["TotalCompras"].HeaderText = "Total compras";
            dataGridCliente.Columns["UltimaCompra"].HeaderText = "Última compra";
            dataGridCliente.Columns["Activo"].HeaderText = "Estado";
        }

        private async Task ResponseAction(Response<Cliente> response)
        {
            UIHelper.MostrarRespuesta(response);
            if (response.Exitoso)
                await CargarClienteAsync();

            CleanForm();
        }

        private async Task CargarClienteAsync()
        {
            var respuesta = await _clienteService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                await ResponseAction(respuesta);
                return;
            }

            dataGridCliente.DataSource = respuesta.Listado;
            ConfigurarColumnasClientes();

            dataGridCliente.ClearSelection();
            dataGridCliente.CurrentCell = null;
            CleanForm();
        }

        private void CleanForm()
        {
            lblClienteId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaNacimiento.Checked = false;
            cmbGenero.SelectedIndex = -1;
            txtTotalCompras.Text = string.Empty;
            txtUltimaCompra.Text = string.Empty;
            chkActivo.Checked = false;
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
                Direccion = txtDireccion.Text,
                FechaNacimiento = dtpFechaNacimiento.Checked ? (DateTime?)dtpFechaNacimiento.Value.Date : null,
                Genero = cmbGenero.SelectedItem == null ? string.Empty : cmbGenero.SelectedItem.ToString(),
                Activo = chkActivo.Checked,
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
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? string.Empty;

                if (fila.Cells["FechaNacimiento"].Value != null && fila.Cells["FechaNacimiento"].Value != DBNull.Value)
                {
                    dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                    dtpFechaNacimiento.Checked = true;
                }
                else
                {
                    dtpFechaNacimiento.Checked = false;
                }

                var generoVal = fila.Cells["Genero"].Value?.ToString() ?? string.Empty;
                cmbGenero.SelectedIndex = string.IsNullOrEmpty(generoVal) ? -1 : cmbGenero.FindStringExact(generoVal);

                txtTotalCompras.Text = fila.Cells["TotalCompras"].Value?.ToString() ?? "0";
                txtUltimaCompra.Text = fila.Cells["UltimaCompra"].Value?.ToString() ?? string.Empty;
                chkActivo.Checked = fila.Cells["Activo"].Value != null && Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private async void ClienteUI_Load(object sender, EventArgs e)
        {
            await CargarClienteAsync();
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
