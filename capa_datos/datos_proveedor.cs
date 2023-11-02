using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class DatosProveedor
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void insertProveedor(long cuitProveedor, string razonSocial, string direccion, string telefono, string email)
        {
            conexion.Open();

            string query = "INSERT INTO proveedor (cuitProveedor, razonSocial, direccion, telefono, email, fechaAlta) " +
                "VALUES (" + cuitProveedor + ",'" + razonSocial + "','" + direccion + "','" + telefono + "','" + email + "','"+ DateTime.Now.ToString("yyyy-MM-dd") + "');";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }

        public SqlDataReader buscarCuit(long cuit)
        {
            conexion.Open();

            string query = "SELECT * FROM proveedor WHERE cuitProveedor =  '" + cuit + "'";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader resultado = comando.ExecuteReader();

            return resultado;
        }

        public SqlDataReader selectTodosProveedor()
        {
            //
            conexion.Open();

            string query = "" +
                "SELECT cuitProveedor AS CUIT, " +
                "razonSocial AS 'Razon Social', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "fechaAlta AS 'Fecha Alta', " +
                "fechaBaja AS 'Fecha Baja', " +
                "baja AS Baja " +
                " FROM proveedor";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
            //
        }

        public SqlDataReader selectProveedorActivos()
        {
            conexion.Open();

            string query = "" +
                "SELECT cuitProveedor AS CUIT, " +
                "razonSocial AS 'Razon Social', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "fechaAlta AS 'Fecha Alta', " +
                "fechaBaja AS 'Fecha Baja', " +
                "baja AS Baja " +
                " FROM proveedor" +
                " WHERE Baja = 0";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public SqlDataReader selectProveedorCuit(long cuit)
        {
            conexion.Open();

            string query = "" +
                "SELECT cuitProveedor AS CUIT," +
                "razonSocial AS Razon Social," +
                "direccion AS Direccion," +
                "telefono AS Telefono," +
                "email AS Email, " +
                "fechaAlta AS 'Fecha Alta'," +
                "fechaBaja AS 'Fecha Baja'," +
                "baja AS Baja," +
                " FROM proveedor " + 
                " WHERE cuitProveedor = " + cuit;

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader empleado = comando.ExecuteReader();

            return empleado;
        }

        public void updateProveedor(long cuit, string razonSocial, string direccion, string telefono, string email,bool baja)
        {
            conexion.Open();

            string query = "";

            if(baja == false){
                string fechBaj = "";
                    query = "" +
                    "UPDATE proveedor " +
                    "SET razonSocial = '" + razonSocial + "' ," +
                    "direccion = '" + direccion + "' ," +
                    "telefono = '" + telefono + "' ," +
                    "email = '" + email + "' ," +
                    "fechaBaja = '"+ fechBaj + "'," +
                    "baja = '" + baja + "' " +
                    "WHERE cuitProveedor = " + 
                    cuit;
            }
            if (baja == true)
            {
                string fechBaj = DateTime.Now.ToString("yyyy-MM-dd");
                query = "" +
                    "UPDATE proveedor " +
                    "SET razonSocial = '" + razonSocial + "' ," +
                    "direccion = '" + direccion + "' ," +
                    "telefono = '" + telefono + "' ," +
                    "email = '" + email + "' ," +
                    "fechaBaja = '"+ fechBaj +"' ," +
                    "baja = '" + baja + "' " +
                    "WHERE cuitProveedor = " +
                    cuit;
            }


            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }

        public SqlDataReader selectProveedorPorRazonSocial(string razonSocial)
        {
            conexion.Open();

            string query = "" +
                "SELECT cuitProveedor AS 'Cuit Proveedor', " +
                "razonSocial AS 'Razon Social' " +
                "FROM proveedor " +
                "WHERE razonSocial = '"+razonSocial+"'";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public SqlDataReader filtroProveedorRazonSocial(string razon)
        {
            conexion.Open();

            string query = "" +
                "SELECT cuitProveedor AS CUIT, " +
                "razonSocial AS 'Razon Social', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "fechaAlta AS 'Fecha Alta', " +
                "fechaBaja AS 'Fecha Baja', " +
                "baja AS Baja " +
                " FROM proveedor" +
                " WHERE razonSocial like '%"+razon+"%'";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }
    }
}
