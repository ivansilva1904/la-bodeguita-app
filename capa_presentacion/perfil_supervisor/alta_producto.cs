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
    public partial class alta_producto : Form
    {
        public alta_producto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = DialogResult.No;
            if (!string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtLinea.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text) &&
                !string.IsNullOrWhiteSpace(txtIdProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                (rbtCristaleria.Checked == true || rbtBebida.Checked == true))
            {
                //Convertir a float precio
                //Fijarse que no haya otro producto con igual id en la db
            ask = MessageBox.Show("Desea Insertar el Nuevo Producto?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ask == DialogResult.Yes)
                {
                    //Guardar los cambios
                    limpiarCampos();
                }

            }
            else
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
        private void limpiarCampos()
        {
                txtIdProducto.Clear();
                txtLinea.Clear();
                rbtCristaleria.Checked = false;
                rbtBebida.Checked = false;
                txtMarca.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
                txtDescripcion.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        //Solo numeros en el txtIdProducto
        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Solo numeros en el txtStock
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Solo numeros y un punto en txtPrecio (nose si funciona)
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//(Si se quiere agregar puntos) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
