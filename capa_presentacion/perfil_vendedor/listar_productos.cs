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
        }
    }
}
