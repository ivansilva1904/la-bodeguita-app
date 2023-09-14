using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.perfil_administrador
{
    public partial class menu_administrador : Form
    {
        public menu_administrador()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form alta_usuario = new alta_usuario();
            alta_usuario.Show();
        }

        private void panAltaUsuario_MouseHover(object sender, EventArgs e)
        {
            OnMouseEnter(panAltaUsuario.BackColor = Color.Bisque);
        }

        /*private void panAltaUsuario_MouseEnter(object sender, EventArgs e)
        {
            panAltaUsuario.BackColor = Color.Bisque;
        }

        private void panAltaUsuario_MouseLeave(object sender, EventArgs e)
        {
            panAltaUsuario.BackColor = Color.Tan;
        }*/
    }
}
