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






        //Funciones para Informes Generales
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

        //Funciones para informes Venta

        public SqlDataReader selectVentasMultiuso(DateTime desde, DateTime hasta,string dniEmpleado,string dniCliente)
        {
            try
            {
                conexion.Open();
                string fechdesde = desde.ToString("yyyy-MM-dd");
                string fechhasta = hasta.ToString("yyyy-MM-dd");

                string query = "" +
                    "SELECT ventaCabecera.idVentaCabecera as 'ID Venta'," +
                    "clientes.dniCliente AS 'DNI Cliente'," +
                    "clientes.nombre +' '+ clientes.apellido AS 'Nombre Cliente' ," +
                    "empleado.dniEmpleado AS 'DNI Empleado'," +
                    "empleado.nombre +' '+empleado.apellido AS 'Nombre Empleado',"+
                    "formasPago.descripcion AS 'Forma Pago', " +
                    "ventaCabecera.importeTotal AS 'Importe Total', " +
                    "ventaCabecera.fecha AS 'Fecha' " +
                    "FROM ventasCabecera ventaCabecera " +
                    "INNER JOIN clientes clientes ON ventaCabecera.dniCliente = clientes.dniCliente " +
                    "INNER JOIN empleados empleado ON ventaCabecera.dniEmpleado = empleado.dniEmpleado " +
                    "INNER JOIN formasPago formasPago ON ventaCabecera.idFormaPago = formasPago.idFormaPago " +
                    "WHERE ventaCabecera.fecha BETWEEN '"+fechdesde+"' AND '"+fechhasta+"'";               
                if (!String.IsNullOrWhiteSpace(dniEmpleado))
                {
                    int dEmp = Convert.ToInt32(dniEmpleado);
                    query = query + " AND empleado.dniEmpleado = " + dEmp;
                }
                if (!String.IsNullOrWhiteSpace(dniCliente))
                {
                    int dCli = Convert.ToInt32(dniCliente);
                    query = query + " AND clientes.dniCliente = " + dCli;
                }


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

        public SqlDataReader selectVentasFactura(int idCabecera)
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "SELECT vc.fecha AS 'Fecha', " + 
	                    "vc.idFormaPago AS 'Forma pago', " +
                        "emp.nombre + ' ' + emp.apellido AS 'Nombre empleado', " +
	                    "cli.dniCliente AS 'DNI cliente', " +
                        "cli.nombre + ' ' + cli.apellido AS 'Nombre cliente', " +
                        "mar.descripcion + ' - ' +  pro.descripcion AS 'Producto', " +
	                    "vd.cantidad AS 'Cantidad', " +
	                    "pro.precioVenta AS 'Precio', " +
	                    "vd.precioParcial AS 'Subtotal', " +
	                    "vc.importeTotal AS 'Total' " +
                    "FROM ventasCabecera vc " +
                    "JOIN ventasDetalle vd ON vc.idVentaCabecera = vd.idVentaCabecera " +
                    "JOIN empleados emp ON vc.dniEmpleado = emp.dniEmpleado " +
                    "JOIN clientes cli ON vc.dniCliente = cli.dniCliente " +
                    "JOIN producto pro ON vd.idProducto = pro.idProducto " +
                    "JOIN marca mar ON pro.idMarca = mar.idMarca " +
                    "WHERE vc.idVentaCabecera = " + idCabecera + ";";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader drComando = comando.ExecuteReader();

                return drComando;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la venta: " + ex.Message);
                return null;
            }
        }

    }
}
