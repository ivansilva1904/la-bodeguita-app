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

namespace capa_presentacion.perfil_vendedor
{
    public partial class listar_productos : Form
    {
        public listar_productos()
        {
            InitializeComponent();
        }

        NegocioProducto negocioProducto = new NegocioProducto();

        private void listar_productos_Load(object sender, EventArgs e)
        {
            DataTable dtProductos = negocioProducto.listarProductosVenta();

            dgvListadoProductos.DataSource = dtProductos;
            dgvListadoProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtProductoDesc = negocioProducto.listarProductosPorDescripcion(txtNombreProducto.Text);

            dgvListadoProductos.DataSource = null;
            dgvListadoProductos.DataSource = dtProductoDesc;

            dgvListadoProductos.Columns[3].Visible = false;
            dgvListadoProductos.Columns[5].Visible = false;
            dgvListadoProductos.Columns[7].Visible = false;
            dgvListadoProductos.Columns[8].Visible = false;
            dgvListadoProductos.Columns[9].Visible = false;
            dgvListadoProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
