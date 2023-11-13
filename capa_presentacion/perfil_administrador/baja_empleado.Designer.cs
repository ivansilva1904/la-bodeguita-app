namespace capa_presentacion.perfil_administrador
{
    partial class baja_empleado
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
            this.dgvEmpleadosActivos = new System.Windows.Forms.DataGridView();
            this.dgvEmpleadosInactivos = new System.Windows.Forms.DataGridView();
            this.pnlBajaEmpleado = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosInactivos)).BeginInit();
            this.pnlBajaEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_USER_ACTUAL
            // 
            this.LBL_USER_ACTUAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_USER_ACTUAL.AutoSize = true;
            this.LBL_USER_ACTUAL.Location = new System.Drawing.Point(243, 16);
            this.LBL_USER_ACTUAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USER_ACTUAL.Name = "LBL_USER_ACTUAL";
            this.LBL_USER_ACTUAL.Size = new System.Drawing.Size(187, 13);
            this.LBL_USER_ACTUAL.TabIndex = 0;
            this.LBL_USER_ACTUAL.Text = "Empleados activos actualmente";
            // 
            // LBL_USER_DESHABILITADOS
            // 
            this.LBL_USER_DESHABILITADOS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBL_USER_DESHABILITADOS.AutoSize = true;
            this.LBL_USER_DESHABILITADOS.Location = new System.Drawing.Point(259, 227);
            this.LBL_USER_DESHABILITADOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USER_DESHABILITADOS.Name = "LBL_USER_DESHABILITADOS";
            this.LBL_USER_DESHABILITADOS.Size = new System.Drawing.Size(154, 13);
            this.LBL_USER_DESHABILITADOS.TabIndex = 1;
            this.LBL_USER_DESHABILITADOS.Text = "Empleados deshabilitados";
            // 
            // dgvEmpleadosActivos
            // 
            this.dgvEmpleadosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleadosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosActivos.Location = new System.Drawing.Point(13, 52);
            this.dgvEmpleadosActivos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvEmpleadosActivos.Name = "dgvEmpleadosActivos";
            this.dgvEmpleadosActivos.Size = new System.Drawing.Size(650, 156);
            this.dgvEmpleadosActivos.TabIndex = 2;
            this.dgvEmpleadosActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosActivos_CellContentClick);
            // 
            // dgvEmpleadosInactivos
            // 
            this.dgvEmpleadosInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleadosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosInactivos.Location = new System.Drawing.Point(13, 259);
            this.dgvEmpleadosInactivos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvEmpleadosInactivos.Name = "dgvEmpleadosInactivos";
            this.dgvEmpleadosInactivos.Size = new System.Drawing.Size(650, 142);
            this.dgvEmpleadosInactivos.TabIndex = 3;
            this.dgvEmpleadosInactivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosInactivos_CellContentClick);
            // 
            // pnlBajaEmpleado
            // 
            this.pnlBajaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBajaEmpleado.Controls.Add(this.dgvEmpleadosActivos);
            this.pnlBajaEmpleado.Controls.Add(this.dgvEmpleadosInactivos);
            this.pnlBajaEmpleado.Controls.Add(this.LBL_USER_ACTUAL);
            this.pnlBajaEmpleado.Controls.Add(this.LBL_USER_DESHABILITADOS);
            this.pnlBajaEmpleado.Location = new System.Drawing.Point(12, 12);
            this.pnlBajaEmpleado.Name = "pnlBajaEmpleado";
            this.pnlBajaEmpleado.Size = new System.Drawing.Size(682, 418);
            this.pnlBajaEmpleado.TabIndex = 4;
            // 
            // baja_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_15455291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 442);
            this.Controls.Add(this.pnlBajaEmpleado);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "baja_empleado";
            this.Text = "Baja usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.baja_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosInactivos)).EndInit();
            this.pnlBajaEmpleado.ResumeLayout(false);
            this.pnlBajaEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_USER_ACTUAL;
        private System.Windows.Forms.Label LBL_USER_DESHABILITADOS;
        private System.Windows.Forms.DataGridView dgvEmpleadosActivos;
        private System.Windows.Forms.DataGridView dgvEmpleadosInactivos;
        private System.Windows.Forms.Panel pnlBajaEmpleado;
    }
}