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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        NegocioProducto negocioProducto = new NegocioProducto();

        private void productos_Load(object sender, EventArgs e)
        {
            DataTable dtProductos = negocioProducto.listarProductosVenta();

            dgvListaProductos.DataSource = dtProductos;
        }
    }
}
