using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_presentacion.perfil_administrador;
using capa_presentacion.perfil_supervisor;
using capa_presentacion.perfil_vendedor;
using capa_negocio;

namespace la_bodeguita
{
    public partial class login : Form
    {
        NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
        public login()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//(Si se quiere agregar puntos) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text) )
            {
                MessageBox.Show("Existen Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblTest.Text = "log nul";
            }
            else
            {
                bool existeEmpleado = negocioEmpleado.verificarDNIExistente(int.Parse(txtUsuario.Text));
                if (existeEmpleado == true)
                {
                    DataTable dtEmpleado = negocioEmpleado.buscarEmpleadoPorDNI(int.Parse(txtUsuario.Text));
                    if(dtEmpleado.Rows[0].Field<bool>("Baja").ToString() == "False")
                    {
                        //Aca iria el if para verificar la contraseña
                        this.Hide();
                        lblTest.Text = "log correcto";

                        switch(dtEmpleado.Rows[0].Field<int>("Tipo empleado"))
                        {
                            case 1:
                            {
                                Form menu_vendedor = new menu_vendedor(dtEmpleado);
                                menu_vendedor.Show();
                                break;
                            }
                            case 2:
                            {
                                Form menu_supervisor = new menu_supervisor(dtEmpleado);
                                menu_supervisor.Show();
                                break;
                            }
                            case 3:
                            {
                                Form menu_administrador = new menu_administrador(dtEmpleado);
                                menu_administrador.Show();
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El empleado existe, pero esta deshabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El empleado no existe. Contacte al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
