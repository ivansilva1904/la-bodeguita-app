
namespace capa_presentacion.perfil_vendedor
{
    partial class informes_venta_vendedor
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
            this.pnlInformesVentaVendedor = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvVentasVendedor = new System.Windows.Forms.DataGridView();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInformesVentaVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformesVentaVendedor
            // 
            this.pnlInformesVentaVendedor.BackColor = System.Drawing.Color.Beige;
            this.pnlInformesVentaVendedor.Controls.Add(this.btnFiltrar);
            this.pnlInformesVentaVendedor.Controls.Add(this.dgvVentasVendedor);
            this.pnlInformesVentaVendedor.Controls.Add(this.txtDniCliente);
            this.pnlInformesVentaVendedor.Controls.Add(this.lblDniCliente);
            this.pnlInformesVentaVendedor.Controls.Add(this.dtpHasta);
            this.pnlInformesVentaVendedor.Controls.Add(this.dtpDesde);
            this.pnlInformesVentaVendedor.Controls.Add(this.lblDesde);
            this.pnlInformesVentaVendedor.Controls.Add(this.lblHasta);
            this.pnlInformesVentaVendedor.Controls.Add(this.label1);
            this.pnlInformesVentaVendedor.Location = new System.Drawing.Point(12, 12);
            this.pnlInformesVentaVendedor.Name = "pnlInformesVentaVendedor";
            this.pnlInformesVentaVendedor.Size = new System.Drawing.Size(709, 442);
            this.pnlInformesVentaVendedor.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(512, 209);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 28);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvVentasVendedor
            // 
            this.dgvVentasVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentasVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasVendedor.Location = new System.Drawing.Point(3, 256);
            this.dgvVentasVendedor.Name = "dgvVentasVendedor";
            this.dgvVentasVendedor.Size = new System.Drawing.Size(703, 183);
            this.dgvVentasVendedor.TabIndex = 15;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(179, 92);
            this.txtDniCliente.MaxLength = 8;
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(181, 21);
            this.txtDniCliente.TabIndex = 1;
            this.txtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniCliente_KeyPress);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(84, 95);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(70, 13);
            this.lblDniCliente.TabIndex = 13;
            this.lblDniCliente.Text = "Dni Cliente";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(470, 143);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(97, 21);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.Value = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(470, 92);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(97, 21);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.Value = new System.DateTime(2023, 9, 1, 0, 0, 0, 0);
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(497, 76);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 13);
            this.lblDesde.TabIndex = 10;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(497, 127);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informes Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // informes_venta_vendedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.purple_grapes_vineyard_napa_valley_napa_vineyard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.pnlInformesVentaVendedor);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "informes_venta_vendedor";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.informes_venta_vendedor_Load);
            this.pnlInformesVentaVendedor.ResumeLayout(false);
            this.pnlInformesVentaVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformesVentaVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.DataGridView dgvVentasVendedor;
        private System.Windows.Forms.Button btnFiltrar;
    }
}