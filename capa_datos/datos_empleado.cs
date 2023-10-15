using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace capa_datos
{
    public class DatosEmpleado
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public SqlDataReader buscarDNI(int dni)
        {
            conexion.Open();

            string query = "SELECT * FROM empleados WHERE dniEmpleado = " + dni;

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader resultado = comando.ExecuteReader();

            return resultado;
        }
    }
}
