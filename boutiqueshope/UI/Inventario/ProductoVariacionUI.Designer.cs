namespace boutiqueshope.UI
{
    partial class ProductoVariacionUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblColores = new System.Windows.Forms.Label();
            this.lblTallas = new System.Windows.Forms.Label();
            this.dataGridViewVariacion = new System.Windows.Forms.DataGridView();
            this.modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarVariacion = new System.Windows.Forms.Button();
            this.btnGestionarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoSku = new System.Windows.Forms.TextBox();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoQr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigoSku = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.checkedListBoxTallas = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxColores = new System.Windows.Forms.CheckedListBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblCodProdut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColores.Location = new System.Drawing.Point(17, 40);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(63, 20);
            this.lblColores.TabIndex = 1;
            this.lblColores.Text = "Colores";
            this.lblColores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTallas
            // 
            this.lblTallas.AutoSize = true;
            this.lblTallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallas.Location = new System.Drawing.Point(192, 40);
            this.lblTallas.Name = "lblTallas";
            this.lblTallas.Size = new System.Drawing.Size(50, 20);
            this.lblTallas.TabIndex = 11;
            this.lblTallas.Text = "Tallas";
            this.lblTallas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewVariacion
            // 
            this.dataGridViewVariacion.AllowUserToAddRows = false;
            this.dataGridViewVariacion.AllowUserToDeleteRows = false;
            this.dataGridViewVariacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVariacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewVariacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVariacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVariacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modificado,
            this.Acciones});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVariacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVariacion.Location = new System.Drawing.Point(8, 265);
            this.dataGridViewVariacion.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewVariacion.Name = "dataGridViewVariacion";
            this.dataGridViewVariacion.Size = new System.Drawing.Size(790, 215);
            this.dataGridViewVariacion.TabIndex = 14;
            this.dataGridViewVariacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVariacion_CellClick);
            this.dataGridViewVariacion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVariacion_CellValueChanged);
            this.dataGridViewVariacion.CurrentCellChanged += new System.EventHandler(this.dataGridViewVariacion_CurrentCellChanged);
            this.dataGridViewVariacion.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewVariacion_EditingControlShowing);
            this.dataGridViewVariacion.SelectionChanged += new System.EventHandler(this.dataGridViewVariacion_SelectionChanged);
            // 
            // modificado
            // 
            this.modificado.HeaderText = "modificado";
            this.modificado.Name = "modificado";
            this.modificado.Visible = false;
            // 
            // Acciones
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Acciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.Acciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.Text = "Eliminar";
            this.Acciones.ToolTipText = "Eliminacion registro";
            this.Acciones.UseColumnTextForButtonValue = true;
            // 
            // btnAgregarVariacion
            // 
            this.btnAgregarVariacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarVariacion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVariacion.Location = new System.Drawing.Point(143, 177);
            this.btnAgregarVariacion.Name = "btnAgregarVariacion";
            this.btnAgregarVariacion.Size = new System.Drawing.Size(134, 34);
            this.btnAgregarVariacion.TabIndex = 13;
            this.btnAgregarVariacion.Text = "AGREGAR";
            this.btnAgregarVariacion.UseVisualStyleBackColor = false;
            this.btnAgregarVariacion.Click += new System.EventHandler(this.btnAgregarVariacion_Click);
            // 
            // btnGestionarProducto
            // 
            this.btnGestionarProducto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGestionarProducto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnGestionarProducto.Location = new System.Drawing.Point(283, 177);
            this.btnGestionarProducto.Name = "btnGestionarProducto";
            this.btnGestionarProducto.Size = new System.Drawing.Size(135, 34);
            this.btnGestionarProducto.TabIndex = 16;
            this.btnGestionarProducto.Text = "TERMINAR";
            this.btnGestionarProducto.UseVisualStyleBackColor = false;
            this.btnGestionarProducto.Click += new System.EventHandler(this.btnGestionarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(82, 36);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(231, 26);
            this.txtProducto.TabIndex = 5;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtCodigoSku
            // 
            this.txtCodigoSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSku.Location = new System.Drawing.Point(388, 33);
            this.txtCodigoSku.Name = "txtCodigoSku";
            this.txtCodigoSku.Size = new System.Drawing.Size(211, 26);
            this.txtCodigoSku.TabIndex = 6;
            this.txtCodigoSku.TextChanged += new System.EventHandler(this.txtCodigoSku_TextChanged);
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AllowUserToAddRows = false;
            this.dataGridViewProducto.AllowUserToDeleteRows = false;
            this.dataGridViewProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Costo,
            this.PorcentajeGanancia,
            this.PrecioVenta,
            this.StockMinimo,
            this.ProveedorId,
            this.MarcaId,
            this.CategoriaId,
            this.CodigoBarras,
            this.CodigoQr,
            this.FechaCreacion,
            this.Descripcion,
            this.Nombre,
            this.CodigoSku,
            this.Activo});
            this.dataGridViewProducto.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewProducto.Location = new System.Drawing.Point(11, 77);
            this.dataGridViewProducto.MultiSelect = false;
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.ReadOnly = true;
            this.dataGridViewProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducto.Size = new System.Drawing.Size(790, 136);
            this.dataGridViewProducto.TabIndex = 7;
            this.dataGridViewProducto.SelectionChanged += new System.EventHandler(this.dataGridViewProducto_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 14.62532F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Visible = false;
            // 
            // PorcentajeGanancia
            // 
            this.PorcentajeGanancia.DataPropertyName = "PorcentajeGanancia";
            this.PorcentajeGanancia.HeaderText = "% Ganancia";
            this.PorcentajeGanancia.Name = "PorcentajeGanancia";
            this.PorcentajeGanancia.ReadOnly = true;
            this.PorcentajeGanancia.Visible = false;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            // 
            // StockMinimo
            // 
            this.StockMinimo.DataPropertyName = "StockMinimo";
            this.StockMinimo.HeaderText = "StockMinimo";
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            this.StockMinimo.Visible = false;
            // 
            // ProveedorId
            // 
            this.ProveedorId.DataPropertyName = "ProveedorId";
            this.ProveedorId.HeaderText = "ProveedorId";
            this.ProveedorId.Name = "ProveedorId";
            this.ProveedorId.ReadOnly = true;
            this.ProveedorId.Visible = false;
            // 
            // MarcaId
            // 
            this.MarcaId.DataPropertyName = "MarcaId";
            this.MarcaId.HeaderText = "MarcaId";
            this.MarcaId.Name = "MarcaId";
            this.MarcaId.ReadOnly = true;
            this.MarcaId.Visible = false;
            // 
            // CategoriaId
            // 
            this.CategoriaId.DataPropertyName = "CategoriaId";
            this.CategoriaId.HeaderText = "CategoriaId";
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.ReadOnly = true;
            this.CategoriaId.Visible = false;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "CodigoBarras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            this.CodigoBarras.Visible = false;
            // 
            // CodigoQr
            // 
            this.CodigoQr.DataPropertyName = "CodigoQr";
            this.CodigoQr.HeaderText = "CodigoQr";
            this.CodigoQr.Name = "CodigoQr";
            this.CodigoQr.ReadOnly = true;
            this.CodigoQr.Visible = false;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "FechaCreacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 203.0457F;
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CodigoSku
            // 
            this.CodigoSku.DataPropertyName = "CodigoSku";
            this.CodigoSku.FillWeight = 91.16449F;
            this.CodigoSku.HeaderText = "Codigo";
            this.CodigoSku.Name = "CodigoSku";
            this.CodigoSku.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.FillWeight = 91.16449F;
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoId.Location = new System.Drawing.Point(860, 53);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(0, 20);
            this.lblProductoId.TabIndex = 8;
            this.lblProductoId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigoSku);
            this.groupBox1.Controls.Add(this.dataGridViewProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 219);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto - Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(690, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 34);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.checkedListBoxTallas);
            this.groupBox2.Controls.Add(this.checkedListBoxColores);
            this.groupBox2.Controls.Add(this.lblInformacion);
            this.groupBox2.Controls.Add(this.dataGridViewVariacion);
            this.groupBox2.Controls.Add(this.lblColores);
            this.groupBox2.Controls.Add(this.lblTallas);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 506);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto - Variacion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigoSku, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaCreacion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarVariacion, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCosto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGestionarProducto, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecioVenta, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigoBarra, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(374, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.13746F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 217);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Codigo Producto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoSku
            // 
            this.lblCodigoSku.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCodigoSku, 2);
            this.lblCodigoSku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSku.Location = new System.Drawing.Point(143, 0);
            this.lblCodigoSku.Name = "lblCodigoSku";
            this.lblCodigoSku.Size = new System.Drawing.Size(275, 29);
            this.lblCodigoSku.TabIndex = 18;
            this.lblCodigoSku.Text = "-";
            this.lblCodigoSku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFechaCreacion, 2);
            this.lblFechaCreacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(143, 145);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(275, 29);
            this.lblFechaCreacion.TabIndex = 24;
            this.lblFechaCreacion.Text = "-";
            this.lblFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 29);
            this.label16.TabIndex = 23;
            this.label16.Text = "Fecha Creacion";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCosto, 2);
            this.lblCosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(143, 87);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(275, 29);
            this.lblCosto.TabIndex = 22;
            this.lblCosto.Text = "-";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 29);
            this.label14.TabIndex = 21;
            this.label14.Text = "Costo";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo Barras";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio Venta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPrecioVenta, 2);
            this.lblPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(143, 116);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(275, 29);
            this.lblPrecioVenta.TabIndex = 20;
            this.lblPrecioVenta.Text = "-";
            this.lblPrecioVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCodigoBarra, 2);
            this.lblCodigoBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.Location = new System.Drawing.Point(143, 29);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(275, 29);
            this.lblCodigoBarra.TabIndex = 16;
            this.lblCodigoBarra.Text = "-";
            this.lblCodigoBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxTallas
            // 
            this.checkedListBoxTallas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxTallas.FormattingEnabled = true;
            this.checkedListBoxTallas.Location = new System.Drawing.Point(196, 63);
            this.checkedListBoxTallas.Name = "checkedListBoxTallas";
            this.checkedListBoxTallas.Size = new System.Drawing.Size(143, 194);
            this.checkedListBoxTallas.TabIndex = 27;
            // 
            // checkedListBoxColores
            // 
            this.checkedListBoxColores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxColores.FormattingEnabled = true;
            this.checkedListBoxColores.Location = new System.Drawing.Point(21, 63);
            this.checkedListBoxColores.Name = "checkedListBoxColores";
            this.checkedListBoxColores.Size = new System.Drawing.Size(143, 194);
            this.checkedListBoxColores.TabIndex = 26;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(8, 485);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 18);
            this.lblInformacion.TabIndex = 25;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(861, 23);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(0, 13);
            this.lblCodigoProducto.TabIndex = 19;
            this.lblCodigoProducto.Visible = false;
            // 
            // lblCodProdut
            // 
            this.lblCodProdut.AutoSize = true;
            this.lblCodProdut.Location = new System.Drawing.Point(861, 100);
            this.lblCodProdut.Name = "lblCodProdut";
            this.lblCodProdut.Size = new System.Drawing.Size(0, 13);
            this.lblCodProdut.TabIndex = 20;
            this.lblCodProdut.Visible = false;
            // 
            // ProductoVariacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 772);
            this.Controls.Add(this.lblCodProdut);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProductoId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductoVariacionUI";
            this.Text = "ProductoVariacionUI";
            this.Load += new System.EventHandler(this.ProductoVariacionUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.Label lblTallas;
        private System.Windows.Forms.DataGridView dataGridViewVariacion;
        private System.Windows.Forms.Button btnAgregarVariacion;
        private System.Windows.Forms.Button btnGestionarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigoSku;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCodigoSku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblCodProdut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoQr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSku;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.CheckedListBox checkedListBoxColores;
        private System.Windows.Forms.CheckedListBox checkedListBoxTallas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificado;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}
