namespace boutiqueshope.UI.Inventario
{
    partial class MovimientoInventarioUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelFiltros = new System.Windows.Forms.Panel();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.comboAlmacen = new System.Windows.Forms.ComboBox();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.comboVariacion = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdTodosTipoMov = new System.Windows.Forms.RadioButton();
            this.rdSalidaTipoMov = new System.Windows.Forms.RadioButton();
            this.rdEntradaTipoMov = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdTodosDocuOrigen = new System.Windows.Forms.RadioButton();
            this.rdTrasladoDocuOrigen = new System.Windows.Forms.RadioButton();
            this.rdAjusteDocuOrigen = new System.Windows.Forms.RadioButton();
            this.rdCompraDocuOrigen = new System.Windows.Forms.RadioButton();
            this.rdVentaDocuOrigen = new System.Windows.Forms.RadioButton();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtDateDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtDateHasta = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewMovimientos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelFiltros.SuspendLayout();
            this.groupBoxFiltros.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelFiltros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMovimientos, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.979073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.20927F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.76682F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.92676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.715994F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 669);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1003, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL MOVIMIENTO DE INVENTARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFiltros
            // 
            this.PanelFiltros.BackColor = System.Drawing.Color.OldLace;
            this.tableLayoutPanel1.SetColumnSpan(this.PanelFiltros, 2);
            this.PanelFiltros.Controls.Add(this.groupBoxFiltros);
            this.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFiltros.Location = new System.Drawing.Point(3, 42);
            this.PanelFiltros.Name = "PanelFiltros";
            this.PanelFiltros.Size = new System.Drawing.Size(1003, 261);
            this.PanelFiltros.TabIndex = 1;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiltros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltros.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(1003, 261);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46409F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.72876F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53326F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscar, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboProducto, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboAlmacen, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboUsuario, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboVariacion, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiar, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaDesde, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.dtDateDesde, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaHasta, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtDateHasta, 3, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.2037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.07407F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(997, 236);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Almacen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Movimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Documento Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Variacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha Desde";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha Hasta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(13, 176);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 47);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "REALIZAR BUSQUEDA";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(173, 13);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(424, 26);
            this.comboProducto.TabIndex = 10;
            this.comboProducto.SelectedIndexChanged += new System.EventHandler(this.comboProducto_SelectedIndexChanged);
            // 
            // comboAlmacen
            // 
            this.comboAlmacen.FormattingEnabled = true;
            this.comboAlmacen.Location = new System.Drawing.Point(173, 49);
            this.comboAlmacen.Name = "comboAlmacen";
            this.comboAlmacen.Size = new System.Drawing.Size(424, 26);
            this.comboAlmacen.TabIndex = 11;
            // 
            // comboUsuario
            // 
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(720, 49);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(264, 26);
            this.comboUsuario.TabIndex = 12;
            // 
            // comboVariacion
            // 
            this.comboVariacion.FormattingEnabled = true;
            this.comboVariacion.Location = new System.Drawing.Point(720, 13);
            this.comboVariacion.Name = "comboVariacion";
            this.comboVariacion.Size = new System.Drawing.Size(264, 26);
            this.comboVariacion.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(173, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 47);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR BUSQUEDA";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdTodosTipoMov);
            this.panel1.Controls.Add(this.rdSalidaTipoMov);
            this.panel1.Controls.Add(this.rdEntradaTipoMov);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(173, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 29);
            this.panel1.TabIndex = 16;
            // 
            // rdTodosTipoMov
            // 
            this.rdTodosTipoMov.AutoSize = true;
            this.rdTodosTipoMov.Location = new System.Drawing.Point(201, 4);
            this.rdTodosTipoMov.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rdTodosTipoMov.Name = "rdTodosTipoMov";
            this.rdTodosTipoMov.Size = new System.Drawing.Size(68, 22);
            this.rdTodosTipoMov.TabIndex = 2;
            this.rdTodosTipoMov.Text = "Todos";
            this.rdTodosTipoMov.UseVisualStyleBackColor = true;
            // 
            // rdSalidaTipoMov
            // 
            this.rdSalidaTipoMov.AutoSize = true;
            this.rdSalidaTipoMov.Location = new System.Drawing.Point(107, 4);
            this.rdSalidaTipoMov.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rdSalidaTipoMov.Name = "rdSalidaTipoMov";
            this.rdSalidaTipoMov.Size = new System.Drawing.Size(71, 22);
            this.rdSalidaTipoMov.TabIndex = 1;
            this.rdSalidaTipoMov.Text = "Salida";
            this.rdSalidaTipoMov.UseVisualStyleBackColor = true;
            // 
            // rdEntradaTipoMov
            // 
            this.rdEntradaTipoMov.AutoSize = true;
            this.rdEntradaTipoMov.Checked = true;
            this.rdEntradaTipoMov.Location = new System.Drawing.Point(3, 4);
            this.rdEntradaTipoMov.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rdEntradaTipoMov.Name = "rdEntradaTipoMov";
            this.rdEntradaTipoMov.Size = new System.Drawing.Size(81, 22);
            this.rdEntradaTipoMov.TabIndex = 0;
            this.rdEntradaTipoMov.TabStop = true;
            this.rdEntradaTipoMov.Text = "Entrada";
            this.rdEntradaTipoMov.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdTodosDocuOrigen);
            this.panel2.Controls.Add(this.rdTrasladoDocuOrigen);
            this.panel2.Controls.Add(this.rdAjusteDocuOrigen);
            this.panel2.Controls.Add(this.rdCompraDocuOrigen);
            this.panel2.Controls.Add(this.rdVentaDocuOrigen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(173, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 26);
            this.panel2.TabIndex = 17;
            // 
            // rdTodosDocuOrigen
            // 
            this.rdTodosDocuOrigen.AutoSize = true;
            this.rdTodosDocuOrigen.Location = new System.Drawing.Point(341, 1);
            this.rdTodosDocuOrigen.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.rdTodosDocuOrigen.Name = "rdTodosDocuOrigen";
            this.rdTodosDocuOrigen.Size = new System.Drawing.Size(68, 22);
            this.rdTodosDocuOrigen.TabIndex = 7;
            this.rdTodosDocuOrigen.Text = "Todos";
            this.rdTodosDocuOrigen.UseVisualStyleBackColor = true;
            // 
            // rdTrasladoDocuOrigen
            // 
            this.rdTrasladoDocuOrigen.AutoSize = true;
            this.rdTrasladoDocuOrigen.Location = new System.Drawing.Point(247, 1);
            this.rdTrasladoDocuOrigen.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.rdTrasladoDocuOrigen.Name = "rdTrasladoDocuOrigen";
            this.rdTrasladoDocuOrigen.Size = new System.Drawing.Size(86, 22);
            this.rdTrasladoDocuOrigen.TabIndex = 6;
            this.rdTrasladoDocuOrigen.Text = "Traslado";
            this.rdTrasladoDocuOrigen.UseVisualStyleBackColor = true;
            // 
            // rdAjusteDocuOrigen
            // 
            this.rdAjusteDocuOrigen.AutoSize = true;
            this.rdAjusteDocuOrigen.Location = new System.Drawing.Point(170, 1);
            this.rdAjusteDocuOrigen.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.rdAjusteDocuOrigen.Name = "rdAjusteDocuOrigen";
            this.rdAjusteDocuOrigen.Size = new System.Drawing.Size(69, 22);
            this.rdAjusteDocuOrigen.TabIndex = 5;
            this.rdAjusteDocuOrigen.Text = "Ajuste";
            this.rdAjusteDocuOrigen.UseVisualStyleBackColor = true;
            // 
            // rdCompraDocuOrigen
            // 
            this.rdCompraDocuOrigen.AutoSize = true;
            this.rdCompraDocuOrigen.Location = new System.Drawing.Point(77, 1);
            this.rdCompraDocuOrigen.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.rdCompraDocuOrigen.Name = "rdCompraDocuOrigen";
            this.rdCompraDocuOrigen.Size = new System.Drawing.Size(83, 22);
            this.rdCompraDocuOrigen.TabIndex = 4;
            this.rdCompraDocuOrigen.Text = "Compra";
            this.rdCompraDocuOrigen.UseVisualStyleBackColor = true;
            // 
            // rdVentaDocuOrigen
            // 
            this.rdVentaDocuOrigen.AutoSize = true;
            this.rdVentaDocuOrigen.Checked = true;
            this.rdVentaDocuOrigen.Location = new System.Drawing.Point(3, 1);
            this.rdVentaDocuOrigen.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.rdVentaDocuOrigen.Name = "rdVentaDocuOrigen";
            this.rdVentaDocuOrigen.Size = new System.Drawing.Size(66, 22);
            this.rdVentaDocuOrigen.TabIndex = 3;
            this.rdVentaDocuOrigen.TabStop = true;
            this.rdVentaDocuOrigen.Text = "Venta";
            this.rdVentaDocuOrigen.UseVisualStyleBackColor = true;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(720, 173);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(0, 18);
            this.lblFechaDesde.TabIndex = 14;
            // 
            // dtDateDesde
            // 
            this.dtDateDesde.Checked = false;
            this.dtDateDesde.Location = new System.Drawing.Point(720, 109);
            this.dtDateDesde.MaxDate = new System.DateTime(2709, 12, 31, 0, 0, 0, 0);
            this.dtDateDesde.Name = "dtDateDesde";
            this.dtDateDesde.Size = new System.Drawing.Size(264, 26);
            this.dtDateDesde.TabIndex = 1;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(13, 82);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(0, 18);
            this.lblFechaHasta.TabIndex = 15;
            // 
            // dtDateHasta
            // 
            this.dtDateHasta.Location = new System.Drawing.Point(720, 144);
            this.dtDateHasta.Name = "dtDateHasta";
            this.dtDateHasta.Size = new System.Drawing.Size(264, 26);
            this.dtDateHasta.TabIndex = 18;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 606);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 60);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::boutiqueshope.Properties.Resources.XLS_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exportar Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewMovimientos
            // 
            this.dataGridViewMovimientos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Fecha,
            this.Producto,
            this.Variacion,
            this.Almacen,
            this.TipoMovimiento,
            this.Documento,
            this.Cantidad,
            this.CostoUnitario,
            this.CostoTotal});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewMovimientos, 2);
            this.dataGridViewMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMovimientos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewMovimientos.Location = new System.Drawing.Point(3, 309);
            this.dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridViewMovimientos, 2);
            this.dataGridViewMovimientos.Size = new System.Drawing.Size(1003, 291);
            this.dataGridViewMovimientos.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha Registro";
            this.Fecha.Name = "Fecha";
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Nombre Producto";
            this.Producto.Name = "Producto";
            // 
            // Variacion
            // 
            this.Variacion.DataPropertyName = "Variacion";
            this.Variacion.HeaderText = "Variacion";
            this.Variacion.Name = "Variacion";
            // 
            // Almacen
            // 
            this.Almacen.DataPropertyName = "Almacen";
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.DataPropertyName = "TipoMovimiento";
            this.TipoMovimiento.HeaderText = "Tipo de Movimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.DataPropertyName = "CostoUnitario";
            this.CostoUnitario.HeaderText = "CostoUnitario";
            this.CostoUnitario.Name = "CostoUnitario";
            // 
            // CostoTotal
            // 
            this.CostoTotal.DataPropertyName = "CostoTotal";
            this.CostoTotal.HeaderText = "CostoTotal";
            this.CostoTotal.Name = "CostoTotal";
            // 
            // MovimientoInventarioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1037, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovimientoInventarioUI";
            this.ShowIcon = false;
            this.Text = "MovimientoInventarioUI";
            this.Load += new System.EventHandler(this.MovimientoInventarioUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PanelFiltros.ResumeLayout(false);
            this.groupBoxFiltros.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelFiltros;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.ComboBox comboAlmacen;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.ComboBox comboVariacion;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdTodosTipoMov;
        private System.Windows.Forms.RadioButton rdSalidaTipoMov;
        private System.Windows.Forms.RadioButton rdEntradaTipoMov;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdTodosDocuOrigen;
        private System.Windows.Forms.RadioButton rdTrasladoDocuOrigen;
        private System.Windows.Forms.RadioButton rdAjusteDocuOrigen;
        private System.Windows.Forms.RadioButton rdCompraDocuOrigen;
        private System.Windows.Forms.RadioButton rdVentaDocuOrigen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewMovimientos;
        private System.Windows.Forms.DateTimePicker dtDateDesde;
        private System.Windows.Forms.DateTimePicker dtDateHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
    }
}
