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
                    /*
                    if(DataGrid !vacio){


                    */
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
                    /*
                    }
                    else
                    {
                        MessageBox.Show("",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    }*/
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
    }
}
