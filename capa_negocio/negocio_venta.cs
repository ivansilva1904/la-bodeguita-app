using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capa_datos;

namespace capa_negocio
{
    public class NegocioVenta
    {
        DatosVenta datosVenta = new DatosVenta();

        public void crearCabeceraEfectivo(DateTime fecha, int formaPago, float importeTotal, int dniEmpleado, int dniCliente)
        {
            int idCabecera = datosVenta.insertCabeceraEfectivo(fecha, formaPago, importeTotal, dniEmpleado, dniCliente);
        }
    }
}
