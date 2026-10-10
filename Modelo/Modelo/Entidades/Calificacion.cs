using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Calificacion
    {
        public int IdCalificacion { get; set; }
        public int IdInscripcion { get; set; }
        public int Periodo { get; set; }
        public string NombreEvaluacion { get; set; }
        public decimal Nota { get; set; }
        public string Observacion { get; set; }

        public DataTable ObtenerCalificaciones()
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbCalificacion.IdCalificacion,
                tbCalificacion.IdInscripcion,
                tbUsuario.NombreCompleto AS Estudiante,
                tbMateria.Nombre AS Materia,
                tbCalificacion.Periodo,
                tbCalificacion.NombreEvaluacion,
                tbCalificacion.Nota,
                tbCalificacion.Observacion
            FROM tbCalificacion
            INNER JOIN tbInscripcion ON tbCalificacion.IdInscripcion = tbInscripcion.IdInscripcion
            INNER JOIN tbUsuario ON tbInscripcion.IdEstudiante = tbUsuario.IdUsuario
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            ORDER BY tbUsuario.NombreCompleto, tbMateria.Nombre, tbCalificacion.Periodo";

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
                MessageBox.Show("No fue posible consultar las calificaciones.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        public bool Insertar()
        {
            string consulta;
            SqlConnection conexion;
            int filas;

            consulta = @"
            INSERT INTO tbCalificacion
            (IdInscripcion, Periodo, NombreEvaluacion, Nota, Observacion)
            VALUES
            (@IdInscripcion, @Periodo, @NombreEvaluacion, @Nota, @Observacion)";

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
                    comando.Parameters.AddWithValue("@Periodo", Periodo);
                    comando.Parameters.AddWithValue("@NombreEvaluacion", NombreEvaluacion);
                    comando.Parameters.AddWithValue("@Nota", Nota);
                    comando.Parameters.AddWithValue("@Observacion", Observacion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible registrar la calificación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        public bool Modificar()
        {
            string consulta;
            SqlConnection conexion;
            int filas;

            consulta = @"
            UPDATE tbCalificacion
            SET IdInscripcion = @IdInscripcion,
                Periodo = @Periodo,
                NombreEvaluacion = @NombreEvaluacion,
                Nota = @Nota,
                Observacion = @Observacion
            WHERE IdCalificacion = @IdCalificacion";

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
                    comando.Parameters.AddWithValue("@Periodo", Periodo);
                    comando.Parameters.AddWithValue("@NombreEvaluacion", NombreEvaluacion);
                    comando.Parameters.AddWithValue("@Nota", Nota);
                    comando.Parameters.AddWithValue("@Observacion", Observacion);
                    comando.Parameters.AddWithValue("@IdCalificacion", IdCalificacion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible modificar la calificación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        public bool Eliminar()
        {
            string consulta;
            SqlConnection conexion;
            int filas;

            consulta = "DELETE FROM tbCalificacion WHERE IdCalificacion = @IdCalificacion";
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdCalificacion", IdCalificacion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible eliminar la calificación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        public int Contar()
        {
            string consulta;
            SqlConnection conexion;
            object resultado;

            consulta = "SELECT COUNT(*) FROM tbCalificacion";
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return 0;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    resultado = comando.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible obtener el total de calificaciones.", "Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = null;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            if (resultado == null || resultado == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(resultado);
        }

        public DataTable ObtenerEstudiantesPorMateria(int idProfesor, int idMateria, int periodo, string nombreEvaluacion)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbInscripcion.IdInscripcion,
                tbUsuario.Codigo,
                tbUsuario.NombreCompleto AS Estudiante,
                tbCalificacion.IdCalificacion,
                tbCalificacion.Nota
            FROM tbInscripcion
            INNER JOIN tbUsuario ON tbInscripcion.IdEstudiante = tbUsuario.IdUsuario
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            LEFT JOIN tbCalificacion ON tbInscripcion.IdInscripcion = tbCalificacion.IdInscripcion
                AND tbCalificacion.Periodo = @Periodo
                AND tbCalificacion.NombreEvaluacion = @NombreEvaluacion
            WHERE tbMateria.IdMateria = @IdMateria
            AND tbMateria.IdProfesor = @IdProfesor
            ORDER BY tbUsuario.NombreCompleto";

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
                    comando.Parameters.AddWithValue("@Periodo", periodo);
                    comando.Parameters.AddWithValue("@NombreEvaluacion", nombreEvaluacion);
                    comando.Parameters.AddWithValue("@IdMateria", idMateria);
                    comando.Parameters.AddWithValue("@IdProfesor", idProfesor);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar los estudiantes de la materia.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
