namespace capa_presentacion.perfil_administrador
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
            this.LBL_USER_REGISTRADOS = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COL_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TIPO_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LBL_DNI = new System.Windows.Forms.Label();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.LBL_APELLIDO = new System.Windows.Forms.Label();
            this.LBL_EMAIL = new System.Windows.Forms.Label();
            this.LBL_TELEFONO = new System.Windows.Forms.Label();
            this.LBL_TIPO_USER = new System.Windows.Forms.Label();
            this.TXT_DNI = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_APELLIDO = new System.Windows.Forms.TextBox();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.TXT_TELEFONO = new System.Windows.Forms.TextBox();
            this.RADBUT_VENDEDOR = new System.Windows.Forms.RadioButton();
            this.RADBUT_SUPERVISOR = new System.Windows.Forms.RadioButton();
            this.LBL_NUEVA_CONTRASEÑA = new System.Windows.Forms.Label();
            this.LBL_NUEVA_CONTRASEÑA2 = new System.Windows.Forms.Label();
            this.TXT_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.TXT_CONTRASEÑA2 = new System.Windows.Forms.TextBox();
            this.BUT_GUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_USER_REGISTRADOS
            // 
            this.LBL_USER_REGISTRADOS.AutoSize = true;
            this.LBL_USER_REGISTRADOS.Location = new System.Drawing.Point(330, 243);
            this.LBL_USER_REGISTRADOS.Name = "LBL_USER_REGISTRADOS";
            this.LBL_USER_REGISTRADOS.Size = new System.Drawing.Size(102, 13);
            this.LBL_USER_REGISTRADOS.TabIndex = 0;
            this.LBL_USER_REGISTRADOS.Text = "Usuarios registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_DNI,
            this.COL_NOMBRE,
            this.COL_APELLIDO,
            this.COL_EMAIL,
            this.COL_TELEFONO,
            this.COL_TIPO_USER,
            this.COL_MODIFICAR});
            this.dataGridView1.Location = new System.Drawing.Point(26, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 1;
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
            // LBL_DNI
            // 
            this.LBL_DNI.AutoSize = true;
            this.LBL_DNI.Location = new System.Drawing.Point(157, 31);
            this.LBL_DNI.Name = "LBL_DNI";
            this.LBL_DNI.Size = new System.Drawing.Size(26, 13);
            this.LBL_DNI.TabIndex = 2;
            this.LBL_DNI.Text = "DNI";
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Location = new System.Drawing.Point(52, 80);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.LBL_NOMBRE.TabIndex = 3;
            this.LBL_NOMBRE.Text = "Nombre";
            // 
            // LBL_APELLIDO
            // 
            this.LBL_APELLIDO.AutoSize = true;
            this.LBL_APELLIDO.Location = new System.Drawing.Point(273, 80);
            this.LBL_APELLIDO.Name = "LBL_APELLIDO";
            this.LBL_APELLIDO.Size = new System.Drawing.Size(44, 13);
            this.LBL_APELLIDO.TabIndex = 4;
            this.LBL_APELLIDO.Text = "Apellido";
            // 
            // LBL_EMAIL
            // 
            this.LBL_EMAIL.AutoSize = true;
            this.LBL_EMAIL.Location = new System.Drawing.Point(52, 138);
            this.LBL_EMAIL.Name = "LBL_EMAIL";
            this.LBL_EMAIL.Size = new System.Drawing.Size(32, 13);
            this.LBL_EMAIL.TabIndex = 5;
            this.LBL_EMAIL.Text = "Email";
            // 
            // LBL_TELEFONO
            // 
            this.LBL_TELEFONO.AutoSize = true;
            this.LBL_TELEFONO.Location = new System.Drawing.Point(273, 138);
            this.LBL_TELEFONO.Name = "LBL_TELEFONO";
            this.LBL_TELEFONO.Size = new System.Drawing.Size(49, 13);
            this.LBL_TELEFONO.TabIndex = 6;
            this.LBL_TELEFONO.Text = "Telefono";
            // 
            // LBL_TIPO_USER
            // 
            this.LBL_TIPO_USER.AutoSize = true;
            this.LBL_TIPO_USER.Location = new System.Drawing.Point(52, 198);
            this.LBL_TIPO_USER.Name = "LBL_TIPO_USER";
            this.LBL_TIPO_USER.Size = new System.Drawing.Size(80, 13);
            this.LBL_TIPO_USER.TabIndex = 7;
            this.LBL_TIPO_USER.Text = "Tipo de usuario";
            // 
            // TXT_DNI
            // 
            this.TXT_DNI.Location = new System.Drawing.Point(212, 28);
            this.TXT_DNI.Name = "TXT_DNI";
            this.TXT_DNI.ReadOnly = true;
            this.TXT_DNI.Size = new System.Drawing.Size(150, 20);
            this.TXT_DNI.TabIndex = 8;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(122, 77);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(120, 20);
            this.TXT_NOMBRE.TabIndex = 9;
            // 
            // TXT_APELLIDO
            // 
            this.TXT_APELLIDO.Location = new System.Drawing.Point(354, 77);
            this.TXT_APELLIDO.Name = "TXT_APELLIDO";
            this.TXT_APELLIDO.Size = new System.Drawing.Size(120, 20);
            this.TXT_APELLIDO.TabIndex = 10;
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Location = new System.Drawing.Point(122, 138);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(120, 20);
            this.TXT_EMAIL.TabIndex = 11;
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.Location = new System.Drawing.Point(354, 138);
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(120, 20);
            this.TXT_TELEFONO.TabIndex = 12;
            // 
            // RADBUT_VENDEDOR
            // 
            this.RADBUT_VENDEDOR.AutoSize = true;
            this.RADBUT_VENDEDOR.Location = new System.Drawing.Point(177, 198);
            this.RADBUT_VENDEDOR.Name = "RADBUT_VENDEDOR";
            this.RADBUT_VENDEDOR.Size = new System.Drawing.Size(71, 17);
            this.RADBUT_VENDEDOR.TabIndex = 13;
            this.RADBUT_VENDEDOR.TabStop = true;
            this.RADBUT_VENDEDOR.Text = "Vendedor";
            this.RADBUT_VENDEDOR.UseVisualStyleBackColor = true;
            // 
            // RADBUT_SUPERVISOR
            // 
            this.RADBUT_SUPERVISOR.AutoSize = true;
            this.RADBUT_SUPERVISOR.Location = new System.Drawing.Point(276, 198);
            this.RADBUT_SUPERVISOR.Name = "RADBUT_SUPERVISOR";
            this.RADBUT_SUPERVISOR.Size = new System.Drawing.Size(75, 17);
            this.RADBUT_SUPERVISOR.TabIndex = 14;
            this.RADBUT_SUPERVISOR.TabStop = true;
            this.RADBUT_SUPERVISOR.Text = "Supervisor";
            this.RADBUT_SUPERVISOR.UseVisualStyleBackColor = true;
            // 
            // LBL_NUEVA_CONTRASEÑA
            // 
            this.LBL_NUEVA_CONTRASEÑA.AutoSize = true;
            this.LBL_NUEVA_CONTRASEÑA.Location = new System.Drawing.Point(582, 35);
            this.LBL_NUEVA_CONTRASEÑA.Name = "LBL_NUEVA_CONTRASEÑA";
            this.LBL_NUEVA_CONTRASEÑA.Size = new System.Drawing.Size(95, 13);
            this.LBL_NUEVA_CONTRASEÑA.TabIndex = 15;
            this.LBL_NUEVA_CONTRASEÑA.Text = "Nueva contraseña";
            // 
            // LBL_NUEVA_CONTRASEÑA2
            // 
            this.LBL_NUEVA_CONTRASEÑA2.AutoSize = true;
            this.LBL_NUEVA_CONTRASEÑA2.Location = new System.Drawing.Point(582, 112);
            this.LBL_NUEVA_CONTRASEÑA2.Name = "LBL_NUEVA_CONTRASEÑA2";
            this.LBL_NUEVA_CONTRASEÑA2.Size = new System.Drawing.Size(114, 13);
            this.LBL_NUEVA_CONTRASEÑA2.TabIndex = 16;
            this.LBL_NUEVA_CONTRASEÑA2.Text = "Reingresar contraseña";
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(585, 71);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(150, 20);
            this.TXT_CONTRASEÑA.TabIndex = 17;
            // 
            // TXT_CONTRASEÑA2
            // 
            this.TXT_CONTRASEÑA2.Location = new System.Drawing.Point(585, 145);
            this.TXT_CONTRASEÑA2.Name = "TXT_CONTRASEÑA2";
            this.TXT_CONTRASEÑA2.Size = new System.Drawing.Size(150, 20);
            this.TXT_CONTRASEÑA2.TabIndex = 18;
            // 
            // BUT_GUARDAR
            // 
            this.BUT_GUARDAR.Location = new System.Drawing.Point(585, 198);
            this.BUT_GUARDAR.Name = "BUT_GUARDAR";
            this.BUT_GUARDAR.Size = new System.Drawing.Size(120, 30);
            this.BUT_GUARDAR.TabIndex = 19;
            this.BUT_GUARDAR.Text = "Guardar cambios";
            this.BUT_GUARDAR.UseVisualStyleBackColor = true;
            // 
            // modificar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BUT_GUARDAR);
            this.Controls.Add(this.TXT_CONTRASEÑA2);
            this.Controls.Add(this.TXT_CONTRASEÑA);
            this.Controls.Add(this.LBL_NUEVA_CONTRASEÑA2);
            this.Controls.Add(this.LBL_NUEVA_CONTRASEÑA);
            this.Controls.Add(this.RADBUT_SUPERVISOR);
            this.Controls.Add(this.RADBUT_VENDEDOR);
            this.Controls.Add(this.TXT_TELEFONO);
            this.Controls.Add(this.TXT_EMAIL);
            this.Controls.Add(this.TXT_APELLIDO);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.TXT_DNI);
            this.Controls.Add(this.LBL_TIPO_USER);
            this.Controls.Add(this.LBL_TELEFONO);
            this.Controls.Add(this.LBL_EMAIL);
            this.Controls.Add(this.LBL_APELLIDO);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.LBL_DNI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LBL_USER_REGISTRADOS);
            this.Name = "modificar_usuario";
            this.Text = "Modificar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_USER_REGISTRADOS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TIPO_USER;
        private System.Windows.Forms.DataGridViewButtonColumn COL_MODIFICAR;
        private System.Windows.Forms.Label LBL_DNI;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.Label LBL_APELLIDO;
        private System.Windows.Forms.Label LBL_EMAIL;
        private System.Windows.Forms.Label LBL_TELEFONO;
        private System.Windows.Forms.Label LBL_TIPO_USER;
        private System.Windows.Forms.TextBox TXT_DNI;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_APELLIDO;
        private System.Windows.Forms.TextBox TXT_EMAIL;
        private System.Windows.Forms.TextBox TXT_TELEFONO;
        private System.Windows.Forms.RadioButton RADBUT_VENDEDOR;
        private System.Windows.Forms.RadioButton RADBUT_SUPERVISOR;
        private System.Windows.Forms.Label LBL_NUEVA_CONTRASEÑA;
        private System.Windows.Forms.Label LBL_NUEVA_CONTRASEÑA2;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA2;
        private System.Windows.Forms.Button BUT_GUARDAR;
    }
}