using capa_negocio;
using System;
using System.Collections;
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
            if (!string.IsNullOrWhiteSpace(cbxMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioCompra.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioVenta.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text) &&
                !string.IsNullOrWhiteSpace(txtStockMinimo.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                !string.IsNullOrWhiteSpace(cbxProveedor.Text) &&
                !string.IsNullOrWhiteSpace(cbxTipoBebida.Text))
            {
                float precioCompra = float.Parse(txtPrecioCompra.Text);
                float precioVenta = float.Parse(txtPrecioVenta.Text);
                int stockAc = Int32.Parse(txtStock.Text);
                int stockMin = Int32.Parse(txtStockMinimo.Text);
                long cuitProveedor = 0;
                int idBebida = 0;
                int idMarca = 0;
                if (precioCompra < precioVenta)
                {
                    if (stockMin < stockAc)
                    {
                        
                        
                        //esto para obterner id proveedor y bebida
                        DataTable tablaProveedor = negocioProveedor.buscarProveedorPorRazonSocial(cbxProveedor.Text);
                        DataTable tablaTipoBebida = negocioTipoBebida.buscarTipoBebida(cbxTipoBebida.Text);
                        DataTable tablaMarca = negocioMarca.obtenerMarca(cbxMarca.Text);
                        DataTableReader lectorProveedor = new DataTableReader(tablaProveedor);
                        DataTableReader lectorTipoBebida = new DataTableReader(tablaTipoBebida);
                        DataTableReader lectorMarca = new DataTableReader(tablaMarca);
                        while (lectorProveedor.Read())
                        {
                            cuitProveedor = lectorProveedor.GetInt64(0);
                        }
                        while (lectorTipoBebida.Read())
                        {
                            idBebida = lectorTipoBebida.GetInt32(0);
                        }
                        while (lectorMarca.Read())
                        {
                            idMarca = lectorMarca.GetInt32(0);
                        }
                        //Final carga
                        if (idBebida != 0 && idMarca != 0 && cuitProveedor != 0)
                        {
                            DialogResult ask = DialogResult.No;

                            ask = MessageBox.Show("Desea Modificar el Producto?",
                                           "Confirmar Modificacion",
                                            MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                            if (ask == DialogResult.Yes)
                            {
                                negocioProducto.modificacionProducto(Int32.Parse(txtIdProducto.Text), txtDescripcion.Text, idMarca,
                                precioCompra, precioVenta, stockMin, stockAc, cuitProveedor, idBebida);

                                limpiarCampos();
                                carga_dgvModificarProducto();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El stock minimo no puede ser mayor stock cctual",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            txtStockMinimo.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            cbxMarca.Items.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            cbxTipoBebida.Items.Clear();
            cbxProveedor.Items.Clear();

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



        public void carga_cbxTipoBebidaycbxProveedorycbxMarca()
        {
            DataTable tablaProveedor = negocioProveedor.listarProveedorActivos();
            DataTable tablaTipoBebida = negocioTipoBebida.listarTipoBebida();
            DataTable tablaMarca = negocioMarca.listarMarca();
            DataTableReader lectorProveedor = new DataTableReader(tablaProveedor);
            DataTableReader lectorTipoBebida = new DataTableReader(tablaTipoBebida);
            DataTableReader lectorMarca = new DataTableReader(tablaMarca);

            while (lectorProveedor.Read())
            {
                cbxProveedor.Items.Add(lectorProveedor.GetString(1));
            }
            while (lectorTipoBebida.Read())
            {
                cbxTipoBebida.Items.Add(lectorTipoBebida.GetString(1));
            }
            while (lectorMarca.Read())
            {
                cbxMarca.Items.Add(lectorMarca.GetString(1));
            }
        }

        private void modificar_producto_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn columnaBotonMod = new DataGridViewButtonColumn();
            columnaBotonMod.HeaderText = "Modificar";
            columnaBotonMod.Name = "colModificar";
            columnaBotonMod.Text = "Modificar";
            columnaBotonMod.UseColumnTextForButtonValue = true;

            dgvModificarProducto.Columns.Add(columnaBotonMod);

            DataTable tablaProductos = negocioProducto.listarTodosProductos();

            dgvModificarProducto.DataSource = tablaProductos;
            carga_cbxTipoBebidaycbxProveedorycbxMarca();
            dgvModificarProducto.Columns["Baja"].Visible = false;
            
        }

        public void carga_dgvModificarProducto()
        {
            carga_cbxTipoBebidaycbxProveedorycbxMarca();
            dgvModificarProducto.DataSource = null;

            DataTable tablaProveedor = negocioProducto.listarTodosProductos();

            dgvModificarProducto.DataSource = tablaProveedor;




        }

        private void dgvModificarProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //int indiceFila = e.RowIndex;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                txtIdProducto.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbxMarca.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrecioCompra.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPrecioVenta.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtStockMinimo.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtStock.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbxProveedor.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbxTipoBebida.Text = dgvModificarProducto.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }
    }
}
/*
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
  */

