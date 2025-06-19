using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriza_IEFI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        clsConexionAuditoriaBD objConexionAuditoria = new clsConexionAuditoriaBD();
        public string usuarioLogueado { get; set; }
        public string FechaIngreso { get; set; }
        public DateTime HoraIngreso { get; set; }
        private void frmPrincipal_Load(object sender, EventArgs e) // se habilitan botones segun el usuario logueado 
        {
            if (usuarioLogueado == "admin")
            {
                btnAuditoria.Enabled = true;
                btnUsuarios.Enabled = true;
                stsUsuario.Text = "admin";
                stsFecha.Text = FechaIngreso;
            }
            else if (usuarioLogueado == "operador")
            {
                btnAuditoria.Enabled = true;
                btnUsuarios.Enabled = false;
                stsUsuario.Text = "operador";
                stsFecha.Text = FechaIngreso;
            }
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // calcula duración de sesión y se registra junto al usuario en auditoria 
            TimeSpan duracionSesion = DateTime.Now - HoraIngreso;
            string tiempoSesion = duracionSesion.Minutes + "m " + duracionSesion.Seconds + "s";
            objConexionAuditoria.RegistrarAuditoria(usuarioLogueado, tiempoSesion);
            this.Close();
        }
        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria frmAuditoria = new frmAuditoria();
            frmAuditoria.Show();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
        }
    }
}
