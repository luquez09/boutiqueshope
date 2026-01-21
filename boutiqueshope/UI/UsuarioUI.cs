using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class UsuarioUI : Form
    {
        private UsuarioService _usuarioService;
        public UsuarioUI()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _usuarioService.CrearAsync(MapearUsuario());
            await ResponseAction(response);
        }

        private Usuario MapearUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Id = string.IsNullOrEmpty(lblIdUsuario.Text) ? 0 : Convert.ToInt32(lblIdUsuario.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Email = txtCorreo.Text;
            usuario.Username = txtUsuario.Text;
            usuario.PasswordHash = txtContrasena.Text;
            usuario.Activo = checkEstado.Checked;
            usuario.Telefono = string.IsNullOrEmpty(txtCelular.Text) ? "000" : txtCelular.Text;
            return usuario;
        }

        private void CleanForm()
        {
            lblIdUsuario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtCelular.Text = string.Empty;
            checkEstado.Checked = false;
            txtNombre.Focus();
        }

        private async Task ResponseAction(Response<Usuario> response)
        {
            UIHelper.MostrarRespuesta(response);

            if (response.Exitoso)
                await CargarUsuariosAsync();

            CleanForm();
        }

        private async Task CargarUsuariosAsync()
        {
            var respuesta = await _usuarioService.ListarAsync();

            if (!respuesta.Exitoso)
            {
                await ResponseAction(respuesta);
                return;
            }

            dataGridUsuarios.DataSource = respuesta.Listado;
            ConfigurarColumnasUsuario();

            dataGridUsuarios.ClearSelection();
            dataGridUsuarios.CurrentCell = null;
        }

        private void ConfigurarColumnasUsuario()
        {
            dataGridUsuarios.Columns["Id"].Visible = false;
            dataGridUsuarios.Columns["PasswordHash"].Visible = false;
            dataGridUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            dataGridUsuarios.Columns["Telefono"].HeaderText = "Celular";
            dataGridUsuarios.Columns["Email"].HeaderText = "Correo Electrónico";
            dataGridUsuarios.Columns["Username"].HeaderText = "Usuario";
            dataGridUsuarios.Columns["Activo"].HeaderText = "Estado";
            dataGridUsuarios.Columns["FechaCreacion"].HeaderText = "Dia creado";
        }

        private async void UsuarioUI_Load(object sender, EventArgs e)
        {
            await CargarUsuariosAsync();
        }

        private async void btnActualizar_Click_1(object sender, EventArgs e)
        {
            var response = await _usuarioService.EditarAsync(MapearUsuario());
            await ResponseAction(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var usuarioId = string.IsNullOrEmpty(lblIdUsuario.Text) ? 0 :
                            Convert.ToInt32(lblIdUsuario.Text);
            var response = await _usuarioService.EliminarAsync(usuarioId);
            await ResponseAction(response);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.SoloLetras(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.SoloNumeros(e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private void dataGridUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
        }

        private void CargarDatosDesdeGrid()
        {
            if (dataGridUsuarios.SelectedRows == null)
                return;

            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                var fila = dataGridUsuarios.SelectedRows[0];
                lblIdUsuario.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = fila.Cells["Email"].Value.ToString();
                txtUsuario.Text = fila.Cells["Username"].Value.ToString();
                txtContrasena.Text = fila.Cells["PasswordHash"].Value.ToString();
                txtCelular.Text = fila.Cells["Telefono"].Value.ToString();
                checkEstado.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }
    }
}
