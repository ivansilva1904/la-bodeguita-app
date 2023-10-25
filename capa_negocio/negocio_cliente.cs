using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capa_entidades;
using capa_datos;
using System.Data.SqlClient;
using System.Data;

namespace capa_negocio
{
    public class NegocioCliente
    {
        DatosCliente datosCliente = new DatosCliente();

        public void crearCliente(int dniCliente, string nombre, string apellido, string email, DateTime fechaNac)
        {
            datosCliente.insertCliente(dniCliente, nombre, apellido, email, fechaNac);
        }

        public DataTable listarClientes()
        {
            SqlDataReader drCliente = datosCliente.selectClientes();

            DataTable dtCliente = new DataTable();

            dtCliente.Load(drCliente);

            datosCliente.cerrarConexion();

            return dtCliente;
        }

        public DataTable listarClientePorDNI(int dni)
        {
            SqlDataReader drCliente = datosCliente.selectClientePorDNI(dni);

            DataTable dtCliente = new DataTable();

            if (drCliente.HasRows)
            {
                dtCliente.Load(drCliente);
                datosCliente.cerrarConexion();

                return dtCliente;
            }
            else
            {
                datosCliente.cerrarConexion();

                return dtCliente;
            }
        }
        public void actualizarCliente(int dni, string nombre, string apellido, string email)
        {
            datosCliente.updateCliente(dni, nombre, apellido, email);
        }
    }
}
