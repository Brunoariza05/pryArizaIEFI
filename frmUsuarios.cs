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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        clsConexionClientesBD objConexionClientes = new clsConexionClientesBD();
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos() // se cargan los datos de los clientes ya cargados 
        {
            try
            {
                dgvDatos.DataSource = objConexionClientes.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCliente frmModificarCliente = new frmModificarCliente();
            frmModificarCliente.ShowDialog();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
