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
using capa_entidades;

namespace capa_presentacion.perfil_vendedor
{
    public partial class listar_clientes : Form
    {
        public listar_clientes()
        {
            InitializeComponent();
        }

        NegocioCliente negocioCliente = new NegocioCliente();

        private void listar_clientes_Load(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = negocioCliente.listarClientes();
        }

        private void txtFiltroDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtCliente = negocioCliente.listarClientePorDNI(int.Parse(txtFiltroDni.Text));

            if(dtCliente.Rows.Count > 0)
            {
                dgvListadoClientes.DataSource = null;
                dgvListadoClientes.DataSource = dtCliente;
            }
            else
            {
                MessageBox.Show("El DNI ingresado no corresponde con un cliente registrado");
            }
        }
    }
}
