namespace capa_presentacion.perfil_administrador
{
    partial class alta_usuario
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
            this.LBL_INGRESAR = new System.Windows.Forms.Label();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.LBL_APELLIDO = new System.Windows.Forms.Label();
            this.LBL_FECHA_NAC = new System.Windows.Forms.Label();
            this.LBL_EMAIL = new System.Windows.Forms.Label();
            this.LBL_TELEFONO = new System.Windows.Forms.Label();
            this.LBL_CONTRASEÑA = new System.Windows.Forms.Label();
            this.LBL_CONTRASEÑA2 = new System.Windows.Forms.Label();
            this.LBL_TIPO_USER = new System.Windows.Forms.Label();
            this.LBL_DNI = new System.Windows.Forms.Label();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_APELLIDO = new System.Windows.Forms.TextBox();
            this.TXT_DNI = new System.Windows.Forms.TextBox();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.TXT_TELEFONO = new System.Windows.Forms.TextBox();
            this.TXT_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.TXT_CONTRASEÑA2 = new System.Windows.Forms.TextBox();
            this.RADBUT_VENDEDOR = new System.Windows.Forms.RadioButton();
            this.RADBUT_SUPERVISOR = new System.Windows.Forms.RadioButton();
            this.BUT_AGREGAR = new System.Windows.Forms.Button();
            this.DTP_FECHA_NACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LBL_INGRESAR
            // 
            this.LBL_INGRESAR.AutoSize = true;
            this.LBL_INGRESAR.Location = new System.Drawing.Point(321, 19);
            this.LBL_INGRESAR.Name = "LBL_INGRESAR";
            this.LBL_INGRESAR.Size = new System.Drawing.Size(127, 13);
            this.LBL_INGRESAR.TabIndex = 0;
            this.LBL_INGRESAR.Text = "Ingrese un nuevo usuario";
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Location = new System.Drawing.Point(73, 70);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.LBL_NOMBRE.TabIndex = 1;
            this.LBL_NOMBRE.Text = "Nombre";
            // 
            // LBL_APELLIDO
            // 
            this.LBL_APELLIDO.AutoSize = true;
            this.LBL_APELLIDO.Location = new System.Drawing.Point(404, 70);
            this.LBL_APELLIDO.Name = "LBL_APELLIDO";
            this.LBL_APELLIDO.Size = new System.Drawing.Size(44, 13);
            this.LBL_APELLIDO.TabIndex = 2;
            this.LBL_APELLIDO.Text = "Apellido";
            // 
            // LBL_FECHA_NAC
            // 
            this.LBL_FECHA_NAC.AutoSize = true;
            this.LBL_FECHA_NAC.Location = new System.Drawing.Point(404, 128);
            this.LBL_FECHA_NAC.Name = "LBL_FECHA_NAC";
            this.LBL_FECHA_NAC.Size = new System.Drawing.Size(106, 13);
            this.LBL_FECHA_NAC.TabIndex = 3;
            this.LBL_FECHA_NAC.Text = "Fecha de nacimiento";
            // 
            // LBL_EMAIL
            // 
            this.LBL_EMAIL.AutoSize = true;
            this.LBL_EMAIL.Location = new System.Drawing.Point(73, 179);
            this.LBL_EMAIL.Name = "LBL_EMAIL";
            this.LBL_EMAIL.Size = new System.Drawing.Size(32, 13);
            this.LBL_EMAIL.TabIndex = 4;
            this.LBL_EMAIL.Text = "Email";
            // 
            // LBL_TELEFONO
            // 
            this.LBL_TELEFONO.AutoSize = true;
            this.LBL_TELEFONO.Location = new System.Drawing.Point(404, 179);
            this.LBL_TELEFONO.Name = "LBL_TELEFONO";
            this.LBL_TELEFONO.Size = new System.Drawing.Size(49, 13);
            this.LBL_TELEFONO.TabIndex = 5;
            this.LBL_TELEFONO.Text = "Telefono";
            // 
            // LBL_CONTRASEÑA
            // 
            this.LBL_CONTRASEÑA.AutoSize = true;
            this.LBL_CONTRASEÑA.Location = new System.Drawing.Point(73, 240);
            this.LBL_CONTRASEÑA.Name = "LBL_CONTRASEÑA";
            this.LBL_CONTRASEÑA.Size = new System.Drawing.Size(61, 13);
            this.LBL_CONTRASEÑA.TabIndex = 6;
            this.LBL_CONTRASEÑA.Text = "Contraseña";
            // 
            // LBL_CONTRASEÑA2
            // 
            this.LBL_CONTRASEÑA2.AutoSize = true;
            this.LBL_CONTRASEÑA2.Location = new System.Drawing.Point(404, 241);
            this.LBL_CONTRASEÑA2.Name = "LBL_CONTRASEÑA2";
            this.LBL_CONTRASEÑA2.Size = new System.Drawing.Size(114, 13);
            this.LBL_CONTRASEÑA2.TabIndex = 7;
            this.LBL_CONTRASEÑA2.Text = "Reingresar contraseña";
            // 
            // LBL_TIPO_USER
            // 
            this.LBL_TIPO_USER.AutoSize = true;
            this.LBL_TIPO_USER.Location = new System.Drawing.Point(73, 304);
            this.LBL_TIPO_USER.Name = "LBL_TIPO_USER";
            this.LBL_TIPO_USER.Size = new System.Drawing.Size(80, 13);
            this.LBL_TIPO_USER.TabIndex = 8;
            this.LBL_TIPO_USER.Text = "Tipo de usuario";
            // 
            // LBL_DNI
            // 
            this.LBL_DNI.AutoSize = true;
            this.LBL_DNI.Location = new System.Drawing.Point(73, 131);
            this.LBL_DNI.Name = "LBL_DNI";
            this.LBL_DNI.Size = new System.Drawing.Size(26, 13);
            this.LBL_DNI.TabIndex = 9;
            this.LBL_DNI.Text = "DNI";
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(162, 67);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(180, 20);
            this.TXT_NOMBRE.TabIndex = 10;
            // 
            // TXT_APELLIDO
            // 
            this.TXT_APELLIDO.Location = new System.Drawing.Point(543, 67);
            this.TXT_APELLIDO.Name = "TXT_APELLIDO";
            this.TXT_APELLIDO.Size = new System.Drawing.Size(180, 20);
            this.TXT_APELLIDO.TabIndex = 11;
            // 
            // TXT_DNI
            // 
            this.TXT_DNI.Location = new System.Drawing.Point(162, 128);
            this.TXT_DNI.Name = "TXT_DNI";
            this.TXT_DNI.Size = new System.Drawing.Size(180, 20);
            this.TXT_DNI.TabIndex = 12;
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Location = new System.Drawing.Point(162, 179);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(180, 20);
            this.TXT_EMAIL.TabIndex = 13;
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.Location = new System.Drawing.Point(543, 176);
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(180, 20);
            this.TXT_TELEFONO.TabIndex = 14;
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(162, 238);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(180, 20);
            this.TXT_CONTRASEÑA.TabIndex = 15;
            // 
            // TXT_CONTRASEÑA2
            // 
            this.TXT_CONTRASEÑA2.Location = new System.Drawing.Point(543, 240);
            this.TXT_CONTRASEÑA2.Name = "TXT_CONTRASEÑA2";
            this.TXT_CONTRASEÑA2.Size = new System.Drawing.Size(180, 20);
            this.TXT_CONTRASEÑA2.TabIndex = 16;
            // 
            // RADBUT_VENDEDOR
            // 
            this.RADBUT_VENDEDOR.AutoSize = true;
            this.RADBUT_VENDEDOR.Location = new System.Drawing.Point(241, 304);
            this.RADBUT_VENDEDOR.Name = "RADBUT_VENDEDOR";
            this.RADBUT_VENDEDOR.Size = new System.Drawing.Size(71, 17);
            this.RADBUT_VENDEDOR.TabIndex = 17;
            this.RADBUT_VENDEDOR.TabStop = true;
            this.RADBUT_VENDEDOR.Text = "Vendedor";
            this.RADBUT_VENDEDOR.UseVisualStyleBackColor = true;
            // 
            // RADBUT_SUPERVISOR
            // 
            this.RADBUT_SUPERVISOR.AutoSize = true;
            this.RADBUT_SUPERVISOR.Location = new System.Drawing.Point(423, 304);
            this.RADBUT_SUPERVISOR.Name = "RADBUT_SUPERVISOR";
            this.RADBUT_SUPERVISOR.Size = new System.Drawing.Size(75, 17);
            this.RADBUT_SUPERVISOR.TabIndex = 18;
            this.RADBUT_SUPERVISOR.TabStop = true;
            this.RADBUT_SUPERVISOR.Text = "Supervisor";
            this.RADBUT_SUPERVISOR.UseVisualStyleBackColor = true;
            // 
            // BUT_AGREGAR
            // 
            this.BUT_AGREGAR.Location = new System.Drawing.Point(298, 365);
            this.BUT_AGREGAR.Name = "BUT_AGREGAR";
            this.BUT_AGREGAR.Size = new System.Drawing.Size(125, 30);
            this.BUT_AGREGAR.TabIndex = 19;
            this.BUT_AGREGAR.Text = "Agregar";
            this.BUT_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // DTP_FECHA_NACIMIENTO
            // 
            this.DTP_FECHA_NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHA_NACIMIENTO.Location = new System.Drawing.Point(543, 125);
            this.DTP_FECHA_NACIMIENTO.Name = "DTP_FECHA_NACIMIENTO";
            this.DTP_FECHA_NACIMIENTO.Size = new System.Drawing.Size(103, 20);
            this.DTP_FECHA_NACIMIENTO.TabIndex = 20;
            // 
            // alta_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_FECHA_NACIMIENTO);
            this.Controls.Add(this.BUT_AGREGAR);
            this.Controls.Add(this.RADBUT_SUPERVISOR);
            this.Controls.Add(this.RADBUT_VENDEDOR);
            this.Controls.Add(this.TXT_CONTRASEÑA2);
            this.Controls.Add(this.TXT_CONTRASEÑA);
            this.Controls.Add(this.TXT_TELEFONO);
            this.Controls.Add(this.TXT_EMAIL);
            this.Controls.Add(this.TXT_DNI);
            this.Controls.Add(this.TXT_APELLIDO);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.LBL_DNI);
            this.Controls.Add(this.LBL_TIPO_USER);
            this.Controls.Add(this.LBL_CONTRASEÑA2);
            this.Controls.Add(this.LBL_CONTRASEÑA);
            this.Controls.Add(this.LBL_TELEFONO);
            this.Controls.Add(this.LBL_EMAIL);
            this.Controls.Add(this.LBL_FECHA_NAC);
            this.Controls.Add(this.LBL_APELLIDO);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.LBL_INGRESAR);
            this.Name = "alta_usuario";
            this.Text = "Alta usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_INGRESAR;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.Label LBL_APELLIDO;
        private System.Windows.Forms.Label LBL_FECHA_NAC;
        private System.Windows.Forms.Label LBL_EMAIL;
        private System.Windows.Forms.Label LBL_TELEFONO;
        private System.Windows.Forms.Label LBL_CONTRASEÑA;
        private System.Windows.Forms.Label LBL_CONTRASEÑA2;
        private System.Windows.Forms.Label LBL_TIPO_USER;
        private System.Windows.Forms.Label LBL_DNI;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_APELLIDO;
        private System.Windows.Forms.TextBox TXT_DNI;
        private System.Windows.Forms.TextBox TXT_EMAIL;
        private System.Windows.Forms.TextBox TXT_TELEFONO;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA2;
        private System.Windows.Forms.RadioButton RADBUT_VENDEDOR;
        private System.Windows.Forms.RadioButton RADBUT_SUPERVISOR;
        private System.Windows.Forms.Button BUT_AGREGAR;
        private System.Windows.Forms.DateTimePicker DTP_FECHA_NACIMIENTO;
    }
}