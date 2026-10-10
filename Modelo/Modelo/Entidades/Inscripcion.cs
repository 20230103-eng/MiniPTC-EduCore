using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }

        public DataTable ObtenerInscripciones()
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbInscripcion.IdInscripcion,
                tbInscripcion.IdEstudiante,
                tbInscripcion.IdMateria,
                tbUsuario.NombreCompleto AS Estudiante,
                tbMateria.Nombre AS Materia,
                tbUsuario.NombreCompleto + ' - ' + tbMateria.Nombre AS Descripcion
            FROM tbInscripcion
            INNER JOIN tbUsuario ON tbInscripcion.IdEstudiante = tbUsuario.IdUsuario
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            ORDER BY tbUsuario.NombreCompleto, tbMateria.Nombre";

            tabla = new DataTable();
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return tabla;
            }

            try
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar las inscripciones.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }
    }
}
