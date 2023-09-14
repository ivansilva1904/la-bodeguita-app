namespace capa_presentacion.perfil_administrador
{
    partial class menu_administrador
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
            this.panOpciones = new System.Windows.Forms.Panel();
            this.panAltaUsuario = new System.Windows.Forms.Panel();
            this.lblAltaUsuario = new System.Windows.Forms.Label();
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.lblModificarUsuario = new System.Windows.Forms.Label();
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            this.panOpciones.SuspendLayout();
            this.panAltaUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panOpciones
            // 
            this.panOpciones.BackColor = System.Drawing.Color.Tan;
            this.panOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panOpciones.Controls.Add(this.panAltaUsuario);
            this.panOpciones.Controls.Add(this.btnGenerarRespaldo);
            this.panOpciones.Controls.Add(this.lblModificarUsuario);
            this.panOpciones.Controls.Add(this.lblBajaUsuario);
            this.panOpciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panOpciones.Location = new System.Drawing.Point(-1, -1);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Size = new System.Drawing.Size(221, 452);
            this.panOpciones.TabIndex = 0;
            // 
            // panAltaUsuario
            // 
            this.panAltaUsuario.Controls.Add(this.lblAltaUsuario);
            this.panAltaUsuario.Location = new System.Drawing.Point(-2, 68);
            this.panAltaUsuario.Name = "panAltaUsuario";
            this.panAltaUsuario.Size = new System.Drawing.Size(221, 51);
            this.panAltaUsuario.TabIndex = 4;
            this.panAltaUsuario.MouseHover += new System.EventHandler(this.panAltaUsuario_MouseHover);
            // 
            // lblAltaUsuario
            // 
            this.lblAltaUsuario.AutoSize = true;
            this.lblAltaUsuario.Location = new System.Drawing.Point(53, 17);
            this.lblAltaUsuario.Name = "lblAltaUsuario";
            this.lblAltaUsuario.Size = new System.Drawing.Size(107, 18);
            this.lblAltaUsuario.TabIndex = 0;
            this.lblAltaUsuario.Text = "Alta usuario";
            // 
            // btnGenerarRespaldo
            // 
            this.btnGenerarRespaldo.Location = new System.Drawing.Point(18, 397);
            this.btnGenerarRespaldo.Name = "btnGenerarRespaldo";
            this.btnGenerarRespaldo.Size = new System.Drawing.Size(161, 30);
            this.btnGenerarRespaldo.TabIndex = 3;
            this.btnGenerarRespaldo.Text = "Generar respaldo";
            this.btnGenerarRespaldo.UseVisualStyleBackColor = true;
            // 
            // lblModificarUsuario
            // 
            this.lblModificarUsuario.AutoSize = true;
            this.lblModificarUsuario.Location = new System.Drawing.Point(32, 214);
            this.lblModificarUsuario.Name = "lblModificarUsuario";
            this.lblModificarUsuario.Size = new System.Drawing.Size(147, 18);
            this.lblModificarUsuario.TabIndex = 2;
            this.lblModificarUsuario.Text = "Modificar usuario";
            // 
            // lblBajaUsuario
            // 
            this.lblBajaUsuario.AutoSize = true;
            this.lblBajaUsuario.Location = new System.Drawing.Point(47, 145);
            this.lblBajaUsuario.Name = "lblBajaUsuario";
            this.lblBajaUsuario.Size = new System.Drawing.Size(111, 18);
            this.lblBajaUsuario.TabIndex = 1;
            this.lblBajaUsuario.Text = "Baja usuario";
            // 
            // menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panOpciones);
            this.Name = "menu_administrador";
            this.Text = "menu";
            this.panOpciones.ResumeLayout(false);
            this.panOpciones.PerformLayout();
            this.panAltaUsuario.ResumeLayout(false);
            this.panAltaUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.Label lblAltaUsuario;
        private System.Windows.Forms.Label lblBajaUsuario;
        private System.Windows.Forms.Button btnGenerarRespaldo;
        private System.Windows.Forms.Label lblModificarUsuario;
        private System.Windows.Forms.Panel panAltaUsuario;
    }
}