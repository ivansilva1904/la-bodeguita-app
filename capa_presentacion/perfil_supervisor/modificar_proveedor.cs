﻿using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capa_presentacion.perfil_supervisor
{
    public partial class modificar_proveedor : Form
    {
        public modificar_proveedor()
        {
            InitializeComponent();
        }

        NegocioProveedor negocioProveedor = new NegocioProveedor();

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

        private void limpiarCampos()
        {
            txtCuit.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = DialogResult.No;// Inicializa una variable de tipo dialogResult para 
            // Falta hacer la validacion de que no exista otro proveedor con el mismo CUIT
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {

                MessageBox.Show("Existen Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else//Mensaje de Modificacion del proveedor
            if (verificarEmail(txtEmail.Text))
            {
                ask = MessageBox.Show("¿Seguro que desea Modificar el Proveedor?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (ask == DialogResult.Yes)
                {
                    bool baja = false;
                    if(cbxEstado.Text == "Habilitado"){
                        baja = false;
                    }
                    else if (cbxEstado.Text == "Deshabilitado")
                    {
                        baja = true;
                    }
                    negocioProveedor.actualizarProveedor(long.Parse(txtCuit.Text), txtRazonSocial.Text,txtDireccion.Text,txtTelefono.Text,txtEmail.Text,baja);
                    //Mensaje de modificacion Correcta
                    MessageBox.Show("El Proveedor " + txtRazonSocial.Text + " se modifico correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiarCampos();
                    cargar_dvgModificarProveedor();
                }
            }
            else
            {
                MessageBox.Show("El formato de email es invalido", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static bool verificarEmail(string email)
        {
            return email != null && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void modificar_proveedor_Load(object sender, EventArgs e)
        {


            DataGridViewButtonColumn columnaBotonMod = new DataGridViewButtonColumn();
            columnaBotonMod.HeaderText = "Modificar";
            columnaBotonMod.Name = "colModificar";
            columnaBotonMod.Text = "Modificar";
            columnaBotonMod.UseColumnTextForButtonValue = true;

            dgvModificarProveedor.Columns.Add(columnaBotonMod);

            DataTable tablaProveedor = negocioProveedor.listarTodosProveedor();

            dgvModificarProveedor.DataSource = tablaProveedor;

           
           
        }
        private void cargar_dvgModificarProveedor()
        {
            dgvModificarProveedor.DataSource = null;
            DataTable tablaProveedor = negocioProveedor.listarTodosProveedor();
            dgvModificarProveedor.DataSource = tablaProveedor;
            
        }
        private void dgvModificarProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //int indiceFila = e.RowIndex;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                txtCuit.Text = dgvModificarProveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRazonSocial.Text = dgvModificarProveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDireccion.Text = dgvModificarProveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefono.Text = dgvModificarProveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = dgvModificarProveedor.Rows[e.RowIndex].Cells[5].Value.ToString();
                string estado = dgvModificarProveedor.Rows[e.RowIndex].Cells["Baja"].Value.ToString();
                if(estado == "False"){
                    cbxEstado.Text = "Habilitado";
                }
                else
                {
                    cbxEstado.Text = "Deshabilitado";
                }
                
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            
            if (String.IsNullOrWhiteSpace(filtro))
            {
                //gridview total
                cargar_dvgModificarProveedor();
            }
            else if(cbxFiltro.Text == "Razon Social")
            {
                cargar_dvgModificarProveedorConFiltro(filtro);
                //trae matchs con el string
            }else if(cbxFiltro.Text == "Cuit")
            {
                long filt = Int64.Parse(filtro);
                cargar_dvgModificarProveedorConFiltroCuit(filt);
            
                // trae matchs con el cuit
            }

        }
        private void cargar_dvgModificarProveedorConFiltro(string filtro)
        {
            dgvModificarProveedor.DataSource = null;
            DataTable tablaProveedor = negocioProveedor.filtrarProveedorPorRazonSocial(filtro);
            dgvModificarProveedor.DataSource = tablaProveedor;
           
        }
        private void cargar_dvgModificarProveedorConFiltroCuit(long cuit)
        {
            dgvModificarProveedor.DataSource = null;
            DataTable tablaProveedor = negocioProveedor.buscarProveedorPorCuit(cuit);
            dgvModificarProveedor.DataSource = tablaProveedor;
           
        }
    }
}
