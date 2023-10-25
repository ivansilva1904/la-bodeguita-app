using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_negocio;

namespace capa_presentacion.perfil_vendedor
{
    public partial class modificar_cliente : Form
    {
        public modificar_cliente()
        {
            InitializeComponent();
        }

        NegocioCliente negocioCliente = new NegocioCliente();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string email = txtEmail.Text;


            if (!string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(apellido) &&
                !string.IsNullOrWhiteSpace(dni) &&
                !string.IsNullOrWhiteSpace(email))
            {
                if (validarCorreo(email) == true)
                {
                    DialogResult resp = MessageBox.Show("Desea Modificar el cliente?",
                            "Aviso", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        // ingresar en la base de datos // verificar que no este repetido en la b (poner try catch?)
                        // faltaria validacion de dni ya existente
                        MessageBox.Show("Se ha Modificado en la base de datos",
                            "Aviso Modificacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                    }


                }
                else
                {
                    MessageBox.Show("Formato de email Invalido",
                        "Email Invalido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos",
                    "Campos faltantes o erroneos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }

        public static bool validarCorreo(string comprobarCorreo)
        {
            return comprobarCorreo != null && Regex.IsMatch(comprobarCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
      

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDNI.Clear();

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void modificar_cliente_Load(object sender, EventArgs e)
        {
            DataTable dtClientes = negocioCliente.listarClientes();

            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();

            btnModificar.HeaderText = "";
            btnModificar.Name = "colModificar";
            btnModificar.Text = "Modificar";
            btnModificar.UseColumnTextForButtonValue = true;

            dgvClientesRegistrados.Columns.Add(btnModificar);
            dgvClientesRegistrados.DataSource = dtClientes;
        }

        private void dgvClientesRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                txtDNI.Text = dgvClientesRegistrados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dgvClientesRegistrados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtApellido.Text = dgvClientesRegistrados.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvClientesRegistrados.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }

}
