namespace capa_presentacion.perfil_vendedor
{
    partial class realizar_venta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.lblVendedorDNI = new System.Windows.Forms.Label();
            this.lblVerificarDNI = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTarjetaNumero = new System.Windows.Forms.TextBox();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.rbutTarjeta = new System.Windows.Forms.RadioButton();
            this.rbutEfectivo = new System.Windows.Forms.RadioButton();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.lblRegistroCliente = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoParcial = new System.Windows.Forms.TextBox();
            this.lblMontoParcial = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvVentaDetalle = new System.Windows.Forms.DataGridView();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.fbdComprobante = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btnComprobante);
            this.panel1.Controls.Add(this.lblVendedorDNI);
            this.panel1.Controls.Add(this.lblVerificarDNI);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtTarjetaNumero);
            this.panel1.Controls.Add(this.lblMedioPago);
            this.panel1.Controls.Add(this.rbutTarjeta);
            this.panel1.Controls.Add(this.rbutEfectivo);
            this.panel1.Controls.Add(this.btnRealizarVenta);
            this.panel1.Controls.Add(this.lblRegistroCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMontoParcial);
            this.panel1.Controls.Add(this.lblMontoParcial);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.dgvVentaDetalle);
            this.panel1.Controls.Add(this.txtDNICliente);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 442);
            this.panel1.TabIndex = 0;
            // 
            // btnComprobante
            // 
            this.btnComprobante.Location = new System.Drawing.Point(573, 155);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(96, 23);
            this.btnComprobante.TabIndex = 16;
            this.btnComprobante.Text = "Comprobante";
            this.btnComprobante.UseVisualStyleBackColor = true;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // lblVendedorDNI
            // 
            this.lblVendedorDNI.AutoSize = true;
            this.lblVendedorDNI.Location = new System.Drawing.Point(232, 59);
            this.lblVendedorDNI.Name = "lblVendedorDNI";
            this.lblVendedorDNI.Size = new System.Drawing.Size(119, 13);
            this.lblVendedorDNI.TabIndex = 15;
            this.lblVendedorDNI.Text = "acaben esta tortura";
            // 
            // lblVerificarDNI
            // 
            this.lblVerificarDNI.AutoSize = true;
            this.lblVerificarDNI.Location = new System.Drawing.Point(232, 104);
            this.lblVerificarDNI.Name = "lblVerificarDNI";
            this.lblVerificarDNI.Size = new System.Drawing.Size(34, 13);
            this.lblVerificarDNI.TabIndex = 14;
            this.lblVerificarDNI.Text = "chau";
            this.lblVerificarDNI.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(73, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(24, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "ola";
            // 
            // txtTarjetaNumero
            // 
            this.txtTarjetaNumero.Enabled = false;
            this.txtTarjetaNumero.Location = new System.Drawing.Point(356, 177);
            this.txtTarjetaNumero.Name = "txtTarjetaNumero";
            this.txtTarjetaNumero.Size = new System.Drawing.Size(165, 21);
            this.txtTarjetaNumero.TabIndex = 12;
            this.txtTarjetaNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaNumero_KeyPress);
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(74, 180);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(90, 13);
            this.lblMedioPago.TabIndex = 11;
            this.lblMedioPago.Text = "Medio de pago";
            // 
            // rbutTarjeta
            // 
            this.rbutTarjeta.AutoSize = true;
            this.rbutTarjeta.Location = new System.Drawing.Point(265, 178);
            this.rbutTarjeta.Name = "rbutTarjeta";
            this.rbutTarjeta.Size = new System.Drawing.Size(65, 17);
            this.rbutTarjeta.TabIndex = 10;
            this.rbutTarjeta.TabStop = true;
            this.rbutTarjeta.Text = "Tarjeta";
            this.rbutTarjeta.UseVisualStyleBackColor = true;
            this.rbutTarjeta.CheckedChanged += new System.EventHandler(this.rbutTarjeta_CheckedChanged);
            this.rbutTarjeta.Click += new System.EventHandler(this.rbutTarjeta_Click);
            // 
            // rbutEfectivo
            // 
            this.rbutEfectivo.AutoSize = true;
            this.rbutEfectivo.Location = new System.Drawing.Point(189, 178);
            this.rbutEfectivo.Name = "rbutEfectivo";
            this.rbutEfectivo.Size = new System.Drawing.Size(70, 17);
            this.rbutEfectivo.TabIndex = 9;
            this.rbutEfectivo.TabStop = true;
            this.rbutEfectivo.Text = "Efectivo";
            this.rbutEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(470, 390);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(150, 24);
            this.btnRealizarVenta.TabIndex = 8;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // lblRegistroCliente
            // 
            this.lblRegistroCliente.AutoSize = true;
            this.lblRegistroCliente.LinkColor = System.Drawing.Color.Black;
            this.lblRegistroCliente.Location = new System.Drawing.Point(73, 135);
            this.lblRegistroCliente.Name = "lblRegistroCliente";
            this.lblRegistroCliente.Size = new System.Drawing.Size(153, 13);
            this.lblRegistroCliente.TabIndex = 7;
            this.lblRegistroCliente.TabStop = true;
            this.lblRegistroCliente.Text = "Cliente nuevo? Registrelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese los productos a vender";
            // 
            // txtMontoParcial
            // 
            this.txtMontoParcial.Location = new System.Drawing.Point(190, 390);
            this.txtMontoParcial.Name = "txtMontoParcial";
            this.txtMontoParcial.ReadOnly = true;
            this.txtMontoParcial.Size = new System.Drawing.Size(150, 21);
            this.txtMontoParcial.TabIndex = 5;
            this.txtMontoParcial.Text = "0";
            // 
            // lblMontoParcial
            // 
            this.lblMontoParcial.AutoSize = true;
            this.lblMontoParcial.Location = new System.Drawing.Point(73, 393);
            this.lblMontoParcial.Name = "lblMontoParcial";
            this.lblMontoParcial.Size = new System.Drawing.Size(83, 13);
            this.lblMontoParcial.TabIndex = 4;
            this.lblMontoParcial.Text = "Monto parcial";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(470, 95);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar productos";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvVentaDetalle
            // 
            this.dgvVentaDetalle.AllowUserToAddRows = false;
            this.dgvVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaDetalle.Location = new System.Drawing.Point(76, 222);
            this.dgvVentaDetalle.Name = "dgvVentaDetalle";
            this.dgvVentaDetalle.Size = new System.Drawing.Size(544, 150);
            this.dgvVentaDetalle.TabIndex = 2;
            this.dgvVentaDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentaDetalle_CellContentClick);
            this.dgvVentaDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentaDetalle_CellEndEdit);
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(76, 101);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(150, 21);
            this.txtDNICliente.TabIndex = 1;
            this.txtDNICliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNICliente_KeyPress);
            this.txtDNICliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtDNICliente_Validating);
            this.txtDNICliente.Validated += new System.EventHandler(this.txtDNICliente_Validated);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(73, 85);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(91, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI del cliente";
            // 
            // realizar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.purple_grapes_vineyard_napa_valley_napa_vineyard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "realizar_venta";
            this.Text = "La bodeguita - Realizar venta";
            this.Load += new System.EventHandler(this.realizar_venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.DataGridView dgvVentaDetalle;
        private System.Windows.Forms.TextBox txtMontoParcial;
        private System.Windows.Forms.Label lblMontoParcial;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRegistroCliente;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.RadioButton rbutTarjeta;
        private System.Windows.Forms.RadioButton rbutEfectivo;
        private System.Windows.Forms.TextBox txtTarjetaNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVerificarDNI;
        private System.Windows.Forms.Label lblVendedorDNI;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.FolderBrowserDialog fbdComprobante;
    }
}