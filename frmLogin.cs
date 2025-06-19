using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriza_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsConexionUsuariosBD objConexion = new clsConexionUsuariosBD();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnIniciarSesion.Enabled = false;
        }
        public void HabilitarBoton()
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "") 
            {
                btnIniciarSesion.Enabled = true;
            } else
            {
                btnIniciarSesion.Enabled = false;
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e) 
        {
            try
            {
                int coincidencias = objConexion.ValidarLogin(txtUsuario.Text, txtContraseña.Text);
                if (coincidencias > 0)
                {
                    frmPrincipal Principal = new frmPrincipal();
                    Principal.usuarioLogueado = txtUsuario.Text;
                    Principal.FechaIngreso = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    Principal.HoraIngreso = DateTime.Now;
                    Principal.Show();
                }
                else
                {
                    MessageBox.Show("❌ Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
