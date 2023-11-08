using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_datos
{
    public class DatosBackup
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void backupDB(string directorio)
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "BACKUP DATABASE bodeguitaBD TO DISK='" + directorio + "'";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();

                cerrarConexion();

                MessageBox.Show("Se ha generado el respaldo de la base de datos",
                    "Confirmacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al generar el respaldo: " + ex.Message);
            }
        }
    }
}
