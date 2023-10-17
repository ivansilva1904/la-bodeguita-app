﻿using System;
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

        public void insertEmpleado(int dni, string nombre, string apellido, DateTime fechaNac, string direccion, string telefono, string email, string contraseña, int tipoEmpleado)
        {
            conexion.Open();

            string query = "INSERT INTO empleados (dniEmpleado, nombre, apellido, fechaNac, fechaIncorp, direccion, telefono, email, contraseña, idTipoEmpleado) " +
                "VALUES (" + dni + ",'" + nombre + "' , '"+ apellido + "', '"+ fechaNac.ToString("yyyy-MM-dd") +"', '"+ DateTime.Now.ToString("yyyy-MM-dd") +"', '"+ direccion +"', '"+ telefono +"', '"+ email +"', '"+ contraseña +"', "+ tipoEmpleado +");";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }

        public SqlDataReader selectEmpleados()
        {
            conexion.Open();

            string query = "SELECT * FROM empleados";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }

        public SqlDataReader selectEmpleadoDNI(int dni)
        {
            conexion.Open();

            string query = "SELECT * FROM empleados WHERE dniEmpleado = "+ dni;

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader empleado = comando.ExecuteReader();

            return empleado;
        }
    }
}