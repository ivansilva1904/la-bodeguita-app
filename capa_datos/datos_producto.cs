using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void insertProducto(int idProducto,string descripcion,int idMarca,float precioCompra,float precioVenta, 
            int stockMinimo, int StockActual, long cuitProveedor, int idTipoBebida)
        {
            conexion.Open();

            string query = "INSERT INTO producto (idProducto,descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida) " +
                "VALUES (" + idProducto + ",'" + descripcion + "'," + idMarca + "" +
                "," + precioCompra + "," + precioVenta +"," + stockMinimo + "," + StockActual + 
                "," + cuitProveedor + "," + idTipoBebida + ");";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }
    }
}
