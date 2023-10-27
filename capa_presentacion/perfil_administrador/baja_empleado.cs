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
    public partial class baja_empleado : Form
    {
        public baja_empleado()
        {
            InitializeComponent();
        }

        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();

        private void baja_empleado_Load(object sender, EventArgs e)
        {
            DataTable dtEmpleadosActivos = negocioEmpleado.listarEmpleadosActivos();

            DataTable dtEmpleadosInactivos = negocioEmpleado.listarEmpleadosInactivos();
            dtEmpleadosInactivos.Columns.Remove("Baja");

            dgvEmpleadosActivos.DataSource = dtEmpleadosActivos;
            dgvEmpleadosInactivos.DataSource = dtEmpleadosInactivos;
        }
    }
}
