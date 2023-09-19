namespace capa_presentacion.perfil_supervisor
{
    partial class menu_supervisor
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
            this.btnAltaProovedor = new System.Windows.Forms.Button();
            this.menuSupervisor = new System.Windows.Forms.Panel();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnBajaProveedor = new System.Windows.Forms.Button();
            this.pnlFormsSupervisor = new System.Windows.Forms.Panel();
            this.menuSupervisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaProovedor
            // 
            this.btnAltaProovedor.Location = new System.Drawing.Point(46, 61);
            this.btnAltaProovedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAltaProovedor.Name = "btnAltaProovedor";
            this.btnAltaProovedor.Size = new System.Drawing.Size(130, 31);
            this.btnAltaProovedor.TabIndex = 0;
            this.btnAltaProovedor.Text = "Alta Proovedor";
            this.btnAltaProovedor.UseVisualStyleBackColor = true;
            this.btnAltaProovedor.Click += new System.EventHandler(this.btnAltaProovedor_Click);
            // 
            // menuSupervisor
            // 
            this.menuSupervisor.BackColor = System.Drawing.Color.Tan;
            this.menuSupervisor.Controls.Add(this.btnAltaProducto);
            this.menuSupervisor.Controls.Add(this.btnModificarProveedor);
            this.menuSupervisor.Controls.Add(this.btnBajaProveedor);
            this.menuSupervisor.Controls.Add(this.btnAltaProovedor);
            this.menuSupervisor.Location = new System.Drawing.Point(1, 0);
            this.menuSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuSupervisor.Name = "menuSupervisor";
            this.menuSupervisor.Size = new System.Drawing.Size(257, 466);
            this.menuSupervisor.TabIndex = 1;
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(46, 226);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(130, 38);
            this.btnAltaProducto.TabIndex = 0;
            this.btnAltaProducto.Text = "Alta Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(46, 169);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(130, 34);
            this.btnModificarProveedor.TabIndex = 0;
            this.btnModificarProveedor.Text = "Modificar Proveedor";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnBajaProveedor
            // 
            this.btnBajaProveedor.Location = new System.Drawing.Point(46, 113);
            this.btnBajaProveedor.Name = "btnBajaProveedor";
            this.btnBajaProveedor.Size = new System.Drawing.Size(130, 32);
            this.btnBajaProveedor.TabIndex = 0;
            this.btnBajaProveedor.Text = "Baja Proveedor";
            this.btnBajaProveedor.UseVisualStyleBackColor = true;
            this.btnBajaProveedor.Click += new System.EventHandler(this.btnBajaProveedor_Click);
            // 
            // pnlFormsSupervisor
            // 
            this.pnlFormsSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormsSupervisor.Location = new System.Drawing.Point(256, -1);
            this.pnlFormsSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFormsSupervisor.Name = "pnlFormsSupervisor";
            this.pnlFormsSupervisor.Size = new System.Drawing.Size(733, 464);
            this.pnlFormsSupervisor.TabIndex = 0;
            // 
            // menu_supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.pnlFormsSupervisor);
            this.Controls.Add(this.menuSupervisor);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "menu_supervisor";
            this.Text = "Supervisor";
            this.menuSupervisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProovedor;
        private System.Windows.Forms.Panel menuSupervisor;
        private System.Windows.Forms.Panel pnlFormsSupervisor;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnBajaProveedor;
    }
}