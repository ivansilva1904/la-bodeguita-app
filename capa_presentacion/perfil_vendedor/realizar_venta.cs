using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

using capa_negocio;

namespace capa_presentacion.perfil_vendedor
{
    public partial class realizar_venta : Form
    {
        productos formProductos;
        DataTable dtDetalleCopia = new DataTable(); //Esta copia es solo necesaria para el correcto calculo del monto final de la venta

        DataTable dtEmpleadoLogueado = new DataTable();

        public realizar_venta(DataTable dtEmpleado)
        {
            InitializeComponent();
            formProductos = new productos(this);
            dtEmpleadoLogueado = dtEmpleado;
        }

        NegocioCliente negocioCliente = new NegocioCliente();
        NegocioVenta negocioVenta = new NegocioVenta();

        private bool verificarCabecera(int id)
        {
            if(id != 0) { return true; }
            else { return false; }
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            float importeTotal = float.Parse(txtMontoParcial.Text);
            int dniEmpleado = dtEmpleadoLogueado.Rows[0].Field<int>("DNI");
            int dniCliente = int.Parse(txtDNICliente.Text);

            if (!string.IsNullOrWhiteSpace(dniCliente.ToString()))
            {
                if(dgvVentaDetalle.Rows.Count > 0)
                {
                    if (rbutEfectivo.Checked == true || rbutTarjeta.Checked == true)
                    {
                        DialogResult resp = MessageBox.Show("Desea completar la venta?",
                                "Aviso", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            int tipoPago = rbutEfectivo.Checked ? 1 : 2;
                            int idCabecera = 0;

                            try
                            {
                                if(tipoPago == 1)
                                {
                                    idCabecera = negocioVenta.crearCabecera(DateTime.Now, tipoPago, 0, importeTotal, dniEmpleado, dniCliente);
                                }
                                else
                                {
                                    if (!string.IsNullOrWhiteSpace(txtTarjetaNumero.Text))
                                    {
                                        long tarjeta = long.Parse(txtTarjetaNumero.Text);
                                        idCabecera = negocioVenta.crearCabecera(DateTime.Now, tipoPago, tarjeta, importeTotal, dniEmpleado, dniCliente);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe ingresar una tarjeta");
                                        return;
                                    }
                                }
                            }
                            catch
                            {
                                return;
                            }

                            if (verificarCabecera(idCabecera) == true)
                            {
                                negocioVenta.crearDetalles(idCabecera, dgvVentaDetalle);
                            }

                            MessageBox.Show("Se ha realizado la venta",
                                "Venta exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar un metodo de pago", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No ha agregado ningun producto al detalle",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El campo DNI Cliente no debe estar vacio",
                    "Campos faltantes o erroneos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbutTarjeta_Click(object sender, EventArgs e)
        {
            txtTarjetaNumero.Enabled = true;
        }

        private void rbutTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            txtTarjetaNumero.Enabled = false;
        }

        private void txtTarjetaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            formProductos.Show();
        }

        int contBtnQuitar = 0;
        public void cargaProductosDatagrid(DataTable producto)
        {
            dgvVentaDetalle.DataSource = producto;
            dgvVentaDetalle.Columns[0].ReadOnly = true;
            dgvVentaDetalle.Columns[1].ReadOnly = true;
            dgvVentaDetalle.Columns[2].ReadOnly = true;
            dgvVentaDetalle.Columns[4].Visible = false;

            dtDetalleCopia.Clear();
            dtDetalleCopia = producto.Clone();
            foreach(DataRow fila in producto.Rows)
            {
                dtDetalleCopia.Rows.Add(fila.ItemArray);
            }

            float precio = float.Parse(dgvVentaDetalle.Rows[dgvVentaDetalle.Rows.Count - 1].Cells[2].Value.ToString());
            int cantidad = int.Parse(dgvVentaDetalle.Rows[dgvVentaDetalle.Rows.Count - 1].Cells[3].Value.ToString());

            float montoParcial = precio * cantidad;
            montoParcial = montoParcial + float.Parse(txtMontoParcial.Text);

            txtMontoParcial.Text = montoParcial.ToString();

            if (contBtnQuitar == 0)
            {
                DataGridViewButtonColumn colQuitar = new DataGridViewButtonColumn();
                colQuitar.HeaderText = "";
                colQuitar.Name = "colQuitar";
                colQuitar.Text = "Quitar";
                colQuitar.UseColumnTextForButtonValue = true;

                dgvVentaDetalle.Columns.Add(colQuitar);

                contBtnQuitar++;
            }
        }

        private void realizar_venta_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            lblFecha.Text = "Fecha: " + fecha;

            string dniVendedor = dtEmpleadoLogueado.Rows[0].Field<int>("DNI").ToString();
            lblVendedorDNI.Text = "DNI del vendedor: " + dniVendedor;
        }

        private void dgvVentaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                float montoAcumulado = float.Parse(txtMontoParcial.Text);
                float precioRemovido = float.Parse(dgvVentaDetalle.Rows[e.RowIndex].Cells["Precio"].Value.ToString());

                string id = dgvVentaDetalle.Rows[e.RowIndex].Cells[0].Value.ToString();
                formProductos.bajaProductoDatatable(id);

                txtMontoParcial.Text = "0";
                txtMontoParcial.Text = (montoAcumulado - precioRemovido).ToString();
            }
        }

        private void txtDNICliente_Validating(object sender, CancelEventArgs e)
        {
            string dni;
            if(txtDNICliente.Text == "")
            {
                dni = "0";
            }
            else
            {
                dni = txtDNICliente.Text;
            }

            DataTable cliente = negocioCliente.listarClientePorDNI(int.Parse(dni));
            if (cliente.Rows.Count == 0)
            {
                e.Cancel = true;

                lblVerificarDNI.ForeColor = Color.Red;
                lblVerificarDNI.Text = "El cliente no esta registrado";
                lblVerificarDNI.Visible = true;
            }
        }

        private void txtDNICliente_Validated(object sender, EventArgs e)
        {
            lblVerificarDNI.ForeColor = Color.Green;
            lblVerificarDNI.Text = "El cliente esta registrado";
            lblVerificarDNI.Visible = true;
        }

        private void dgvVentaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Obtengo el precio unitario del producto por medio de la copia del datatable
            //No se puede usar el valor del original porque esta bindeado a los cambios que se hagan dentro del datagrid
            float precioUnitario = float.Parse(dtDetalleCopia.Rows[e.RowIndex].Field<string>("Precio"));

            //Obtengo el valor del producto acumulado, por si ya se haya agregado mas de una unidad del mismo
            float precioProductoAcumulado = float.Parse(dgvVentaDetalle.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
            int nuevaCantidad = int.Parse(dgvVentaDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

            int stock = int.Parse(dtDetalleCopia.Rows[e.RowIndex].Field<string>("Stock"));

            //Verifico que la cantidad deseada no supere al stock
            if (nuevaCantidad < 1)
            {
                dgvVentaDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                dgvVentaDetalle_CellEndEdit(sender, e);

                MessageBox.Show("No puede ingresar valores menores a 1");
            }
            else
            {
                if (nuevaCantidad <= stock)
                {
                    //Esto actualiza en el datagrid y, consecuentemente, tambien en el datatable recibido por el form productos
                    dgvVentaDetalle.Rows[e.RowIndex].Cells["Precio"].Value = precioUnitario * nuevaCantidad;

                    //Todo el calculo final de la operacion para actualizar el txtMontoParcial
                    float montoAcumulado = float.Parse(txtMontoParcial.Text);
                    float montoParcial = montoAcumulado - precioProductoAcumulado;
                    txtMontoParcial.Text = (montoParcial + (precioUnitario * nuevaCantidad)).ToString();
                }
                else
                {
                    dgvVentaDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value = stock;
                    dgvVentaDetalle_CellEndEdit(sender, e); //anda a buscarla al angulo con esta recursividad papa

                    MessageBox.Show("Stock insuficiente. Maximo: " + dtDetalleCopia.Rows[e.RowIndex].Field<string>("Stock"));
                }
            }
        }
    }
}
