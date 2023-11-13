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
    public class NegocioMarca
    {
        DatosMarca datosMarca = new DatosMarca();


        public void crearMarca(string descripcion)
        {
            datosMarca.insertMarca(descripcion);
        }

        public bool verificarMarcaExistente(string descripcion)
        {
            SqlDataReader resultado = datosMarca.buscarMarca(descripcion);

            if (resultado.HasRows)
            {
                datosMarca.cerrarConexion();
                return true;
            }
            else
            {
                datosMarca.cerrarConexion();
                return false;
            }
        }
        public DataTable obtenerMarca(string descripcion)
        {
            SqlDataReader marcaReader = datosMarca.buscarMarca(descripcion);

            DataTable tablaMarca = new DataTable();

            if (marcaReader.HasRows)
            {
                tablaMarca.Load(marcaReader);
                datosMarca.cerrarConexion();

                return tablaMarca;
            }
            else
            {
                datosMarca.cerrarConexion();

                return tablaMarca;
            }
        }
        public DataTable listarMarca()
        {
            SqlDataReader dataReaderMarca = datosMarca.selectMarcas();

            DataTable tablaMarca = new DataTable();
            tablaMarca.Load(dataReaderMarca);


            datosMarca.cerrarConexion();

            return tablaMarca;
        }
    }
}
