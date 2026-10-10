using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelo.Modelo
{
    public class Conexion
    {
        private static string servidor = @".\MSSQLSERVER01";
        private static string baseDeDatos = "DbGestionAcademica";

        public static SqlConnection conectar()
        {
            string servidorConfigurado;
            string cadena;
            SqlConnection conexion;

            servidorConfigurado = ConfigurationManager.AppSettings["ServidorSQL"];

            if (string.IsNullOrEmpty(servidorConfigurado) == false)
            {
                servidor = servidorConfigurado;
            }

            cadena = "Data Source=" + servidor + ";Initial Catalog=" + baseDeDatos + ";Integrated Security=true;";
            conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (SqlException)
            {
                conexion.Dispose();
                MessageBox.Show("No fue posible conectarse a la base de datos.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool ProbarConexion()
        {
            SqlConnection conexion;

            conexion = conectar();

            if (conexion == null)
            {
                return false;
            }

            conexion.Close();
            conexion.Dispose();
            return true;
        }
    }
}
