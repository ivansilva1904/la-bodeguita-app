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
            this.BUT_OTRA_VISTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUT_OTRA_VISTA
            // 
            this.BUT_OTRA_VISTA.Location = new System.Drawing.Point(209, 124);
            this.BUT_OTRA_VISTA.Name = "BUT_OTRA_VISTA";
            this.BUT_OTRA_VISTA.Size = new System.Drawing.Size(75, 23);
            this.BUT_OTRA_VISTA.TabIndex = 0;
            this.BUT_OTRA_VISTA.Text = "Otra vista";
            this.BUT_OTRA_VISTA.UseVisualStyleBackColor = true;
            this.BUT_OTRA_VISTA.Click += new System.EventHandler(this.BUT_OTRA_VISTA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BUT_OTRA_VISTA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUT_OTRA_VISTA;
    }
}

