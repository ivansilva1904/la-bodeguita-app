using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class NegocioProveedor
    {
        DatosProveedor datosProveedor = new DatosProveedor();
       
        public bool verificarCuitExistente(long cuit)
        {
            SqlDataReader resultado = datosProveedor.buscarCuit(cuit);

            if (resultado.HasRows)
            {
                datosProveedor.cerrarConexion();
                return true;
            }
            else
            {
                datosProveedor.cerrarConexion();
                return false;
            }
        }

        public void crearProveedor(long cuitProveedor, string razonSocial, string direccion, string telefono, string email)
        {
            datosProveedor.insertProveedor(cuitProveedor, razonSocial, direccion, telefono, email);
        }

        public DataTable listarTodosProveedor()
        {
            SqlDataReader dataReaderProveedor = datosProveedor.selectTodosProveedor();

            DataTable tablaProveedor = new DataTable();
            tablaProveedor.Load(dataReaderProveedor);
           

            datosProveedor.cerrarConexion();

            return tablaProveedor;
        }
         //Ver si va
        public DataTable listarProveedorActivos()
        {
            SqlDataReader dataReaderProveedor = datosProveedor.selectProveedorActivos();

            DataTable tablaProveedor = new DataTable();
            tablaProveedor.Load(dataReaderProveedor);
            tablaProveedor.Columns.Remove("Fecha baja");
            tablaProveedor.Columns.Remove("Baja");

            datosProveedor.cerrarConexion();

            return tablaProveedor;
        }
        //
        public DataTable buscarProveedorPorCuit(long cuit)
        {
            SqlDataReader proveedorReader = datosProveedor.selectProveedorCuit(cuit);

            DataTable tablaProveedor = new DataTable();

            if (proveedorReader.HasRows)
            {
                tablaProveedor.Load(proveedorReader);
                datosProveedor.cerrarConexion();

                return tablaProveedor;
            }
            else
            {
                datosProveedor.cerrarConexion();

                return tablaProveedor;
            }
        }

        public void actualizarProveedor(long cuitProveedor, string razonSocial, string direccion, string telefono, string email,bool baja)
        {
          
            
               datosProveedor.updateProveedor(cuitProveedor, razonSocial, direccion, telefono, email,baja);
            
           
        }

        
        public DataTable buscarProveedorPorRazonSocial(string razonSocial) //Usado para obtener el registro a modificar
        {
            SqlDataReader proveedorReader = datosProveedor.selectProveedorPorRazonSocial(razonSocial);

            DataTable tablaProveedor = new DataTable();

            if (proveedorReader.HasRows)
            {
                tablaProveedor.Load(proveedorReader);
                datosProveedor.cerrarConexion();

                return tablaProveedor;
            }
            else
            {
                datosProveedor.cerrarConexion();

                return tablaProveedor;
            }
        }

        public DataTable filtrarProveedorPorRazonSocial(string razon)
        {
            SqlDataReader proveedorReader = datosProveedor.filtroProveedorRazonSocial(razon);

            DataTable tablaProveedor = new DataTable();

            if (proveedorReader.HasRows)
            {
                tablaProveedor.Load(proveedorReader);
                datosProveedor.cerrarConexion();

                return tablaProveedor;
            }
            else
            {
                datosProveedor.cerrarConexion();

                return tablaProveedor;
            }
        }

    }
}
