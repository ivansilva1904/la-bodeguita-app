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
        NegocioProducto negocioProducto = new NegocioProducto();
        NegocioProveedor negocioProveedor = new NegocioProveedor();
        NegocioMarca negocioMarca = new NegocioMarca();
        NegocioTipoBebida negocioTipoBebida = new NegocioTipoBebida();
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = DialogResult.No;
            if (!string.IsNullOrWhiteSpace(cbxMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioCompra.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioVenta.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text) &&
                !string.IsNullOrWhiteSpace(cbxProveedor.Text) &&
                !string.IsNullOrWhiteSpace(cbxTipoBebida.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                !string.IsNullOrWhiteSpace(txtStockMinimo.Text))
            {
                float precioCompra = float.Parse(txtPrecioCompra.Text);
                float precioVenta = float.Parse(txtPrecioVenta.Text);
                int idMarca = 0;
                long cuitProveedor = 0;
                int idBebida = 0;
                if (precioCompra < precioVenta)
                {
                    int stockMin = int.Parse(txtStockMinimo.Text);
                    int stock = int.Parse(txtStock.Text);
                    if (stockMin < stock)
                    {
                        
                      //if (negocioProducto.verificarIdProductoExistente(idProducto) == false)
                     // {
                            // hacer carga
                            //1rp la marca
                            
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
                            if(idBebida != 0 && idMarca != 0 && cuitProveedor != 0)
                            {
                                
                                ask = MessageBox.Show("Desea Insertar el Nuevo Producto?",
                                               "Confirmar Insercion",
                                                MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                                if (ask == DialogResult.Yes)
                                {
                                    negocioProducto.crearProducto( txtDescripcion.Text,idMarca,
                                    precioCompra, precioVenta, stockMin, stock,cuitProveedor,idBebida);
                                    
                                    limpiarCampos();          
                                }
                            }
                     // }                          
                      /*  else
                        {
                            MessageBox.Show("Ya existe un producto con la misma ID",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        }
                      */

                    }
                    else
                    {
                        MessageBox.Show("El stock es menor que el stock minimo",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    /*ask = MessageBox.Show("Desea Insertar el Nuevo Producto?",
                        "Confirmar Insercion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        //Guardar los cambios
                        limpiarCampos();
                    }*/
                }
                else
                {
                MessageBox.Show("El precio de venta es menor que el precio de compra",
                    "Error",
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
            cbxProveedor.Items.Clear();
            cbxMarca.Items.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();
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

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void alta_producto_Load(object sender, EventArgs e)
        {
            carga_cbxTipoBebidaycbxProveedorycbxMarca();
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

        
    }
}
