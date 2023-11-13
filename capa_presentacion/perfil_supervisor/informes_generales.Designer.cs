
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.pnlInformesGenerales = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblChartGanancia = new System.Windows.Forms.Label();
            this.chartGanancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.lblChartCantidad = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblInformesG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).BeginInit();
            this.pnlInformesGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancia)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCantidad
            // 
            this.chartCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea3.Name = "ChartArea1";
            this.chartCantidad.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCantidad.Legends.Add(legend3);
            this.chartCantidad.Location = new System.Drawing.Point(35, 143);
            this.chartCantidad.Name = "chartCantidad";
            this.chartCantidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCantidad.Series.Add(series3);
            this.chartCantidad.Size = new System.Drawing.Size(307, 242);
            this.chartCantidad.TabIndex = 0;
            this.chartCantidad.Text = "Cantidad";
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
            this.dtpHasta.Location = new System.Drawing.Point(246, 78);
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
            this.pnlInformesGenerales.Controls.Add(this.btnGenerar);
            this.pnlInformesGenerales.Controls.Add(this.lblChartGanancia);
            this.pnlInformesGenerales.Controls.Add(this.chartGanancia);
            this.pnlInformesGenerales.Controls.Add(this.label5);
            this.pnlInformesGenerales.Controls.Add(this.lblChartCantidad);
            this.pnlInformesGenerales.Controls.Add(this.lblHasta);
            this.pnlInformesGenerales.Controls.Add(this.lblDesde);
            this.pnlInformesGenerales.Controls.Add(this.label1);
            this.pnlInformesGenerales.Controls.Add(this.cbxFiltro);
            this.pnlInformesGenerales.Controls.Add(this.lblInformesG);
            this.pnlInformesGenerales.Controls.Add(this.chartCantidad);
            this.pnlInformesGenerales.Controls.Add(this.dtpHasta);
            this.pnlInformesGenerales.Controls.Add(this.dtpDesde);
            this.pnlInformesGenerales.Location = new System.Drawing.Point(12, 12);
            this.pnlInformesGenerales.Name = "pnlInformesGenerales";
            this.pnlInformesGenerales.Size = new System.Drawing.Size(693, 404);
            this.pnlInformesGenerales.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(548, 76);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(94, 23);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblChartGanancia
            // 
            this.lblChartGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChartGanancia.AutoSize = true;
            this.lblChartGanancia.Location = new System.Drawing.Point(354, 127);
            this.lblChartGanancia.Name = "lblChartGanancia";
            this.lblChartGanancia.Size = new System.Drawing.Size(103, 13);
            this.lblChartGanancia.TabIndex = 12;
            this.lblChartGanancia.Text = "Ganancia Neta : ";
            // 
            // chartGanancia
            // 
            this.chartGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartGanancia.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGanancia.Legends.Add(legend4);
            this.chartGanancia.Location = new System.Drawing.Point(357, 143);
            this.chartGanancia.Name = "chartGanancia";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartGanancia.Series.Add(series4);
            this.chartGanancia.Size = new System.Drawing.Size(300, 242);
            this.chartGanancia.TabIndex = 11;
            this.chartGanancia.Text = "chart1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Informacion Sobre";
            // 
            // lblChartCantidad
            // 
            this.lblChartCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChartCantidad.AutoSize = true;
            this.lblChartCantidad.Location = new System.Drawing.Point(32, 127);
            this.lblChartCantidad.Name = "lblChartCantidad";
            this.lblChartCantidad.Size = new System.Drawing.Size(132, 13);
            this.lblChartCantidad.TabIndex = 9;
            this.lblChartCantidad.Text = "Cantidad de Ventas : ";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(189, 84);
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
            this.cbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Tipo de Bebida",
            "Vendedores",
            "Marca"});
            this.cbxFiltro.Location = new System.Drawing.Point(394, 78);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(132, 21);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).EndInit();
            this.pnlInformesGenerales.ResumeLayout(false);
            this.pnlInformesGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantidad;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Panel pnlInformesGenerales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblChartCantidad;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblInformesG;
        private System.Windows.Forms.Label lblChartGanancia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancia;
        private System.Windows.Forms.Button btnGenerar;
    }
}