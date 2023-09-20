using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.perfil_supervisor
{
    public partial class menu_supervisor : Form
    {
        public menu_supervisor()
        {
            InitializeComponent();
        }

        private void btnAltaProovedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();
         
                alta_proovedor altaprov = new alta_proovedor();
                altaprov.TopLevel = false;
                pnlFormsSupervisor.Controls.Add(altaprov);
                altaprov.Show();
        
            
        }

        private void btnBajaProveedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();
         
                baja_proveedor bajaprov = new baja_proveedor();
                bajaprov.TopLevel = false;
                pnlFormsSupervisor.Controls.Add(bajaprov);
                bajaprov.Show();

        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            modificar_proveedor modifprov = new modificar_proveedor();
            modifprov.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(modifprov);
            modifprov.Show();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            pnlFormsSupervisor.Controls.Clear();

            alta_producto altaprod = new alta_producto();
            altaprod.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(altaprod);
            altaprod.Show();
        }

        private void btnAltaProovedor_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
