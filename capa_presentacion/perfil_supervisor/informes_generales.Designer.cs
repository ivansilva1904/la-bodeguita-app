
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.chartGanancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancia)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCantidad
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCantidad.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCantidad.Legends.Add(legend1);
            this.chartCantidad.Location = new System.Drawing.Point(277, 77);
            this.chartCantidad.Name = "chartCantidad";
            this.chartCantidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCantidad.Series.Add(series1);
            this.chartCantidad.Size = new System.Drawing.Size(240, 210);
            this.chartCantidad.TabIndex = 0;
            this.chartCantidad.Text = "Cantidad";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(12, 92);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(119, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(137, 92);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(119, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bebidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartGanancia
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGanancia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGanancia.Legends.Add(legend2);
            this.chartGanancia.Location = new System.Drawing.Point(523, 77);
            this.chartGanancia.Name = "chartGanancia";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGanancia.Series.Add(series2);
            this.chartGanancia.Size = new System.Drawing.Size(231, 210);
            this.chartGanancia.TabIndex = 4;
            this.chartGanancia.Text = "Ganancia";
            // 
            // informes_generales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartGanancia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.chartCantidad);
            this.Name = "informes_generales";
            this.Text = "informes_generales";
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantidad;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancia;
    }
}