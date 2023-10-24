using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class DatosTipoBebida
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public SqlDataReader selectTiposBebida()
        {
            //
            conexion.Open();

            string query = "" +
                "SELECT descripcion AS Descripcion " +              
                " FROM tipoBebida";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
            //
        }
    }
}
