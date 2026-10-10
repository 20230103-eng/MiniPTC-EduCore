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
        public int IdEvaluacion { get; set; }
        public decimal Nota { get; set; }
        public string Observacion { get; set; }

        // traemos todas las calificaciones con el estudiante, la materia y la evaluacion para la tabla de el administrador
        public DataTable ObtenerCalificaciones()
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbCalificacion.IdCalificacion,
                tbCalificacion.IdInscripcion,
                tbCalificacion.IdEvaluacion,
                tbUsuario.NombreCompleto AS Estudiante,
                tbMateria.Nombre AS Materia,
                tbEvaluacion.Periodo,
                tbEvaluacion.Nombre AS NombreEvaluacion,
                tbCalificacion.Nota,
                tbCalificacion.Observacion
            FROM tbCalificacion
            INNER JOIN tbInscripcion ON tbCalificacion.IdInscripcion = tbInscripcion.IdInscripcion
            INNER JOIN tbUsuario ON tbInscripcion.IdEstudiante = tbUsuario.IdUsuario
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            INNER JOIN tbEvaluacion ON tbCalificacion.IdEvaluacion = tbEvaluacion.IdEvaluacion
            ORDER BY tbUsuario.NombreCompleto, tbMateria.Nombre, tbEvaluacion.Periodo, tbEvaluacion.Nombre";

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

        // antes de guardar la nota revisamos que el estudiante no tenga ya una nota en esa evaluacion, si no tiene la insertamos
        public bool Insertar()
        {
            string consultaValidar;
            string consultaInsertar;
            SqlConnection conexion;
            int existentes;
            int filas;

            consultaValidar = @"
            SELECT COUNT(*)
            FROM tbCalificacion
            WHERE IdInscripcion = @IdInscripcion
            AND IdEvaluacion = @IdEvaluacion";

            consultaInsertar = @"
            INSERT INTO tbCalificacion
            (IdInscripcion, IdEvaluacion, Nota, Observacion)
            VALUES
            (@IdInscripcion, @IdEvaluacion, @Nota, @Observacion)";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            existentes = 0;
            filas = 0;

            try
            {
                using (SqlCommand comando = new SqlCommand(consultaValidar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    existentes = Convert.ToInt32(comando.ExecuteScalar());
                }

                if (existentes > 0)
                {
                    MessageBox.Show("Ya existe una calificación para ese estudiante y evaluación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaInsertar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    comando.Parameters.AddWithValue("@Nota", Nota);
                    comando.Parameters.AddWithValue("@Observacion", Observacion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible registrar la calificación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // con este modificamos la nota, tambien revisamos que no quede repetida en la misma evaluacion
        public bool Modificar()
        {
            string consultaValidar;
            string consultaModificar;
            SqlConnection conexion;
            int existentes;
            int filas;

            consultaValidar = @"
            SELECT COUNT(*)
            FROM tbCalificacion
            WHERE IdInscripcion = @IdInscripcion
            AND IdEvaluacion = @IdEvaluacion
            AND IdCalificacion <> @IdCalificacion";

            consultaModificar = @"
            UPDATE tbCalificacion
            SET IdInscripcion = @IdInscripcion,
                IdEvaluacion = @IdEvaluacion,
                Nota = @Nota,
                Observacion = @Observacion
            WHERE IdCalificacion = @IdCalificacion";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            existentes = 0;
            filas = 0;

            try
            {
                using (SqlCommand comando = new SqlCommand(consultaValidar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    comando.Parameters.AddWithValue("@IdCalificacion", IdCalificacion);
                    existentes = Convert.ToInt32(comando.ExecuteScalar());
                }

                if (existentes > 0)
                {
                    MessageBox.Show("Ya existe otra calificación para ese estudiante y evaluación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaModificar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdInscripcion", IdInscripcion);
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    comando.Parameters.AddWithValue("@Nota", Nota);
                    comando.Parameters.AddWithValue("@Observacion", Observacion);
                    comando.Parameters.AddWithValue("@IdCalificacion", IdCalificacion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible modificar la calificación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // aca eliminamos la calificacion usando su id
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

            filas = 0;

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
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // contamos cuantas calificaciones hay registradas para el panel
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

            resultado = null;

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

        // traemos los estudiantes inscritos en la materia de el profesor junto con la nota que tienen en la evaluacion que escogimos, si no tienen nota sale vacia
        public DataTable ObtenerEstudiantesPorMateria(int idProfesor, int idMateria, int idEvaluacion)
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
                AND tbCalificacion.IdEvaluacion = @IdEvaluacion
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
                    comando.Parameters.AddWithValue("@IdEvaluacion", idEvaluacion);
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

        // traemos todas las calificaciones de las materias de el profesor
        public DataTable ObtenerCalificacionesPorProfesor(int idProfesor)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbCalificacion.IdCalificacion,
                tbCalificacion.IdInscripcion,
                tbCalificacion.IdEvaluacion,
                tbUsuario.IdUsuario AS IdEstudiante,
                tbUsuario.Codigo,
                tbUsuario.NombreCompleto AS Estudiante,
                tbMateria.IdMateria,
                tbMateria.Nombre AS Materia,
                tbEvaluacion.Periodo,
                tbEvaluacion.Nombre AS NombreEvaluacion,
                tbCalificacion.Nota,
                tbCalificacion.Observacion
            FROM tbCalificacion
            INNER JOIN tbInscripcion ON tbCalificacion.IdInscripcion = tbInscripcion.IdInscripcion
            INNER JOIN tbUsuario ON tbInscripcion.IdEstudiante = tbUsuario.IdUsuario
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            INNER JOIN tbEvaluacion ON tbCalificacion.IdEvaluacion = tbEvaluacion.IdEvaluacion
            WHERE tbMateria.IdProfesor = @IdProfesor
            ORDER BY tbCalificacion.IdCalificacion DESC";

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
                MessageBox.Show("No fue posible consultar las calificaciones del profesor.", "Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        // traemos las evaluaciones de una materia y un periodo para llenar el combobox de el profesor
        public DataTable ObtenerEvaluacionesPorMateria(int idProfesor, int idMateria, int periodo)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbEvaluacion.IdEvaluacion,
                tbEvaluacion.Nombre AS NombreEvaluacion
            FROM tbEvaluacion
            INNER JOIN tbMateria ON tbEvaluacion.IdMateria = tbMateria.IdMateria
            WHERE tbMateria.IdProfesor = @IdProfesor
            AND tbEvaluacion.IdMateria = @IdMateria
            AND tbEvaluacion.Periodo = @Periodo
            AND tbEvaluacion.Estado = 1
            ORDER BY tbEvaluacion.Nombre";

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
                    comando.Parameters.AddWithValue("@IdMateria", idMateria);
                    comando.Parameters.AddWithValue("@Periodo", periodo);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar las evaluaciones de la materia.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        // aca traemos las notas de el estudiante que inicio sesion con su materia y evaluacion
        public DataTable ObtenerCalificacionesPorEstudiante(int idEstudiante)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbCalificacion.IdCalificacion,
                tbCalificacion.IdEvaluacion,
                tbMateria.IdMateria,
                tbMateria.Codigo AS CodigoMateria,
                tbMateria.Nombre AS Materia,
                tbUsuario.NombreCompleto AS Profesor,
                tbEvaluacion.Periodo,
                tbEvaluacion.Nombre AS NombreEvaluacion,
                tbCalificacion.Nota,
                tbCalificacion.Observacion
            FROM tbCalificacion
            INNER JOIN tbInscripcion ON tbCalificacion.IdInscripcion = tbInscripcion.IdInscripcion
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            INNER JOIN tbUsuario ON tbMateria.IdProfesor = tbUsuario.IdUsuario
            INNER JOIN tbEvaluacion ON tbCalificacion.IdEvaluacion = tbEvaluacion.IdEvaluacion
            WHERE tbInscripcion.IdEstudiante = @IdEstudiante
            ORDER BY tbCalificacion.IdCalificacion DESC";

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
                    comando.Parameters.AddWithValue("@IdEstudiante", idEstudiante);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar las calificaciones del estudiante.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
