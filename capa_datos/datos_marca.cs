using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class DatosMarca
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void insertMarca(string descripcion)
        {
            conexion.Open();

            string query = "INSERT INTO marca (descripcion) " +
                "VALUES ("+descripcion+");";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }
        public SqlDataReader buscarMarca(string desc)
        {
            conexion.Open();

            string query = "SELECT idMarca AS 'IDMarca', " +
                "descripcion AS 'Descripcion' " +
                "FROM marca " +
                "WHERE descripcion = '"+desc+"'";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader resultado = comando.ExecuteReader();

            return resultado;
        }

        public SqlDataReader selectMarcas()
        {
            //
            conexion.Open();

            string query = "" +
                "SELECT idMarca AS Marca," +
                "descripcion AS Descripcion " +
                " FROM marca";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
            //
        }

    }
}
