﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capa_datos
{
    public class DatosCliente
    {
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bodeguitaBD;Integrated Security=true");

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void insertCliente(int dni, string nombre, string apellido, string email, DateTime fechaNac)
        {
            conexion.Open();

            string query = "INSERT INTO clientes(dniCliente, nombre, apellido, email, fechaNac, baja) " +
                "VALUES("+ dni +", '"+ nombre +"', '"+ apellido +"', '"+ email +"', '"+ fechaNac.ToString("yyyy-MM-dd") +"', "+ 0 +")";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }

        public SqlDataReader selectClientes()
        {
            conexion.Open();

            string query = "SELECT * FROM clientes";

            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader tabla = comando.ExecuteReader();

            return tabla;
        }
    }
}