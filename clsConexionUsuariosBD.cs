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
    public class clsConexionUsuariosBD
    {
        public OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\baseDeDatos\\UsuariosBD.mdb");
        public void Abrir()
        {
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
        }
        public int ValidarLogin(string usuario, string contraseña) // compara el usuario y contraseña con la BD de Usuarios usando un contador, si este es 1 se encontro user. 
        {
            int coincidencias = 0;
            try
            {
                string consulta = "SELECT COUNT(*) FROM Users WHERE Usuario = ? AND Contraseña = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                Abrir();
                coincidencias = (int)cmd.ExecuteScalar();
                Cerrar();
            }
            catch (Exception ex)
            {
                Cerrar();
                MessageBox.Show("Error: " + ex.Message);
            }
            return coincidencias;
        }
    }
}
