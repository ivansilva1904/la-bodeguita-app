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

using capa_negocio;
using System.IO;
using HtmlAgilityPack;
using System.Xml.Linq;

namespace capa_presentacion.perfil_vendedor
{
    public partial class informes_venta_vendedor : Form
    {

        DataTable dtEmpleadoLogueado = new DataTable();

        public informes_venta_vendedor(DataTable dtEmpleado)
        {
            InitializeComponent();
            
            dtEmpleadoLogueado = dtEmpleado;
            
        }

        
        NegocioCliente negocioCliente = new NegocioCliente();
        NegocioVenta negocioVenta = new NegocioVenta();


        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void informes_venta_vendedor_Load(object sender, EventArgs e)
        {
            string dniEmpleado = Convert.ToString(dtEmpleadoLogueado.Rows[0].Field<int>("DNI"));
            DataGridViewButtonColumn columnaBotonDetalles = new DataGridViewButtonColumn();
            columnaBotonDetalles.HeaderText = "Detalle Venta";
            columnaBotonDetalles.Name = "colDetalleVenta";
            columnaBotonDetalles.Text = "Detalle Venta";
            columnaBotonDetalles.UseColumnTextForButtonValue = true;
            dgvVentasVendedor.Columns.Add(columnaBotonDetalles);
            DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(dtpDesde.Value, dtpHasta.Value, dniEmpleado, "");
            dgvVentasVendedor.DataSource = tablaVentas;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string dniCliente = txtDniCliente.Text;
            string dniEmpleado = Convert.ToString(dtEmpleadoLogueado.Rows[0].Field<int>("DNI"));
            if (desde < hasta)
            {
                //Busqueda filtro solo por fecha
                if (String.IsNullOrWhiteSpace(dniCliente) == true)
                {
                    DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, "");
                    recargar_dgvVentasVendedor(tablaVentas);
                }
                else if (String.IsNullOrWhiteSpace(dniCliente) == false)
                {//Verifica que dicho empleado exista
                    if (negocioCliente.verificarClienteExistente(Convert.ToInt32(dniCliente)) == true)
                    {
                        DataTable tablaVentas = negocioVenta.ventasInformesMultiuso(desde, hasta, dniEmpleado, dniCliente);
                        recargar_dgvVentasVendedor(tablaVentas);
                    }
                    else
                    {
                        MessageBox.Show("El Empleado no existe",
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

        private void recargar_dgvVentasVendedor(DataTable tablaVentas)
        {
            dgvVentasVendedor.DataSource = null;
            dgvVentasVendedor.DataSource = tablaVentas;
        }

        private void dgvVentasVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //int indiceFila = e.RowIndex;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int cabecera = Convert.ToInt32(dgvVentasVendedor.Rows[e.RowIndex].Cells[1].Value.ToString());
                generarComprobante(cabecera);
            }
        }



        private void generarComprobante(int idCabecera)
        {
            DataTable dtVenta = negocioVenta.listarVenta(idCabecera);
            if (dtVenta == null || dtVenta.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la cabecera para formar el comprobante");
                return;
            }
            //carga del comprobante
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


            // Guarda el contenido HTML en una cadena 
            string contenidoHTML = documento.DocumentNode.OuterHtml;

            // Llama a la función para abrir el navegador con el contenido HTML
            AbrirNavegadorConHTML(contenidoHTML,idCabecera);
        }


        private void AbrirNavegadorConHTML(string contenidoHTML,int idCabecera)
        {
            try
            {
                // Crea un archivo HTML temporal en una ubicación temporal del sistema
                string rutaArchivoHTML = Path.Combine(Path.GetTempPath(), "comprobante_temporal_venta"+idCabecera+".html");
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
