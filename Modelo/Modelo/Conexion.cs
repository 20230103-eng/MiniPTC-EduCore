using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelo.Modelo
{
    public class Conexion
    {
        // ponemos el nombre de nuestra base de datos y el nombre de el servidor donde se encuentra
        private static string servidor = @".\MSSQLSERVER01";
        private static string baseDeDatos = "DbGestionAcademica";

        // definimos el metodo conectar para conectarnos a la base de datos de el servidor, primero revisamos si en el app config pusimos otro servidor y si lo pusimos usamos ese, despues abrimos la conexion y la devolvemos para poder hacer consultas, si falla mostramos un mensaje y devolvemos null
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

        // aca probamos si la conexion funciona, la abrimos y la cerramos de una vez, esto lo usamos en los formularios antes de cargar los datos
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
