namespace capa_presentacion.perfil_supervisor
{
    partial class baja_proveedor
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
            this.pnlBajaProveedor = new System.Windows.Forms.Panel();
            this.lblProveedoresBaja = new System.Windows.Forms.Label();
            this.lblProveedoresRegistrados = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cuitBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlBajaProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBajaProveedor
            // 
            this.pnlBajaProveedor.BackColor = System.Drawing.Color.Beige;
            this.pnlBajaProveedor.Controls.Add(this.lblProveedoresBaja);
            this.pnlBajaProveedor.Controls.Add(this.lblProveedoresRegistrados);
            this.pnlBajaProveedor.Controls.Add(this.dataGridView2);
            this.pnlBajaProveedor.Controls.Add(this.dataGridView1);
            this.pnlBajaProveedor.Location = new System.Drawing.Point(12, 12);
            this.pnlBajaProveedor.Name = "pnlBajaProveedor";
            this.pnlBajaProveedor.Size = new System.Drawing.Size(693, 404);
            this.pnlBajaProveedor.TabIndex = 0;
            // 
            // lblProveedoresBaja
            // 
            this.lblProveedoresBaja.AutoSize = true;
            this.lblProveedoresBaja.Location = new System.Drawing.Point(259, 212);
            this.lblProveedoresBaja.Name = "lblProveedoresBaja";
            this.lblProveedoresBaja.Size = new System.Drawing.Size(167, 13);
            this.lblProveedoresBaja.TabIndex = 3;
            this.lblProveedoresBaja.Text = "Proveedores Dados de Baja";
            // 
            // lblProveedoresRegistrados
            // 
            this.lblProveedoresRegistrados.AutoSize = true;
            this.lblProveedoresRegistrados.Location = new System.Drawing.Point(272, 19);
            this.lblProveedoresRegistrados.Name = "lblProveedoresRegistrados";
            this.lblProveedoresRegistrados.Size = new System.Drawing.Size(143, 13);
            this.lblProveedoresRegistrados.TabIndex = 2;
            this.lblProveedoresRegistrados.Text = "Provedores Registrados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuitBaja,
            this.razonSocialBaja,
            this.rubroBaja,
            this.direccionBaja});
            this.dataGridView2.Location = new System.Drawing.Point(64, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(556, 122);
            this.dataGridView2.TabIndex = 1;
            // 
            // cuitBaja
            // 
            this.cuitBaja.HeaderText = "Cuit";
            this.cuitBaja.Name = "cuitBaja";
            // 
            // razonSocialBaja
            // 
            this.razonSocialBaja.HeaderText = "RazonSocial";
            this.razonSocialBaja.Name = "razonSocialBaja";
            // 
            // rubroBaja
            // 
            this.rubroBaja.HeaderText = "Rubro";
            this.rubroBaja.Name = "rubroBaja";
            // 
            // direccionBaja
            // 
            this.direccionBaja.HeaderText = "Direccion";
            this.direccionBaja.Name = "direccionBaja";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit,
            this.razonSocial,
            this.rubro,
            this.direccion,
            this.eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(64, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            // 
            // rubro
            // 
            this.rubro.HeaderText = "Rubro";
            this.rubro.Name = "rubro";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            // 
            // baja_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.pnlBajaProveedor);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "baja_proveedor";
            this.Text = "baja_proveedor";
            this.pnlBajaProveedor.ResumeLayout(false);
            this.pnlBajaProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBajaProveedor;
        private System.Windows.Forms.Label lblProveedoresBaja;
        private System.Windows.Forms.Label lblProveedoresRegistrados;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionBaja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}