using capa_negocio;
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

        NegocioProducto negocioProducto = new NegocioProducto();
        NegocioProveedor negocioProveedor = new NegocioProveedor();
        NegocioMarca negocioMarca = new NegocioMarca();
        NegocioTipoBebida negocioTipoBebida = new NegocioTipoBebida();

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
                !string.IsNullOrWhiteSpace(txtPrecioCompra.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioVenta.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                float precioCompra = float.Parse(txtPrecioCompra.Text);
                float precioVenta = float.Parse(txtPrecioVenta.Text);
                if (precioCompra < precioVenta)
                {
                    DialogResult resp = MessageBox.Show("Esta seguro de modificar los datos del producto?",
                    "Confirmar cambios",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);



                    if (resp == DialogResult.Yes)
                    {
                        MessageBox.Show("Se ha modificado el producto",
                            "Cambios realizados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("El precio de venta es mayor que el precio de compra",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
        
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        

        public void carga_cbxTipoBebidaycbxProveedor()
        {
            DataTable tablaProveedor = negocioProveedor.listarProveedorActivos();
            DataTable tablaTipoBebida = negocioTipoBebida.listarTipoBebida();

            DataTableReader lectorProveedor = new DataTableReader(tablaProveedor);
            DataTableReader lectorTipoBebida = new DataTableReader(tablaTipoBebida);

            while (lectorProveedor.Read())
            {
                cbxProveedor.Items.Add(lectorProveedor.GetString(1));
            }
            while (lectorTipoBebida.Read())
            {
                cbxTipoBebida.Items.Add(lectorTipoBebida.GetString(1));
            }
        }

        private void modificar_producto_Load(object sender, EventArgs e)
        {
            carga_cbxTipoBebidaycbxProveedor();
            carga_dgvModificarProducto();
        }

        public void carga_dgvModificarProducto()
        {

            DataGridViewButtonColumn columnaBotonMod = new DataGridViewButtonColumn();
            columnaBotonMod.HeaderText = "Modificar";
            columnaBotonMod.Name = "colModificar";
            columnaBotonMod.Text = "Modificar";
            columnaBotonMod.UseColumnTextForButtonValue = true;

            dgvModificarProducto.Columns.Add(columnaBotonMod);

            DataTable tablaProductos = negocioProducto.listarTodosProductos();

            dgvModificarProducto.DataSource = tablaProductos;

     
        }
    }
}
