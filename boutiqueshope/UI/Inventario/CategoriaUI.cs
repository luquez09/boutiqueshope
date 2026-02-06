using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI
{
    public partial class CategoriaUI : Form
    {
        private CategoriaService _categoriaService;

        public CategoriaUI()
        {
            _categoriaService = new CategoriaService();
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _categoriaService.CrearAsync(MapearCategoria());
            await ResponseAction(response);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var response = await _categoriaService.EditarAsync(MapearCategoria());
            await ResponseAction(response);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!UIHelper.Confirmar("Seguro de eliminar este registro ?"))
                return;

            var categoriaId = string.IsNullOrEmpty(lblCategoriaId.Text) ? 0 :
                              Convert.ToInt32(lblCategoriaId.Text);
            var response = await _categoriaService.EliminarAsync(categoriaId);
            await ResponseAction(response);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void ConfigurarColumnasCategorias()
        {
            if (dataGridCategoria.Columns.Count == 0) return;

            dataGridCategoria.Columns["Id"].Visible = false;
            dataGridCategoria.Columns["Descripcion"].Visible = false;
            dataGridCategoria.Columns["FechaCreacion"].HeaderText = "Creado el";
            dataGridCategoria.Columns["Nombre"].HeaderText = "Categoría";
            dataGridCategoria.Columns["Descripcion"].HeaderText = "Descripción";
            dataGridCategoria.Columns["Activo"].HeaderText = "Estado";
        }

        private async Task ResponseAction(Response<Categoria> response)
        {
            UIHelper.MostrarRespuesta(response);
            if (response.Exitoso)
                await CargarCategoriaAsync();

            CleanForm();
        }

        private async Task CargarCategoriaAsync()
        {
            var respuesta = await _categoriaService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                await ResponseAction(respuesta);
                return;
            }

            dataGridCategoria.DataSource = respuesta.Listado;
            ConfigurarColumnasCategorias();

            dataGridCategoria.ClearSelection();
            dataGridCategoria.CurrentCell = null;
        }

        private void CleanForm()
        {
            lblCategoriaId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            chkActivo.Checked = false;
            txtNombre.Focus();
        }

        private Categoria MapearCategoria()
        {
            return new Categoria
            {
                Id = string.IsNullOrEmpty(lblCategoriaId.Text) ? 0 : Convert.ToInt32(lblCategoriaId.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Activo = chkActivo.Checked
            };
        }

        private void CargarDatosDesdeGrid()
        {
            if (dataGridCategoria.SelectedRows == null)
                return;

            if (dataGridCategoria.SelectedRows.Count > 0)
            {
                var fila = dataGridCategoria.SelectedRows[0];
                lblCategoriaId.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private void dataGridCategoria_SelectionChanged(object sender, EventArgs e)
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

        private async void CategoriaUI_Load(object sender, EventArgs e)
        {
            await CargarCategoriaAsync();
        }
    }
}
