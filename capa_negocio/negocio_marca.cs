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


        public void crearProveedor(string descripcion)
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
    }
}
