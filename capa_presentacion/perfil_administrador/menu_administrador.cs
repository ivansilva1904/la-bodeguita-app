using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_presentacion.perfil_vendedor;

namespace capa_presentacion.perfil_administrador
{
    public partial class menu_administrador : Form
    {
        DataTable dtEmpleadoLogueado = new DataTable();
        public menu_administrador(DataTable dtEmpleado)
        {
            InitializeComponent();
            dtEmpleadoLogueado = dtEmpleado;
        }
        private void btnAltaEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnAltaEmpleado.BackColor = Color.Bisque;
        }
        
        private void btnAltaEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnAltaEmpleado.BackColor = Color.Tan;
        }
        /*
        private void btnBajaEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnBajaEmpleado.BackColor = Color.Bisque;
        }

        private void btnBajaEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnBajaEmpleado.BackColor = Color.Tan;
        }
        */
        private void btnModEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnModEmpleado.BackColor = Color.Bisque;
        }

        private void btnModEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnModEmpleado.BackColor = Color.Tan;
        }

        private void btnGenerarRespaldo_MouseEnter(object sender, EventArgs e)
        {
            btnGenerarRespaldo.BackColor = Color.Bisque;
        }

        private void btnGenerarRespaldo_MouseLeave(object sender, EventArgs e)
        {
            btnGenerarRespaldo.BackColor = Color.Tan;
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            alta_usuario vistaAltaUsuario = new alta_usuario();
            vistaAltaUsuario.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaAltaUsuario);
            vistaAltaUsuario.Show();
        }
       /*
        private void btnBajaEmpleado_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            baja_usuario vistaBajaUsuario = new baja_usuario();
            vistaBajaUsuario.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaBajaUsuario);
            vistaBajaUsuario.Show();
        }
        */
        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            modificar_empleado vistaModUsuario = new modificar_empleado();
            vistaModUsuario.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaModUsuario);
            vistaModUsuario.Show();
        }

        private void picboxLogo_MouseEnter(object sender, EventArgs e)
        {
            picboxLogo.BackColor = Color.Bisque;
        }

        private void picboxLogo_MouseLeave(object sender, EventArgs e)
        {
            picboxLogo.BackColor = Color.Tan;
        }

        private void picboxLogo_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            listar_clientes vistaListarClientes = new listar_clientes();
            vistaListarClientes.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaListarClientes);
            vistaListarClientes.Show();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            listar_productos vistaListarProductos = new listar_productos();
            vistaListarProductos.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaListarProductos);
            vistaListarProductos.Show();
        }

        /*
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
        */
        private void btnGenerarRespaldo_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            generar_respaldo vistaGenerarRespaldo = new generar_respaldo();
            vistaGenerarRespaldo.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaGenerarRespaldo);
            vistaGenerarRespaldo.Show();
        }
        
        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            listar_empleados vistaListarEmpleados = new listar_empleados();
            vistaListarEmpleados.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaListarEmpleados);
            vistaListarEmpleados.Show();
        }

        private void btnListarEmpleados_MouseEnter(object sender, EventArgs e)
        {
            btnListarEmpleados.BackColor = Color.Bisque;
        }

        private void btnListarEmpleados_MouseLeave(object sender, EventArgs e)
        {
            btnListarEmpleados.BackColor = Color.Tan;
        }

        private void menu_administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnBajaEmpleado_MouseEnter(object sender, EventArgs e)
        {
            btnBajaEmpleado.BackColor = Color.Bisque;
        }

        private void btnBajaEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnBajaEmpleado.BackColor = Color.Tan;
        }

        private void btnBajaEmpleado_Click(object sender, EventArgs e)
        {
            panFormsAdministrador.Controls.Clear();
            baja_empleado vistaBajaEmpleado = new baja_empleado();
            vistaBajaEmpleado.TopLevel = false;
            panFormsAdministrador.Controls.Add(vistaBajaEmpleado);
            vistaBajaEmpleado.Location = new Point(12, 12);
            vistaBajaEmpleado.Show();
        }
    }
}
