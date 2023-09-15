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
        private void panAltaUsuario_MouseEnter_1(object sender, EventArgs e)
        {
            //panAltaUsuario.BackColor = Color.Bisque;
        }

        private void panAltaUsuario_MouseLeave_1(object sender, EventArgs e)
        {
            //panAltaUsuario.BackColor = Color.Tan;
        }

        private void btnAltaEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnAltaEmpleado.BackColor = Color.Bisque;
        }

        private void btnAltaEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnAltaEmpleado.BackColor = Color.Tan;
        }

        private void btnBajaEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnBajaEmpleado.BackColor = Color.Bisque;
        }

        private void btnBajaEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnBajaEmpleado.BackColor = Color.Tan;
        }

        private void btnModEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnModEmpleado.BackColor = Color.Bisque;
        }

        private void btnModEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnModEmpleado.BackColor = Color.Tan;
        }

        private void btnGenerarRespaldo_MouseEnter(object sender, EventArgs e)
        {
            btnGenerarRespaldo.BackColor = Color.Bisque;
        }

        private void btnGenerarRespaldo_MouseLeave(object sender, EventArgs e)
        {
            btnGenerarRespaldo.BackColor = Color.Tan;
        }
    }
}
