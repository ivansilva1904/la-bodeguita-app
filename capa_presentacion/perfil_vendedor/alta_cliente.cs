using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_datos;

namespace capa_presentacion.perfil_vendedor
{
    public partial class alta_cliente : Form
    {
        public alta_cliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            DateTime fechaNac = dtpFechaNac.Value;

            if (!string.IsNullOrWhiteSpace(dni) &&
                !string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(apellido) &&
                !string.IsNullOrWhiteSpace(email))
            {
                Cliente cliente = new Cliente();
                cliente.crearCliente(int.Parse(dni), nombre, apellido, email, fechaNac);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios",
                    "Campos faltantes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
