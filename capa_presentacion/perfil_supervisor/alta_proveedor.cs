using capa_negocio;
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

namespace capa_presentacion.perfil_supervisor
{
    public partial class alta_proveedor : Form
    {
        public alta_proveedor()
        {
            InitializeComponent();
        }
        NegocioProveedor negocioProveedor = new NegocioProveedor();
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = DialogResult.No;// Inicializa una variable de tipo dialogResult para 
            // Falta hacer la validacion de que no exista otro proveedor con el mismo CUIT
            if (!string.IsNullOrWhiteSpace(txtCuit.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                !string.IsNullOrWhiteSpace(txtTelefono.Text) && 
                !string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                if (validarCorreo(txtEmail.Text) == true)
                {
                    ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Proveedor?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (ask == DialogResult.Yes)
                    {
                        long valor = long.Parse(txtCuit.Text);
                        if (negocioProveedor.verificarCuitExistente(valor) == false)
                        {
                            negocioProveedor.crearProveedor(long.Parse(txtCuit.Text), txtRazonSocial.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                            MessageBox.Show("Se ha registrado el Proveedor",
                            "Aviso de Alta",
                            MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("El Proveedor ya existe");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Formato de Email Invalido",
                        "Email Invalido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Existen Campos Vacios",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
        private void limpiarCampos()
        {
            txtCuit.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static bool validarCorreo(string comprobarCorreo)
        {
            return comprobarCorreo != null && Regex.IsMatch(comprobarCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

    }
}
