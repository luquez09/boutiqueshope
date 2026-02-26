using System;
using System.Windows.Forms;
using boutiqueshope.UI;
using boutiqueshope.UI.Clientes;
using boutiqueshope.UI.Inventario;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope
{
    public partial class MenuOptions : Form
    {
        private Form activeForm = null;

        public MenuOptions()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void MenuOptions_Load(object sender, System.EventArgs e)
        {
            //this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.Bounds = Screen.FromControl(this).Bounds;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // Oculta submenús al iniciar
        private void CustomizeDesign()
        {
            panelVentasSubMenu.Visible = false;
            panelInventarioSubMenu.Visible = false;
        }


        // Oculta todos los submenús
        private void HideSubMenus()
        {
            if (panelVentasSubMenu.Visible)
                panelVentasSubMenu.Visible = false;

            if (panelInventarioSubMenu.Visible)
                panelInventarioSubMenu.Visible = false;
        }

        // Muestra un submenú específico
        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // -------------------------
        // EVENTOS DEL MENÚ LATERAL
        // -------------------------

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuOptions_Load_1(object sender, EventArgs e)
        {

        }

        /**
         * BOTONES DEL DASHBOARD
         * 
         */
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmDashboard());
        }

        /*
         BOTONES DE VENTAS
         */

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelVentasSubMenu);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmNuevaVenta());
        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmHistorialVentas());
        }

        private void btnVentasCredito_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmVentasCredito());
        }

        private void btnPagosClientes_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmPagosClientes());
        }

        /*
         * BOTONES DE INVENTARIO
         * **/
        private void btnInventario_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelInventarioSubMenu);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductoUI());
        }

        private void btnVariacionesProducto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductoVariacionUI());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoriaUI());
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MarcaUI());
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AlmacenUI());
        }

        private void btnMovimientosInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AjusteInventarioUI());
        }

        private void btnAjustesInventario_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmAjusteInventario());
        }

        /*
         * BOTONES DE CLIENTES
         * **/

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelClientesSubMenu);
        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmClientes());
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClienteUI(new Cliente(), false));
        }

        private void btnCreditosCliente_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmCreditosCliente());
        }

        private void btnAbonosCliente_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmAbonosCliente());
        }

        /*
         * BOTONES PROVEEDORES
         * **/
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelProveedoresSubMenu);
        }

        private void btnListadoProveedores_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmProveedores());
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProveedorUI());
        }

        /*
         * BOTONES ADMINISTRACION
         * **/
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdministracionSubMenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsuarioUI());
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmRoles());
        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmTipoDocumento());
        }

        /*
         BOTONES CONFIGURACION
         */
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelConfiguracionSubMenu);
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmParametros());
        }

        private void btnImpresoras_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmImpresoras());
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmImpuestos());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmBackup());
        }

        private void btnHistorialInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MovimientoInventarioUI());
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionClientesUI());
        }
    }
}
