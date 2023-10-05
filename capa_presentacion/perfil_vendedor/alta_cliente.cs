using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_negocio;

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
                if (validarCorreo(email) == true)
                {
                    DialogResult resp = MessageBox.Show("Desea Agregar el nuevo Cliente?",
                    "Confirmar Nuevo Cliente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        //falta validacion de cliente unico
                        NegocioCliente negocioCliente = new NegocioCliente();
                        negocioCliente.crearCliente(int.Parse(dni), nombre, apellido, email, fechaNac);
                        
                        MessageBox.Show("El nuevo cliente ha sido añadido",
                            "Nuevo Cliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El formato de email no es valido",
                    "Campos Invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                
                
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios",
                    "Campos faltantes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Comprobacion email
        public static bool validarCorreo(string comprobarCorreo)
        {
            return comprobarCorreo != null && Regex.IsMatch(comprobarCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDNI.Clear();
            
        }
    }
}
