using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class ProveedorUI : Form
    {
        private ProveedorService _proveedorService;

        public ProveedorUI()
        {
            _proveedorService = new ProveedorService();
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _proveedorService.CrearAsync(MapearProveedor());
            await ResponseAction(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var response = await _proveedorService.EditarAsync(MapearProveedor());
            await ResponseAction(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var proveedorId = string.IsNullOrEmpty(lblProveedorId.Text) ? 0 :
                              Convert.ToInt32(lblProveedorId.Text);
            var response = await _proveedorService.EliminarAsync(proveedorId);
            await ResponseAction(response);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void ConfigurarColumnasProveedores()
        {
            if (dataGridProveedor.Columns.Count == 0) return;

            dataGridProveedor.Columns["Id"].Visible = false;
            dataGridProveedor.Columns["Direccion"].Visible = false;
            dataGridProveedor.Columns["FechaCreacion"].HeaderText = "Creado el";
            dataGridProveedor.Columns["Nombre"].HeaderText = "Proveedor";
            dataGridProveedor.Columns["Nit"].HeaderText = "NIT";
            dataGridProveedor.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridProveedor.Columns["Email"].HeaderText = "Mail";
            dataGridProveedor.Columns["ContactoNombre"].HeaderText = "Contacto";
            dataGridProveedor.Columns["ContactoTelefono"].HeaderText = "Tel. contacto";
            dataGridProveedor.Columns["Activo"].HeaderText = "Estado";
        }

        private async Task ResponseAction(Response<Proveedor> response)
        {
            UIHelper.MostrarRespuesta(response);
            if (response.Exitoso)
                await CargarProveedorAsync();

            CleanForm();
        }

        private async Task CargarProveedorAsync()
        {
            var respuesta = await _proveedorService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                await ResponseAction(respuesta);
                return;
            }

            dataGridProveedor.DataSource = respuesta.Listado;
            ConfigurarColumnasProveedores();

            dataGridProveedor.ClearSelection();
            dataGridProveedor.CurrentCell = null;
            CleanForm();
        }

        private void CleanForm()
        {
            lblProveedorId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNit.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtContactoNombre.Text = string.Empty;
            txtContactoTelefono.Text = string.Empty;
            chkActivo.Checked = false;
            dataGridProveedor.ClearSelection();
            dataGridProveedor.CurrentCell = null;
            txtNombre.Focus();
        }

        private Proveedor MapearProveedor()
        {
            return new Proveedor
            {
                Id = string.IsNullOrEmpty(lblProveedorId.Text) ? 0 : Convert.ToInt32(lblProveedorId.Text),
                Nombre = txtNombre.Text,
                Nit = txtNit.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text,
                ContactoNombre = txtContactoNombre.Text,
                ContactoTelefono = txtContactoTelefono.Text,
                Activo = chkActivo.Checked
            };
        }

        private void CargarDatosDesdeGrid()
        {
            if (dataGridProveedor.SelectedRows.Count > 0)
            {
                var fila = dataGridProveedor.SelectedRows[0];
                lblProveedorId.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtNit.Text = fila.Cells["Nit"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtContactoNombre.Text = fila.Cells["ContactoNombre"].Value.ToString();
                txtContactoTelefono.Text = fila.Cells["ContactoTelefono"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private async void ProveedorUI_Load(object sender, EventArgs e)
        {
            await CargarProveedorAsync();
        }

        private void dataGridProveedor_SelectionChanged_1(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
        }
    }
}
