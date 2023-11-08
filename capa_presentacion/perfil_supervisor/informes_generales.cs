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
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            DataTable v_cantidad_bebidas = new DataTable();
            if (desde < hasta)
            {
                v_cantidad_bebidas = negocioVenta.ventas_por_cantidad_tipoBebida(desde, hasta);
                if (v_cantidad_bebidas != null)
                {
                     chartCantidad.Series.Clear(); 
                     chartCantidad.Series.Add("Cantidad/TipoBebidas"); 
                     chartCantidad.Series["Cantidad/TipoBebidas"].ChartType = SeriesChartType.Pie;
                     foreach (DataRow row in v_cantidad_bebidas.Rows)
                     {
                         string nombre = row["Tipo de Bebida"].ToString();
                         double y = Convert.ToDouble(row["Cantidad Vendida"]);
                         chartCantidad.Series["Cantidad/TipoBebidas"].Points.AddXY(nombre, y);
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
               

            else
                {
                    MessageBox.Show("ERROR AMIGO COMO VAS A PONER DESDE MAYOR QUE HASTA");
                }
            }
                      
        }
    }
}
