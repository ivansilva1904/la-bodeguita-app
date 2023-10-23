using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using capa_negocio;

namespace capa_presentacion.perfil_supervisor
{
    public partial class alta_producto : Form
    {
        public alta_producto()
        {
            InitializeComponent();
        }

        NegocioProveedor negocioProveedor = new NegocioProveedor();
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = DialogResult.No;
            if (!string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioCompra.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioVenta.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text) &&
                !string.IsNullOrWhiteSpace(txtIdProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                (rbtCristaleria.Checked == true || rbtBebida.Checked == true))
            {
                float precioCompra = float.Parse(txtPrecioCompra.Text);
                float precioVenta = float.Parse(txtPrecioVenta.Text);
                if (precioCompra < precioVenta)
                {
                    ask = MessageBox.Show("Desea Insertar el Nuevo Producto?",
                        "Confirmar Insercion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        //Guardar los cambios
                        limpiarCampos();
                    }
                }
                else
                {
                MessageBox.Show("El precio de venta es menor que el precio de compra",
                    "Errpr",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                //Convertir a float precio
                //Fijarse que no haya otro producto con igual id en la db
           

            }
            else
            {
                MessageBox.Show("Faltan campos por completar", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

           
        }
        private void limpiarCampos()
        {
            txtIdProducto.Clear();
            rbtCristaleria.Checked = false;
            rbtBebida.Checked = false;
            txtMarca.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
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
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void alta_producto_Load(object sender, EventArgs e)
        {
            DataTable tablaProveedor = negocioProveedor.listarProveedorActivos();

            DataTableReader lector = new DataTableReader(tablaProveedor);

            while (lector.Read())
            {
                cbxProveedor.Items.Add(lector.GetString(1));
            }
        }
    }
}
