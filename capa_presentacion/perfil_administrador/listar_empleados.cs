using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_entidades;
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
            List<EntidadEmpleado> lista = negocioEmpleado.listarEmpleados();

            dgvListaEmpleados.DataSource = lista;

            /* Buscar como sacar la columna de fecha deshabilitacion
             * Como mostrar la columna baja con string*/

            dgvListaEmpleados.Columns[0].HeaderText = "DNI";
            dgvListaEmpleados.Columns[1].HeaderText = "Nombre";
            dgvListaEmpleados.Columns[2].HeaderText = "Apellido";
            dgvListaEmpleados.Columns[3].HeaderText = "Fecha nacimiento";
            dgvListaEmpleados.Columns[4].HeaderText = "Fecha incorporación";
            dgvListaEmpleados.Columns[5].HeaderText = "Fecha deshabilitación";
            dgvListaEmpleados.Columns[6].HeaderText = "Dirección";
            dgvListaEmpleados.Columns[7].HeaderText = "Telefono";
            dgvListaEmpleados.Columns[8].HeaderText = "Email";
            dgvListaEmpleados.Columns[9].HeaderText = "Contraseña";
            dgvListaEmpleados.Columns[10].HeaderText = "Tipo empleado";
            dgvListaEmpleados.Columns[11].HeaderText = "Baja";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNI.Text);

            EntidadEmpleado empleado = negocioEmpleado.buscarEmpleadoPorDNI(dni);

            if(empleado.DniEmpleado != 0)
            {
                dgvListaEmpleados.DataSource = empleado;

                dgvListaEmpleados.Columns[0].HeaderText = "DNI";
                dgvListaEmpleados.Columns[1].HeaderText = "Nombre";
                dgvListaEmpleados.Columns[2].HeaderText = "Apellido";
                dgvListaEmpleados.Columns[3].HeaderText = "Fecha nacimiento";
                dgvListaEmpleados.Columns[4].HeaderText = "Fecha incorporación";
                dgvListaEmpleados.Columns[5].HeaderText = "Fecha deshabilitación";
                dgvListaEmpleados.Columns[6].HeaderText = "Dirección";
                dgvListaEmpleados.Columns[7].HeaderText = "Telefono";
                dgvListaEmpleados.Columns[8].HeaderText = "Email";
                dgvListaEmpleados.Columns[9].HeaderText = "Contraseña";
                dgvListaEmpleados.Columns[10].HeaderText = "Tipo empleado";
                dgvListaEmpleados.Columns[11].HeaderText = "Baja";
            }
            else
            {
                MessageBox.Show("El empleado ingresado no se encuentra registrado");
            }
        }
    }
}
