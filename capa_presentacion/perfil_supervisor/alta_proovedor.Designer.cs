﻿namespace capa_presentacion.perfil_supervisor
{
    partial class alta_proovedor
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
            this.lblRubro = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.pnlAltaProovedor = new System.Windows.Forms.Panel();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.pnlAltaProovedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(385, 93);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(80, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(96, 93);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(36, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(96, 150);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(41, 13);
            this.lblRubro.TabIndex = 2;
            this.lblRubro.Text = "Rubro";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(492, 143);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(116, 21);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(172, 90);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(116, 21);
            this.txtCuit.TabIndex = 4;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(172, 143);
            this.txtRubro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(116, 21);
            this.txtRubro.TabIndex = 5;
            this.txtRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRubro_KeyPress);
            // 
            // pnlAltaProovedor
            // 
            this.pnlAltaProovedor.BackColor = System.Drawing.Color.Beige;
            this.pnlAltaProovedor.Controls.Add(this.lblCabecera);
            this.pnlAltaProovedor.Controls.Add(this.btnGuardarProveedor);
            this.pnlAltaProovedor.Controls.Add(this.txtRazonSocial);
            this.pnlAltaProovedor.Controls.Add(this.lblDireccion);
            this.pnlAltaProovedor.Controls.Add(this.txtCuit);
            this.pnlAltaProovedor.Controls.Add(this.txtRubro);
            this.pnlAltaProovedor.Controls.Add(this.lblRazonSocial);
            this.pnlAltaProovedor.Controls.Add(this.lblCuit);
            this.pnlAltaProovedor.Controls.Add(this.txtDireccion);
            this.pnlAltaProovedor.Controls.Add(this.lblRubro);
            this.pnlAltaProovedor.Location = new System.Drawing.Point(14, 12);
            this.pnlAltaProovedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAltaProovedor.Name = "pnlAltaProovedor";
            this.pnlAltaProovedor.Size = new System.Drawing.Size(752, 317);
            this.pnlAltaProovedor.TabIndex = 6;
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Location = new System.Drawing.Point(329, 39);
            this.lblCabecera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(106, 13);
            this.lblCabecera.TabIndex = 9;
            this.lblCabecera.Text = "Nuevo Proovedor";
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Location = new System.Drawing.Point(573, 269);
            this.btnGuardarProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(125, 29);
            this.btnGuardarProveedor.TabIndex = 8;
            this.btnGuardarProveedor.Text = "Guardar Proovedor";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(492, 90);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(116, 21);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(385, 146);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // alta_proovedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(780, 341);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAltaProovedor);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "alta_proovedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.pnlAltaProovedor.ResumeLayout(false);
            this.pnlAltaProovedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.Panel pnlAltaProovedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Button btnGuardarProveedor;
    }
}