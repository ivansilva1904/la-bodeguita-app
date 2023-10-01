using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capa_entidades;
using capa_datos;
using System.Data.SqlClient;

namespace capa_negocio
{
    public class NegocioCliente
    {
        DatosCliente datosCliente = new DatosCliente();

        public void crearCliente(int dniCliente, string nombre, string apellido, string email, DateTime fechaNac)
        {
            datosCliente.insertCliente(dniCliente, nombre, apellido, email, fechaNac);
        }

        public List<EntidadCliente> listarClientes()
        {
            SqlDataReader tabla = datosCliente.selectClientes();

            List<EntidadCliente> lista = new List<EntidadCliente>();

            using (tabla)
            {
                while (tabla.Read())
                {
                    EntidadCliente cliente = new EntidadCliente()
                    {
                        DniCliente = tabla.GetInt32(0),
                        Nombre = tabla.GetString(1),
                        Apellido = tabla.GetString(2),
                        Email = tabla.GetString(3),
                        FechaNac = tabla.GetDateTime(4),
                        Baja = tabla.GetBoolean(5)
                    };
                    lista.Add(cliente);
                }
            }

            datosCliente.cerrarConexion();

            return lista;
        }
    }
}
