using System;
using System.ComponentModel;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI.Inventario
{
    public partial class SearchProductUI : Form
    {
        private ProductoService _productoService;
        public event Action<Producto> SearchProduct;

        public SearchProductUI()
        {
            InitializeComponent();
            _productoService = new ProductoService();
        }

        private async void SearchProduct_Load(object sender, EventArgs e)
        {
            configurationDataGridViewProducto();
        }

        private void configurationDataGridViewProducto()
        {
            dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducto.MultiSelect = false;
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.AllowUserToAddRows = false;
            dataGridViewProducto.AllowUserToDeleteRows = false;
            dataGridViewProducto.AllowUserToResizeRows = false;
            dataGridViewProducto.AutoGenerateColumns = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProducto();
            }
        }

        private async void BuscarProducto()
        {
            string nombreProducto = txtProducto.Text.Trim();
            var respuesta = await _productoService.BuscarProducto(nombreProducto);
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarAdvertencia("No encontramos coincidencias.");
                return;
            }

            dataGridViewProducto.DataSource = null;
            dataGridViewProducto.DataSource = new BindingList<Producto>(respuesta.Listado);
            dataGridViewProducto.ClearSelection();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProducto.Text.Trim()))
            {
                if (dataGridViewProducto.CurrentCell == null)
                {
                    UIHelper.MostrarAdvertencia("Selecciona un producto, de la lista.");
                    return;
                }

                Producto producto = (Producto)dataGridViewProducto.CurrentRow.DataBoundItem;
                SearchProduct?.Invoke(producto);
                Close();
            }
            else
            {
                UIHelper.MostrarAdvertencia("Ingresa el nombre del producto a buscar.");
            }
        }
    }
}
