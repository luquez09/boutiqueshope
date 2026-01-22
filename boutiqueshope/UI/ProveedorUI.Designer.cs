namespace boutiqueshope.UI
{
    partial class ProveedorUI
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

        #region Código generado por el Diseñador

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.lblProveedorId = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtContactoTelefono = new System.Windows.Forms.TextBox();
            this.lblContactoTelefono = new System.Windows.Forms.Label();
            this.txtContactoNombre = new System.Windows.Forms.TextBox();
            this.lblContactoNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridProveedor = new System.Windows.Forms.DataGridView();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.lblProveedorId);
            this.groupBoxForm.Controls.Add(this.chkActivo);
            this.groupBoxForm.Controls.Add(this.txtContactoTelefono);
            this.groupBoxForm.Controls.Add(this.lblContactoTelefono);
            this.groupBoxForm.Controls.Add(this.txtContactoNombre);
            this.groupBoxForm.Controls.Add(this.lblContactoNombre);
            this.groupBoxForm.Controls.Add(this.txtDireccion);
            this.groupBoxForm.Controls.Add(this.lblDireccion);
            this.groupBoxForm.Controls.Add(this.txtEmail);
            this.groupBoxForm.Controls.Add(this.lblEmail);
            this.groupBoxForm.Controls.Add(this.txtTelefono);
            this.groupBoxForm.Controls.Add(this.lblTelefono);
            this.groupBoxForm.Controls.Add(this.txtNit);
            this.groupBoxForm.Controls.Add(this.lblNit);
            this.groupBoxForm.Controls.Add(this.txtNombre);
            this.groupBoxForm.Controls.Add(this.lblNombre);
            this.groupBoxForm.Location = new System.Drawing.Point(12, 12);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(565, 160);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Datos de proveedor";
            // 
            // lblProveedorId
            // 
            this.lblProveedorId.AutoSize = true;
            this.lblProveedorId.Location = new System.Drawing.Point(6, 0);
            this.lblProveedorId.Name = "lblProveedorId";
            this.lblProveedorId.Size = new System.Drawing.Size(0, 13);
            this.lblProveedorId.TabIndex = 20;
            this.lblProveedorId.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(482, 24);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtContactoTelefono
            // 
            this.txtContactoTelefono.Location = new System.Drawing.Point(86, 83);
            this.txtContactoTelefono.MaxLength = 20;
            this.txtContactoTelefono.Name = "txtContactoTelefono";
            this.txtContactoTelefono.Size = new System.Drawing.Size(129, 20);
            this.txtContactoTelefono.TabIndex = 9;
            // 
            // lblContactoTelefono
            // 
            this.lblContactoTelefono.AutoSize = true;
            this.lblContactoTelefono.Location = new System.Drawing.Point(6, 86);
            this.lblContactoTelefono.Name = "lblContactoTelefono";
            this.lblContactoTelefono.Size = new System.Drawing.Size(70, 13);
            this.lblContactoTelefono.TabIndex = 18;
            this.lblContactoTelefono.Text = "Tel contacto:";
            // 
            // txtContactoNombre
            // 
            this.txtContactoNombre.Location = new System.Drawing.Point(399, 86);
            this.txtContactoNombre.MaxLength = 100;
            this.txtContactoNombre.Name = "txtContactoNombre";
            this.txtContactoNombre.Size = new System.Drawing.Size(129, 20);
            this.txtContactoNombre.TabIndex = 8;
            // 
            // lblContactoNombre
            // 
            this.lblContactoNombre.AutoSize = true;
            this.lblContactoNombre.Location = new System.Drawing.Point(300, 89);
            this.lblContactoNombre.Name = "lblContactoNombre";
            this.lblContactoNombre.Size = new System.Drawing.Size(92, 13);
            this.lblContactoNombre.TabIndex = 16;
            this.lblContactoNombre.Text = "Nombre contacto:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(86, 112);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(188, 40);
            this.txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 115);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(399, 115);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(300, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(29, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(399, 52);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(300, 55);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(86, 52);
            this.txtNit.MaxLength = 20;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(197, 20);
            this.txtNit.TabIndex = 5;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(6, 55);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(28, 13);
            this.lblNit.TabIndex = 7;
            this.lblNit.Text = "NIT:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 22);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(390, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnCancelar);
            this.groupBoxActions.Controls.Add(this.btnEliminar);
            this.groupBoxActions.Controls.Add(this.btnActualizar);
            this.groupBoxActions.Controls.Add(this.btnAgregar);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 178);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(565, 56);
            this.groupBoxActions.TabIndex = 11;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(444, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 27);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(233, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 27);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(151, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(66, 27);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(69, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 27);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridProveedor
            // 
            this.dataGridProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedor.Location = new System.Drawing.Point(12, 240);
            this.dataGridProveedor.MultiSelect = false;
            this.dataGridProveedor.Name = "dataGridProveedor";
            this.dataGridProveedor.ReadOnly = true;
            this.dataGridProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedor.Size = new System.Drawing.Size(565, 133);
            this.dataGridProveedor.TabIndex = 16;
            this.dataGridProveedor.SelectionChanged += new System.EventHandler(this.dataGridProveedor_SelectionChanged_1);
            // 
            // ProveedorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.dataGridProveedor);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "ProveedorUI";
            this.Text = "Gestión de Proveedores";
            this.Load += new System.EventHandler(this.ProveedorUI_Load);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label lblProveedorId;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtContactoTelefono;
        private System.Windows.Forms.Label lblContactoTelefono;
        private System.Windows.Forms.TextBox txtContactoNombre;
        private System.Windows.Forms.Label lblContactoNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridProveedor;
    }
}
