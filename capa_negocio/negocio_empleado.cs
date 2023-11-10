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
            SqlDataReader dataReaderEmpleados = datosEmpleado.selectEmpleadosActivos();

            DataTable tablaEmpleados = new DataTable();
            tablaEmpleados.Load(dataReaderEmpleados);

            datosEmpleado.cerrarConexion();

            return tablaEmpleados;
        }

        public DataTable listarEmpleadosInactivos()
        {
            SqlDataReader drEmpleados = datosEmpleado.selectEmpleadosInactivos();

            DataTable dtEmpleados = new DataTable();
            dtEmpleados.Load(drEmpleados);

            datosEmpleado.cerrarConexion();

            return dtEmpleados;
        }

        public DataTable buscarEmpleadoPorDNI(int dni)
        {
            SqlDataReader empleadoReader = datosEmpleado.selectEmpleadoDNI(dni);

            DataTable tablaEmpleado = new DataTable();

            if (empleadoReader.HasRows)
            {
                tablaEmpleado.Load(empleadoReader);
                datosEmpleado.cerrarConexion();

                return tablaEmpleado;
            }
            else
            {
                datosEmpleado.cerrarConexion();

                return tablaEmpleado;
            }
        }

        public void actualizarEmpleado(int dni, string nombre, string apellido, string email, string telefono, string direccion, int tipoEmpleado, string nuevaContraseña)
        {
            datosEmpleado.updateEmpleado(dni, nombre, apellido, email, telefono, direccion, tipoEmpleado, nuevaContraseña);
        }

        public void bajaEmpleado(int dni)
        {
            datosEmpleado.deleteEmpleado(dni);
        }

        public void altaEmpleado(int dni)
        {
            datosEmpleado.restoreEmpleado(dni);
        }


        //Funcion para Informes Venta

        public bool verificarEmpleadoExistente(int dniEmpleado)
        {
            SqlDataReader empleadoReader = datosEmpleado.selectEmpleadoDNI(dniEmpleado);

            DataTable tablaEmpleado = new DataTable();

            if (empleadoReader.HasRows)
            {
                tablaEmpleado.Load(empleadoReader);
                datosEmpleado.cerrarConexion();

                return true;
            }
            else
            {
                datosEmpleado.cerrarConexion();

                return false;
            }
        }

    }
}
