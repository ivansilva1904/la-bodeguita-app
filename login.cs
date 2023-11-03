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
using capa_presentacion.perfil_supervisor;
using capa_presentacion.perfil_vendedor;
using capa_negocio;

namespace la_bodeguita
{
    public partial class login : Form
    {
        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
        public login()
        {
            InitializeComponent();
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
                bool existeEmpleado = negocioEmpleado.verificarEmpleado(int.Parse(txtUsuario.Text));
                this.Hide();
                //Checkear login con base de datos y entrar al menu de usuario correspondiente
                lblTest.Text = "log correcto";
                if(txtUsuario.Text == "1")
                {
                    Form menu_administrador = new menu_administrador();
                    menu_administrador.Show();
                }
                if(txtUsuario.Text == "2")
                {
                    Form menu_supervisor = new menu_supervisor();
                    menu_supervisor.Show();
                }
                if(txtUsuario.Text == "3")
                {
                    Form menu_vendedor = new menu_vendedor();
                    menu_vendedor.Show();
                }
            }
        }
    }
}
