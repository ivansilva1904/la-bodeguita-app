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
        //Estas deben ser globales para el manejo del menu
        char formularioActivo = ' ';
        alta_usuario alta_user = new alta_usuario();
        baja_usuario baja_user = new baja_usuario();
        modificar_usuario mod_user = new modificar_usuario();

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

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            switch (formularioActivo)
            {
                case 'A':{
                    panFormsAdministrador.Controls.Remove(alta_user);
                    break;
                }
                case 'B':{
                    panFormsAdministrador.Controls.Remove(baja_user);
                    break;
                }
                case 'M':{
                    panFormsAdministrador.Controls.Remove(mod_user);
                    break;
                }
            }
            alta_user.TopLevel = false;
            panFormsAdministrador.Controls.Add(alta_user);
            alta_user.Show();
            formularioActivo = 'A';
        }

        private void btnBajaEmpleado_Click(object sender, EventArgs e)
        {
            switch (formularioActivo){
                case 'A':{
                    panFormsAdministrador.Controls.Remove(alta_user);
                    break;
                }
                case 'B':{
                    panFormsAdministrador.Controls.Remove(baja_user);
                    break;
                }
                case 'M':{
                    panFormsAdministrador.Controls.Remove(mod_user);
                    break;
                }
            }
            baja_user.TopLevel = false;
            panFormsAdministrador.Controls.Add(baja_user);
            baja_user.Show();
            formularioActivo = 'B';
        }

        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            switch (formularioActivo)
            {
                case 'A':{
                    panFormsAdministrador.Controls.Remove(alta_user);
                    break;
                }
                case 'B':{
                    panFormsAdministrador.Controls.Remove(baja_user);
                    break;
                }
                case 'M':{
                    panFormsAdministrador.Controls.Remove(mod_user);
                    break;
                }
            }
            mod_user.TopLevel = false;
            panFormsAdministrador.Controls.Add(mod_user);
            mod_user.Show();
            formularioActivo = 'M';
        }
    }
}
