using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class AlmacenUI : Form
    {
        private AlmacenService _almacenService;
        private UsuarioService _usuarioService;

        public AlmacenUI()
        {
            _almacenService = new AlmacenService();
            _usuarioService = new UsuarioService();
            InitializeComponent();

            // Suscribir evento del combo aquí (asegura que existe después de InitializeComponent)
            comboUsuario.SelectedIndexChanged += ComboUsuario_SelectedIndexChanged;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _almacenService.CrearAsync(MapearAlmacen());
            await ResponseAction(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var response = await _almacenService.EditarAsync(MapearAlmacen());
            await ResponseAction(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var almacenId = string.IsNullOrEmpty(lblAlmacenId.Text) ? 0 :
                              Convert.ToInt32(lblAlmacenId.Text);
            var response = await _almacenService.EliminarAsync(almacenId);
            await ResponseAction(response);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void ConfigurarColumnasAlmacenes()
        {
            if (dataGridAlmacen.Columns.Count == 0) return;

            dataGridAlmacen.Columns["Id"].Visible = false;
            dataGridAlmacen.Columns["Direccion"].Visible = false;
            dataGridAlmacen.Columns["FechaCreacion"].HeaderText = "Creado el";
            dataGridAlmacen.Columns["Nombre"].HeaderText = "Almacén";
            dataGridAlmacen.Columns["Tipo"].HeaderText = "Tipo";
            dataGridAlmacen.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridAlmacen.Columns["ResponsableId"].HeaderText = "Responsable ID";
            dataGridAlmacen.Columns["Activo"].HeaderText = "Estado";
        }

        private async Task ResponseAction(Response<Almacen> response)
        {
            UIHelper.MostrarRespuesta(response);
            if (response.Exitoso)
                await CargarAlmacenAsync();

            CleanForm();
        }

        private async Task CargarAlmacenAsync()
        {
            var respuesta = await _almacenService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                await ResponseAction(respuesta);
                return;
            }

            dataGridAlmacen.DataSource = respuesta.Listado;
            ConfigurarColumnasAlmacenes();

            dataGridAlmacen.ClearSelection();
            dataGridAlmacen.CurrentCell = null;
            CleanForm();
        }

        // Nuevo: Cargar usuarios para el combo
        private async Task CargarUsuariosAsync()
        {
            var resp = await _usuarioService.ListarAsync();
            if (!resp.Exitoso)
            {
                UIHelper.MostrarRespuesta(resp);
                return;
            }

            // Source directo de objetos Usuario; DisplayMember/ValueMember permiten recoger el Id
            comboUsuario.DisplayMember = "Nombre";
            comboUsuario.ValueMember = "Id";
            comboUsuario.DataSource = resp.Listado;
            comboUsuario.SelectedIndex = -1;
        }

        private void CleanForm()
        {
            lblAlmacenId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbTipo.SelectedIndex = -1;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            chkActivo.Checked = false;
            comboUsuario.SelectedIndex = -1;
            dataGridAlmacen.ClearSelection();
            dataGridAlmacen.CurrentCell = null;
            txtNombre.Focus();
        }

        private Almacen MapearAlmacen()
        {
            int? responsable = null;
            if (comboUsuario.DataSource != null && comboUsuario.SelectedValue != null)
            {
                int val;
                if (int.TryParse(comboUsuario.SelectedValue.ToString(), out val))
                    responsable = val;
            }

            return new Almacen
            {
                Id = string.IsNullOrEmpty(lblAlmacenId.Text) ? 0 : Convert.ToInt32(lblAlmacenId.Text),
                Nombre = txtNombre.Text,
                Tipo = cmbTipo.SelectedItem == null ? string.Empty : cmbTipo.SelectedItem.ToString(),
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                ResponsableId = responsable,
                Activo = chkActivo.Checked
            };
        }

        private void CargarDatosDesdeGrid()
        {
            if (dataGridAlmacen.SelectedRows == null)
                return;

            if (dataGridAlmacen.SelectedRows.Count > 0)
            {
                var fila = dataGridAlmacen.SelectedRows[0];
                lblAlmacenId.Text = fila.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;

                var tipoVal = fila.Cells["Tipo"].Value?.ToString() ?? string.Empty;
                cmbTipo.SelectedIndex = string.IsNullOrEmpty(tipoVal) ? -1 : cmbTipo.FindStringExact(tipoVal);

                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? string.Empty;
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? string.Empty;

                // Establecer responsable: setear txt y seleccionar en combo si está cargado
                var respVal = fila.Cells["ResponsableId"].Value;
                if (respVal != null && respVal != DBNull.Value)
                {
                    var respIdStr = respVal.ToString();

                    // Si el combo está poblado, seleccionar por ValueMember
                    int respId;
                    if (comboUsuario.DataSource != null && int.TryParse(respIdStr, out respId))
                    {
                        try
                        {
                            comboUsuario.SelectedValue = respId;
                        }
                        catch
                        {
                            // ignorar si no se encuentra
                            comboUsuario.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    comboUsuario.SelectedIndex = -1;
                }

                chkActivo.Checked = fila.Cells["Activo"].Value != null && Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private async void AlmacenUI_Load(object sender, EventArgs e)
        {
            // Cargar usuarios antes de cargar almacenes para poder seleccionar responsable al mostrar datos
            await CargarUsuariosAsync();
            await CargarAlmacenAsync();
        }

        private void dataGridAlmacen_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        // Maneja la selección del combo y actualiza el campo txtResponsableId
        private void ComboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUsuario.SelectedItem == null)
            {
                return;
            }

            // Intentar obtener Id desde SelectedValue (ValueMember = "Id")
            if (comboUsuario.SelectedValue != null)
            {
                int val;
                if (int.TryParse(comboUsuario.SelectedValue.ToString(), out val))
                {
                    return;
                }
            }
        }
    }
}
