using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using capa_negocio;

namespace capa_presentacion.perfil_administrador
{
    public partial class alta_usuario : Form
    {
        public alta_usuario()
        {
            InitializeComponent();
        }

        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string contraseña = txtContraseña.Text;
            string contraseña2 = txtContraseña2.Text;

            if (!string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(apellido) &&
                !string.IsNullOrWhiteSpace(dni) &&
                !string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(telefono) &&
                !string.IsNullOrWhiteSpace(contraseña) &&
                !string.IsNullOrWhiteSpace(contraseña2) && 
                (radbtnSupervisor.Checked == true || radbtnVendedor.Checked == true))
            {
                if (validarCorreo(email) == true)
                {
                    if (contraseña == contraseña2)
                    {
                        DialogResult resp = MessageBox.Show("Desea Ingresar el nuevo Empleado?",
                            "Aviso",MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            if (negocioEmpleado.verificarDNIExistente(int.Parse(dni)) == false)
                            {
                                MessageBox.Show("Se ha registrado el empleado",
                                    "Aviso de Alta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("El cliente ya existe");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las Contraseñas no coinciden",
                        "Error Contraseña",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email Invalido",
                        "Email Invalido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos",
                    "Campos faltantes o erroneos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Obtiene el texto del textboxx
            string cadena = txtNombre.Text;
            // Verifica que la cadena no este vacia
            if (!string.IsNullOrEmpty(cadena))
            {
                // Hace mayuscula al 1er miembro del string y minusculas al resto
                string cadenaMayuscula = char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
                // Actualiza la cadena 
                txtNombre.Text = cadenaMayuscula;
                // Pone el cursor al final de la cadena para prevenir que vaya al comienzo
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto del textboxx
            string cadena = txtApellido.Text;
            // Verifica que la cadena no este vacia
            if (!string.IsNullOrEmpty(cadena))
            {
                // Hace mayuscula al 1er miembro del string y minusculas al resto
                string cadenaMayuscula = char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
                // Actualiza la cadena 
                txtApellido.Text = cadenaMayuscula;
                // Pone el cursor al final de la cadena para prevenir que vaya al comienzo
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDNI.Clear();
            txtContraseña.Clear();
            txtContraseña2.Clear();
            txtTelefono.Clear();
            radbtnSupervisor.Checked = false;
            radbtnVendedor.Checked = false;
        }
        //Comprobacion email
        public static bool validarCorreo(string comprobarCorreo)
        {
           return comprobarCorreo != null && Regex.IsMatch(comprobarCorreo,@"^[^@\s]+@[^@\s]+\.[^@\s]+$");      
        }
 
    }
}
