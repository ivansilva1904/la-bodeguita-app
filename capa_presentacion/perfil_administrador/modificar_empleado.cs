﻿using System;
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

namespace capa_presentacion.perfil_administrador
{
    public partial class modificar_empleado : Form
    {
        public modificar_empleado()
        {
            InitializeComponent();
        }

        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtNuevaContraseña.Clear();
            txtNuevaContraseña2.Clear();
            txtTelefono.Clear();
            radbtnSupervisor.Checked = false;
            radbtnVendedor.Checked = false;
            txtBuscar.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Obtiene el texto del textboxx
            string cadena = txtNombre.Text;
            // Verifica que la cadena no este vacia
            if (!string.IsNullOrEmpty(cadena))
            {
                // Hace mayuscula al 1er miembro del string y minusculas al resto
                string cadenaMayuscula = char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
                // Actualiza la cadena 
                txtNombre.Text = cadenaMayuscula;
                // Pone el cursor al final de la cadena para prevenir que vaya al comienzo
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto del textboxx
            string cadena = txtApellido.Text;
            // Verifica que la cadena no este vacia
            if (!string.IsNullOrEmpty(cadena))
            {
                // Hace mayuscula al 1er miembro del string y minusculas al resto
                string cadenaMayuscula = char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
                // Actualiza la cadena 
                txtApellido.Text = cadenaMayuscula;
                // Pone el cursor al final de la cadena para prevenir que vaya al comienzo
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            int tipoEmpleado = radbtnVendedor.Checked == true ? 1 : 2;
            string nuevaContraseña = txtNuevaContraseña.Text;
            string nuevaContraseña2 = txtNuevaContraseña2.Text;

            if (!string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(apellido) &&
                !string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(telefono) &&
                !string.IsNullOrWhiteSpace(direccion))
            {
                if (validarCorreo(email) == true)
                {
                    if (nuevaContraseña == nuevaContraseña2)
                    {
                        DialogResult resp = MessageBox.Show("Desea Modificar el Empleado?",
                            "Aviso", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            negocioEmpleado.actualizarEmpleado(int.Parse(dni), nombre, apellido, email, telefono, direccion, tipoEmpleado, nuevaContraseña);

                            MessageBox.Show("Se han modificado los datos del empleado",
                                "Aviso de Alta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Las Contraseñas no coinciden",
                        "Error Contraseña",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de Email Invalido",
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

        private void modificar_usuario_Load(object sender, EventArgs e)
        {
            DataTable tablaEmpleados = negocioEmpleado.listarEmpleadosActivos();

            DataGridViewButtonColumn columnaBotonMod = new DataGridViewButtonColumn();
            columnaBotonMod.HeaderText = "";
            columnaBotonMod.Name = "colModificar";
            columnaBotonMod.Text = "Modificar";
            columnaBotonMod.UseColumnTextForButtonValue = true;
            tablaEmpleados.Columns.Remove("Fecha deshabilitacion");
            tablaEmpleados.Columns.Remove("Baja");

            dgvUsersRegistrados.Columns.Add(columnaBotonMod);

            dgvUsersRegistrados.DataSource = tablaEmpleados;
        }

        private void dgvUsersRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                txtDNI.Text = dgvUsersRegistrados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dgvUsersRegistrados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtApellido.Text = dgvUsersRegistrados.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvUsersRegistrados.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtTelefono.Text = dgvUsersRegistrados.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDireccion.Text = dgvUsersRegistrados.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (dgvUsersRegistrados.Rows[e.RowIndex].Cells[9].Value.ToString() == "1")
                {
                    radbtnVendedor.Checked = true;
                }
                else
                {
                    radbtnSupervisor.Checked = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable empleado = negocioEmpleado.buscarEmpleadoPorDNI(int.Parse(txtBuscar.Text));

            if(empleado.Rows.Count > 0)
            {
                empleado.Columns.Remove("Fecha deshabilitacion");
                empleado.Columns.Remove("Baja");

                dgvUsersRegistrados.DataSource = null;

                dgvUsersRegistrados.DataSource = empleado;
            }
            else
            {
                MessageBox.Show("El DNI ingresado no pertenece a un empleado registrado");
            }
        }
    }
}
