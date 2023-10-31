using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_datos
{
    public class DatosProducto
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }
        public SqlDataReader buscarProducto(int idProducto)
        {
            conexion.Open();

            string query = "SELECT * FROM empleados WHERE dniEmpleado = " + idProducto;

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader resultado = comando.ExecuteReader();

            return resultado;
        }

        public void insertProducto(string descripcion, int idMarca, float precioCompra, float precioVenta,
            int stockMinimo, int StockActual, long cuitProveedor, int idTipoBebida)
        {
            conexion.Open();

            string query = "INSERT INTO producto (descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida) " +
                "VALUES ('" + descripcion + "'," + idMarca + "" +
                "," + precioCompra + "," + precioVenta + "," + stockMinimo + "," + StockActual +
                "," + cuitProveedor + "," + idTipoBebida + ");";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }
        public SqlDataReader selectTodosProductos()
        {
            conexion.Open();
            string query = "" +
               "SELECT producto.idProducto AS 'ID Producto',producto.descripcion AS 'Descripcion',marca.descripcion AS 'Marca',"+
               "producto.precioCompra AS 'Precio Compra',producto.precioVenta AS 'Precio Venta',producto.stockMinimo AS 'Stock Minimo',"+
               "producto.stockActual AS 'Stock Actual',proveedor.razonSocial AS 'Nombre Proveedor',tipoBebida.descripcion AS 'Tipo Bebida',producto.baja AS 'Baja'"+
               "FROM producto "+
               "INNER JOIN marca ON(producto.idMarca = marca.idMarca) "+
               "INNER JOIN proveedor ON(producto.cuitProveedor = proveedor.cuitProveedor) "+
                "INNER JOIN tipoBebida ON(producto.idTipoBebida = tipoBebida.idTipoBebida) "+
                "SELECT idProducto AS 'Id Producto', " +
                "descripcion AS 'Descripcion', " +
                "idMarca AS 'Marca', " +
                "precioCompra AS 'Precio Compra', " +
                "precioVenta AS 'Precio Venta', " +
                "stockMinimo AS 'Stock Minimo', " +
                "stockActual AS 'Stock', " +
                "cuitProveedor AS 'Cuit Proveedor' " +
                " FROM producto";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public void updateProducto(int idProducto, string descripcion,
            int idMarca, float precioCompra, float precioVenta, int stockMinimo,
            int stockActual, long cuitProveedor, int idTipoBebida)
        {
            conexion.Open();

            string query = "" +
            "UPDATE producto " +
                "SET descripcion = '" + descripcion + "'," +
                "idMarca = " + idMarca + "," +
                "precioCompra = " + precioCompra + "," +
                "precioVenta = " + precioVenta + "," +
                "stockMinimo = " + stockMinimo + "," +
                "stockActual = " + stockActual + "," +
                "cuitProveedor = " + cuitProveedor + "," +
                "idTipoBebida = " + idTipoBebida  +
                " WHERE idProducto = " + idProducto;




            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }

        public SqlDataReader selectProductosVenta()
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "SELECT producto.idProducto AS 'ID Producto', " +
                    "marca.descripcion AS 'Marca', " +
                    "producto.descripcion AS 'Descripcion', " +
                    "producto.precioVenta AS 'Precio', " +
                    "producto.stockActual AS 'Stock' " +
                    "FROM producto " +
                    "JOIN marca ON producto.idMarca = marca.idMarca " +
                    "WHERE producto.baja = 0 AND producto.stockActual > producto.stockMinimo";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader drComando = comando.ExecuteReader();

                return drComando;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo la consulta: ", ex.Message);
                return null;
            }
        }
    }
}
