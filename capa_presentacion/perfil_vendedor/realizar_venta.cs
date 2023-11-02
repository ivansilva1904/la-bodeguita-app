using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.perfil_vendedor
{
    public partial class realizar_venta : Form
    {
        public realizar_venta()
        {
            InitializeComponent();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            //revisar que haya items en en datagrid que el campo dni cliente este completo y exista
            if (!string.IsNullOrWhiteSpace(txtDNICliente.Text))
            {
                int dnicliente = 11;
                int dnitomado = Int32.Parse(txtDNICliente.Text);
                if (dnitomado == dnicliente)
                {
                    if(dgvVentaDetalle.Rows.Count > 0)
                    {
                        if (rbutEfectivo.Checked == true || rbutTarjeta.Checked == true)
                        {
                            DialogResult resp = MessageBox.Show("Desea completar la venta?",
                                    "Aviso", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                            if (resp == DialogResult.Yes)
                            {
                                MessageBox.Show("Se ha realizado la venta",
                                    "Venta exitosa",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe agregar un metodo de pago", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha agregado ningun producto al detalle",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI del cliente no se encuentra",
                    "Cliente no Existe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo DNI Cliente no debe estar vacio",
                    "Campos faltantes o erroneos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbutTarjeta_Click(object sender, EventArgs e)
        {
            txtTarjetaNumero.Enabled = true;
        }

        private void rbutTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            txtTarjetaNumero.Enabled = false;
        }

        private void txtTarjetaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Form productos = new productos(this);
            productos.Show();
        }

        int contBtnQuitar = 0;
        public void cargaProductosDatagrid(DataTable producto)
        {
            dgvVentaDetalle.DataSource = producto;
            dgvVentaDetalle.Columns[0].ReadOnly = true;
            dgvVentaDetalle.Columns[1].ReadOnly = true;
            dgvVentaDetalle.Columns[2].ReadOnly = true;

            if (contBtnQuitar == 0)
            {
                DataGridViewButtonColumn colQuitar = new DataGridViewButtonColumn();
                colQuitar.HeaderText = "";
                colQuitar.Name = "colQuitar";
                colQuitar.Text = "Quitar";
                colQuitar.UseColumnTextForButtonValue = true;

                dgvVentaDetalle.Columns.Add(colQuitar);

                contBtnQuitar++;
            }
        }

        private void realizar_venta_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            lblFecha.Text = "Fecha: " + fecha;
        }

        private void dgvVentaDetalle_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            
        }
    }
}
