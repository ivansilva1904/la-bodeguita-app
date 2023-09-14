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
            alta_proovedor altaprov = new alta_proovedor();
            altaprov.TopLevel = false;
            pnlFormsSupervisor.Controls.Add(altaprov);
            altaprov.Show();
        }
    }
}
