using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class NegocioProducto
    {

        DatosProducto datosProducto = new DatosProducto();

        public bool verificarIdProductoExistente(int idProducto)
        {
            SqlDataReader resultado = datosProducto.buscarProducto(idProducto);

            if (resultado.HasRows)
            {
                datosProducto.cerrarConexion();
                return true;
            }
            else
            {
                datosProducto.cerrarConexion();
                return false;
            }
        }
        public void crearProducto(int idProducto, string descripcion, int idMarca, float precioCompra, float precioVenta,
            int stockMinimo, int StockActual, long cuitProveedor, int idTipoBebida)
        {
            datosProducto.insertProducto(idProducto, descripcion, idMarca,precioCompra, precioVenta,
             stockMinimo, StockActual,cuitProveedor,idTipoBebida);
        }
    }
}
