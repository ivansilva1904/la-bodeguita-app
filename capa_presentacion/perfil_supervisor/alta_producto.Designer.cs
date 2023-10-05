namespace capa_presentacion.perfil_supervisor
{
    partial class alta_producto
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
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.pnlNuevoProducto = new System.Windows.Forms.Panel();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.rbtCristaleria = new System.Windows.Forms.RadioButton();
            this.rbtBebida = new System.Windows.Forms.RadioButton();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblIdTipoProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNuevoProducto = new System.Windows.Forms.Label();
            this.pnlNuevoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(162, 82);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(127, 21);
            this.txtIdProducto.TabIndex = 0;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // pnlNuevoProducto
            // 
            this.pnlNuevoProducto.BackColor = System.Drawing.Color.Beige;
            this.pnlNuevoProducto.Controls.Add(this.txtPrecioVenta);
            this.pnlNuevoProducto.Controls.Add(this.label1);
            this.pnlNuevoProducto.Controls.Add(this.btnLimpiar);
            this.pnlNuevoProducto.Controls.Add(this.lblStock);
            this.pnlNuevoProducto.Controls.Add(this.txtStock);
            this.pnlNuevoProducto.Controls.Add(this.btnGuardarProducto);
            this.pnlNuevoProducto.Controls.Add(this.txtPrecioCompra);
            this.pnlNuevoProducto.Controls.Add(this.txtDescripcion);
            this.pnlNuevoProducto.Controls.Add(this.txtMarca);
            this.pnlNuevoProducto.Controls.Add(this.cbxProveedor);
            this.pnlNuevoProducto.Controls.Add(this.rbtCristaleria);
            this.pnlNuevoProducto.Controls.Add(this.rbtBebida);
            this.pnlNuevoProducto.Controls.Add(this.lblDescripcion);
            this.pnlNuevoProducto.Controls.Add(this.lblPrecioCompra);
            this.pnlNuevoProducto.Controls.Add(this.lblMarca);
            this.pnlNuevoProducto.Controls.Add(this.lblIdTipoProducto);
            this.pnlNuevoProducto.Controls.Add(this.label3);
            this.pnlNuevoProducto.Controls.Add(this.lblIdProducto);
            this.pnlNuevoProducto.Controls.Add(this.lblNuevoProducto);
            this.pnlNuevoProducto.Controls.Add(this.txtIdProducto);
            this.pnlNuevoProducto.Location = new System.Drawing.Point(12, 12);
            this.pnlNuevoProducto.Name = "pnlNuevoProducto";
            this.pnlNuevoProducto.Size = new System.Drawing.Size(709, 442);
            this.pnlNuevoProducto.TabIndex = 1;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(490, 214);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(121, 21);
            this.txtPrecioVenta.TabIndex = 21;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Precio Venta";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(420, 391);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(385, 129);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(39, 13);
            this.lblStock.TabIndex = 18;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(490, 126);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 21);
            this.txtStock.TabIndex = 17;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(556, 390);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(117, 24);
            this.btnGuardarProducto.TabIndex = 16;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(162, 214);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(127, 21);
            this.txtPrecioCompra.TabIndex = 15;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(162, 258);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 21);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(162, 126);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(127, 21);
            this.txtMarca.TabIndex = 13;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(490, 82);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxProveedor.TabIndex = 11;
            // 
            // rbtCristaleria
            // 
            this.rbtCristaleria.AutoSize = true;
            this.rbtCristaleria.Location = new System.Drawing.Point(170, 173);
            this.rbtCristaleria.Name = "rbtCristaleria";
            this.rbtCristaleria.Size = new System.Drawing.Size(84, 17);
            this.rbtCristaleria.TabIndex = 10;
            this.rbtCristaleria.TabStop = true;
            this.rbtCristaleria.Text = "Cristaleria";
            this.rbtCristaleria.UseVisualStyleBackColor = true;
            // 
            // rbtBebida
            // 
            this.rbtBebida.AutoSize = true;
            this.rbtBebida.Location = new System.Drawing.Point(260, 173);
            this.rbtBebida.Name = "rbtBebida";
            this.rbtBebida.Size = new System.Drawing.Size(64, 17);
            this.rbtBebida.TabIndex = 9;
            this.rbtBebida.TabStop = true;
            this.rbtBebida.Text = "Bebida";
            this.rbtBebida.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(71, 261);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(71, 217);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(89, 13);
            this.lblPrecioCompra.TabIndex = 7;
            this.lblPrecioCompra.Text = "Precio compra";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(71, 129);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(41, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // lblIdTipoProducto
            // 
            this.lblIdTipoProducto.AutoSize = true;
            this.lblIdTipoProducto.Location = new System.Drawing.Point(71, 175);
            this.lblIdTipoProducto.Name = "lblIdTipoProducto";
            this.lblIdTipoProducto.Size = new System.Drawing.Size(85, 13);
            this.lblIdTipoProducto.TabIndex = 5;
            this.lblIdTipoProducto.Text = "Tipo Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proveedor";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(71, 85);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(75, 13);
            this.lblIdProducto.TabIndex = 2;
            this.lblIdProducto.Text = "ID Producto";
            // 
            // lblNuevoProducto
            // 
            this.lblNuevoProducto.AutoSize = true;
            this.lblNuevoProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProducto.Location = new System.Drawing.Point(290, 19);
            this.lblNuevoProducto.Name = "lblNuevoProducto";
            this.lblNuevoProducto.Size = new System.Drawing.Size(110, 13);
            this.lblNuevoProducto.TabIndex = 1;
            this.lblNuevoProducto.Text = "Nuevo Producto";
            // 
            // alta_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_wine_barrel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.pnlNuevoProducto);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "alta_producto";
            this.Text = "alta_producto";
            this.pnlNuevoProducto.ResumeLayout(false);
            this.pnlNuevoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Panel pnlNuevoProducto;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.RadioButton rbtCristaleria;
        private System.Windows.Forms.RadioButton rbtBebida;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblIdTipoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblNuevoProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label1;
    }
}