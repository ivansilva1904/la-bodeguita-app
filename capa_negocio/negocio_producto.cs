using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class NegocioProducto
    {

        DatosProducto datosProducto = new DatosProducto();
        /*
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
        }*/
        public void crearProducto(string descripcion, int idMarca, float precioCompra, float precioVenta,
            int stockMinimo, int StockActual, long cuitProveedor, int idTipoBebida)
        {
            datosProducto.insertProducto(descripcion, idMarca, precioCompra, precioVenta,
             stockMinimo, StockActual, cuitProveedor, idTipoBebida);
        }


        public DataTable listarTodosProductos()
        {
            SqlDataReader dataReaderProducto = datosProducto.selectTodosProductos();

            DataTable tablaProducto = new DataTable();
            tablaProducto.Load(dataReaderProducto);
           


            datosProducto.cerrarConexion();

            return tablaProducto;
        }

        public void modificacionProducto(int idProducto, string descripcion,
           int idMarca, float precioCompra, float precioVenta, int stockMinimo,
           int stockActual, long cuitProveedor, int idTipoBebida)
        {

            datosProducto.updateProducto(idProducto, descripcion, idMarca, precioCompra, precioVenta, stockMinimo, stockActual, cuitProveedor, idTipoBebida);



        }

        public DataTable listarProductosVenta()
        {
            SqlDataReader drProductos = datosProducto.selectProductosVenta();

            DataTable dtProductos = new DataTable();
            datosProducto.cerrarConexion();
            if (drProductos.HasRows)
            {
                dtProductos.Load(drProductos);
                return dtProductos;
                
            }
            else
            {
                return dtProductos;
            }
            
        }

        public DataTable listarProductosDeBaja()
        {
            SqlDataReader dataReaderProducto = datosProducto.selectProductosDebaja();

            DataTable tablaProducto = new DataTable();
            tablaProducto.Load(dataReaderProducto);

            datosProducto.cerrarConexion();

            return tablaProducto;
        }
        public DataTable listarProductosPorDescripcion(string desc)
        {
            SqlDataReader dataReaderProducto = datosProducto.selectProductosPorDescripcion(desc);

            DataTable tablaProducto = new DataTable();
            tablaProducto.Load(dataReaderProducto);

            datosProducto.cerrarConexion();

            return tablaProducto;
        }
        public DataTable listarProductosPorTipo(string desc)
        {
            SqlDataReader dataReaderProducto = datosProducto.selectProductosPorTipo(desc);

            DataTable tablaProducto = new DataTable();
            tablaProducto.Load(dataReaderProducto);

            datosProducto.cerrarConexion();

            return tablaProducto;
        }
    }
}

