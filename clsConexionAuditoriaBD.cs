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
    public class clsConexionAuditoriaBD
    {
        public OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\baseDeDatos\\AuditoriaBD.mdb");
        public void Abrir()
        {
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
        }
        public void RegistrarAuditoria(string usuario, string tiempoSesion) // se guarda en la BD de auditoria la informacion de la sesion de un usuario 
        {
            try
            {
                string consulta = "INSERT INTO Auditoria (Usuario, TiempoSesion) VALUES (?, ?)";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@TiempoSesion", tiempoSesion);

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
        public List<string> ListarAuditoria() // se lista en el from de auditoria toda la BD 
        {
            List<string> registros = new List<string>();
            try
            {
                string consulta = "SELECT * FROM Auditoria";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                Abrir();
                OleDbDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    string usuario = lector["Usuario"].ToString();
                    string tiempo = lector["TiempoSesion"].ToString();
                    registros.Add("El usuario " + usuario + " estuvo en la sesión " + tiempo);
                }
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Cerrar();
            }
            return registros;
        }
    }
}
