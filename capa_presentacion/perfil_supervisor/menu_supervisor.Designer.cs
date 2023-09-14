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
            this.pnlFormsSupervisor = new System.Windows.Forms.Panel();
            this.menuSupervisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaProovedor
            // 
            this.btnAltaProovedor.Location = new System.Drawing.Point(39, 61);
            this.btnAltaProovedor.Name = "btnAltaProovedor";
            this.btnAltaProovedor.Size = new System.Drawing.Size(85, 32);
            this.btnAltaProovedor.TabIndex = 0;
            this.btnAltaProovedor.Text = "Alta Proovedor";
            this.btnAltaProovedor.UseVisualStyleBackColor = true;
            this.btnAltaProovedor.Click += new System.EventHandler(this.btnAltaProovedor_Click);
            // 
            // menuSupervisor
            // 
            this.menuSupervisor.Controls.Add(this.btnAltaProovedor);
            this.menuSupervisor.Location = new System.Drawing.Point(12, 12);
            this.menuSupervisor.Name = "menuSupervisor";
            this.menuSupervisor.Size = new System.Drawing.Size(221, 452);
            this.menuSupervisor.TabIndex = 1;
            // 
            // pnlFormsSupervisor
            // 
            this.pnlFormsSupervisor.Location = new System.Drawing.Point(239, 12);
            this.pnlFormsSupervisor.Name = "pnlFormsSupervisor";
            this.pnlFormsSupervisor.Size = new System.Drawing.Size(633, 438);
            this.pnlFormsSupervisor.TabIndex = 2;
            // 
            // menu_supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.pnlFormsSupervisor);
            this.Controls.Add(this.menuSupervisor);
            this.Name = "menu_supervisor";
            this.Text = "Supervisor";
            this.menuSupervisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProovedor;
        private System.Windows.Forms.Panel menuSupervisor;
        private System.Windows.Forms.Panel pnlFormsSupervisor;
    }
}