using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryAriza_IEFI
{
    public class clsConexionClientesBD
    {
        public OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\baseDeDatos\\ClienteBD.mdb");
        public void Abrir()
        {
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
        }
        public DataTable ListarClientes() // se lista clientes de la BD en la grilla de usuarios 
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = "SELECT * FROM Datos";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                Abrir();
                adaptador.Fill(tabla);
                Cerrar();
            }
            catch (Exception ex)
            {
                Cerrar();
                MessageBox.Show("Error: " + ex.Message);
            }
            return tabla;
        }
        public void AgregarCliente(string dni, string nombre, int edad, double peso) // te permite agregar un nuevo cliente a la BD
        {
            try
            {
                string consulta = "INSERT INTO Datos (DNI, Nombre, Edad, Peso) VALUES (?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@DNI", dni);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Edad", edad);
                cmd.Parameters.AddWithValue("@Peso", peso);

                Abrir();
                cmd.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Cerrar();
            }
        }
        public void BuscarCliente(string dni, TextBox nombre, TextBox edad, TextBox peso, Button btnEliminar, Button btnModificar) // se busca cliente por DNI en la BD (para eliminar o modificar)
        {
            try
            {
                string consulta = "SELECT * FROM Datos WHERE DNI = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@DNI", dni);
                Abrir();
                OleDbDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    nombre.Text = lector["Nombre"].ToString();
                    edad.Text = lector["Edad"].ToString();
                    peso.Text = lector["Peso"].ToString();

                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Cerrar();
            }
        }
        public void EliminarCliente(string dni) // permite eliminar cliente de la BD 
        {
            try
            {
                string consulta = "DELETE FROM Datos WHERE DNI=?";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@DNI", dni);
                Abrir();
                cmd.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Cerrar();
            }
        }
        public void ModificarCliente(string dni, string nombre, int edad, double peso) // permite modificar cliente de la BD
        {
            try
            {
                string consulta = "UPDATE Datos SET Nombre=?, Edad=?, Peso=? WHERE DNI=?";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Edad", edad);
                cmd.Parameters.AddWithValue("@Peso", peso);
                cmd.Parameters.AddWithValue("@DNIOriginal", dni);
                Abrir();
                cmd.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Cerrar();
            }
        }
    }
}
