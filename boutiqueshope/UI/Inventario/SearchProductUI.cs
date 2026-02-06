using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI.Inventario
{
    public partial class SearchProductUI : Form
    {
        private ProductoService _productoService;
        private BindingList<Producto> _listProductos;
        public SearchProductUI()
        {
            InitializeComponent();
            _productoService = new ProductoService();
            _listProductos = new BindingList<Producto>();
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            searchProducto();
        }
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            searchProducto();
        }
        private async void SearchProduct_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
            configurationDataGridViewProducto();
            ConfigurarColumnasProductos();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void searchProducto()
        {
            string criterioProducto = txtProducto.Text.Trim().ToLower();

            bool buscarPorNombre = !string.IsNullOrWhiteSpace(criterioProducto);

            var searchProducto = _listProductos.Where(p =>
                (!buscarPorNombre || p.Nombre.ToLower().Contains(criterioProducto))
            ).ToList();

            dataGridViewProducto.DataSource = null;
            dataGridViewProducto.DataSource = new BindingSource { DataSource = searchProducto };
            dataGridViewProducto.ClearSelection();
        }

        private async Task CargarProductosAsync()
        {
            var respuesta = await _productoService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarRespuesta(respuesta);
                return;
            }

            dataGridViewProducto.AutoGenerateColumns = true;
            _listProductos = new BindingList<Producto>(respuesta.Listado);
            dataGridViewProducto.DataSource = _listProductos;
            dataGridViewProducto.ClearSelection();
        }

        private void ConfigurarColumnasProductos()
        {
            if (dataGridViewProducto.Columns.Count == 0) return;

            dataGridViewProducto.Columns["Id"].HeaderText = "Id";
            dataGridViewProducto.Columns["Id"].Visible = false;
            dataGridViewProducto.Columns["Costo"].Visible = false;
            dataGridViewProducto.Columns["PorcentajeGanancia"].Visible = false;
            dataGridViewProducto.Columns["PrecioVenta"].Visible = false;
            dataGridViewProducto.Columns["StockMinimo"].Visible = false;
            dataGridViewProducto.Columns["ProveedorId"].Visible = false;
            dataGridViewProducto.Columns["MarcaId"].Visible = false;
            dataGridViewProducto.Columns["CategoriaId"].Visible = false;
            dataGridViewProducto.Columns["CodigoBarras"].Visible = false;
            dataGridViewProducto.Columns["CodigoQr"].Visible = false;
            dataGridViewProducto.Columns["Nombre"].HeaderText = "Nombre";
            dataGridViewProducto.Columns["Descripcion"].Visible =false;
            dataGridViewProducto.Columns["Activo"].Visible = false;
            dataGridViewProducto.Columns["FechaCreacion"].Visible = false;
            dataGridViewProducto.Columns["CodigoSku"].Visible = false;
            dataGridViewProducto.Columns["FechaCreacion"].Visible = false;
            dataGridViewProducto.Columns["Tipo"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AjusteInventarioUI ajusteInventarioUI = Owner as AjusteInventarioUI;
            if (dataGridViewProducto.CurrentRow != null)
            {
                // Convertimos la fila directamente al objeto de tu clase
                var miProducto = (Producto)dataGridViewProducto.CurrentRow.DataBoundItem;
                txtProducto.Text = miProducto.Nombre;
                ajusteInventarioUI.txtProducto.Text = miProducto.Nombre;
                ajusteInventarioUI.lblIdProducto.Text = miProducto.Id.ToString();
            } else
            {
                UIHelper.MostrarError("Debe seleccionar un producto de la lista.");
            }

            if (!string.IsNullOrEmpty(ajusteInventarioUI.lblIdProducto.Text))
            {
                Close();
            }
        }
    }
}
