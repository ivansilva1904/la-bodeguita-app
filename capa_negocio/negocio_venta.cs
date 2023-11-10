using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using capa_datos;
using System.Globalization;

namespace capa_negocio
{
    public class NegocioVenta
    {
        DatosVenta datosVenta = new DatosVenta();

        public int crearCabecera(DateTime fecha, int formaPago, long tarjeta, float importeTotal, int dniEmpleado, int dniCliente)
        {
            int idCabecera = datosVenta.insertCabecera(fecha, formaPago, tarjeta, importeTotal, dniEmpleado, dniCliente);

            return idCabecera;
        }

        public void crearDetalles(int idCabecera, DataGridView dgvDetalle)
        {
            foreach(DataGridViewRow fila in dgvDetalle.Rows)
            {
                datosVenta.insertDetalle(idCabecera, int.Parse(fila.Cells["ID Producto"].Value.ToString()), int.Parse(fila.Cells["Cantidad"].Value.ToString()), float.Parse(fila.Cells["Precio"].Value.ToString()));
            }
        }

        //Funciones para informes generales
        //
        public DataTable ventas_por_cantidad_tipoBebida(DateTime desde, DateTime hasta)
        {
            SqlDataReader dataReaderVentas = datosVenta.selectVentasCantidadBebidas(desde,hasta);

            DataTable tablaCantidadBebidas = new DataTable();
            tablaCantidadBebidas.Load(dataReaderVentas);



            datosVenta.cerrarConexion();

            return tablaCantidadBebidas;
        }


        //funciones para Informes Ventas

        public DataTable ventasInformesMultiuso(DateTime desde, DateTime hasta, string dniEmplead, string dniCliente)
        {
            /*
            SqlDataReader ventaReader = datosVenta.selectVentasMultiuso(desde, hasta, dniEmplead, dniCliente);

            DataTable tablaVentas = new DataTable();

            if (ventaReader.HasRows)
            {
                tablaVentas.Load(ventaReader);
                datosVenta.cerrarConexion();

                return tablaVentas;
            }
            else
            {
                datosVenta.cerrarConexion();

                return tablaVentas;
            }
            */
            SqlDataReader dataReaderVentas = datosVenta.selectVentasMultiuso(desde, hasta, dniEmplead, dniCliente);

            DataTable tablaCantidadBebidas = new DataTable();
            tablaCantidadBebidas.Load(dataReaderVentas);



            datosVenta.cerrarConexion();

            return tablaCantidadBebidas;

        }
    }

}
