namespace capa_presentacion.perfil_supervisor
{
    partial class alta_proveedor
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
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlAltaProovedor = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.pnlAltaProovedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(343, 111);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(80, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(56, 110);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(36, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 167);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(450, 166);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.MaxLength = 30;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(185, 21);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(132, 107);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuit.MaxLength = 11;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(169, 21);
            this.txtCuit.TabIndex = 1;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 165);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 21);
            this.txtEmail.TabIndex = 3;
            // 
            // pnlAltaProovedor
            // 
            this.pnlAltaProovedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAltaProovedor.BackColor = System.Drawing.Color.Beige;
            this.pnlAltaProovedor.Controls.Add(this.btnLimpiar);
            this.pnlAltaProovedor.Controls.Add(this.txtTelefono);
            this.pnlAltaProovedor.Controls.Add(this.lblTelefono);
            this.pnlAltaProovedor.Controls.Add(this.lblCabecera);
            this.pnlAltaProovedor.Controls.Add(this.btnGuardarProveedor);
            this.pnlAltaProovedor.Controls.Add(this.txtRazonSocial);
            this.pnlAltaProovedor.Controls.Add(this.lblDireccion);
            this.pnlAltaProovedor.Controls.Add(this.txtCuit);
            this.pnlAltaProovedor.Controls.Add(this.txtEmail);
            this.pnlAltaProovedor.Controls.Add(this.lblRazonSocial);
            this.pnlAltaProovedor.Controls.Add(this.lblCuit);
            this.pnlAltaProovedor.Controls.Add(this.txtDireccion);
            this.pnlAltaProovedor.Controls.Add(this.lblEmail);
            this.pnlAltaProovedor.Location = new System.Drawing.Point(14, 12);
            this.pnlAltaProovedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAltaProovedor.Name = "pnlAltaProovedor";
            this.pnlAltaProovedor.Size = new System.Drawing.Size(706, 442);
            this.pnlAltaProovedor.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(417, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 29);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(132, 223);
            this.txtTelefono.MaxLength = 30;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 21);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(56, 224);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCabecera
            // 
            this.lblCabecera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(275, 38);
            this.lblCabecera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(120, 13);
            this.lblCabecera.TabIndex = 9;
            this.lblCabecera.Text = "Nuevo Proovedor";
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProveedor.Location = new System.Drawing.Point(549, 383);
            this.btnGuardarProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(125, 29);
            this.btnGuardarProveedor.TabIndex = 7;
            this.btnGuardarProveedor.Text = "Guardar Proveedor";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazonSocial.Location = new System.Drawing.Point(450, 111);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(185, 21);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(343, 164);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // alta_proveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_wine_barrel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAltaProovedor);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "alta_proveedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlAltaProovedor.ResumeLayout(false);
            this.pnlAltaProovedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlAltaProovedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnLimpiar;
    }
}