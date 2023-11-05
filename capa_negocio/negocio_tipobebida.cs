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
    public class NegocioTipoBebida
    { 
        DatosTipoBebida datosTipoBebida = new DatosTipoBebida();

        public DataTable listarTipoBebida()
        {
            SqlDataReader dataReaderTipoBebida = datosTipoBebida.selectTiposBebida();

            DataTable tablaTipoBebida = new DataTable();
            tablaTipoBebida.Load(dataReaderTipoBebida);


            datosTipoBebida.cerrarConexion();

            return tablaTipoBebida;
        }
        public DataTable buscarTipoBebida(string descripcion)
        {
            SqlDataReader tipoBebidaReader = datosTipoBebida.selectTipoBebidaPorDescripcion(descripcion);

            DataTable tablaBebida = new DataTable();

            if (tipoBebidaReader.HasRows)
            {
                tablaBebida.Load(tipoBebidaReader);
                datosTipoBebida.cerrarConexion();

                return tablaBebida;
            }
            else
            {
                datosTipoBebida.cerrarConexion();

                return tablaBebida;
            }
        }
    }
}
