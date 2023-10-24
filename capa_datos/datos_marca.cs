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
        public SqlDataReader buscarMarca(string descripcion)
        {
            conexion.Open();

            string query = "SELECT * FROM marca WHERE descripcion = " + descripcion;

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader resultado = comando.ExecuteReader();

            return resultado;
        }
    }
}
