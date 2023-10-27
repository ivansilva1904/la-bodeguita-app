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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_USER_ACTUAL
            // 
            this.LBL_USER_ACTUAL.AutoSize = true;
            this.LBL_USER_ACTUAL.Location = new System.Drawing.Point(259, 49);
            this.LBL_USER_ACTUAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USER_ACTUAL.Name = "LBL_USER_ACTUAL";
            this.LBL_USER_ACTUAL.Size = new System.Drawing.Size(187, 13);
            this.LBL_USER_ACTUAL.TabIndex = 0;
            this.LBL_USER_ACTUAL.Text = "Empleados activos actualmente";
            // 
            // LBL_USER_DESHABILITADOS
            // 
            this.LBL_USER_DESHABILITADOS.AutoSize = true;
            this.LBL_USER_DESHABILITADOS.Location = new System.Drawing.Point(277, 238);
            this.LBL_USER_DESHABILITADOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USER_DESHABILITADOS.Name = "LBL_USER_DESHABILITADOS";
            this.LBL_USER_DESHABILITADOS.Size = new System.Drawing.Size(154, 13);
            this.LBL_USER_DESHABILITADOS.TabIndex = 1;
            this.LBL_USER_DESHABILITADOS.Text = "Empleados deshabilitados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 130);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 265);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(659, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // baja_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(706, 442);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.LBL_USER_DESHABILITADOS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LBL_USER_ACTUAL);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "baja_empleado";
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
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}