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
            Form vista_altaUsuario = new alta_usuario();
            vista_altaUsuario.Show();
        }

        private void BUT_BAJA_USUARIO_Click(object sender, EventArgs e)
        {
            Form vista_bajaUsuario = new baja_usuario();
            vista_bajaUsuario.Show();
        }
    }
}
