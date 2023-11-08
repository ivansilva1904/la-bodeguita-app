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

namespace capa_presentacion.perfil_administrador
{
    public partial class generar_respaldo : Form
    {
        public generar_respaldo()
        {
            InitializeComponent();
        }

        NegocioBackup negocioBackup = new NegocioBackup();

        private void btnGenerarRespaldo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreRespaldo.Text) && !string.IsNullOrWhiteSpace(txtDirectorio.Text))
            {
                DialogResult resp = MessageBox.Show("Desea crear el respaldo de la base de datos?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(resp == DialogResult.Yes)
                {
                    MessageBox.Show("Se ha generado el respaldo de la base de datos",
                        "Confirmacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tiene que ponerle un nombre al respaldo",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation); ;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fwdDirectorio.Description = "Seleccione el directorio donde guardar el backup";
            //fwdDirectorio.RootFolder = Environment.SpecialFolder.Personal;

            if (fwdDirectorio.ShowDialog() == DialogResult.OK)
            {
                txtDirectorio.Text = fwdDirectorio.SelectedPath;
            }
        }
    }
}
