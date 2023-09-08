namespace capa_presentacion.perfil_administrador
{
    partial class baja_usuario
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
            this.LBL_USER_ACTUAL = new System.Windows.Forms.Label();
            this.LBL_USER_DESHABILITADOS = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COL_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_FECHA_NAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_FECHA_INCORP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TIPO_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.COL2_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_FECHA_INCORP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_FECHA_DESHAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2_TIPO_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_USER_ACTUAL
            // 
            this.LBL_USER_ACTUAL.AutoSize = true;
            this.LBL_USER_ACTUAL.Location = new System.Drawing.Point(407, 30);
            this.LBL_USER_ACTUAL.Name = "LBL_USER_ACTUAL";
            this.LBL_USER_ACTUAL.Size = new System.Drawing.Size(163, 13);
            this.LBL_USER_ACTUAL.TabIndex = 0;
            this.LBL_USER_ACTUAL.Text = "Usuarios registrados actualmente";
            // 
            // LBL_USER_DESHABILITADOS
            // 
            this.LBL_USER_DESHABILITADOS.AutoSize = true;
            this.LBL_USER_DESHABILITADOS.Location = new System.Drawing.Point(407, 229);
            this.LBL_USER_DESHABILITADOS.Name = "LBL_USER_DESHABILITADOS";
            this.LBL_USER_DESHABILITADOS.Size = new System.Drawing.Size(118, 13);
            this.LBL_USER_DESHABILITADOS.TabIndex = 1;
            this.LBL_USER_DESHABILITADOS.Text = "Uusarios deshabilitados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_DNI,
            this.COL_NOMBRE,
            this.COL_APELLIDO,
            this.COL_FECHA_NAC,
            this.COL_FECHA_INCORP,
            this.COL_EMAIL,
            this.COL_TELEFONO,
            this.COL_TIPO_USER,
            this.COL_ELIMINAR});
            this.dataGridView1.Location = new System.Drawing.Point(18, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 130);
            this.dataGridView1.TabIndex = 2;
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
            // COL_FECHA_NAC
            // 
            this.COL_FECHA_NAC.HeaderText = "Fecha nacimiento";
            this.COL_FECHA_NAC.Name = "COL_FECHA_NAC";
            this.COL_FECHA_NAC.ReadOnly = true;
            // 
            // COL_FECHA_INCORP
            // 
            this.COL_FECHA_INCORP.HeaderText = "Fecha incorporación";
            this.COL_FECHA_INCORP.Name = "COL_FECHA_INCORP";
            this.COL_FECHA_INCORP.ReadOnly = true;
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
            // COL_ELIMINAR
            // 
            this.COL_ELIMINAR.HeaderText = "Eliminar";
            this.COL_ELIMINAR.Name = "COL_ELIMINAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL2_DNI,
            this.COL2_NOMBRE,
            this.COL2_APELLIDO,
            this.COL2_FECHA_INCORP,
            this.COL2_FECHA_DESHAB,
            this.COL2_EMAIL,
            this.COL2_TELEFONO,
            this.COL2_TIPO_USER});
            this.dataGridView2.Location = new System.Drawing.Point(70, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(846, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // COL2_DNI
            // 
            this.COL2_DNI.HeaderText = "DNI";
            this.COL2_DNI.Name = "COL2_DNI";
            this.COL2_DNI.ReadOnly = true;
            // 
            // COL2_NOMBRE
            // 
            this.COL2_NOMBRE.HeaderText = "Nombre";
            this.COL2_NOMBRE.Name = "COL2_NOMBRE";
            this.COL2_NOMBRE.ReadOnly = true;
            // 
            // COL2_APELLIDO
            // 
            this.COL2_APELLIDO.HeaderText = "Apellido";
            this.COL2_APELLIDO.Name = "COL2_APELLIDO";
            this.COL2_APELLIDO.ReadOnly = true;
            // 
            // COL2_FECHA_INCORP
            // 
            this.COL2_FECHA_INCORP.HeaderText = "Fecha incorporación";
            this.COL2_FECHA_INCORP.Name = "COL2_FECHA_INCORP";
            this.COL2_FECHA_INCORP.ReadOnly = true;
            // 
            // COL2_FECHA_DESHAB
            // 
            this.COL2_FECHA_DESHAB.HeaderText = "Fecha deshabilitación";
            this.COL2_FECHA_DESHAB.Name = "COL2_FECHA_DESHAB";
            this.COL2_FECHA_DESHAB.ReadOnly = true;
            // 
            // COL2_EMAIL
            // 
            this.COL2_EMAIL.HeaderText = "Email";
            this.COL2_EMAIL.Name = "COL2_EMAIL";
            this.COL2_EMAIL.ReadOnly = true;
            // 
            // COL2_TELEFONO
            // 
            this.COL2_TELEFONO.HeaderText = "Telefono";
            this.COL2_TELEFONO.Name = "COL2_TELEFONO";
            this.COL2_TELEFONO.ReadOnly = true;
            // 
            // COL2_TIPO_USER
            // 
            this.COL2_TIPO_USER.HeaderText = "Tipo usuario";
            this.COL2_TIPO_USER.Name = "COL2_TIPO_USER";
            this.COL2_TIPO_USER.ReadOnly = true;
            // 
            // baja_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LBL_USER_DESHABILITADOS);
            this.Controls.Add(this.LBL_USER_ACTUAL);
            this.Name = "baja_usuario";
            this.Text = "Baja usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_USER_ACTUAL;
        private System.Windows.Forms.Label LBL_USER_DESHABILITADOS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_FECHA_NAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_FECHA_INCORP;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TIPO_USER;
        private System.Windows.Forms.DataGridViewButtonColumn COL_ELIMINAR;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_FECHA_INCORP;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_FECHA_DESHAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2_TIPO_USER;
    }
}