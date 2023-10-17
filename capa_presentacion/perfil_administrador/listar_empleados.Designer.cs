namespace capa_presentacion.perfil_administrador
{
    partial class listar_empleados
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
            this.pnlListarEmpleados = new System.Windows.Forms.Panel();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlListarEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListarEmpleados
            // 
            this.pnlListarEmpleados.BackColor = System.Drawing.Color.Beige;
            this.pnlListarEmpleados.Controls.Add(this.dgvListaEmpleados);
            this.pnlListarEmpleados.Controls.Add(this.lblDni);
            this.pnlListarEmpleados.Controls.Add(this.btnBuscar);
            this.pnlListarEmpleados.Controls.Add(this.txtDNI);
            this.pnlListarEmpleados.Controls.Add(this.label1);
            this.pnlListarEmpleados.Location = new System.Drawing.Point(12, 12);
            this.pnlListarEmpleados.Name = "pnlListarEmpleados";
            this.pnlListarEmpleados.Size = new System.Drawing.Size(709, 442);
            this.pnlListarEmpleados.TabIndex = 0;
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(26, 117);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.Size = new System.Drawing.Size(654, 292);
            this.dgvListaEmpleados.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(14, 79);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(269, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(49, 76);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(214, 21);
            this.txtDNI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Empleados";
            // 
            // listar_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_15455291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.pnlListarEmpleados);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "listar_empleados";
            this.Text = "listar_empleados";
            this.Load += new System.EventHandler(this.listar_empleados_Load);
            this.pnlListarEmpleados.ResumeLayout(false);
            this.pnlListarEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListarEmpleados;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
    }
}