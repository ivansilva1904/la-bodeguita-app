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
using System.IO;
using HtmlAgilityPack;
using System.Xml.Linq;

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

            if (string.IsNullOrWhiteSpace(txtDNICliente.Text))
            {
                MessageBox.Show("El campo DNI Cliente no debe estar vacio",
                    "Campos faltantes o erroneos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if(dgvVentaDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No ha agregado ningun producto al detalle",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(rbutEfectivo.Checked == false && rbutTarjeta.Checked == false)
            {
                MessageBox.Show("Debe agregar un metodo de pago", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult resp = MessageBox.Show("Desea completar la venta?",
                "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(resp == DialogResult.No)
            {
                return;
            }

            int tipoPago = rbutEfectivo.Checked ? 1 : 2;
            int idCabecera = 0;
            int dniCliente = int.Parse(txtDNICliente.Text);

            if (tipoPago == 1)
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

            if (verificarCabecera(idCabecera) == true)
            {
                negocioVenta.crearDetalles(idCabecera, dgvVentaDetalle);
            }
            else
            {
                return;
            }

            MessageBox.Show("Se ha realizado la venta",
                "Venta exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            generarComprobante(idCabecera);
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
                //dni = "0";
                return;
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

        private void generarComprobante(int idCabecera)
        {
            DataTable dtVenta = negocioVenta.listarVenta(idCabecera);
            string directorio = " ";

            if (dtVenta == null)
            {
                return;
            }
            if(dtVenta.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro la cabecera para formar el comprobante");
                return;
            }

            start:

            fbdComprobante.Description = "Seleccione donde guardar el comprobante";
            fbdComprobante.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult accion = fbdComprobante.ShowDialog();

            if(accion == DialogResult.OK)
            {
                directorio = fbdComprobante.SelectedPath;
            }
            else
            {
                DialogResult resp = MessageBox.Show("Si sale ahora no podra guardar el comprobante. Esta seguro de continuar?",
                    "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    goto start; //EL FAMOSISIMO GOTO PAPAAAAAAAAAAAAAAAAAAAAAAAAAA
                }
            }

            //Aca recien comienza la carga del comprobante
            var documento = new HtmlAgilityPack.HtmlDocument();

            documento.LoadHtml(Properties.Resources.modelo_comprobante);

            string metodoPago = dtVenta.Rows[0].Field<int>(1) == 1 ? "Efectivo" : "Tarjeta";

            documento.GetElementbyId("nro-comprobante").InnerHtml = "Nro. comprobante: " + idCabecera;
            documento.GetElementbyId("fecha").InnerHtml = "Fecha: " + dtVenta.Rows[0].Field<DateTime>(0).ToString("dd-MM-yyyy");
            documento.GetElementbyId("empleado-nombre").InnerHtml = "Empleado: " + dtVenta.Rows[0].Field<string>(2);
            documento.GetElementbyId("cliente-nombre").InnerHtml = "Cliente: " + dtVenta.Rows[0].Field<string>(4);
            documento.GetElementbyId("cliente-dni").InnerHtml = "Cliente DNI: " + dtVenta.Rows[0].Field<int>(3).ToString();
            documento.GetElementbyId("metodo-pago").InnerHtml = "Metodo de pago: " + metodoPago;

            foreach (DataRow fila in dtVenta.Rows)
            {
                string nombreProducto = fila.Field<string>(5);
                string cantidad = fila.Field<int>(6).ToString();
                string precio = fila.Field<double>(7).ToString();
                string subtotal = fila.Field<double>(8).ToString();

                HtmlNode filaDetalle = HtmlNode.CreateNode(
                    "<tr>" +
                        "<td>" + nombreProducto + "</td>" +
                        "<td>" + cantidad + "</td>" +
                        "<td>" + precio + "</td>" +
                        "<td>" + subtotal + "</td>" +
                "</tr>");

                documento.GetElementbyId("venta-detalle").AppendChild(filaDetalle);
            }

            documento.GetElementbyId("monto-final").InnerHtml = "Monto final: $" + dtVenta.Rows[0].Field<double>(9).ToString();

            documento.Save(directorio + "\\comprobante_de_compra" + idCabecera + ".html");
        }
    }
}
