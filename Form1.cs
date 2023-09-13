using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_presentacion.perfil_administrador;

namespace la_bodeguita
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void BUT_ALTA_USUARIO_Click(object sender, EventArgs e)
        {
            Form vista_altaUsuario = new alta_usuario();
            vista_altaUsuario.Show();
        }

        private void BUT_BAJA_USUARIO_Click(object sender, EventArgs e)
        {
            Form vista_bajaUsuario = new baja_usuario();
            vista_bajaUsuario.Show();
        }

        private void BUT_MODIFICAR_USUARIO_Click(object sender, EventArgs e)
        {
            Form vista_modificarUsuario = new modificar_usuario();
            vista_modificarUsuario.Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//(Si se quiere agregar puntos) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text) )
            {
                MessageBox.Show("Existen Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblTest.Text = "log nul";
            }
            else
            {
                //Checkear login con base de datos y entrar al menu de usuario correspondiente
                lblTest.Text = "log correcto";

            }
        }
    }
}
