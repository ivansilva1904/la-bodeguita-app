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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_administrador));
            this.panOpciones = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.btnModEmpleado = new System.Windows.Forms.Button();
            this.btnBajaEmpleado = new System.Windows.Forms.Button();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.panFormsAdministrador = new System.Windows.Forms.Panel();
            this.panOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panOpciones
            // 
            this.panOpciones.AutoSize = true;
            this.panOpciones.BackColor = System.Drawing.Color.Tan;
            this.panOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panOpciones.Controls.Add(this.picboxLogo);
            this.panOpciones.Controls.Add(this.btnModEmpleado);
            this.panOpciones.Controls.Add(this.btnBajaEmpleado);
            this.panOpciones.Controls.Add(this.btnAltaEmpleado);
            this.panOpciones.Controls.Add(this.btnGenerarRespaldo);
            this.panOpciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panOpciones.Location = new System.Drawing.Point(-1, -1);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Size = new System.Drawing.Size(262, 466);
            this.panOpciones.TabIndex = 0;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLogo.BackgroundImage")));
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxLogo.Location = new System.Drawing.Point(33, 13);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(186, 104);
            this.picboxLogo.TabIndex = 7;
            this.picboxLogo.TabStop = false;
            // 
            // btnModEmpleado
            // 
            this.btnModEmpleado.FlatAppearance.BorderSize = 0;
            this.btnModEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModEmpleado.Location = new System.Drawing.Point(-2, 235);
            this.btnModEmpleado.Name = "btnModEmpleado";
            this.btnModEmpleado.Size = new System.Drawing.Size(257, 50);
            this.btnModEmpleado.TabIndex = 6;
            this.btnModEmpleado.Text = "Modificar empleado";
            this.btnModEmpleado.UseVisualStyleBackColor = true;
            this.btnModEmpleado.Click += new System.EventHandler(this.btnModEmpleado_Click);
            this.btnModEmpleado.MouseEnter += new System.EventHandler(this.btnModEmpleado_MouseEnter);
            this.btnModEmpleado.MouseLeave += new System.EventHandler(this.btnModEmpleado_MouseLeave);
            // 
            // btnBajaEmpleado
            // 
            this.btnBajaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBajaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaEmpleado.Location = new System.Drawing.Point(-2, 179);
            this.btnBajaEmpleado.Name = "btnBajaEmpleado";
            this.btnBajaEmpleado.Size = new System.Drawing.Size(257, 50);
            this.btnBajaEmpleado.TabIndex = 5;
            this.btnBajaEmpleado.Text = "Baja empleado";
            this.btnBajaEmpleado.UseVisualStyleBackColor = true;
            this.btnBajaEmpleado.Click += new System.EventHandler(this.btnBajaEmpleado_Click);
            this.btnBajaEmpleado.MouseEnter += new System.EventHandler(this.btnBajaEmpleado_MouseEnter);
            this.btnBajaEmpleado.MouseLeave += new System.EventHandler(this.btnBajaEmpleado_MouseLeave);
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(-2, 123);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(257, 50);
            this.btnAltaEmpleado.TabIndex = 4;
            this.btnAltaEmpleado.Text = "Alta empleado";
            this.btnAltaEmpleado.UseVisualStyleBackColor = true;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            this.btnAltaEmpleado.MouseEnter += new System.EventHandler(this.btnAltaEmpleado_MouseEnter);
            this.btnAltaEmpleado.MouseLeave += new System.EventHandler(this.btnAltaEmpleado_MouseLeave);
            // 
            // btnGenerarRespaldo
            // 
            this.btnGenerarRespaldo.FlatAppearance.BorderSize = 0;
            this.btnGenerarRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRespaldo.Location = new System.Drawing.Point(-2, 389);
            this.btnGenerarRespaldo.Name = "btnGenerarRespaldo";
            this.btnGenerarRespaldo.Size = new System.Drawing.Size(257, 50);
            this.btnGenerarRespaldo.TabIndex = 3;
            this.btnGenerarRespaldo.Text = "Generar respaldo";
            this.btnGenerarRespaldo.UseVisualStyleBackColor = true;
            this.btnGenerarRespaldo.MouseEnter += new System.EventHandler(this.btnGenerarRespaldo_MouseEnter);
            this.btnGenerarRespaldo.MouseLeave += new System.EventHandler(this.btnGenerarRespaldo_MouseLeave);
            // 
            // panFormsAdministrador
            // 
            this.panFormsAdministrador.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_1283219;
            this.panFormsAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panFormsAdministrador.Location = new System.Drawing.Point(254, -1);
            this.panFormsAdministrador.Name = "panFormsAdministrador";
            this.panFormsAdministrador.Size = new System.Drawing.Size(733, 466);
            this.panFormsAdministrador.TabIndex = 1;
            // 
            // menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panFormsAdministrador);
            this.Controls.Add(this.panOpciones);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "menu_administrador";
            this.Text = "menu";
            this.panOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.Button btnGenerarRespaldo;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.Button btnBajaEmpleado;
        private System.Windows.Forms.Panel panFormsAdministrador;
        private System.Windows.Forms.Button btnModEmpleado;
        private System.Windows.Forms.PictureBox picboxLogo;
    }
}