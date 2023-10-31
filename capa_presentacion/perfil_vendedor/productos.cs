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
        realizar_venta formVenta;
        public productos(realizar_venta formVenta)
        {
            InitializeComponent();
            this.formVenta = formVenta;
        }

        NegocioProducto negocioProducto = new NegocioProducto();

        private void productos_Load(object sender, EventArgs e)
        {
            DataTable dtProductos = negocioProducto.listarProductosVenta();

            DataGridViewButtonColumn colAgregar = new DataGridViewButtonColumn();
            colAgregar.HeaderText = "";
            colAgregar.Name = "colAgregar";
            colAgregar.Text = "Agregar";
            colAgregar.UseColumnTextForButtonValue = true;

            dgvListaProductos.Columns.Add(colAgregar);
            dgvListaProductos.DataSource = dtProductos;
            dgvListaProductos.Columns["ID Producto"].Visible = false;
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            DataTable producto = new DataTable();

            producto.Columns.Add("ID Producto");
            producto.Columns.Add("Descripcion");
            producto.Columns.Add("Precio unitario");
            producto.Columns.Add("Cantidad");

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                string id = dgvListaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                string descripcion = dgvListaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                string precio = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();

                producto.Rows.Add(id, descripcion, precio, 0);

                formVenta.cargaProductosDatagrid(producto);
            }
        }
    }
}
