using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using capa_negocio;

namespace capa_presentacion.perfil_supervisor
{
    public partial class informes_generales : Form
    {
        public informes_generales()
        {
            InitializeComponent();
        }
        NegocioVenta negocioVenta = new NegocioVenta();


        private void graficoDeTorta(DataTable tabla,string nombreSerie,string nombreX,string nombreY)
        {

            if (tabla != null)
            {
                chartGeneral.Series.Clear();
                chartGeneral.Series.Add(nombreSerie);
                chartGeneral.Series[nombreSerie].ChartType = SeriesChartType.Pie;
                foreach (DataRow row in tabla.Rows)
                {
                    string nombre = row[nombreX].ToString() + " " + Convert.ToString(row[nombreY]);
                    double y = Convert.ToDouble(row[nombreY]);
                    chartGeneral.Series[nombreSerie].Points.AddXY(nombre, y);
                }
                /*
                chartCantidad.Series.Clear();

                foreach (DataRow row in v_cantidad_bebidas.Rows)
                {   
                    string nombre = row["Tipo de Bebida"].ToString();
                    Series serie = chartCantidad.Series.Add(nombre);
                    chartCantidad.Series[nombre].ChartType = SeriesChartType.Column;
                    int y = Convert.ToInt32(row["Cantidad Vendida"]);
                    serie.Label = Convert.ToString(y);
                    serie.Points.Add(y);
                }
                */
            }
        }

        private void graficoDeBarras(DataTable tabla,string nombreSerie,string nombreX,string nombreY)
        {
            if (tabla != null)
            {       
                chartGeneral.Series.Clear();
                foreach (DataRow row in tabla.Rows)
                {   
                    Series serie = chartGeneral.Series.Add(nombreSerie);
                    chartGeneral.Series[nombreX].ChartType = SeriesChartType.Column;
                    int y = Convert.ToInt32(row[nombreY]);
                    serie.Label = Convert.ToString(y);
                    serie.Points.Add(y);
                }           
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string filtro = cbxFiltro.Text;
            if (desde < hasta)
            {
                if (filtro == "Tipo de Bebida")
                {
                    lblNombreGrafico.Text = "Ventas por Cantidad";
                    DataTable v_cantidad_bebidas = new DataTable();
                    v_cantidad_bebidas = negocioVenta.ventas_por_cantidad_tipoBebida(desde, hasta);
                   // string nombre_Serie = "Cantidad/TipoBebidas";
                    string nombreX = v_cantidad_bebidas.Columns[0].ColumnName;
                    string nombreY = v_cantidad_bebidas.Columns[1].ColumnName;
                    graficoDeTorta(v_cantidad_bebidas, "Cantidad/TipoBebidas",nombreX,nombreY);
                 
                }
                else if (filtro == "Vendedor")
                {

                }
                else if (filtro == "Marca")
                {

                }
            }
            else
            {
                MessageBox.Show("La fecha desde es mayor a la fecha hasta"
                    ,"Error"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string filtro = cbxFiltro.Text;
            if (desde < hasta)
            {
                if (filtro == "Tipo de Bebida")
                {
                    lblNombreGrafico.Text = "Ventas por Cantidad";
                    DataTable v_cantidad_bebidas = new DataTable();
                    v_cantidad_bebidas = negocioVenta.ventas_por_cantidad_tipoBebida(desde, hasta);
                    // string nombre_Serie = "Cantidad/TipoBebidas";
                    string nombreX = v_cantidad_bebidas.Columns[0].ColumnName;
                    string nombreY = v_cantidad_bebidas.Columns[1].ColumnName;
                    graficoDeTorta(v_cantidad_bebidas, "Cantidad/TipoBebidas", nombreX, nombreY);

                }
                else if (filtro == "Vendedor")
                {

                }
                else if (filtro == "Marca")
                {

                }
            }
            else
            {
                MessageBox.Show("La fecha desde es mayor a la fecha hasta"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        
    }

    
}
        
   
