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

namespace capa_presentacion.perfil_supervisor
{
    public partial class informes_ventas : Form
    {
        public informes_ventas()
        {
            InitializeComponent();
        }

        NegocioVenta negocioVenta = new NegocioVenta();
        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
        NegocioCliente negocioCliente = new NegocioCliente();


        private void txtDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string dniEmpleado = txtDniEmpleado.Text;
            string dniCliente = txtDniCliente.Text;

            if (desde < hasta)
            {
                //Busqueda solo por fecha
                if (String.IsNullOrWhiteSpace(dniCliente) && String.IsNullOrWhiteSpace(dniEmpleado))
                {
                    DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, "", "");
                    recargar_dgvVentas(tablaVentas);
                }
                else if (String.IsNullOrWhiteSpace(dniEmpleado) == false &&
                    String.IsNullOrWhiteSpace(dniCliente) == true)
                {
                    if (negocioEmpleado.verificarEmpleadoExistente(Convert.ToInt32(dniEmpleado)) == true)
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, "");
                        recargar_dgvVentas(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Empleado no existe",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }                   
                }
                else if (String.IsNullOrWhiteSpace(dniEmpleado) == true &&
                    String.IsNullOrWhiteSpace(dniCliente) == false)
                {
                    if (negocioCliente.verificarClienteExistente(Convert.ToInt32(dniCliente)) == true)
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, "", dniCliente);
                        recargar_dgvVentas(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Cliente no existe",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else if (String.IsNullOrWhiteSpace(dniEmpleado) == false &&
                    String.IsNullOrWhiteSpace(dniCliente) == false)
                {
                    if (negocioCliente.verificarClienteExistente(Convert.ToInt32(dniCliente)) == true &&
                         negocioEmpleado.verificarEmpleadoExistente(Convert.ToInt32(dniEmpleado)))
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, dniCliente);
                        recargar_dgvVentas(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Cliente o el Empleado no Existen",
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

        private void informes_ventas_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn columnaBotonDetalles = new DataGridViewButtonColumn();
            columnaBotonDetalles.HeaderText = "Detalle Venta";
            columnaBotonDetalles.Name = "colDetalleVenta";
            columnaBotonDetalles.Text = "Detalle";
            columnaBotonDetalles.UseColumnTextForButtonValue = true;
            dgvVentas.Columns.Add(columnaBotonDetalles);
            DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(dtpDesde.Value, dtpHasta.Value, "", "");
            dgvVentas.DataSource = tablaVentas;
        }

        private void recargar_dgvVentas(DataTable tablaVentas)
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = tablaVentas;
        }
    }
}
