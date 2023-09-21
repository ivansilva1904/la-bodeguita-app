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
    public partial class modificar_producto : Form
    {
        public modificar_producto()
        {
            InitializeComponent();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtLinea.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                (rbtCristaleria.Checked == true || rbtBebida.Checked == true))
            {
                //Convertir a float precio
                //Guardar los cambios
                
                
            }
            else
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            txtIdProducto.Clear();
            rbtCristaleria.Checked = false;
            rbtBebida.Checked = false;
            txtPrecio.Clear();
            txtMarca.Clear();
            txtLinea.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
