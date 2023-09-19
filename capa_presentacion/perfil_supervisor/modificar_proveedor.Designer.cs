namespace capa_presentacion.perfil_supervisor
{
    partial class modificar_proveedor
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
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panelModificarProveedor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.guardarCambios = new System.Windows.Forms.Button();
            this.panelModificarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(185, 41);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(168, 21);
            this.txtCuit.TabIndex = 0;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(466, 41);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(168, 21);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(185, 121);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(168, 21);
            this.txtRubro.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(466, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(168, 21);
            this.txtDireccion.TabIndex = 3;
            // 
            // panelModificarProveedor
            // 
            this.panelModificarProveedor.BackColor = System.Drawing.Color.Beige;
            this.panelModificarProveedor.Controls.Add(this.guardarCambios);
            this.panelModificarProveedor.Controls.Add(this.lblDireccion);
            this.panelModificarProveedor.Controls.Add(this.lblRubro);
            this.panelModificarProveedor.Controls.Add(this.lblCuit);
            this.panelModificarProveedor.Controls.Add(this.lblRazonSocial);
            this.panelModificarProveedor.Controls.Add(this.dataGridView1);
            this.panelModificarProveedor.Controls.Add(this.txtDireccion);
            this.panelModificarProveedor.Controls.Add(this.txtCuit);
            this.panelModificarProveedor.Controls.Add(this.txtRubro);
            this.panelModificarProveedor.Controls.Add(this.txtRazonSocial);
            this.panelModificarProveedor.Location = new System.Drawing.Point(12, 12);
            this.panelModificarProveedor.Name = "panelModificarProveedor";
            this.panelModificarProveedor.Size = new System.Drawing.Size(825, 404);
            this.panelModificarProveedor.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.razonSocial,
            this.cuitProveedor,
            this.rubro,
            this.direccion});
            this.dataGridView1.Location = new System.Drawing.Point(61, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.HeaderText = "Cuit";
            this.cuitProveedor.Name = "cuitProveedor";
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
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(370, 44);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(80, 13);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(135, 44);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(30, 13);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "Cuit";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(135, 124);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(41, 13);
            this.lblRubro.TabIndex = 6;
            this.lblRubro.Text = "Rubro";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(380, 124);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // guardarCambios
            // 
            this.guardarCambios.Location = new System.Drawing.Point(551, 178);
            this.guardarCambios.Name = "guardarCambios";
            this.guardarCambios.Size = new System.Drawing.Size(118, 27);
            this.guardarCambios.TabIndex = 8;
            this.guardarCambios.Text = "Guardar Cambios";
            this.guardarCambios.UseVisualStyleBackColor = true;
            // 
            // modificar_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(849, 428);
            this.Controls.Add(this.panelModificarProveedor);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "modificar_proveedor";
            this.Text = "modificar_proveedor";
            this.panelModificarProveedor.ResumeLayout(false);
            this.panelModificarProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panelModificarProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button guardarCambios;
    }
}