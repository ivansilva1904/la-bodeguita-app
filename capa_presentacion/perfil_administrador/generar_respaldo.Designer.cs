namespace capa_presentacion.perfil_administrador
{
    partial class generar_respaldo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreRespaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btnGenerarRespaldo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreRespaldo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 442);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Respaldo";
            // 
            // txtNombreRespaldo
            // 
            this.txtNombreRespaldo.Location = new System.Drawing.Point(165, 98);
            this.txtNombreRespaldo.Name = "txtNombreRespaldo";
            this.txtNombreRespaldo.Size = new System.Drawing.Size(326, 21);
            this.txtNombreRespaldo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Respaldo";
            // 
            // btnGenerarRespaldo
            // 
            this.btnGenerarRespaldo.Location = new System.Drawing.Point(507, 98);
            this.btnGenerarRespaldo.Name = "btnGenerarRespaldo";
            this.btnGenerarRespaldo.Size = new System.Drawing.Size(129, 21);
            this.btnGenerarRespaldo.TabIndex = 3;
            this.btnGenerarRespaldo.Text = "Generar Respaldo";
            this.btnGenerarRespaldo.UseVisualStyleBackColor = true;
            this.btnGenerarRespaldo.Click += new System.EventHandler(this.btnGenerarRespaldo_Click);
            // 
            // generar_respaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_15455291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 466);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "generar_respaldo";
            this.Text = "generar respaldo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerarRespaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRespaldo;
        private System.Windows.Forms.Label label1;
    }
}