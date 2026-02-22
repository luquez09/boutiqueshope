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
        private System.Windows.Forms.Button btnPagosClientes;

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel panelInventarioSubMenu;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVariacionesProducto;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnAlmacenes;
        private System.Windows.Forms.Button btnAjusteInventarios;

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelClientesSubMenu;
        private System.Windows.Forms.Button btnCrearCliente;

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panelProveedoresSubMenu;
        private System.Windows.Forms.Button btnListadoProveedores;
        private System.Windows.Forms.Button btnCrearProveedor;

        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Panel panelAdministracionSubMenu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRoles;

        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel panelConfiguracionSubMenu;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnImpresoras;

        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Panel panelChildForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelConfiguracionSubMenu = new System.Windows.Forms.Panel();
            this.btnImpresoras = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.panelAdministracionSubMenu = new System.Windows.Forms.Panel();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.panelProveedoresSubMenu = new System.Windows.Forms.Panel();
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.btnListadoProveedores = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.panelClientesSubMenu = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelInventarioSubMenu = new System.Windows.Forms.Panel();
            this.btnHistorialInventario = new System.Windows.Forms.Button();
            this.btnAjusteInventarios = new System.Windows.Forms.Button();
            this.btnAlmacenes = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnVariacionesProducto = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panelVentasSubMenu = new System.Windows.Forms.Panel();
            this.btnPagosClientes = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelConfiguracionSubMenu.SuspendLayout();
            this.panelAdministracionSubMenu.SuspendLayout();
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
            this.panelSidebar.Size = new System.Drawing.Size(214, 749);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 709);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(214, 40);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "⏻  Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelConfiguracionSubMenu
            // 
            this.panelConfiguracionSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelConfiguracionSubMenu.Controls.Add(this.btnImpresoras);
            this.panelConfiguracionSubMenu.Controls.Add(this.btnParametros);
            this.panelConfiguracionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracionSubMenu.Location = new System.Drawing.Point(0, 847);
            this.panelConfiguracionSubMenu.Name = "panelConfiguracionSubMenu";
            this.panelConfiguracionSubMenu.Size = new System.Drawing.Size(214, 63);
            this.panelConfiguracionSubMenu.TabIndex = 16;
            this.panelConfiguracionSubMenu.Visible = false;
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
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 812);
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
            this.panelAdministracionSubMenu.Controls.Add(this.btnRoles);
            this.panelAdministracionSubMenu.Controls.Add(this.btnUsuarios);
            this.panelAdministracionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdministracionSubMenu.Location = new System.Drawing.Point(0, 746);
            this.panelAdministracionSubMenu.Name = "panelAdministracionSubMenu";
            this.panelAdministracionSubMenu.Size = new System.Drawing.Size(214, 66);
            this.panelAdministracionSubMenu.TabIndex = 14;
            this.panelAdministracionSubMenu.Visible = false;
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
            this.btnAdministracion.Location = new System.Drawing.Point(0, 711);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(214, 35);
            this.btnAdministracion.TabIndex = 13;
            this.btnAdministracion.Text = "🛠  Administración";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // panelProveedoresSubMenu
            // 
            this.panelProveedoresSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panelProveedoresSubMenu.Controls.Add(this.btnCrearProveedor);
            this.panelProveedoresSubMenu.Controls.Add(this.btnListadoProveedores);
            this.panelProveedoresSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProveedoresSubMenu.Location = new System.Drawing.Point(0, 650);
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
            this.btnProveedores.Location = new System.Drawing.Point(0, 615);
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
            this.panelClientesSubMenu.Controls.Add(this.btnBuscarCliente);
            this.panelClientesSubMenu.Controls.Add(this.btnCrearCliente);
            this.panelClientesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubMenu.Location = new System.Drawing.Point(0, 549);
            this.panelClientesSubMenu.Name = "panelClientesSubMenu";
            this.panelClientesSubMenu.Size = new System.Drawing.Size(214, 66);
            this.panelClientesSubMenu.TabIndex = 8;
            this.panelClientesSubMenu.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarCliente.Location = new System.Drawing.Point(0, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBuscarCliente.Size = new System.Drawing.Size(214, 30);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCliente.FlatAppearance.BorderSize = 0;
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnCrearCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearCliente.Size = new System.Drawing.Size(214, 30);
            this.btnCrearCliente.TabIndex = 1;
            this.btnCrearCliente.Text = "Crear cliente";
            this.btnCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Location = new System.Drawing.Point(0, 514);
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
            this.panelInventarioSubMenu.Controls.Add(this.btnHistorialInventario);
            this.panelInventarioSubMenu.Controls.Add(this.btnAjusteInventarios);
            this.panelInventarioSubMenu.Controls.Add(this.btnAlmacenes);
            this.panelInventarioSubMenu.Controls.Add(this.btnMarcas);
            this.panelInventarioSubMenu.Controls.Add(this.btnCategorias);
            this.panelInventarioSubMenu.Controls.Add(this.btnVariacionesProducto);
            this.panelInventarioSubMenu.Controls.Add(this.btnProductos);
            this.panelInventarioSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventarioSubMenu.Location = new System.Drawing.Point(0, 303);
            this.panelInventarioSubMenu.Name = "panelInventarioSubMenu";
            this.panelInventarioSubMenu.Size = new System.Drawing.Size(214, 211);
            this.panelInventarioSubMenu.TabIndex = 6;
            this.panelInventarioSubMenu.Visible = false;
            // 
            // btnHistorialInventario
            // 
            this.btnHistorialInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialInventario.FlatAppearance.BorderSize = 0;
            this.btnHistorialInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialInventario.ForeColor = System.Drawing.Color.Silver;
            this.btnHistorialInventario.Location = new System.Drawing.Point(0, 180);
            this.btnHistorialInventario.Name = "btnHistorialInventario";
            this.btnHistorialInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorialInventario.Size = new System.Drawing.Size(214, 30);
            this.btnHistorialInventario.TabIndex = 6;
            this.btnHistorialInventario.Text = "Historial Inventario";
            this.btnHistorialInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialInventario.UseVisualStyleBackColor = true;
            this.btnHistorialInventario.Click += new System.EventHandler(this.btnHistorialInventario_Click);
            // 
            // btnAjusteInventarios
            // 
            this.btnAjusteInventarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjusteInventarios.FlatAppearance.BorderSize = 0;
            this.btnAjusteInventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjusteInventarios.ForeColor = System.Drawing.Color.Silver;
            this.btnAjusteInventarios.Location = new System.Drawing.Point(0, 150);
            this.btnAjusteInventarios.Name = "btnAjusteInventarios";
            this.btnAjusteInventarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAjusteInventarios.Size = new System.Drawing.Size(214, 30);
            this.btnAjusteInventarios.TabIndex = 5;
            this.btnAjusteInventarios.Text = "Ajuste de inventario";
            this.btnAjusteInventarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjusteInventarios.UseVisualStyleBackColor = true;
            this.btnAjusteInventarios.Click += new System.EventHandler(this.btnMovimientosInventario_Click);
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
            this.btnInventario.Location = new System.Drawing.Point(0, 268);
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
            this.panelVentasSubMenu.Controls.Add(this.btnHistorialVentas);
            this.panelVentasSubMenu.Controls.Add(this.btnNuevaVenta);
            this.panelVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentasSubMenu.Location = new System.Drawing.Point(0, 174);
            this.panelVentasSubMenu.Name = "panelVentasSubMenu";
            this.panelVentasSubMenu.Size = new System.Drawing.Size(214, 94);
            this.panelVentasSubMenu.TabIndex = 4;
            this.panelVentasSubMenu.Visible = false;
            // 
            // btnPagosClientes
            // 
            this.btnPagosClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagosClientes.FlatAppearance.BorderSize = 0;
            this.btnPagosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagosClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnPagosClientes.Location = new System.Drawing.Point(0, 60);
            this.btnPagosClientes.Name = "btnPagosClientes";
            this.btnPagosClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPagosClientes.Size = new System.Drawing.Size(214, 30);
            this.btnPagosClientes.TabIndex = 3;
            this.btnPagosClientes.Text = "Pagos de clientes";
            this.btnPagosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagosClientes.UseVisualStyleBackColor = true;
            this.btnPagosClientes.Click += new System.EventHandler(this.btnPagosClientes_Click);
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
            this.btnDashboard.Visible = false;
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
            this.panelChildForm.Size = new System.Drawing.Size(770, 749);
            this.panelChildForm.TabIndex = 1;
            // 
            // MenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSidebar);
            this.MaximizeBox = false;
            this.Name = "MenuOptions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas - Boutique";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuOptions_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelConfiguracionSubMenu.ResumeLayout(false);
            this.panelAdministracionSubMenu.ResumeLayout(false);
            this.panelProveedoresSubMenu.ResumeLayout(false);
            this.panelClientesSubMenu.ResumeLayout(false);
            this.panelInventarioSubMenu.ResumeLayout(false);
            this.panelVentasSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistorialInventario;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}
