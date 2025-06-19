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
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }
        clsConexionClientesBD objConexionClientes = new clsConexionClientesBD();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objConexionClientes.AgregarCliente(txtDni.Text, txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToDouble(txtPeso.Text));
                MessageBox.Show("✅ Cliente agregado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
        }
        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }
        private void txtDni_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void txtNombre_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void txtEdad_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void txtPeso_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void Controlar()
        {
            btnAgregar.Enabled = (txtDni.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtPeso.Text != "");
        }
    }
}
