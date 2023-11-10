
namespace capa_presentacion.perfil_supervisor
{
    partial class informes_generales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.pnlInformesGenerales = new System.Windows.Forms.Panel();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreGrafico = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblInformesG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).BeginInit();
            this.pnlInformesGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGeneral
            // 
            this.chartGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartGeneral.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGeneral.Legends.Add(legend2);
            this.chartGeneral.Location = new System.Drawing.Point(282, 66);
            this.chartGeneral.Name = "chartGeneral";
            this.chartGeneral.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGeneral.Series.Add(series2);
            this.chartGeneral.Size = new System.Drawing.Size(394, 335);
            this.chartGeneral.TabIndex = 0;
            this.chartGeneral.Text = "Cantidad";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(89, 80);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(96, 21);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(89, 123);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(96, 21);
            this.dtpHasta.TabIndex = 2;
            // 
            // pnlInformesGenerales
            // 
            this.pnlInformesGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformesGenerales.BackColor = System.Drawing.Color.Beige;
            this.pnlInformesGenerales.Controls.Add(this.btnGanancia);
            this.pnlInformesGenerales.Controls.Add(this.btnCantidad);
            this.pnlInformesGenerales.Controls.Add(this.label5);
            this.pnlInformesGenerales.Controls.Add(this.lblNombreGrafico);
            this.pnlInformesGenerales.Controls.Add(this.lblHasta);
            this.pnlInformesGenerales.Controls.Add(this.lblDesde);
            this.pnlInformesGenerales.Controls.Add(this.label1);
            this.pnlInformesGenerales.Controls.Add(this.cbxFiltro);
            this.pnlInformesGenerales.Controls.Add(this.lblInformesG);
            this.pnlInformesGenerales.Controls.Add(this.chartGeneral);
            this.pnlInformesGenerales.Controls.Add(this.dtpHasta);
            this.pnlInformesGenerales.Controls.Add(this.dtpDesde);
            this.pnlInformesGenerales.Location = new System.Drawing.Point(12, 12);
            this.pnlInformesGenerales.Name = "pnlInformesGenerales";
            this.pnlInformesGenerales.Size = new System.Drawing.Size(693, 404);
            this.pnlInformesGenerales.TabIndex = 4;
            // 
            // btnGanancia
            // 
            this.btnGanancia.Location = new System.Drawing.Point(133, 238);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(100, 23);
            this.btnGanancia.TabIndex = 5;
            this.btnGanancia.Text = "Ganancia Neta";
            this.btnGanancia.UseVisualStyleBackColor = true;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // btnCantidad
            // 
            this.btnCantidad.Location = new System.Drawing.Point(33, 238);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(94, 23);
            this.btnCantidad.TabIndex = 4;
            this.btnCantidad.Text = "Cantidad";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Informacion Sobre";
            // 
            // lblNombreGrafico
            // 
            this.lblNombreGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreGrafico.AutoSize = true;
            this.lblNombreGrafico.Location = new System.Drawing.Point(446, 50);
            this.lblNombreGrafico.Name = "lblNombreGrafico";
            this.lblNombreGrafico.Size = new System.Drawing.Size(97, 13);
            this.lblNombreGrafico.TabIndex = 9;
            this.lblNombreGrafico.Text = "Nombre Grafico";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(32, 129);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(44, 13);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(30, 86);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 13);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccion de Fecha";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Tipo de Bebida",
            "Vendedores",
            "Marca"});
            this.cbxFiltro.Location = new System.Drawing.Point(33, 194);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltro.TabIndex = 3;
            // 
            // lblInformesG
            // 
            this.lblInformesG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInformesG.AutoSize = true;
            this.lblInformesG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformesG.Location = new System.Drawing.Point(279, 15);
            this.lblInformesG.Name = "lblInformesG";
            this.lblInformesG.Size = new System.Drawing.Size(137, 13);
            this.lblInformesG.TabIndex = 4;
            this.lblInformesG.Text = "Informes Generales";
            // 
            // informes_generales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::capa_presentacion.Properties.Resources.pexels_photo_wine_barrel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.pnlInformesGenerales);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "informes_generales";
            this.Text = "informes_generales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).EndInit();
            this.pnlInformesGenerales.ResumeLayout(false);
            this.pnlInformesGenerales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneral;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Panel pnlInformesGenerales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreGrafico;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblInformesG;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Button btnCantidad;
    }
}