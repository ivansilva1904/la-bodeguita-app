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
                chartCantidad.Series.Clear();
                chartCantidad.Series.Add(nombreSerie);
                chartCantidad.Series[nombreSerie].ChartType = SeriesChartType.Pie;
                foreach (DataRow row in tabla.Rows)
                {
                    string nombre = row[nombreX].ToString() + "/" + Convert.ToString(row[nombreY]);
                    double y = Convert.ToDouble(row[nombreY]);
                    chartCantidad.Series[nombreSerie].Points.AddXY(nombre, y);
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

        private void graficoDeBarras(DataTable tabla, string nombreSerie, string nombreX, string nombreY)
        {
            if (tabla != null)
            {
                chartGanancia.Series.Clear();

                chartGanancia.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartGanancia.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chartGanancia.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                chartGanancia.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                chartGanancia.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

                foreach (DataRow row in tabla.Rows)
                {

                    string x = Convert.ToString(row[nombreX]);
                    int y = Convert.ToInt32(row[nombreY]);


                    Series serie = chartGanancia.Series.Add(x);
                    chartGanancia.Series[x].ChartType = SeriesChartType.Column;

                    DataPoint dataPoint = new DataPoint();
                    // dataPoint.AxisLabel = x; // Etiqueta en el eje X
                    dataPoint.YValues = new double[] { y };

                    // Agregar etiqueta personalizada a cada punto
                    dataPoint.Label = $"{y}";

                    // Agregar el punto de datos a la serie
                    chartGanancia.Series[x].Points.Add(dataPoint);

                }
            }
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string filtro = cbxFiltro.Text;
            if (desde < hasta)
            {
                if (filtro == "Tipo de Bebida")
                {

                    //para el grafico de torta
                    lblChartCantidad.Text = "Cantidad de Ventas : Tipo de Bebidas";
                    DataTable v_cantidad_bebidas = new DataTable();
                    v_cantidad_bebidas = negocioVenta.ventas_por_cantidad_tipoBebida(desde, hasta);
                    string nombreX = v_cantidad_bebidas.Columns[0].ColumnName;
                    string nombreY = v_cantidad_bebidas.Columns[1].ColumnName;
                    graficoDeTorta(v_cantidad_bebidas, "Cantidad/TipoBebidas", nombreX, nombreY);

                    //para el grafico de barras
                    lblChartGanancia.Text = "Ganancia Neta : Tipo de Bebidas";
                    DataTable v_ganancia_bebidas = new DataTable();
                    v_ganancia_bebidas = negocioVenta.ventas_por_ganancia_tipoBebida(desde, hasta);
                    string nombreX2 = v_ganancia_bebidas.Columns[0].ColumnName;
                    string nombreY2 = v_ganancia_bebidas.Columns[1].ColumnName;

                    graficoDeBarras(v_ganancia_bebidas, "Ganancia/TipoBebidas", nombreX2, nombreY2);

                }
                else if (filtro == "Vendedores")
                {
                    //para el grafico de torta
                    lblChartCantidad.Text = "Cantidad de Ventas : Vendedores";
                    DataTable v_cantidad_vendedor = new DataTable();
                    v_cantidad_vendedor = negocioVenta.ventas_por_cantidad_vendedor(desde, hasta);
                    string nombreX = v_cantidad_vendedor.Columns[0].ColumnName;
                    string nombreY = v_cantidad_vendedor.Columns[1].ColumnName;
                    graficoDeTorta(v_cantidad_vendedor, "Cantidad/Vendedor", nombreX, nombreY);

                    //para el grafico de barras
                    lblChartGanancia.Text = "Ganancia Neta : Vendedores";
                    DataTable v_ganancia_vendedor = new DataTable();
                    v_ganancia_vendedor = negocioVenta.ventas_por_ganancia_vendedor(desde, hasta);
                    string nombreX2 = v_ganancia_vendedor.Columns[0].ColumnName;
                    string nombreY2 = v_ganancia_vendedor.Columns[1].ColumnName;
                    graficoDeBarras(v_ganancia_vendedor, "Ganancia/Vendedor", nombreX2, nombreY2);
                }
                else if (filtro == "Marca")
                {
                    //para el grafico de torta
                    lblChartCantidad.Text = "Cantidad de Ventas : Marca";
                    DataTable v_cantidad_Marca = new DataTable();
                    v_cantidad_Marca = negocioVenta.ventas_por_cantidad_marca(desde, hasta);
                    string nombreX = v_cantidad_Marca.Columns[0].ColumnName;
                    string nombreY = v_cantidad_Marca.Columns[1].ColumnName;
                    graficoDeTorta(v_cantidad_Marca, "Cantidad/Marcar", nombreX, nombreY);

                    //para el grafico de barras
                    lblChartGanancia.Text = "Ganancia Neta : Marca";
                    DataTable v_ganancia_marca = new DataTable();
                    v_ganancia_marca = negocioVenta.ventas_por_ganancia_marca(desde, hasta);
                    string nombreX2 = v_ganancia_marca.Columns[0].ColumnName;
                    string nombreY2 = v_ganancia_marca.Columns[1].ColumnName;
                    graficoDeBarras(v_ganancia_marca, "Ganancia/Marca", nombreX2, nombreY2);
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
        
   
