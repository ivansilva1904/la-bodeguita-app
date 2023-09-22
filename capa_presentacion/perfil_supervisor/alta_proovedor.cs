using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.perfil_supervisor
{
    public partial class alta_proovedor : Form
    {
        public alta_proovedor()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = DialogResult.No;// Inicializa una variable de tipo dialogResult para 
            // Falta hacer la validacion de que no exista otro proveedor con el mismo CUIT
            if (string.IsNullOrWhiteSpace(txtCuit.Text) &&
                string.IsNullOrWhiteSpace(txtRubro.Text) &&
                string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("Existen Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else//Mensaje de insercion del nuevo cliente
                ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Proveedor?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ask == DialogResult.Yes)
            {
                
                //Mensaje de insercion correcta
                MessageBox.Show("El Proveedor : se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void limpiarCampos()
        {
            txtCuit.Clear();
            txtRubro.Clear();
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
    }
}
