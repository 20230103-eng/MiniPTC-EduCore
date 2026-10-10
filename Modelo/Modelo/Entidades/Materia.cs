using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int IdProfesor { get; set; }
        public bool Estado { get; set; }

        public DataTable ObtenerMaterias()
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbMateria.IdMateria,
                tbMateria.Codigo,
                tbMateria.Nombre,
                tbMateria.IdProfesor,
                tbUsuario.NombreCompleto AS Profesor,
                tbMateria.Estado
            FROM tbMateria
            INNER JOIN tbUsuario ON tbMateria.IdProfesor = tbUsuario.IdUsuario
            ORDER BY tbMateria.Nombre";

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
                MessageBox.Show("No fue posible consultar las materias.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            INSERT INTO tbMateria
            (Codigo, Nombre, IdProfesor, Estado)
            VALUES
            (@Codigo, @Nombre, @IdProfesor, @Estado)";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Codigo", Codigo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@IdProfesor", IdProfesor);
                    comando.Parameters.AddWithValue("@Estado", Estado);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible registrar la materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UPDATE tbMateria
            SET Codigo = @Codigo,
                Nombre = @Nombre,
                IdProfesor = @IdProfesor,
                Estado = @Estado
            WHERE IdMateria = @IdMateria";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Codigo", Codigo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@IdProfesor", IdProfesor);
                    comando.Parameters.AddWithValue("@Estado", Estado);
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible modificar la materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            consulta = "DELETE FROM tbMateria WHERE IdMateria = @IdMateria";
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdMateria", IdMateria);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible eliminar la materia. Verifica que no tenga información relacionada.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            consulta = "SELECT COUNT(*) FROM tbMateria";
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
                MessageBox.Show("No fue posible obtener el total de materias.", "Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataTable ObtenerMateriasPorProfesor(int idProfesor, string textoBuscar)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                IdMateria,
                Codigo,
                Nombre,
                IdProfesor,
                Estado
            FROM tbMateria
            WHERE IdProfesor = @IdProfesor
            AND (Codigo LIKE @Buscar OR Nombre LIKE @Buscar)
            ORDER BY Nombre";

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
                    comando.Parameters.AddWithValue("@Buscar", "%" + textoBuscar + "%");

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar las materias del profesor.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }


        public DataTable ObtenerMateriasPorEstudiante(int idEstudiante, string textoBuscar)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbMateria.IdMateria,
                tbMateria.Codigo,
                tbMateria.Nombre,
                tbUsuario.NombreCompleto AS Profesor,
                tbMateria.Estado
            FROM tbInscripcion
            INNER JOIN tbMateria ON tbInscripcion.IdMateria = tbMateria.IdMateria
            INNER JOIN tbUsuario ON tbMateria.IdProfesor = tbUsuario.IdUsuario
            WHERE tbInscripcion.IdEstudiante = @IdEstudiante
            AND (tbMateria.Codigo LIKE @Buscar OR tbMateria.Nombre LIKE @Buscar OR tbUsuario.NombreCompleto LIKE @Buscar)
            ORDER BY tbMateria.Nombre";

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
                    comando.Parameters.AddWithValue("@Buscar", "%" + textoBuscar + "%");

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar las materias del estudiante.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
