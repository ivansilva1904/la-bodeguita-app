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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUT_ALTA_USUARIO_Click(object sender, EventArgs e)
        {
            Form vista_menu = new menu_administrador();
            vista_menu.Show();
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
    }
}
