namespace la_bodeguita
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BUT_ALTA_USUARIO = new System.Windows.Forms.Button();
            this.BUT_BAJA_USUARIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUT_ALTA_USUARIO
            // 
            this.BUT_ALTA_USUARIO.Location = new System.Drawing.Point(209, 124);
            this.BUT_ALTA_USUARIO.Name = "BUT_ALTA_USUARIO";
            this.BUT_ALTA_USUARIO.Size = new System.Drawing.Size(125, 35);
            this.BUT_ALTA_USUARIO.TabIndex = 0;
            this.BUT_ALTA_USUARIO.Text = "Alta usuario";
            this.BUT_ALTA_USUARIO.UseVisualStyleBackColor = true;
            this.BUT_ALTA_USUARIO.Click += new System.EventHandler(this.BUT_ALTA_USUARIO_Click);
            // 
            // BUT_BAJA_USUARIO
            // 
            this.BUT_BAJA_USUARIO.Location = new System.Drawing.Point(434, 124);
            this.BUT_BAJA_USUARIO.Name = "BUT_BAJA_USUARIO";
            this.BUT_BAJA_USUARIO.Size = new System.Drawing.Size(125, 35);
            this.BUT_BAJA_USUARIO.TabIndex = 1;
            this.BUT_BAJA_USUARIO.Text = "Baja usuario";
            this.BUT_BAJA_USUARIO.UseVisualStyleBackColor = true;
            this.BUT_BAJA_USUARIO.Click += new System.EventHandler(this.BUT_BAJA_USUARIO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BUT_BAJA_USUARIO);
            this.Controls.Add(this.BUT_ALTA_USUARIO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUT_ALTA_USUARIO;
        private System.Windows.Forms.Button BUT_BAJA_USUARIO;
    }
}

