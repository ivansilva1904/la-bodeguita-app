using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capa_entidades;
using capa_datos;
using System.Data.SqlClient;
using System.Net;

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

        public List<EntidadEmpleado> listarEmpleados()
        {
            SqlDataReader tabla = datosEmpleado.selectEmpleados();

            List<EntidadEmpleado> lista = new List<EntidadEmpleado>();

            using(tabla)
            {
                while (tabla.Read())
                {
                    EntidadEmpleado empleado = new EntidadEmpleado()
                    {
                        DniEmpleado = tabla.GetInt32(0),
                        Nombre = tabla.GetString(1),
                        Apellido = tabla.GetString(2),
                        FechaNac = tabla.GetDateTime(3),
                        FechaIncorp = tabla.GetDateTime(4),
                        Direccion = tabla.GetString(6),
                        Telefono = tabla.GetString(7),
                        Email = tabla.GetString(8),
                        Contraseña = tabla.GetString(9),
                        IdTipoEmpleado = tabla.GetInt32(10),
                        Baja = tabla.GetBoolean(11)
                    };
                    lista.Add(empleado);
                }
            }

            datosEmpleado.cerrarConexion();

            return lista;
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
                EntidadEmpleado empleado = new EntidadEmpleado()
                {
                    DniEmpleado = 0
                };
                listaEmpleado.Add(empleado);
                datosEmpleado.cerrarConexion();

                return listaEmpleado;
            }
        }
    }
}
