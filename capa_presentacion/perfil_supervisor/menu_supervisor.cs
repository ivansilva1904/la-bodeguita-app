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
    public partial class menu_supervisor : Form
    {
        DataTable dtEmpleadoLogueado = new DataTable();
        public menu_supervisor(DataTable dtEmpleado)
        {
            InitializeComponent();
            dtEmpleadoLogueado = dtEmpleado;
        }

        private void btnAltaProovedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            alta_proveedor altaprov = new alta_proveedor();
            altaprov.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(altaprov);
            altaprov.Show();


        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();
            modificar_producto modifProd = new modificar_producto();
            modifProd.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(modifProd);
            modifProd.Show();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            modificar_proveedor modifprov = new modificar_proveedor();
            modifprov.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(modifprov);
            modifprov.Show();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            alta_producto altaprod = new alta_producto();
            altaprod.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(altaprod);
            altaprod.Show();
        }

        private void btnAltaProovedor_MouseEnter(object sender, EventArgs e)
        {
            btnAltaProovedor.BackColor = Color.Bisque;
        }

        private void btnAltaProovedor_MouseLeave(object sender, EventArgs e)
        {
            btnAltaProovedor.BackColor = Color.Tan;
        }

        private void btnModificarProducto_MouseEnter(object sender, EventArgs e)
        {
            btnModificarProducto.BackColor = Color.Bisque;
        }

        private void btnModificarProducto_MouseLeave(object sender, EventArgs e)
        {
            btnModificarProducto.BackColor = Color.Tan;
        }

        private void btnModificarProveedor_MouseEnter(object sender, EventArgs e)
        {
            btnModificarProveedor.BackColor = Color.Bisque;
        }

        private void btnModificarProveedor_MouseLeave(object sender, EventArgs e)
        {
            btnModificarProveedor.BackColor = Color.Tan;
        }

        private void btnAltaProducto_MouseEnter(object sender, EventArgs e)
        {
            btnAltaProducto.BackColor = Color.Bisque;
        }

        private void btnAltaProducto_MouseLeave(object sender, EventArgs e)
        {
            btnAltaProducto.BackColor = Color.Tan;
        }

        private void picboxLogo_MouseEnter(object sender, EventArgs e)
        {
            picboxLogo.BackColor = Color.Bisque;
        }

        private void picboxLogo_MouseLeave(object sender, EventArgs e)
        {
            picboxLogo.BackColor = Color.Tan;
        }

        private void btnInformeVentas_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            informes_ventas vistaInformeVentas = new informes_ventas();
            vistaInformeVentas.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(vistaInformeVentas);
            vistaInformeVentas.Show();
        }

        private void btnInformeVentas_MouseEnter(object sender, EventArgs e)
        {
            btnInformeVentas.BackColor = Color.Bisque;
        }

        private void btnInformeVentas_MouseLeave(object sender, EventArgs e)
        {
            btnInformeVentas.BackColor = Color.Tan;
        }

        private void menu_supervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
