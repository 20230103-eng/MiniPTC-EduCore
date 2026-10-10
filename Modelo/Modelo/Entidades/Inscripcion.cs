using System;
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

        // traemos todas las inscripciones con el nombre de el estudiante y de la materia
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


        // traemos los estudiantes que estan inscritos en las materias de el profesor
        public DataTable ObtenerInscripcionesPorProfesor(int idProfesor)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbInscripcion.IdInscripcion,
                tbInscripcion.IdEstudiante,
                tbUsuario.Codigo,
                tbUsuario.NombreCompleto AS Estudiante,
                tbInscripcion.IdMateria,
                tbMateria.Nombre AS Materia
            FROM tbInscripcion
            INNER JOIN tbUsuario ON tbInscripcion.IdEstudiante = tbUsuario.IdUsuario
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            WHERE tbMateria.IdProfesor = @IdProfesor
            ORDER BY tbMateria.Nombre, tbUsuario.NombreCompleto";

            tabla = new DataTable();
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return tabla;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProfesor", idProfesor);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar los estudiantes asignados al profesor.", "Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        // definimos el metodo insertar para inscribir un estudiante en una materia
        public bool Insertar()
        {
            string consulta;
            SqlConnection conexion;
            int filas;

            consulta = @"
            INSERT INTO tbInscripcion
            (IdEstudiante, IdMateria)
            VALUES
            (@IdEstudiante, @IdMateria)";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEstudiante", IdEstudiante);
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible registrar la inscripción.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // con este cambiamos el estudiante o la materia de una inscripcion
        public bool Modificar()
        {
            string consulta;
            SqlConnection conexion;
            int filas;

            consulta = @"
            UPDATE tbInscripcion
            SET IdEstudiante = @IdEstudiante,
                IdMateria = @IdMateria
            WHERE IdInscripcion = @IdInscripcion";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEstudiante", IdEstudiante);
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible modificar la inscripción.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // aca eliminamos la inscripcion, si el estudiante ya tiene notas en esa materia no se puede borrar
        public bool Eliminar()
        {
            string consulta;
            SqlConnection conexion;
            int filas;

            consulta = "DELETE FROM tbInscripcion WHERE IdInscripcion = @IdInscripcion";
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible eliminar la inscripción. Verifica que no tenga calificaciones registradas.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // revisamos si el estudiante ya esta inscrito en esa materia para no inscribirlo dos veces
        public bool Existe()
        {
            string consulta;
            SqlConnection conexion;
            object resultado;

            consulta = @"
            SELECT COUNT(*)
            FROM tbInscripcion
            WHERE IdEstudiante = @IdEstudiante
            AND IdMateria = @IdMateria
            AND IdInscripcion <> @IdInscripcion";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEstudiante", IdEstudiante);
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    resultado = comando.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible validar la inscripción.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = null;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            if (resultado == null || resultado == DBNull.Value)
            {
                return false;
            }

            return Convert.ToInt32(resultado) > 0;
        }
    }
}
