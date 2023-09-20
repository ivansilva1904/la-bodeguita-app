﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.perfil_vendedor
{
    public partial class menu_vendedor : Form
    {
        public menu_vendedor()
        {
            InitializeComponent();
        }

        private void btnAltaCliente_MouseEnter(object sender, EventArgs e)
        {
            btnAltaCliente.BackColor = Color.Bisque;
        }

        private void btnAltaCliente_MouseLeave(object sender, EventArgs e)
        {
            btnAltaCliente.BackColor = Color.Tan;
        }

        private void btnModificarCliente_MouseEnter(object sender, EventArgs e)
        {
            btnModificarCliente.BackColor = Color.Bisque;
        }

        private void btnModificarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnModificarCliente.BackColor = Color.Tan;
        }

        private void btnRealizarVenta_MouseEnter(object sender, EventArgs e)
        {
            btnRealizarVenta.BackColor = Color.Bisque;
        }

        private void btnRealizarVenta_MouseLeave(object sender, EventArgs e)
        {
            btnRealizarVenta.BackColor = Color.Tan;
        }

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
    }
}
