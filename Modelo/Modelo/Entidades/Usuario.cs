using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string codigo;
        private string nombreUsuario;
        private string contrasena;
        private string nombreCompleto;
        private int idTipoUsuario;
        private string tipoUsuario;
        private bool estado;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public int IdTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DataTable ObtenerUsuarios()
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbUsuario.IdUsuario,
                tbUsuario.Codigo,
                tbUsuario.NombreUsuario,
                tbUsuario.NombreCompleto,
                tbUsuario.IdTipoUsuario,
                tbTipoUsuario.Nombre AS TipoUsuario,
                tbUsuario.Estado
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            ORDER BY tbUsuario.NombreCompleto";

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
                MessageBox.Show("No fue posible consultar los usuarios.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        public DataTable ObtenerUsuariosPorTipo(string tipo)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbUsuario.IdUsuario,
                tbUsuario.Codigo,
                tbUsuario.NombreUsuario,
                tbUsuario.NombreCompleto,
                tbUsuario.IdTipoUsuario,
                tbTipoUsuario.Nombre AS TipoUsuario,
                tbUsuario.Estado
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbTipoUsuario.Nombre = @TipoUsuario
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
                    comando.Parameters.AddWithValue("@TipoUsuario", tipo);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar los usuarios.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        public DataTable ObtenerTiposUsuario()
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = "SELECT IdTipoUsuario, Nombre FROM tbTipoUsuario ORDER BY IdTipoUsuario";
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
                MessageBox.Show("No fue posible consultar los tipos de usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        public int ObtenerIdTipoUsuario(string tipo)
        {
            string consulta;
            SqlConnection conexion;
            object resultado;

            consulta = "SELECT IdTipoUsuario FROM tbTipoUsuario WHERE Nombre = @TipoUsuario";
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return 0;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@TipoUsuario", tipo);
                    resultado = comando.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar el tipo de usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool Insertar()
        {
            string consulta;
            string contrasenaEncriptada;
            SqlConnection conexion;
            int filas;

            contrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(Contrasena);
            consulta = @"
            INSERT INTO tbUsuario
            (Codigo, NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, Estado)
            VALUES
            (@Codigo, @NombreUsuario, @Contrasena, @NombreCompleto, @IdTipoUsuario, @Estado)";

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
                    comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    comando.Parameters.AddWithValue("@Contrasena", contrasenaEncriptada);
                    comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    comando.Parameters.AddWithValue("@IdTipoUsuario", IdTipoUsuario);
                    comando.Parameters.AddWithValue("@Estado", Estado);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible registrar el usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        public bool Modificar(bool cambiarContrasena)
        {
            string consulta;
            string contrasenaEncriptada;
            SqlConnection conexion;
            int filas;

            contrasenaEncriptada = "";

            if (cambiarContrasena)
            {
                contrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(Contrasena);
                consulta = @"
                UPDATE tbUsuario
                SET Codigo = @Codigo,
                    NombreUsuario = @NombreUsuario,
                    Contrasena = @Contrasena,
                    NombreCompleto = @NombreCompleto,
                    IdTipoUsuario = @IdTipoUsuario,
                    Estado = @Estado
                WHERE IdUsuario = @IdUsuario";
            }
            else
            {
                consulta = @"
                UPDATE tbUsuario
                SET Codigo = @Codigo,
                    NombreUsuario = @NombreUsuario,
                    NombreCompleto = @NombreCompleto,
                    IdTipoUsuario = @IdTipoUsuario,
                    Estado = @Estado
                WHERE IdUsuario = @IdUsuario";
            }

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
                    comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    comando.Parameters.AddWithValue("@IdTipoUsuario", IdTipoUsuario);
                    comando.Parameters.AddWithValue("@Estado", Estado);
                    comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                    if (cambiarContrasena)
                    {
                        comando.Parameters.AddWithValue("@Contrasena", contrasenaEncriptada);
                    }

                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible modificar el usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            consulta = "DELETE FROM tbUsuario WHERE IdUsuario = @IdUsuario";
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    filas = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible eliminar el usuario. Verifica que no tenga información relacionada.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return filas > 0;
        }

        public Usuario ValidarUsuario(string usuarioIngresado, string contrasenaIngresada)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;
            string contrasenaGuardada;
            bool contrasenaCorrecta;
            Usuario usuario;

            consulta = @"
            SELECT
                tbUsuario.IdUsuario,
                tbUsuario.Codigo,
                tbUsuario.NombreUsuario,
                tbUsuario.Contrasena,
                tbUsuario.NombreCompleto,
                tbUsuario.IdTipoUsuario,
                tbTipoUsuario.Nombre AS TipoUsuario,
                tbUsuario.Estado
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbUsuario.NombreUsuario = @NombreUsuario
            AND tbUsuario.Estado = 1";

            tabla = new DataTable();
            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return null;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", usuarioIngresado);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible validar el usuario.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            if (tabla.Rows.Count == 0)
            {
                return null;
            }

            contrasenaGuardada = tabla.Rows[0]["Contrasena"].ToString();
            contrasenaCorrecta = BCrypt.Net.BCrypt.Verify(contrasenaIngresada, contrasenaGuardada);

            if (contrasenaCorrecta == false)
            {
                return null;
            }

            usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(tabla.Rows[0]["IdUsuario"]);
            usuario.Codigo = tabla.Rows[0]["Codigo"].ToString();
            usuario.NombreUsuario = tabla.Rows[0]["NombreUsuario"].ToString();
            usuario.NombreCompleto = tabla.Rows[0]["NombreCompleto"].ToString();
            usuario.IdTipoUsuario = Convert.ToInt32(tabla.Rows[0]["IdTipoUsuario"]);
            usuario.TipoUsuario = tabla.Rows[0]["TipoUsuario"].ToString();
            usuario.Estado = Convert.ToBoolean(tabla.Rows[0]["Estado"]);
            return usuario;
        }

        public int ContarPorTipo(string tipo)
        {
            string consulta;
            SqlConnection conexion;
            object resultado;

            consulta = @"
            SELECT COUNT(*)
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbTipoUsuario.Nombre = @TipoUsuario";

            conexion = Conexion.conectar();

            if (conexion == null)
            {
                return 0;
            }

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@TipoUsuario", tipo);
                    resultado = comando.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible obtener el total de usuarios.", "Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataTable ObtenerUsuarioPorId(int idUsuarioBuscado)
        {
            string consulta;
            DataTable tabla;
            SqlConnection conexion;

            consulta = @"
            SELECT
                tbUsuario.IdUsuario,
                tbUsuario.Codigo,
                tbUsuario.NombreUsuario,
                tbUsuario.NombreCompleto,
                tbTipoUsuario.Nombre AS TipoUsuario,
                tbUsuario.Estado
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbUsuario.IdUsuario = @IdUsuario";

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
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuarioBuscado);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No fue posible consultar la información del usuario.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
