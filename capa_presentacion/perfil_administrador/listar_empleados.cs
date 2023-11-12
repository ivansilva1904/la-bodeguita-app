using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;

namespace capa_presentacion.perfil_administrador
{
    public partial class listar_empleados : Form
    {
        public listar_empleados()
        {
            InitializeComponent();
        }

        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();

        private void listar_empleados_Load(object sender, EventArgs e)
        {
            DataTable tablaEmpleados = negocioEmpleado.listarTodosEmpleados();

            dgvListaEmpleados.DataSource = tablaEmpleados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNI.Text);

            DataTable empleado = negocioEmpleado.buscarEmpleadoPorDNI(dni);

            if(empleado.Rows.Count > 0)
            {
                dgvListaEmpleados.DataSource = null;

                dgvListaEmpleados.DataSource = empleado;
            }
            else
            {
                MessageBox.Show("El DNI ingresado no pertenece a un empleado registrado");
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
