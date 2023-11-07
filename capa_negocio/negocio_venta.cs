﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using capa_datos;

namespace capa_negocio
{
    public class NegocioVenta
    {
        DatosVenta datosVenta = new DatosVenta();

        public int crearCabeceraEfectivo(DateTime fecha, int formaPago, float importeTotal, int dniEmpleado, int dniCliente)
        {
            int idCabecera = datosVenta.insertCabeceraEfectivo(fecha, formaPago, importeTotal, dniEmpleado, dniCliente);

            return idCabecera;
        }

        public void crearDetalles(int idCabecera, DataGridView dgvDetalle)
        {
            foreach(DataGridViewRow fila in dgvDetalle.Rows)
            {
                datosVenta.insertDetalle(idCabecera, int.Parse(fila.Cells["ID Producto"].ToString()), int.Parse(fila.Cells["Cantidad"].ToString()), float.Parse(fila.Cells["Precio"].ToString()));
            }
        }
    }
}
