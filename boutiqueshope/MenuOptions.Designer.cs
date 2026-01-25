namespace boutiqueshope
{
    partial class MenuOptions
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDashboard;

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelVentasSubMenu;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnHistorialVentas;
        private System.Windows.Forms.Button btnVentasCredito;
        private System.Windows.Forms.Button btnPagosClientes;

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel panelInventarioSubMenu;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVariacionesProducto;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnAlmacenes;
        private System.Windows.Forms.Button btnMovimientosInventario;
        private System.Windows.Forms.Button btnAjustesInventario;

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelClientesSubMenu;
        private System.Windows.Forms.Button btnListadoClientes;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnCreditosCliente;
        private System.Windows.Forms.Button btnAbonosCliente;

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panelProveedoresSubMenu;
        private System.Windows.Forms.Button btnListadoProveedores;
        private System.Windows.Forms.Button btnCrearProveedor;

        private System.Windows.Forms.Button btnFinanzas;
        private System.Windows.Forms.Panel panelFinanzasSubMenu;
        private System.Windows.Forms.Button btnMetodosPago;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnPagosDocumento;
        private System.Windows.Forms.Button btnFinanzasCreditos;
        private System.Windows.Forms.Button btnFinanzasAbonos;

        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Panel panelAdministracionSubMenu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnTipoDocumento;

        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel panelConfiguracionSubMenu;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnImpresoras;
        private System.Windows.Forms.Button btnImpuestos;
        private System.Windows.Forms.Button btnBackup;

        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Timer timerSidebar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelConfiguracionSubMenu = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnImpuestos = new System.Windows.Forms.Button();
            this.btnImpresoras = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.panelAdministracionSubMenu = new System.Windows.Forms.Panel();
            this.btnTipoDocumento = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.panelFinanzasSubMenu = new System.Windows.Forms.Panel();
            this.btnFinanzasAbonos = new System.Windows.Forms.Button();
            this.btnFinanzasCreditos = new System.Windows.Forms.Button();
            this.btnPagosDocumento = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.btnFinanzas = new System.Windows.Forms.Button();
            this.panelProveedoresSubMenu = new System.Windows.Forms.Panel();
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.btnListadoProveedores = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.panelClientesSubMenu = new System.Windows.Forms.Panel();
            this.btnAbonosCliente = new System.Windows.Forms.Button();
            this.btnCreditosCliente = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelInventarioSubMenu = new System.Windows.Forms.Panel();
            this.btnAjustesInventario = new System.Windows.Forms.Button();
            this.btnMovimientosInventario = new System.Windows.Forms.Button();
            this.btnAlmacenes = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnVariacionesProducto = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panelVentasSubMenu = new System.Windows.Forms.Panel();
            this.btnPagosClientes = new System.Windows.Forms.Button();
            this.btnVentasCredito = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelConfiguracionSubMenu.SuspendLayout();
            this.panelAdministracionSubMenu.SuspendLayout();
            this.panelFinanzasSubMenu.SuspendLayout();
            this.panelProveedoresSubMenu.SuspendLayout();
            this.panelClientesSubMenu.SuspendLayout();
            this.panelInventarioSubMenu.SuspendLayout();
            this.panelVentasSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelSidebar.Controls.Add(this.btnSalir);
            this.panelSidebar.Controls.Add(this.panelConfiguracionSubMenu);
            this.panelSidebar.Controls.Add(this.btnConfiguracion);
            this.panelSidebar.Controls.Add(this.panelAdministracionSubMenu);
            this.panelSidebar.Controls.Add(this.btnAdministracion);
            this.panelSidebar.Controls.Add(this.panelFinanzasSubMenu);
            this.panelSidebar.Controls.Add(this.btnFinanzas);
            this.panelSidebar.Controls.Add(this.panelProveedoresSubMenu);
            this.panelSidebar.Controls.Add(this.btnProveedores);
            this.panelSidebar.Controls.Add(this.panelClientesSubMenu);
            this.panelSidebar.Controls.Add(this.btnClientes);
            this.panelSidebar.Controls.Add(this.panelInventarioSubMenu);
            this.panelSidebar.Controls.Add(this.btnInventario);
            this.panelSidebar.Controls.Add(this.panelVentasSubMenu);
            this.panelSidebar.Controls.Add(this.btnVentas);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(214, 722);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 687);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(214, 35);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "⏻  Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelConfiguracionSubMenu
            // 
            this.panelConfiguracionSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelConfiguracionSubMenu.Controls.Add(this.btnBackup);
            this.panelConfiguracionSubMenu.Controls.Add(this.btnImpuestos);
            this.panelConfiguracionSubMenu.Controls.Add(this.btnImpresoras);
            this.panelConfiguracionSubMenu.Controls.Add(this.btnParametros);
            this.panelConfiguracionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracionSubMenu.Location = new System.Drawing.Point(0, 1142);
            this.panelConfiguracionSubMenu.Name = "panelConfiguracionSubMenu";
            this.panelConfiguracionSubMenu.Size = new System.Drawing.Size(214, 121);
            this.panelConfiguracionSubMenu.TabIndex = 16;
            this.panelConfiguracionSubMenu.Visible = false;
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.Silver;
            this.btnBackup.Location = new System.Drawing.Point(0, 90);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(214, 30);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup / Restore";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnImpuestos
            // 
            this.btnImpuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImpuestos.FlatAppearance.BorderSize = 0;
            this.btnImpuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpuestos.ForeColor = System.Drawing.Color.Silver;
            this.btnImpuestos.Location = new System.Drawing.Point(0, 60);
            this.btnImpuestos.Name = "btnImpuestos";
            this.btnImpuestos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnImpuestos.Size = new System.Drawing.Size(214, 30);
            this.btnImpuestos.TabIndex = 2;
            this.btnImpuestos.Text = "Impuestos";
            this.btnImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpuestos.UseVisualStyleBackColor = true;
            this.btnImpuestos.Click += new System.EventHandler(this.btnImpuestos_Click);
            // 
            // btnImpresoras
            // 
            this.btnImpresoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImpresoras.FlatAppearance.BorderSize = 0;
            this.btnImpresoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresoras.ForeColor = System.Drawing.Color.Silver;
            this.btnImpresoras.Location = new System.Drawing.Point(0, 30);
            this.btnImpresoras.Name = "btnImpresoras";
            this.btnImpresoras.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnImpresoras.Size = new System.Drawing.Size(214, 30);
            this.btnImpresoras.TabIndex = 1;
            this.btnImpresoras.Text = "Impresoras";
            this.btnImpresoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresoras.UseVisualStyleBackColor = true;
            this.btnImpresoras.Click += new System.EventHandler(this.btnImpresoras_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.ForeColor = System.Drawing.Color.Silver;
            this.btnParametros.Location = new System.Drawing.Point(0, 0);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnParametros.Size = new System.Drawing.Size(214, 30);
            this.btnParametros.TabIndex = 0;
            this.btnParametros.Text = "Parámetros";
            this.btnParametros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametros.UseVisualStyleBackColor = true;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 1107);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(214, 35);
            this.btnConfiguracion.TabIndex = 15;
            this.btnConfiguracion.Text = "⚙  Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panelAdministracionSubMenu
            // 
            this.panelAdministracionSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelAdministracionSubMenu.Controls.Add(this.btnTipoDocumento);
            this.panelAdministracionSubMenu.Controls.Add(this.btnRoles);
            this.panelAdministracionSubMenu.Controls.Add(this.btnUsuarios);
            this.panelAdministracionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdministracionSubMenu.Location = new System.Drawing.Point(0, 1016);
            this.panelAdministracionSubMenu.Name = "panelAdministracionSubMenu";
            this.panelAdministracionSubMenu.Size = new System.Drawing.Size(214, 91);
            this.panelAdministracionSubMenu.TabIndex = 14;
            this.panelAdministracionSubMenu.Visible = false;
            // 
            // btnTipoDocumento
            // 
            this.btnTipoDocumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoDocumento.FlatAppearance.BorderSize = 0;
            this.btnTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoDocumento.ForeColor = System.Drawing.Color.Silver;
            this.btnTipoDocumento.Location = new System.Drawing.Point(0, 60);
            this.btnTipoDocumento.Name = "btnTipoDocumento";
            this.btnTipoDocumento.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTipoDocumento.Size = new System.Drawing.Size(214, 30);
            this.btnTipoDocumento.TabIndex = 2;
            this.btnTipoDocumento.Text = "Tipo de documento";
            this.btnTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoDocumento.UseVisualStyleBackColor = true;
            this.btnTipoDocumento.Click += new System.EventHandler(this.btnTipoDocumento_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.ForeColor = System.Drawing.Color.Silver;
            this.btnRoles.Location = new System.Drawing.Point(0, 30);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(214, 30);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles / Permisos";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Silver;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(214, 30);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 981);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(214, 35);
            this.btnAdministracion.TabIndex = 13;
            this.btnAdministracion.Text = "🛠  Administración";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // panelFinanzasSubMenu
            // 
            this.panelFinanzasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelFinanzasSubMenu.Controls.Add(this.btnFinanzasAbonos);
            this.panelFinanzasSubMenu.Controls.Add(this.btnFinanzasCreditos);
            this.panelFinanzasSubMenu.Controls.Add(this.btnPagosDocumento);
            this.panelFinanzasSubMenu.Controls.Add(this.btnCuentas);
            this.panelFinanzasSubMenu.Controls.Add(this.btnMetodosPago);
            this.panelFinanzasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinanzasSubMenu.Location = new System.Drawing.Point(0, 829);
            this.panelFinanzasSubMenu.Name = "panelFinanzasSubMenu";
            this.panelFinanzasSubMenu.Size = new System.Drawing.Size(214, 152);
            this.panelFinanzasSubMenu.TabIndex = 12;
            this.panelFinanzasSubMenu.Visible = false;
            // 
            // btnFinanzasAbonos
            // 
            this.btnFinanzasAbonos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanzasAbonos.FlatAppearance.BorderSize = 0;
            this.btnFinanzasAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzasAbonos.ForeColor = System.Drawing.Color.Silver;
            this.btnFinanzasAbonos.Location = new System.Drawing.Point(0, 120);
            this.btnFinanzasAbonos.Name = "btnFinanzasAbonos";
            this.btnFinanzasAbonos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFinanzasAbonos.Size = new System.Drawing.Size(214, 30);
            this.btnFinanzasAbonos.TabIndex = 4;
            this.btnFinanzasAbonos.Text = "Abonos de clientes";
            this.btnFinanzasAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzasAbonos.UseVisualStyleBackColor = true;
            this.btnFinanzasAbonos.Click += new System.EventHandler(this.btnFinanzasAbonos_Click);
            // 
            // btnFinanzasCreditos
            // 
            this.btnFinanzasCreditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanzasCreditos.FlatAppearance.BorderSize = 0;
            this.btnFinanzasCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzasCreditos.ForeColor = System.Drawing.Color.Silver;
            this.btnFinanzasCreditos.Location = new System.Drawing.Point(0, 90);
            this.btnFinanzasCreditos.Name = "btnFinanzasCreditos";
            this.btnFinanzasCreditos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFinanzasCreditos.Size = new System.Drawing.Size(214, 30);
            this.btnFinanzasCreditos.TabIndex = 3;
            this.btnFinanzasCreditos.Text = "Créditos de clientes";
            this.btnFinanzasCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzasCreditos.UseVisualStyleBackColor = true;
            this.btnFinanzasCreditos.Click += new System.EventHandler(this.btnFinanzasCreditos_Click);
            // 
            // btnPagosDocumento
            // 
            this.btnPagosDocumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagosDocumento.FlatAppearance.BorderSize = 0;
            this.btnPagosDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagosDocumento.ForeColor = System.Drawing.Color.Silver;
            this.btnPagosDocumento.Location = new System.Drawing.Point(0, 60);
            this.btnPagosDocumento.Name = "btnPagosDocumento";
            this.btnPagosDocumento.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPagosDocumento.Size = new System.Drawing.Size(214, 30);
            this.btnPagosDocumento.TabIndex = 2;
            this.btnPagosDocumento.Text = "Pagos de documentos";
            this.btnPagosDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagosDocumento.UseVisualStyleBackColor = true;
            this.btnPagosDocumento.Click += new System.EventHandler(this.btnPagosDocumento_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.ForeColor = System.Drawing.Color.Silver;
            this.btnCuentas.Location = new System.Drawing.Point(0, 30);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCuentas.Size = new System.Drawing.Size(214, 30);
            this.btnCuentas.TabIndex = 1;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnMetodosPago
            // 
            this.btnMetodosPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetodosPago.FlatAppearance.BorderSize = 0;
            this.btnMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodosPago.ForeColor = System.Drawing.Color.Silver;
            this.btnMetodosPago.Location = new System.Drawing.Point(0, 0);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMetodosPago.Size = new System.Drawing.Size(214, 30);
            this.btnMetodosPago.TabIndex = 0;
            this.btnMetodosPago.Text = "Métodos de pago";
            this.btnMetodosPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetodosPago.UseVisualStyleBackColor = true;
            this.btnMetodosPago.Click += new System.EventHandler(this.btnMetodosPago_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanzas.FlatAppearance.BorderSize = 0;
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinanzas.Location = new System.Drawing.Point(0, 794);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnFinanzas.Size = new System.Drawing.Size(214, 35);
            this.btnFinanzas.TabIndex = 11;
            this.btnFinanzas.Text = "💰  Finanzas";
            this.btnFinanzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.UseVisualStyleBackColor = true;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // panelProveedoresSubMenu
            // 
            this.panelProveedoresSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelProveedoresSubMenu.Controls.Add(this.btnCrearProveedor);
            this.panelProveedoresSubMenu.Controls.Add(this.btnListadoProveedores);
            this.panelProveedoresSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProveedoresSubMenu.Location = new System.Drawing.Point(0, 733);
            this.panelProveedoresSubMenu.Name = "panelProveedoresSubMenu";
            this.panelProveedoresSubMenu.Size = new System.Drawing.Size(214, 61);
            this.panelProveedoresSubMenu.TabIndex = 10;
            this.panelProveedoresSubMenu.Visible = false;
            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearProveedor.FlatAppearance.BorderSize = 0;
            this.btnCrearProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProveedor.ForeColor = System.Drawing.Color.Silver;
            this.btnCrearProveedor.Location = new System.Drawing.Point(0, 30);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearProveedor.Size = new System.Drawing.Size(214, 30);
            this.btnCrearProveedor.TabIndex = 1;
            this.btnCrearProveedor.Text = "Crear proveedor";
            this.btnCrearProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearProveedor.UseVisualStyleBackColor = true;
            this.btnCrearProveedor.Click += new System.EventHandler(this.btnCrearProveedor_Click);
            // 
            // btnListadoProveedores
            // 
            this.btnListadoProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoProveedores.FlatAppearance.BorderSize = 0;
            this.btnListadoProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoProveedores.ForeColor = System.Drawing.Color.Silver;
            this.btnListadoProveedores.Location = new System.Drawing.Point(0, 0);
            this.btnListadoProveedores.Name = "btnListadoProveedores";
            this.btnListadoProveedores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnListadoProveedores.Size = new System.Drawing.Size(214, 30);
            this.btnListadoProveedores.TabIndex = 0;
            this.btnListadoProveedores.Text = "Listado de proveedores";
            this.btnListadoProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoProveedores.UseVisualStyleBackColor = true;
            this.btnListadoProveedores.Click += new System.EventHandler(this.btnListadoProveedores_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProveedores.Location = new System.Drawing.Point(0, 698);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(214, 35);
            this.btnProveedores.TabIndex = 9;
            this.btnProveedores.Text = "🏭  Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // panelClientesSubMenu
            // 
            this.panelClientesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelClientesSubMenu.Controls.Add(this.btnAbonosCliente);
            this.panelClientesSubMenu.Controls.Add(this.btnCreditosCliente);
            this.panelClientesSubMenu.Controls.Add(this.btnCrearCliente);
            this.panelClientesSubMenu.Controls.Add(this.btnListadoClientes);
            this.panelClientesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubMenu.Location = new System.Drawing.Point(0, 577);
            this.panelClientesSubMenu.Name = "panelClientesSubMenu";
            this.panelClientesSubMenu.Size = new System.Drawing.Size(214, 121);
            this.panelClientesSubMenu.TabIndex = 8;
            this.panelClientesSubMenu.Visible = false;
            // 
            // btnAbonosCliente
            // 
            this.btnAbonosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbonosCliente.FlatAppearance.BorderSize = 0;
            this.btnAbonosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonosCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnAbonosCliente.Location = new System.Drawing.Point(0, 90);
            this.btnAbonosCliente.Name = "btnAbonosCliente";
            this.btnAbonosCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAbonosCliente.Size = new System.Drawing.Size(214, 30);
            this.btnAbonosCliente.TabIndex = 3;
            this.btnAbonosCliente.Text = "Abonos del cliente";
            this.btnAbonosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbonosCliente.UseVisualStyleBackColor = true;
            this.btnAbonosCliente.Click += new System.EventHandler(this.btnAbonosCliente_Click);
            // 
            // btnCreditosCliente
            // 
            this.btnCreditosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreditosCliente.FlatAppearance.BorderSize = 0;
            this.btnCreditosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditosCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnCreditosCliente.Location = new System.Drawing.Point(0, 60);
            this.btnCreditosCliente.Name = "btnCreditosCliente";
            this.btnCreditosCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCreditosCliente.Size = new System.Drawing.Size(214, 30);
            this.btnCreditosCliente.TabIndex = 2;
            this.btnCreditosCliente.Text = "Créditos del cliente";
            this.btnCreditosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditosCliente.UseVisualStyleBackColor = true;
            this.btnCreditosCliente.Click += new System.EventHandler(this.btnCreditosCliente_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCliente.FlatAppearance.BorderSize = 0;
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnCrearCliente.Location = new System.Drawing.Point(0, 30);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearCliente.Size = new System.Drawing.Size(214, 30);
            this.btnCrearCliente.TabIndex = 1;
            this.btnCrearCliente.Text = "Crear cliente";
            this.btnCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnListadoClientes
            // 
            this.btnListadoClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoClientes.FlatAppearance.BorderSize = 0;
            this.btnListadoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnListadoClientes.Location = new System.Drawing.Point(0, 0);
            this.btnListadoClientes.Name = "btnListadoClientes";
            this.btnListadoClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnListadoClientes.Size = new System.Drawing.Size(214, 30);
            this.btnListadoClientes.TabIndex = 0;
            this.btnListadoClientes.Text = "Listado de clientes";
            this.btnListadoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoClientes.UseVisualStyleBackColor = true;
            this.btnListadoClientes.Click += new System.EventHandler(this.btnListadoClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Location = new System.Drawing.Point(0, 542);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(214, 35);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "👥  Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelInventarioSubMenu
            // 
            this.panelInventarioSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelInventarioSubMenu.Controls.Add(this.btnAjustesInventario);
            this.panelInventarioSubMenu.Controls.Add(this.btnMovimientosInventario);
            this.panelInventarioSubMenu.Controls.Add(this.btnAlmacenes);
            this.panelInventarioSubMenu.Controls.Add(this.btnMarcas);
            this.panelInventarioSubMenu.Controls.Add(this.btnCategorias);
            this.panelInventarioSubMenu.Controls.Add(this.btnVariacionesProducto);
            this.panelInventarioSubMenu.Controls.Add(this.btnProductos);
            this.panelInventarioSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventarioSubMenu.Location = new System.Drawing.Point(0, 330);
            this.panelInventarioSubMenu.Name = "panelInventarioSubMenu";
            this.panelInventarioSubMenu.Size = new System.Drawing.Size(214, 212);
            this.panelInventarioSubMenu.TabIndex = 6;
            this.panelInventarioSubMenu.Visible = false;
            // 
            // btnAjustesInventario
            // 
            this.btnAjustesInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjustesInventario.FlatAppearance.BorderSize = 0;
            this.btnAjustesInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustesInventario.ForeColor = System.Drawing.Color.Silver;
            this.btnAjustesInventario.Location = new System.Drawing.Point(0, 180);
            this.btnAjustesInventario.Name = "btnAjustesInventario";
            this.btnAjustesInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAjustesInventario.Size = new System.Drawing.Size(214, 30);
            this.btnAjustesInventario.TabIndex = 6;
            this.btnAjustesInventario.Text = "Ajustes de inventario";
            this.btnAjustesInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustesInventario.UseVisualStyleBackColor = true;
            this.btnAjustesInventario.Click += new System.EventHandler(this.btnAjustesInventario_Click);
            // 
            // btnMovimientosInventario
            // 
            this.btnMovimientosInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimientosInventario.FlatAppearance.BorderSize = 0;
            this.btnMovimientosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientosInventario.ForeColor = System.Drawing.Color.Silver;
            this.btnMovimientosInventario.Location = new System.Drawing.Point(0, 150);
            this.btnMovimientosInventario.Name = "btnMovimientosInventario";
            this.btnMovimientosInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMovimientosInventario.Size = new System.Drawing.Size(214, 30);
            this.btnMovimientosInventario.TabIndex = 5;
            this.btnMovimientosInventario.Text = "Movimientos de inventario";
            this.btnMovimientosInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientosInventario.UseVisualStyleBackColor = true;
            this.btnMovimientosInventario.Click += new System.EventHandler(this.btnMovimientosInventario_Click);
            // 
            // btnAlmacenes
            // 
            this.btnAlmacenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlmacenes.FlatAppearance.BorderSize = 0;
            this.btnAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacenes.ForeColor = System.Drawing.Color.Silver;
            this.btnAlmacenes.Location = new System.Drawing.Point(0, 120);
            this.btnAlmacenes.Name = "btnAlmacenes";
            this.btnAlmacenes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAlmacenes.Size = new System.Drawing.Size(214, 30);
            this.btnAlmacenes.TabIndex = 4;
            this.btnAlmacenes.Text = "Almacenes";
            this.btnAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacenes.UseVisualStyleBackColor = true;
            this.btnAlmacenes.Click += new System.EventHandler(this.btnAlmacenes_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.ForeColor = System.Drawing.Color.Silver;
            this.btnMarcas.Location = new System.Drawing.Point(0, 90);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(214, 30);
            this.btnMarcas.TabIndex = 3;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.ForeColor = System.Drawing.Color.Silver;
            this.btnCategorias.Location = new System.Drawing.Point(0, 60);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(214, 30);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnVariacionesProducto
            // 
            this.btnVariacionesProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVariacionesProducto.FlatAppearance.BorderSize = 0;
            this.btnVariacionesProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariacionesProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnVariacionesProducto.Location = new System.Drawing.Point(0, 30);
            this.btnVariacionesProducto.Name = "btnVariacionesProducto";
            this.btnVariacionesProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVariacionesProducto.Size = new System.Drawing.Size(214, 30);
            this.btnVariacionesProducto.TabIndex = 1;
            this.btnVariacionesProducto.Text = "Variaciones de producto";
            this.btnVariacionesProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariacionesProducto.UseVisualStyleBackColor = true;
            this.btnVariacionesProducto.Click += new System.EventHandler(this.btnVariacionesProducto_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.Silver;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(214, 30);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.Location = new System.Drawing.Point(0, 295);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(214, 35);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "📦  Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // panelVentasSubMenu
            // 
            this.panelVentasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelVentasSubMenu.Controls.Add(this.btnPagosClientes);
            this.panelVentasSubMenu.Controls.Add(this.btnVentasCredito);
            this.panelVentasSubMenu.Controls.Add(this.btnHistorialVentas);
            this.panelVentasSubMenu.Controls.Add(this.btnNuevaVenta);
            this.panelVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentasSubMenu.Location = new System.Drawing.Point(0, 174);
            this.panelVentasSubMenu.Name = "panelVentasSubMenu";
            this.panelVentasSubMenu.Size = new System.Drawing.Size(214, 121);
            this.panelVentasSubMenu.TabIndex = 4;
            this.panelVentasSubMenu.Visible = false;
            // 
            // btnPagosClientes
            // 
            this.btnPagosClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagosClientes.FlatAppearance.BorderSize = 0;
            this.btnPagosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagosClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnPagosClientes.Location = new System.Drawing.Point(0, 90);
            this.btnPagosClientes.Name = "btnPagosClientes";
            this.btnPagosClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPagosClientes.Size = new System.Drawing.Size(214, 30);
            this.btnPagosClientes.TabIndex = 3;
            this.btnPagosClientes.Text = "Pagos de clientes";
            this.btnPagosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagosClientes.UseVisualStyleBackColor = true;
            this.btnPagosClientes.Click += new System.EventHandler(this.btnPagosClientes_Click);
            // 
            // btnVentasCredito
            // 
            this.btnVentasCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentasCredito.FlatAppearance.BorderSize = 0;
            this.btnVentasCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasCredito.ForeColor = System.Drawing.Color.Silver;
            this.btnVentasCredito.Location = new System.Drawing.Point(0, 60);
            this.btnVentasCredito.Name = "btnVentasCredito";
            this.btnVentasCredito.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVentasCredito.Size = new System.Drawing.Size(214, 30);
            this.btnVentasCredito.TabIndex = 2;
            this.btnVentasCredito.Text = "Ventas a crédito";
            this.btnVentasCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasCredito.UseVisualStyleBackColor = true;
            this.btnVentasCredito.Click += new System.EventHandler(this.btnVentasCredito_Click);
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialVentas.FlatAppearance.BorderSize = 0;
            this.btnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialVentas.ForeColor = System.Drawing.Color.Silver;
            this.btnHistorialVentas.Location = new System.Drawing.Point(0, 30);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorialVentas.Size = new System.Drawing.Size(214, 30);
            this.btnHistorialVentas.TabIndex = 1;
            this.btnHistorialVentas.Text = "Historial de ventas";
            this.btnHistorialVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialVentas.UseVisualStyleBackColor = true;
            this.btnHistorialVentas.Click += new System.EventHandler(this.btnHistorialVentas_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevaVenta.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaVenta.Size = new System.Drawing.Size(214, 30);
            this.btnNuevaVenta.TabIndex = 0;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.Location = new System.Drawing.Point(0, 139);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(214, 35);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "🛒  Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Location = new System.Drawing.Point(0, 104);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(214, 35);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "🏠  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.Location = new System.Drawing.Point(0, 69);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(214, 35);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "☰  Menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(214, 69);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(214, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(638, 722);
            this.panelChildForm.TabIndex = 1;
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 10;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // MenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(852, 722);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSidebar);
            this.MaximizeBox = false;
            this.Name = "MenuOptions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Ventas - Boutique";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuOptions_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelConfiguracionSubMenu.ResumeLayout(false);
            this.panelAdministracionSubMenu.ResumeLayout(false);
            this.panelFinanzasSubMenu.ResumeLayout(false);
            this.panelProveedoresSubMenu.ResumeLayout(false);
            this.panelClientesSubMenu.ResumeLayout(false);
            this.panelInventarioSubMenu.ResumeLayout(false);
            this.panelVentasSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
