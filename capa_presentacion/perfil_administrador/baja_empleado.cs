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
            dtEmpleadosActivos.Columns.Remove("Fecha deshabilitacion");
            dtEmpleadosActivos.Columns.Remove("Baja");
            DataGridViewButtonColumn colBtnBaja = new DataGridViewButtonColumn();
            colBtnBaja.HeaderText = "";
            colBtnBaja.Name = "colBaja";
            colBtnBaja.Text = "Dar de baja";
            colBtnBaja.UseColumnTextForButtonValue = true;

            DataTable dtEmpleadosInactivos = negocioEmpleado.listarEmpleadosInactivos();
            dtEmpleadosInactivos.Columns.Remove("Baja");
            DataGridViewButtonColumn colBtnAlta = new DataGridViewButtonColumn();
            colBtnAlta.HeaderText = "";
            colBtnAlta.Name = "colAlta";
            colBtnAlta.Text = "Dar de alta";
            colBtnAlta.UseColumnTextForButtonValue = true;

            dgvEmpleadosActivos.Columns.Add(colBtnBaja);
            dgvEmpleadosInactivos.Columns.Add(colBtnAlta);

            dgvEmpleadosActivos.DataSource = dtEmpleadosActivos;
            dgvEmpleadosInactivos.DataSource = dtEmpleadosInactivos;
        }
    }
}
