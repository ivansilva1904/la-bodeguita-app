﻿namespace capa_presentacion.perfil_administrador
{
    partial class modificar_usuario
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
            this.lblUsersRegistrados = new System.Windows.Forms.Label();
            this.dgvUsersRegistrados = new System.Windows.Forms.DataGridView();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.radbtnVendedor = new System.Windows.Forms.RadioButton();
            this.radbtnSupervisor = new System.Windows.Forms.RadioButton();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblNuevaContraseña2 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña2 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblModificarEmpleado = new System.Windows.Forms.Label();
            this.COL_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TIPO_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersRegistrados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsersRegistrados
            // 
            this.lblUsersRegistrados.AutoSize = true;
            this.lblUsersRegistrados.Location = new System.Drawing.Point(294, 273);
            this.lblUsersRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsersRegistrados.Name = "lblUsersRegistrados";
            this.lblUsersRegistrados.Size = new System.Drawing.Size(124, 13);
            this.lblUsersRegistrados.TabIndex = 0;
            this.lblUsersRegistrados.Text = "Usuarios registrados";
            // 
            // dgvUsersRegistrados
            // 
            this.dgvUsersRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_DNI,
            this.COL_NOMBRE,
            this.COL_APELLIDO,
            this.COL_EMAIL,
            this.COL_TELEFONO,
            this.COL_TIPO_USER,
            this.COL_MODIFICAR,
            this.baja});
            this.dgvUsersRegistrados.Location = new System.Drawing.Point(4, 289);
            this.dgvUsersRegistrados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvUsersRegistrados.Name = "dgvUsersRegistrados";
            this.dgvUsersRegistrados.Size = new System.Drawing.Size(698, 150);
            this.dgvUsersRegistrados.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(114, 61);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 104);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(259, 104);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 145);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(255, 148);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Location = new System.Drawing.Point(26, 184);
            this.lblTipoUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(95, 13);
            this.lblTipoUser.TabIndex = 7;
            this.lblTipoUser.Text = "Tipo de usuario";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(178, 58);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(174, 21);
            this.txtDNI.TabIndex = 8;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 21);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(319, 101);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(139, 21);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 145);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 21);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(319, 145);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 21);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // radbtnVendedor
            // 
            this.radbtnVendedor.AutoSize = true;
            this.radbtnVendedor.Location = new System.Drawing.Point(136, 182);
            this.radbtnVendedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radbtnVendedor.Name = "radbtnVendedor";
            this.radbtnVendedor.Size = new System.Drawing.Size(80, 17);
            this.radbtnVendedor.TabIndex = 13;
            this.radbtnVendedor.TabStop = true;
            this.radbtnVendedor.Text = "Vendedor";
            this.radbtnVendedor.UseVisualStyleBackColor = true;
            // 
            // radbtnSupervisor
            // 
            this.radbtnSupervisor.AutoSize = true;
            this.radbtnSupervisor.Location = new System.Drawing.Point(224, 182);
            this.radbtnSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radbtnSupervisor.Name = "radbtnSupervisor";
            this.radbtnSupervisor.Size = new System.Drawing.Size(87, 17);
            this.radbtnSupervisor.TabIndex = 14;
            this.radbtnSupervisor.TabStop = true;
            this.radbtnSupervisor.Text = "Supervisor";
            this.radbtnSupervisor.UseVisualStyleBackColor = true;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(510, 61);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(110, 13);
            this.lblNuevaContraseña.TabIndex = 15;
            this.lblNuevaContraseña.Text = "Nueva contraseña";
            // 
            // lblNuevaContraseña2
            // 
            this.lblNuevaContraseña2.AutoSize = true;
            this.lblNuevaContraseña2.Location = new System.Drawing.Point(510, 123);
            this.lblNuevaContraseña2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaContraseña2.Name = "lblNuevaContraseña2";
            this.lblNuevaContraseña2.Size = new System.Drawing.Size(136, 13);
            this.lblNuevaContraseña2.TabIndex = 16;
            this.lblNuevaContraseña2.Text = "Reingresar contraseña";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(513, 87);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(174, 21);
            this.txtNuevaContraseña.TabIndex = 17;
            // 
            // txtNuevaContraseña2
            // 
            this.txtNuevaContraseña2.Location = new System.Drawing.Point(513, 148);
            this.txtNuevaContraseña2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaContraseña2.Name = "txtNuevaContraseña2";
            this.txtNuevaContraseña2.PasswordChar = '*';
            this.txtNuevaContraseña2.Size = new System.Drawing.Size(174, 21);
            this.txtNuevaContraseña2.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(529, 239);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 30);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblModificarEmpleado);
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dgvUsersRegistrados);
            this.panel1.Controls.Add(this.lblUsersRegistrados);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.txtNuevaContraseña2);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNuevaContraseña);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNuevaContraseña2);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblNuevaContraseña);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.radbtnSupervisor);
            this.panel1.Controls.Add(this.lblTipoUser);
            this.panel1.Controls.Add(this.radbtnVendedor);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 442);
            this.panel1.TabIndex = 20;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(529, 200);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(140, 30);
            this.btnLimpiarCampos.TabIndex = 20;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblModificarEmpleado
            // 
            this.lblModificarEmpleado.AutoSize = true;
            this.lblModificarEmpleado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEmpleado.Location = new System.Drawing.Point(283, 17);
            this.lblModificarEmpleado.Name = "lblModificarEmpleado";
            this.lblModificarEmpleado.Size = new System.Drawing.Size(135, 13);
            this.lblModificarEmpleado.TabIndex = 21;
            this.lblModificarEmpleado.Text = "Modificar Empleado";
            // 
            // COL_DNI
            // 
            this.COL_DNI.HeaderText = "DNI";
            this.COL_DNI.Name = "COL_DNI";
            this.COL_DNI.ReadOnly = true;
            // 
            // COL_NOMBRE
            // 
            this.COL_NOMBRE.HeaderText = "Nombre";
            this.COL_NOMBRE.Name = "COL_NOMBRE";
            this.COL_NOMBRE.ReadOnly = true;
            // 
            // COL_APELLIDO
            // 
            this.COL_APELLIDO.HeaderText = "Apellido";
            this.COL_APELLIDO.Name = "COL_APELLIDO";
            this.COL_APELLIDO.ReadOnly = true;
            // 
            // COL_EMAIL
            // 
            this.COL_EMAIL.HeaderText = "Email";
            this.COL_EMAIL.Name = "COL_EMAIL";
            this.COL_EMAIL.ReadOnly = true;
            // 
            // COL_TELEFONO
            // 
            this.COL_TELEFONO.HeaderText = "Telefono";
            this.COL_TELEFONO.Name = "COL_TELEFONO";
            this.COL_TELEFONO.ReadOnly = true;
            // 
            // COL_TIPO_USER
            // 
            this.COL_TIPO_USER.HeaderText = "Tipo usuario";
            this.COL_TIPO_USER.Name = "COL_TIPO_USER";
            this.COL_TIPO_USER.ReadOnly = true;
            // 
            // COL_MODIFICAR
            // 
            this.COL_MODIFICAR.HeaderText = "Modificar";
            this.COL_MODIFICAR.Name = "COL_MODIFICAR";
            // 
            // baja
            // 
            this.baja.HeaderText = "De Baja";
            this.baja.Name = "baja";
            this.baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar por DNI";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(117, 245);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(133, 21);
            this.txtBuscar.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(262, 243);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // modificar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_15455291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "modificar_usuario";
            this.Text = "Modificar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersRegistrados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsersRegistrados;
        private System.Windows.Forms.DataGridView dgvUsersRegistrados;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton radbtnVendedor;
        private System.Windows.Forms.RadioButton radbtnSupervisor;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblNuevaContraseña2;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtNuevaContraseña2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TIPO_USER;
        private System.Windows.Forms.DataGridViewButtonColumn COL_MODIFICAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baja;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModificarEmpleado;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}