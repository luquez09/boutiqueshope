using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class MarcaUI : Form
    {

        private MarcaService _marcaService;
        public MarcaUI()
        {
            _marcaService = new MarcaService();
            InitializeComponent();
            
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _marcaService.CrearAsync(MapearMarca());
            await ResponseAction(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var response = await _marcaService.EditarAsync(MapearMarca());
            await ResponseAction(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var usuarioId = string.IsNullOrEmpty(lblMarcaId.Text) ? 0 :
                            Convert.ToInt32(lblMarcaId.Text);
            var response = await _marcaService.EliminarAsync(usuarioId);
            await ResponseAction(response);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void ConfigurarColumnasMarcas()
        {
            if (dataGridMarca.Columns.Count == 0) return;

            dataGridMarca.Columns["Id"].Visible = false;
            dataGridMarca.Columns["Descripcion"].Visible = false;
            dataGridMarca.Columns["FechaCreacion"].HeaderText = "Creado el";
            dataGridMarca.Columns["Nombre"].HeaderText = "Marca";
            dataGridMarca.Columns["Descripcion"].HeaderText = "Descripcion";
            dataGridMarca.Columns["Activo"].HeaderText = "Estado";
        }

        private async Task ResponseAction(Response<Marca> response)
        {
            UIHelper.MostrarRespuesta(response);
            if (response.Exitoso)
                await CargarMarcaAsync();

            CleanForm();
        }

        private async Task CargarMarcaAsync()
        {
            var respuesta = await _marcaService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                await ResponseAction(respuesta);
                return;
            }

            dataGridMarca.DataSource = respuesta.Listado;
            ConfigurarColumnasMarcas();

            dataGridMarca.ClearSelection();
            dataGridMarca.CurrentCell = null;
        }

        private void CleanForm()
        {
            lblMarcaId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            checkBoxActivo.Checked = false;
            txtNombre.Focus();
        }

        private Marca MapearMarca()
        {
            return new Marca
            {
                Id = string.IsNullOrEmpty(lblMarcaId.Text) ? 0 : Convert.ToInt32(lblMarcaId.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Activo = checkBoxActivo.Checked
            };
        }

        private void CargarDatosDesdeGrid()
        {
            if (dataGridMarca.SelectedRows == null)
                return;

            if (dataGridMarca.SelectedRows.Count > 0)
            {
                var fila = dataGridMarca.SelectedRows[0];
                lblMarcaId.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                checkBoxActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private void dataGridMarca_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidatorHelper.LetrasYNumeros(e);
        }

        private async void MarcaUI_Load(object sender, EventArgs e)
        {
            await CargarMarcaAsync();
        }
    }
}
