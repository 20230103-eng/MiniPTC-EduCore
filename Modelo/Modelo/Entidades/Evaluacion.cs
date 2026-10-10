using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public int IdMateria { get; set; }
        public int Periodo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        // traemos todas las evaluaciones de las materias que da el profesor
        public DataTable ObtenerPorProfesor(int idProfesor)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbEvaluacion.IdEvaluacion,
                tbEvaluacion.IdMateria,
                tbMateria.Codigo,
                tbMateria.Nombre AS Materia,
                tbEvaluacion.Periodo,
                tbEvaluacion.Nombre,
                tbEvaluacion.Estado
            FROM tbEvaluacion
            INNER JOIN tbMateria ON tbEvaluacion.IdMateria = tbMateria.IdMateria
            WHERE tbMateria.IdProfesor = @IdProfesor
            ORDER BY tbMateria.Nombre, tbEvaluacion.Periodo, tbEvaluacion.Nombre";

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
                MessageBox.Show("No fue posible consultar las evaluaciones.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        // traemos las evaluaciones de una materia en un periodo especifico
        public DataTable ObtenerPorMateriaPeriodo(int idProfesor, int idMateria, int periodo)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbEvaluacion.IdEvaluacion,
                tbEvaluacion.Nombre
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
                MessageBox.Show("No fue posible consultar las evaluaciones de la materia.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        // traemos las evaluaciones que tiene una materia
        public DataTable ObtenerPorMateria(int idMateria)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                IdEvaluacion,
                Periodo,
                Nombre
            FROM tbEvaluacion
            WHERE IdMateria = @IdMateria
            ORDER BY Periodo, Nombre";

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
                    comando.Parameters.AddWithValue("@IdMateria", idMateria);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar las evaluaciones de la materia.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        // antes de insertar la evaluacion revisamos que no exista otra con el mismo nombre en la misma materia y periodo, y que la materia sea de el profesor
        public bool Insertar(int idProfesor)
        {
            string consultaValidar;
            string consultaInsertar;
            SqlConnection conexion;
            object resultado;
            int filas;

            consultaValidar = @"
            SELECT COUNT(*)
            FROM tbEvaluacion
            INNER JOIN tbMateria ON tbEvaluacion.IdMateria = tbMateria.IdMateria
            WHERE tbEvaluacion.IdMateria = @IdMateria
            AND tbMateria.IdProfesor = @IdProfesor
            AND tbEvaluacion.Periodo = @Periodo
            AND tbEvaluacion.Nombre = @Nombre";

            consultaInsertar = @"
            INSERT INTO tbEvaluacion
            (IdMateria, Periodo, Nombre, Estado)
            VALUES
            (@IdMateria, @Periodo, @Nombre, @Estado)";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            filas = 0;
            resultado = null;

            try
            {
                using (SqlCommand comando = new SqlCommand(consultaValidar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    comando.Parameters.AddWithValue("@IdProfesor", idProfesor);
                    comando.Parameters.AddWithValue("@Periodo", Periodo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    resultado = comando.ExecuteScalar();
                }

                if (resultado != null && Convert.ToInt32(resultado) > 0)
                {
                    MessageBox.Show("Ya existe una evaluación con ese nombre en la materia y período seleccionados.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaInsertar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    comando.Parameters.AddWithValue("@Periodo", Periodo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Estado", Estado);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible registrar la evaluación.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // con este modificamos la evaluacion, solo si la materia es de el profesor y no queda repetida con otra
        public bool Modificar(int idProfesor)
        {
            string consultaActual;
            string consultaDuplicado;
            string consultaUso;
            string consultaActualizar;
            SqlConnection conexion;
            int idMateriaAnterior;
            int cantidadDuplicados;
            int cantidadUso;
            int filas;

            consultaActual = @"
            SELECT tbEvaluacion.IdMateria
            FROM tbEvaluacion
            INNER JOIN tbMateria ON tbEvaluacion.IdMateria = tbMateria.IdMateria
            WHERE tbEvaluacion.IdEvaluacion = @IdEvaluacion
            AND tbMateria.IdProfesor = @IdProfesor";

            consultaDuplicado = @"
            SELECT COUNT(*)
            FROM tbEvaluacion
            INNER JOIN tbMateria ON tbEvaluacion.IdMateria = tbMateria.IdMateria
            WHERE tbEvaluacion.IdMateria = @IdMateria
            AND tbMateria.IdProfesor = @IdProfesor
            AND tbEvaluacion.Periodo = @Periodo
            AND tbEvaluacion.Nombre = @Nombre
            AND tbEvaluacion.IdEvaluacion <> @IdEvaluacion";

            consultaUso = "SELECT COUNT(*) FROM tbCalificacion WHERE IdEvaluacion = @IdEvaluacion";

            consultaActualizar = @"
            UPDATE tbEvaluacion
            SET IdMateria = @IdMateria,
                Periodo = @Periodo,
                Nombre = @Nombre,
                Estado = @Estado
            WHERE IdEvaluacion = @IdEvaluacion";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            idMateriaAnterior = 0;
            cantidadDuplicados = 0;
            cantidadUso = 0;
            filas = 0;

            try
            {
                using (SqlCommand comando = new SqlCommand(consultaActual, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    comando.Parameters.AddWithValue("@IdProfesor", idProfesor);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idMateriaAnterior = Convert.ToInt32(resultado);
                    }
                }

                if (idMateriaAnterior == 0)
                {
                    MessageBox.Show("No se encontró la evaluación seleccionada.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaDuplicado, conexion))
                {
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    comando.Parameters.AddWithValue("@IdProfesor", idProfesor);
                    comando.Parameters.AddWithValue("@Periodo", Periodo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    cantidadDuplicados = Convert.ToInt32(comando.ExecuteScalar());
                }

                if (cantidadDuplicados > 0)
                {
                    MessageBox.Show("Ya existe una evaluación con ese nombre en la materia y período seleccionados.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaUso, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    cantidadUso = Convert.ToInt32(comando.ExecuteScalar());
                }

                if (cantidadUso > 0 && idMateriaAnterior != IdMateria)
                {
                    MessageBox.Show("No puedes cambiar de materia una evaluación que ya tiene calificaciones registradas.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaActualizar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    comando.Parameters.AddWithValue("@Periodo", Periodo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Estado", Estado);
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible modificar la evaluación.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        // primero revisamos si la evaluacion ya tiene notas, si tiene no la dejamos borrar, si no tiene la eliminamos
        public bool Eliminar(int idProfesor)
        {
            string consultaUso;
            string consultaEliminar;
            SqlConnection conexion;
            int cantidadUso;
            int filas;

            consultaUso = "SELECT COUNT(*) FROM tbCalificacion WHERE IdEvaluacion = @IdEvaluacion";

            consultaEliminar = @"
            DELETE FROM tbEvaluacion
            WHERE IdEvaluacion = @IdEvaluacion
            AND IdMateria IN
            (
                SELECT IdMateria
                FROM tbMateria
                WHERE IdProfesor = @IdProfesor
            )";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            cantidadUso = 0;
            filas = 0;

            try
            {
                using (SqlCommand comando = new SqlCommand(consultaUso, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    cantidadUso = Convert.ToInt32(comando.ExecuteScalar());
                }

                if (cantidadUso > 0)
                {
                    MessageBox.Show("No se puede eliminar la evaluación porque ya tiene calificaciones registradas.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                using (SqlCommand comando = new SqlCommand(consultaEliminar, conexion))
                {
                    comando.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
                    comando.Parameters.AddWithValue("@IdProfesor", idProfesor);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible eliminar la evaluación.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }
    }
}
