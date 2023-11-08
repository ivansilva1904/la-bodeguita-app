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

        public int insertCabecera(DateTime fecha, int formaPago, long tarjeta, float importeTotal, int dniEmpleado, int dniCliente)
        {
            try
            {
                conexion.Open();

                string query = " ";

                if (tarjeta == 0)
                {
                    query = "" +
                        "INSERT INTO ventasCabecera (fecha, idFormaPago, importeTotal, dniEmpleado, dniCliente) " +
                        "VALUES ('" + fecha.ToString("yyyy-MM-dd") + "', " + formaPago + ", " + importeTotal.ToString("0.00", CultureInfo.InvariantCulture) + ", " + dniEmpleado + ", " + dniCliente + "); " +
                        "SELECT SCOPE_IDENTITY();";
                }
                else
                {
                    query = "" +
                        "INSERT INTO ventasCabecera (fecha, idFormaPago, nroTarjeta, importeTotal, dniEmpleado, dniCliente) " +
                        "VALUES ('" + fecha.ToString("yyyy-MM-dd") + "', " + formaPago + ", " + tarjeta + ", " + importeTotal.ToString("0.00", CultureInfo.InvariantCulture) + ", " + dniEmpleado + ", " + dniCliente + "); " +
                        "SELECT SCOPE_IDENTITY();";
                }

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

                updateStock(idProducto, cantidad);

                comando.ExecuteNonQuery();

                cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el detalle. ID del producto: " + idProducto + "\nError: " + ex.Message);
            }
        }

        private void updateStock(int idProducto, int cantidad)
        {
            //Esto no abre ni cierra la conexion porque ya se encuentra abierta en la funcion donde es llamada
            try
            {
                string query = "" +
                    "UPDATE producto " +
                    "SET stockActual = stockActual - " + cantidad + " " +
                    "WHERE idProducto = " + idProducto;

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock del producto: " + idProducto + "\nError: " + ex.Message);
            }
        }




        public SqlDataReader selectVentasCantidadBebidas(DateTime desde, DateTime hasta)
        {
            try
            {
                conexion.Open();
                string fechdesde = desde.ToString("yyyy-MM-dd");
                string fechhasta = hasta.ToString("yyyy-MM-dd");

                string query = "" +
                     "SELECT tb.descripcion AS 'Tipo de Bebida', " +
                     "SUM(vd.cantidad) AS 'Cantidad Vendida'" +
                     "FROM ventasDetalle vd " +
                     "INNER JOIN producto p ON vd.idProducto = p.idProducto " +
                     "INNER JOIN tipoBebida tb ON p.idTipoBebida = tb.idTipoBebida " +
                     "INNER JOIN ventasCabecera vc ON vd.idVentaCabecera = vc.idVentaCabecera " +
                     "WHERE vc.fecha BETWEEN '" + fechdesde + "' AND '" + fechhasta + "' " +
                     "GROUP BY tb.descripcion ";


                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader drComando = comando.ExecuteReader();

                return drComando;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        

    }
}
