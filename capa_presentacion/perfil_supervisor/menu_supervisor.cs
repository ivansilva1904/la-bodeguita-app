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
            
            this.SizeChanged += menu_supervisor_SizeChanged;

        }
        
        private void btnAltaProovedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            alta_proveedor altaprov = new alta_proveedor();
            altaprov.TopLevel = false;
            altaprov.FormBorderStyle = FormBorderStyle.None;
            altaprov.Dock = DockStyle.Fill;
            pnlFormsSupervisor.Controls.Add(altaprov);
            altaprov.Show();


        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();
            modificar_producto modifProd = new modificar_producto();
            modifProd.TopLevel = false;
            modifProd.FormBorderStyle = FormBorderStyle.None;
            modifProd.Dock = DockStyle.Fill;
            pnlFormsSupervisor.Controls.Add(modifProd);
            modifProd.Show();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            modificar_proveedor modifprov = new modificar_proveedor();
            modifprov.TopLevel = false;
            modifprov.FormBorderStyle = FormBorderStyle.None;
            modifprov.Dock = DockStyle.Fill;
            pnlFormsSupervisor.Controls.Add(modifprov);
            modifprov.Show();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();
           
            alta_producto altaprod = new alta_producto();
            altaprod.TopLevel = false;
            altaprod.FormBorderStyle = FormBorderStyle.None;
            altaprod.Dock = DockStyle.Fill; 
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
            vistaInformeVentas.FormBorderStyle = FormBorderStyle.None;
            vistaInformeVentas.Dock = DockStyle.Fill;
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
            System.Windows.Forms.Application.ExitThread();
        }

        private void menu_supervisor_SizeChanged(object sender, EventArgs e)
        {
            Form formularioInterno = null;
            foreach(Control control in pnlFormsSupervisor.Controls)
            {
                formularioInterno = (Form)control;
                if (formularioInterno is alta_producto)
                {
                    
                    formularioInterno.Size = pnlFormsSupervisor.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is modificar_producto)
                {

                    formularioInterno.Size = pnlFormsSupervisor.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is alta_proveedor)
                {
                    formularioInterno.Size = pnlFormsSupervisor.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is modificar_proveedor)
                {
                    formularioInterno.Size = pnlFormsSupervisor.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
                if (formularioInterno is informes_ventas)
                {
                    formularioInterno.Size = pnlFormsSupervisor.Size;
                    formularioInterno.WindowState = FormWindowState.Normal;
                    formularioInterno.WindowState = FormWindowState.Maximized;
                }
            }

        }


    }
}
