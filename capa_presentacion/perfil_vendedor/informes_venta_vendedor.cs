using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_negocio;
using System.IO;
using HtmlAgilityPack;
using System.Xml.Linq;

namespace capa_presentacion.perfil_vendedor
{
    public partial class informes_venta_vendedor : Form
    {

        DataTable dtEmpleadoLogueado = new DataTable();

        public informes_venta_vendedor(DataTable dtEmpleado)
        {
            InitializeComponent();

            dtEmpleadoLogueado = dtEmpleado;
        }

        
        NegocioCliente negocioCliente = new NegocioCliente();
        NegocioVenta negocioVenta = new NegocioVenta();


        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void informes_venta_vendedor_Load(object sender, EventArgs e)
        {
            string dniEmpleado = Convert.ToString(dtEmpleadoLogueado.Rows[0].Field<int>("DNI"));
            DataGridViewButtonColumn columnaBotonDetalles = new DataGridViewButtonColumn();
            columnaBotonDetalles.HeaderText = "Detalle Venta";
            columnaBotonDetalles.Name = "colDetalleVenta";
            columnaBotonDetalles.Text = "Detalle Venta";
            columnaBotonDetalles.UseColumnTextForButtonValue = true;
            dgvVentasVendedor.Columns.Add(columnaBotonDetalles);
            DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(dtpDesde.Value, dtpHasta.Value, dniEmpleado, "");
            dgvVentasVendedor.DataSource = tablaVentas;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string dniCliente = txtDniCliente.Text;
            string dniEmpleado = Convert.ToString(dtEmpleadoLogueado.Rows[0].Field<int>("DNI"));
            if (desde < hasta)
            {
                //Busqueda filtro solo por fecha
                if (String.IsNullOrWhiteSpace(dniCliente) == true)
                {
                    DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, "");
                    recargar_dgvVentasVendedor(tablaVentas);
                }
                else if (String.IsNullOrWhiteSpace(dniCliente) == false)
                {//Verifica que dicho empleado exista
                    if (negocioCliente.verificarClienteExistente(Convert.ToInt32(dniCliente)) == true)
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, dniCliente);
                        recargar_dgvVentasVendedor(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Empleado no existe",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("La fecha Desde es mayor a la fecha Hasta",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void recargar_dgvVentasVendedor(DataTable tablaVentas)
        {
            dgvVentasVendedor.DataSource = null;
            dgvVentasVendedor.DataSource = tablaVentas;
        }

    }
}
