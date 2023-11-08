using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
    }
}
