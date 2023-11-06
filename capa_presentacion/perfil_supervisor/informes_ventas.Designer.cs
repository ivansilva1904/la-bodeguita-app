namespace capa_presentacion.perfil_supervisor
{
    partial class informes_ventas
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
            this.pnlInformeVentas = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleVenta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDniEmpleado = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblInformeVentas = new System.Windows.Forms.Label();
            this.pnlInformeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformeVentas
            // 
            this.pnlInformeVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformeVentas.BackColor = System.Drawing.Color.Beige;
            this.pnlInformeVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInformeVentas.Controls.Add(this.btnFiltrar);
            this.pnlInformeVentas.Controls.Add(this.dgvVentas);
            this.pnlInformeVentas.Controls.Add(this.txtDniCliente);
            this.pnlInformeVentas.Controls.Add(this.txtDniEmpleado);
            this.pnlInformeVentas.Controls.Add(this.dtpHasta);
            this.pnlInformeVentas.Controls.Add(this.dtpDesde);
            this.pnlInformeVentas.Controls.Add(this.label7);
            this.pnlInformeVentas.Controls.Add(this.label6);
            this.pnlInformeVentas.Controls.Add(this.label5);
            this.pnlInformeVentas.Controls.Add(this.lblDniEmpleado);
            this.pnlInformeVentas.Controls.Add(this.lblHasta);
            this.pnlInformeVentas.Controls.Add(this.lblDniCliente);
            this.pnlInformeVentas.Controls.Add(this.lblInformeVentas);
            this.pnlInformeVentas.Location = new System.Drawing.Point(12, 12);
            this.pnlInformeVentas.Name = "pnlInformeVentas";
            this.pnlInformeVentas.Size = new System.Drawing.Size(709, 442);
            this.pnlInformeVentas.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(530, 215);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 28);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenta,
            this.dniEmpleado,
            this.dniCliente,
            this.fecha,
            this.detalleVenta,
            this.total});
            this.dgvVentas.Location = new System.Drawing.Point(3, 269);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(703, 170);
            this.dgvVentas.TabIndex = 11;
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "ID Venta";
            this.idVenta.Name = "idVenta";
            // 
            // dniEmpleado
            // 
            this.dniEmpleado.HeaderText = "DNI Empleado";
            this.dniEmpleado.Name = "dniEmpleado";
            // 
            // dniCliente
            // 
            this.dniCliente.HeaderText = "DNI Cliente";
            this.dniCliente.Name = "dniCliente";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // detalleVenta
            // 
            this.detalleVenta.HeaderText = "Detalle Venta";
            this.detalleVenta.Name = "detalleVenta";
            // 
            // total
            // 
            this.total.HeaderText = "Total Venta";
            this.total.Name = "total";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(176, 155);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(181, 21);
            this.txtDniCliente.TabIndex = 10;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.Location = new System.Drawing.Point(176, 104);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(181, 21);
            this.txtDniEmpleado.TabIndex = 9;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(455, 155);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(97, 21);
            this.dtpHasta.TabIndex = 8;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(455, 104);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(97, 21);
            this.dtpDesde.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Beige;
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(21, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre Empleado :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Beige;
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(21, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Cliente :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desde";
            // 
            // lblDniEmpleado
            // 
            this.lblDniEmpleado.AutoSize = true;
            this.lblDniEmpleado.Location = new System.Drawing.Point(71, 107);
            this.lblDniEmpleado.Name = "lblDniEmpleado";
            this.lblDniEmpleado.Size = new System.Drawing.Size(89, 13);
            this.lblDniEmpleado.TabIndex = 3;
            this.lblDniEmpleado.Text = "DNI Empleado";
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(482, 139);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(81, 158);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(70, 13);
            this.lblDniCliente.TabIndex = 1;
            this.lblDniCliente.Text = "Dni Cliente";
            // 
            // lblInformeVentas
            // 
            this.lblInformeVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInformeVentas.AutoSize = true;
            this.lblInformeVentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeVentas.Location = new System.Drawing.Point(297, 31);
            this.lblInformeVentas.Name = "lblInformeVentas";
            this.lblInformeVentas.Size = new System.Drawing.Size(108, 13);
            this.lblInformeVentas.TabIndex = 0;
            this.lblInformeVentas.Text = "Informe Ventas";
            // 
            // informes_ventas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_wine_barrel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.pnlInformeVentas);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "informes_ventas";
            this.Text = "informes_ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlInformeVentas.ResumeLayout(false);
            this.pnlInformeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformeVentas;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDniEmpleado;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblInformeVentas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewButtonColumn detalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}