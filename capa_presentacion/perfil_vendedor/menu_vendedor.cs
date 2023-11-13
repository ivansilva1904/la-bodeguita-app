using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.perfil_vendedor
{
    public partial class menu_vendedor : Form
    {
        DataTable dtEmpleadoLogueado = new DataTable();
        public menu_vendedor(DataTable dtEmpleado)
        {
            InitializeComponent();
            dtEmpleadoLogueado = dtEmpleado;
            this.SizeChanged += menu_vendedor_SizeChanged;
        }

        private void btnAltaCliente_MouseEnter(object sender, EventArgs e)
        {
            btnAltaCliente.BackColor = Color.Bisque;
        }

        private void btnAltaCliente_MouseLeave(object sender, EventArgs e)
        {
            btnAltaCliente.BackColor = Color.Tan;
        }

        private void btnModificarCliente_MouseEnter(object sender, EventArgs e)
        {
            btnModificarCliente.BackColor = Color.Bisque;
        }

        private void btnModificarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnModificarCliente.BackColor = Color.Tan;
        }

        private void btnRealizarVenta_MouseEnter(object sender, EventArgs e)
        {
            btnRealizarVenta.BackColor = Color.Bisque;
        }

        private void btnRealizarVenta_MouseLeave(object sender, EventArgs e)
        {
            btnRealizarVenta.BackColor = Color.Tan;
        }

        private void btnListarClientes_MouseEnter(object sender, EventArgs e)
        {
            btnListarClientes.BackColor = Color.Bisque;
        }

        private void btnListarClientes_MouseLeave(object sender, EventArgs e)
        {
            btnListarClientes.BackColor = Color.Tan;
        }

        private void btnListarProductos_MouseEnter(object sender, EventArgs e)
        {
            btnListarProductos.BackColor = Color.Bisque;
        }

        private void btnListarProductos_MouseLeave(object sender, EventArgs e)
        {
            btnListarProductos.BackColor = Color.Tan;
        }

        private void picboxLogo_MouseEnter(object sender, EventArgs e)
        {
            picboxLogo.BackColor = Color.Bisque;
        }

        private void picboxLogo_MouseLeave(object sender, EventArgs e)
        {
            picboxLogo.BackColor = Color.Tan;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
            alta_cliente vistaAltaCliente = new alta_cliente();
            vistaAltaCliente.TopLevel = false;
            vistaAltaCliente.FormBorderStyle = FormBorderStyle.None;
            vistaAltaCliente.Dock = DockStyle.Fill;
            panVistasMenu.Controls.Add(vistaAltaCliente);
            vistaAltaCliente.Show();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
            modificar_cliente vistaModCliente = new modificar_cliente();
            vistaModCliente.TopLevel = false;
            vistaModCliente.FormBorderStyle = FormBorderStyle.None;
            vistaModCliente.Dock = DockStyle.Fill;
            panVistasMenu.Controls.Add(vistaModCliente);
            vistaModCliente.Show();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
            realizar_venta vistaVenta = new realizar_venta(dtEmpleadoLogueado);
            vistaVenta.TopLevel = false;
            vistaVenta.FormBorderStyle = FormBorderStyle.None;
            vistaVenta.Dock = DockStyle.Fill;
            panVistasMenu.Controls.Add(vistaVenta);
            vistaVenta.Show();
        }

        private void picboxLogo_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
            listar_clientes vistaListaClientes = new listar_clientes();
            vistaListaClientes.TopLevel = false;
            vistaListaClientes.FormBorderStyle = FormBorderStyle.None;
            vistaListaClientes.Dock = DockStyle.Fill;
            panVistasMenu.Controls.Add(vistaListaClientes);
            vistaListaClientes.Show();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
            listar_productos vistaListaProductos = new listar_productos();
            vistaListaProductos.TopLevel = false;
            vistaListaProductos.FormBorderStyle = FormBorderStyle.None;
            vistaListaProductos.Dock = DockStyle.Fill;
            panVistasMenu.Controls.Add(vistaListaProductos);
            vistaListaProductos.Show();
        }

        private void menu_vendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void menu_vendedor_SizeChanged(object sender, EventArgs e)
        {
            Form formularioInterno = null;
            foreach (Control control in panVistasMenu.Controls)
            {
                formularioInterno = (Form)control;
                if (formularioInterno is alta_cliente)
                {

                    formularioInterno.Size = panVistasMenu.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is listar_clientes)
                {

                    formularioInterno.Size = panVistasMenu.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is listar_productos)
                {
                    formularioInterno.Size = panVistasMenu.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is modificar_cliente)
                {
                    formularioInterno.Size = panVistasMenu.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is realizar_venta)
                {
                    formularioInterno.Size = panVistasMenu.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is informes_venta_vendedor)
                {
                    formularioInterno.Size = panVistasMenu.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }

            }
        }

        private void btnInformesVentas_Click(object sender, EventArgs e)
        {
            panVistasMenu.Controls.Clear();
            informes_venta_vendedor vistaInformesVentas = new informes_venta_vendedor(dtEmpleadoLogueado);
            vistaInformesVentas.TopLevel = false;
            vistaInformesVentas.FormBorderStyle = FormBorderStyle.None;
            vistaInformesVentas.Dock = DockStyle.Fill;
            panVistasMenu.Controls.Add(vistaInformesVentas);
            vistaInformesVentas.Show();
        }

        private void btnInformesVentas_MouseEnter(object sender, EventArgs e)
        {
            btnInformesVentas.BackColor = Color.Bisque;
        }

        private void btnInformesVentas_MouseLeave(object sender, EventArgs e)
        {
            btnInformesVentas.BackColor = Color.Tan;
        }

    }
}
