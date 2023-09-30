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
using capa_entidades;

namespace capa_presentacion.perfil_vendedor
{
    public partial class listar_clientes : Form
    {
        public listar_clientes()
        {
            InitializeComponent();
        }

        NegocioCliente negocioCliente = new NegocioCliente();

        private void listar_clientes_Load(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = negocioCliente.listarClientes();

            dgvListadoClientes.Columns[0].HeaderText = "DNI";
            dgvListadoClientes.Columns[1].HeaderText = "Nombre";
            dgvListadoClientes.Columns[2].HeaderText = "Apellido";
            dgvListadoClientes.Columns[3].HeaderText = "Email";
            dgvListadoClientes.Columns[4].HeaderText = "Fecha de nacimiento";
            dgvListadoClientes.Columns[5].HeaderText = "Estado";

            /* Lo que vera a continuacion son mis cientos de intentos por poner un string
             * "activo" o "inactivo" en la columna baja y que planeo continuar en el futuro */

            /*foreach(DataGridViewRow fila in dgvListadoClientes.Rows)
            {
                if (Convert.ToBoolean(fila.Cells[5].Value) == false)
                {
                    fila.Cells[5].ValueType = typeof(string);
                    fila.Cells[5].Value = "Activo";
                }
                else
                {
                    fila.Cells[5].ValueType = typeof(string);
                    fila.Cells[5].Value = "Inactivo";
                }
            }*/

            //int index = 0;

            /*List<EntidadCliente> listado = negocioCliente.listarClientes();

            /*foreach(DataGridViewRow fila in dgvListadoClientes.Rows)
            {
                fila.Cells[0] = listado.
            }*/

            /*List<EntidadCliente> clientes = negocioCliente.listarClientes();

            for(int i = 0; i < negocioCliente.listarClientes().Count; i++)
            {
                dgvListadoClientes.Rows[index].Cells[0].Value = clientes[i].DniCliente;
                dgvListadoClientes.Rows[index].Cells[1].Value = clientes[i].Nombre;
                dgvListadoClientes.Rows[index].Cells[2].Value = clientes[i].Apellido;
                dgvListadoClientes.Rows[index].Cells[3].Value = clientes[i].Email;
                dgvListadoClientes.Rows[index].Cells[4].Value = clientes[i].FechaNac;
                if (clientes[i].Baja == false)
                {
                    dgvListadoClientes.Rows[index].Cells[5].Value = "Activo";
                }
                else
                {
                    dgvListadoClientes.Rows[index].Cells[5].Value = "Inactivo";
                }
            }

            /*foreach (EntidadCliente cliente in negocioCliente.listarClientes())
            {
                dgvListadoClientes.Rows[index].Cells[0].Value = cliente.DniCliente;
                dgvListadoClientes.Rows[index].Cells[1].Value = cliente.Nombre;
                dgvListadoClientes.Rows[index].Cells[2].Value = cliente.Apellido;
                dgvListadoClientes.Rows[index].Cells[3].Value = cliente.Email;
                dgvListadoClientes.Rows[index].Cells[4].Value = cliente.FechaNac;
                if (cliente.Baja == false)
                {
                    dgvListadoClientes.Rows[index].Cells[5].Value = "Activo";
                }
                else
                {
                    dgvListadoClientes.Rows[index].Cells[5].Value = "Inactivo";
                }
                index++;
            }*/
        }
    }
}
