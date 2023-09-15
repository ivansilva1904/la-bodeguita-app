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
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.btnBajaEmpleado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModEmpleado = new System.Windows.Forms.Button();
            this.panOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panOpciones
            // 
            this.panOpciones.BackColor = System.Drawing.Color.Tan;
            this.panOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panOpciones.Controls.Add(this.btnModEmpleado);
            this.panOpciones.Controls.Add(this.btnBajaEmpleado);
            this.panOpciones.Controls.Add(this.btnAltaEmpleado);
            this.panOpciones.Controls.Add(this.btnGenerarRespaldo);
            this.panOpciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panOpciones.Location = new System.Drawing.Point(-1, -1);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Size = new System.Drawing.Size(257, 466);
            this.panOpciones.TabIndex = 0;
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
            this.btnAltaEmpleado.MouseEnter += new System.EventHandler(this.btnAltaEmpleado_MouseEnter);
            this.btnAltaEmpleado.MouseLeave += new System.EventHandler(this.btnAltaEmpleado_MouseLeave);
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
            this.btnBajaEmpleado.MouseEnter += new System.EventHandler(this.btnBajaEmpleado_MouseEnter);
            this.btnBajaEmpleado.MouseLeave += new System.EventHandler(this.btnBajaEmpleado_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(256, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 466);
            this.panel1.TabIndex = 1;
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
            this.btnModEmpleado.MouseEnter += new System.EventHandler(this.btnModEmpleado_MouseEnter);
            this.btnModEmpleado.MouseLeave += new System.EventHandler(this.btnModEmpleado_MouseLeave);
            // 
            // menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panOpciones);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "menu_administrador";
            this.Text = "menu";
            this.panOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.Button btnGenerarRespaldo;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.Button btnBajaEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModEmpleado;
    }
}