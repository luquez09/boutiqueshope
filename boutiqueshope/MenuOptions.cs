using System;
using System.Windows.Forms;
using boutiqueshope.UI;

namespace boutiqueshope
{
    public partial class MenuOptions : Form
    {
        bool sidebarExpand = true;
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
            timerSidebar.Start();
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

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= 250)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                }
            }
        }

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
            //OpenChildForm(new FrmProductoVariacion());
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
            //OpenChildForm(new FrmMovimientoInventario());
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
            //OpenChildForm(new FrmCrearCliente());
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

        /**
         BOTONES DE FINANZAS
         */
        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFinanzasSubMenu);
        }

        private void btnMetodosPago_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmMetodoPago());
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmCuenta());
        }

        private void btnPagosDocumento_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmPagoDocumento());
        }

        private void btnFinanzasCreditos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmCreditosCliente());
        }

        private void btnFinanzasAbonos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmAbonosCliente());
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
    }
}
