using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capa_entidades;
using capa_datos;
using System.Data.SqlClient;
using System.Net;
using System.Data;

namespace capa_negocio
{
    public class NegocioEmpleado
    {
        DatosEmpleado datosEmpleado = new DatosEmpleado();

        public bool verificarDNIExistente(int dni)
        {
            SqlDataReader resultado = datosEmpleado.buscarDNI(dni);

            if (resultado.HasRows)
            {
                datosEmpleado.cerrarConexion();
                return true;
            }
            else
            {
                datosEmpleado.cerrarConexion();
                return false;
            }
        }

        public void crearEmpleado(int dni, string nombre, string apellido, DateTime fechaNac, string direccion, string telefono, string email, string contraseña, int tipoEmpleado)
        {
            datosEmpleado.insertEmpleado(dni, nombre, apellido, fechaNac, direccion, telefono, email, contraseña, tipoEmpleado);
        }

        public DataTable listarTodosEmpleados()
        {
            SqlDataReader dataReaderEmpleados = datosEmpleado.selectTodosEmpleados();

            DataTable tablaEmpleados = new DataTable();
            tablaEmpleados.Load(dataReaderEmpleados);

            datosEmpleado.cerrarConexion();

            return tablaEmpleados;
        }

        public DataTable listarEmpleadosActivos()
        {
            /* Este metodo es igual al anterior, pero devolviendo otro tipo de dato para probar su funcionalidad */

            SqlDataReader dataReaderEmpleados = datosEmpleado.selectEmpleadosActivos();

            DataTable tablaEmpleados = new DataTable();
            tablaEmpleados.Load(dataReaderEmpleados);
            tablaEmpleados.Columns.Remove("Fecha deshabilitacion");
            tablaEmpleados.Columns.Remove("Baja");

            datosEmpleado.cerrarConexion();

            return tablaEmpleados;
        }

        public List<EntidadEmpleado> buscarEmpleadoPorDNI(int dni)
        {
            SqlDataReader empleadoReader = datosEmpleado.selectEmpleadoDNI(dni);

            List<EntidadEmpleado> listaEmpleado = new List<EntidadEmpleado>();

            if (empleadoReader.HasRows)
            {
                while (empleadoReader.Read())
                {
                    EntidadEmpleado empleado = new EntidadEmpleado()
                    {
                        DniEmpleado = empleadoReader.GetInt32(0),
                        Nombre = empleadoReader.GetString(1),
                        Apellido = empleadoReader.GetString(2),
                        FechaNac = empleadoReader.GetDateTime(3),
                        FechaIncorp = empleadoReader.GetDateTime(4),
                        Direccion = empleadoReader.GetString(6),
                        Telefono = empleadoReader.GetString(7),
                        Email = empleadoReader.GetString(8),
                        Contraseña = empleadoReader.GetString(9),
                        IdTipoEmpleado = empleadoReader.GetInt32(10),
                        Baja = empleadoReader.GetBoolean(11)
                    };
                    listaEmpleado.Add(empleado);
                }

                datosEmpleado.cerrarConexion();

                return listaEmpleado;
            }
            else
            {
                datosEmpleado.cerrarConexion();

                return listaEmpleado;
            }
        }

        public void actualizarEmpleado(int dni, string nombre, string apellido, string email, string telefono, string direccion, int tipoEmpleado, string nuevaContraseña)
        {
            datosEmpleado.updateEmpleado(dni, nombre, apellido, email, telefono, direccion, tipoEmpleado, nuevaContraseña);
        }
    }
}
