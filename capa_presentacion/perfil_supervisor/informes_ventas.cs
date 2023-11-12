using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Diagnostics;


using System.IO;
using HtmlAgilityPack;
using System.Xml.Linq;

using capa_negocio;

namespace capa_presentacion.perfil_supervisor
{
    public partial class informes_ventas : Form
    {


        DataTable dtDetalleCopia = new DataTable();
        public informes_ventas()
        {
            InitializeComponent();
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
        }

        NegocioVenta negocioVenta = new NegocioVenta();
        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
        NegocioCliente negocioCliente = new NegocioCliente();


        private void txtDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string dniEmpleado = txtDniEmpleado.Text;
            string dniCliente = txtDniCliente.Text;

            if (desde < hasta)
            {
                //Busqueda filtro solo por fecha
                if (String.IsNullOrWhiteSpace(dniCliente) && String.IsNullOrWhiteSpace(dniEmpleado))
                {
                    DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, "", "");
                    recargar_dgvVentas(tablaVentas);
                }//verifica si el campo DNI EMPLEADO contiene un string
                else if (String.IsNullOrWhiteSpace(dniEmpleado) == false &&
                    String.IsNullOrWhiteSpace(dniCliente) == true)
                {//Verifica que dicho empleado exista
                    if (negocioEmpleado.verificarEmpleadoExistente(Convert.ToInt32(dniEmpleado)) == true)
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, "");
                        recargar_dgvVentas(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Empleado no existe",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }                   
                }//Verifica si el campo DNI CLIENTE contiene un string
                else if (String.IsNullOrWhiteSpace(dniEmpleado) == true &&
                    String.IsNullOrWhiteSpace(dniCliente) == false)
                {//verifica que dicho cliente Exista
                    if (negocioCliente.verificarClienteExistente(Convert.ToInt32(dniCliente)) == true)
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, "", dniCliente);
                        recargar_dgvVentas(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Cliente no existe",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }//Verifica que los campos DNI EMPLEADO y DNI CLIENTE contengan un string
                else if (String.IsNullOrWhiteSpace(dniEmpleado) == false &&
                    String.IsNullOrWhiteSpace(dniCliente) == false)
                {//Verifica que tanto el cliente como el empleado Existan
                    if (negocioCliente.verificarClienteExistente(Convert.ToInt32(dniCliente)) == true &&
                         negocioEmpleado.verificarEmpleadoExistente(Convert.ToInt32(dniEmpleado)))
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, dniCliente);
                        recargar_dgvVentas(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Cliente o el Empleado no Existen",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("La fecha Desde es mayor a la fecha Hasta",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void informes_ventas_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn columnaBotonDetalles = new DataGridViewButtonColumn();
            columnaBotonDetalles.HeaderText = "Detalle Venta";
            columnaBotonDetalles.Name = "colDetalleVenta";
            columnaBotonDetalles.Text = "Detalle Venta";
            columnaBotonDetalles.UseColumnTextForButtonValue = true;
            dgvVentas.Columns.Add(columnaBotonDetalles);
            DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(dtpDesde.Value, dtpHasta.Value, "", "");
            dgvVentas.DataSource = tablaVentas;
        }

        private void recargar_dgvVentas(DataTable tablaVentas)
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = tablaVentas;
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //int indiceFila = e.RowIndex;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int cabecera = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells[1].Value.ToString());              
                generarComprobante(cabecera);
            }
        }

        private void generarComprobante(int idCabecera)
        {
           
            DataTable dtVenta = negocioVenta.listarVenta(idCabecera);
            string directorio = " ";

            if (dtVenta == null || dtVenta.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la cabecera para formar el comprobante");
                return;
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

            
            // Guarda el contenido HTML en una cadena en lugar de en un archivo
            string contenidoHTML = documento.DocumentNode.OuterHtml;

            // Llama a la función para abrir el navegador con el contenido HTML
            AbrirNavegadorConHTML(contenidoHTML);
        }


        private void AbrirNavegadorConHTML(string contenidoHTML)
        {
            try
            {
                // Crea un archivo HTML temporal en una ubicación temporal del sistema
                string rutaArchivoHTML = Path.Combine(Path.GetTempPath(), "comprobante_temporal.html");

                // Escribe el contenido HTML en el archivo temporal
                File.WriteAllText(rutaArchivoHTML, contenidoHTML);

                // Utiliza Process.Start para abrir el navegador predeterminado con el archivo HTML
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaArchivoHTML,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al intentar abrir el navegador: {ex.Message}");
            }
        }
    }
}
