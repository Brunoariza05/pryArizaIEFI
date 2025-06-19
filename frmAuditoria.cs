using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriza_IEFI
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }
        clsConexionAuditoriaBD objConexionAuditoria = new clsConexionAuditoriaBD();
        private void frmAuditoria_Load(object sender, EventArgs e) // se muestran las sesiones abiertas hasta el momento 
        {
            lstDatosLogin.Items.Clear();
            List<string> registros = objConexionAuditoria.ListarAuditoria();
            foreach (string registro in registros)
            {
                lstDatosLogin.Items.Add(registro);
            }
        }
        private void lstDatosLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
