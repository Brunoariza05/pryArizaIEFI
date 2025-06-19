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
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }
        clsConexionClientesBD objConexionClientes = new clsConexionClientesBD();
        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        private void txtDniBusqueda_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = txtDniBusqueda.Text != "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            objConexionClientes.BuscarCliente(txtDniBusqueda.Text, txtNombre, txtEdad, txtPeso, btnEliminar, btnModificar);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtPeso.Enabled = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objConexionClientes.EliminarCliente(txtDniBusqueda.Text);
            MessageBox.Show("Cliente eliminado.");
            LimpiarCampos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objConexionClientes.ModificarCliente(txtDniBusqueda.Text, txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToDouble(txtPeso.Text));
            MessageBox.Show("Datos actualizados.");
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtDniBusqueda.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtNombre.Enabled = false;
            txtEdad.Enabled = false;
            txtPeso.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        private void txtNombre_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void txtEdad_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void txtPeso_TextChanged(object sender, EventArgs e) { Controlar(); }
        private void Controlar()
        {
            bool completo = txtNombre.Text != "" && txtEdad.Text != "" && txtPeso.Text != "";
            btnEliminar.Enabled = completo;
            btnModificar.Enabled = completo;
        }
    }
}
