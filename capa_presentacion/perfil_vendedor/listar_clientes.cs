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
    }
}
