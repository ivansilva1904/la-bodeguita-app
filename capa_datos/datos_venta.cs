using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_datos
{
    public class DatosVenta
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public int insertCabeceraEfectivo(DateTime fecha, int formaPago, float importeTotal, int dniEmpleado, int dniCliente)
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "INSERT INTO ventasCabecera (fecha, idFormaPago, importeTotal, dniEmpleado, dniCliente) " +
                    "VALUES ('" + fecha.ToString("yyyy-MM-dd") + "', " + formaPago + ", " + importeTotal.ToString("0.00", CultureInfo.InvariantCulture) +", "+ dniEmpleado +", "+ dniCliente +"); " +
                    "SELECT SCOPE_IDENTITY();";

                SqlCommand comando = new SqlCommand(query, conexion);

                int idCabecera = int.Parse(comando.ExecuteScalar().ToString());

                cerrarConexion();

                return idCabecera;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la cabecera: " + ex.Message);
                cerrarConexion();
                return 0;
            }
        }

        public void insertDetalle(int idCabecera, int idProducto, int cantidad, float precio)
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "INSERT INTO ventasDetalle (idVentaCabecera, idProducto, cantidad, precioParcial) " +
                    "VALUES ("+ idCabecera +", "+ idProducto +", "+ cantidad +", "+ precio.ToString("0.00", CultureInfo.InvariantCulture) +")";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();

                cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el detalle. ID del producto: " + idProducto + "\nError: " + ex.Message);
            }
        }
    }
}
