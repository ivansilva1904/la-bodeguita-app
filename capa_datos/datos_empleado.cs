using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

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

        public void insertEmpleado(int dni, string nombre, string apellido, DateTime fechaNac, string direccion, string telefono, string email, string contraseña, int tipoEmpleado)
        {
            try
            {
                conexion.Open();

                string query = "INSERT INTO empleados (dniEmpleado, nombre, apellido, fechaNac, fechaIncorp, direccion, telefono, email, contraseña, idTipoEmpleado) " +
                    "VALUES (" + dni + ",'" + nombre + "' , '"+ apellido + "', '"+ fechaNac.ToString("yyyy-MM-dd") +"', '"+ DateTime.Now.ToString("yyyy-MM-dd") +"', '"+ direccion +"', '"+ telefono +"', '"+ email +"', '"+ BCrypt.Net.BCrypt.HashPassword(contraseña) +"', "+ tipoEmpleado +");";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();

                cerrarConexion();

                MessageBox.Show("Se ha registrado el empleado", "Aviso de Alta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public SqlDataReader selectTodosEmpleados()
        {
            conexion.Open();

            string query = "" +
                "SELECT dniEmpleado AS DNI, " +
                "nombre AS Nombre, " +
                "apellido AS Apellido, " +
                "fechaNac AS 'Fecha nacimiento', " +
                "fechaIncorp AS 'Fecha incorporacion', " +
                "fechaDeshab AS 'Fecha deshabilitacion', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "idTipoEmpleado AS 'Tipo empleado', " +
                "baja AS Baja" +
                " FROM empleados";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public SqlDataReader selectEmpleadosActivos()
        {
            conexion.Open();

            string query = "" +
                "SELECT dniEmpleado AS DNI, " +
                "nombre AS Nombre, " +
                "apellido AS Apellido, " +
                "fechaNac AS 'Fecha nacimiento', " +
                "fechaIncorp AS 'Fecha incorporacion', " +
                "fechaDeshab AS 'Fecha deshabilitacion', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "idTipoEmpleado AS 'Tipo empleado', " +
                "baja AS Baja" +
                " FROM empleados" +
                " WHERE Baja = 0";

            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public SqlDataReader selectEmpleadosInactivos()
        {
            conexion.Open();

            string query = "" +
                "SELECT dniEmpleado AS DNI, " +
                "nombre AS Nombre, " +
                "apellido AS Apellido, " +
                "fechaNac AS 'Fecha nacimiento', " +
                "fechaIncorp AS 'Fecha incorporacion', " +
                "fechaDeshab AS 'Fecha deshabilitacion', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "idTipoEmpleado AS 'Tipo empleado', " +
                "baja AS Baja" +
                " FROM empleados" +
                " WHERE Baja = 1";

            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public SqlDataReader selectEmpleadoDNI(int dni)
        {
            conexion.Open();

            string query = "" +
                "SELECT dniEmpleado AS DNI, " +
                "nombre AS Nombre, " +
                "apellido AS Apellido, " +
                "fechaNac AS 'Fecha nacimiento', " +
                "fechaIncorp AS 'Fecha incorporacion', " +
                "fechaDeshab AS 'Fecha deshabilitacion', " +
                "direccion AS Direccion, " +
                "telefono AS Telefono, " +
                "email AS Email, " +
                "idTipoEmpleado AS 'Tipo empleado', " +
                "baja AS Baja, " +
                "contraseña AS 'Contraseña' " +
                "FROM empleados " +
                "WHERE dniEmpleado = " + dni;

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader empleado = comando.ExecuteReader();

            return empleado;
        }

        public void updateEmpleado(int dni, string nombre, string apellido, string email, string telefono, string direccion, int tipoEmpleado, string nuevaContraseña)
        {
            try
            {
                conexion.Open();

                string query = "";

                if(nuevaContraseña != "")
                {
                    query = "" +
                        "UPDATE empleados " +
                        "SET nombre = '"+ nombre + "', " +
                        "apellido = '"+ apellido + "', " +
                        "direccion = '"+ direccion + "', " +
                        "telefono = '"+ telefono + "', " +
                        "email = '"+ email + "', " +
                        "idTipoEmpleado = "+ tipoEmpleado + ", " +
                        "contraseña = '"+ nuevaContraseña + "' " +
                        "WHERE dniEmpleado = "+ dni;
                }
                else
                {
                    query = "" +
                        "UPDATE empleados " +
                        "SET nombre = '" + nombre + "', " +
                        "apellido = '" + apellido + "', " +
                        "direccion = '" + direccion + "', " +
                        "telefono = '" + telefono + "', " +
                        "email = '" + email + "', " +
                        "idTipoEmpleado = " + tipoEmpleado + " " +
                        "WHERE dniEmpleado = " + dni;
                }

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();

                cerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void deleteEmpleado(int dni)
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "UPDATE empleados " +
                    "SET baja = 1 " +
                    "WHERE dniEmpleado = "+ dni;

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();

                cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void restoreEmpleado(int dni)
        {
            try
            {
                conexion.Open();

                string query = "" +
                    "UPDATE empleados " +
                    "SET baja = 0 " +
                    "WHERE dniEmpleado = " + dni;

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();

                cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
