using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPerfilUsuario : Form
    {
        private int idUsuario;
        private Usuario usuarioModelo;

        public frmPerfilUsuario()
        {
            InitializeComponent();
            idUsuario = 0;
            usuarioModelo = new Usuario();
            ConfigurarVista();
        }

        public frmPerfilUsuario(int idUsuarioActual) : this()
        {
            idUsuario = idUsuarioActual;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Mi perfil";
            ucEncabezado.Subtitulo = "Consulta la información de tu cuenta y actualiza tu contraseña de forma segura.";
            EstilosFormulario.AplicarBotonPrimario(btnCambiarContrasena);
            EstilosFormulario.AplicarBotonSecundario(btnLimpiar);

            txtContrasenaActual.UseSystemPasswordChar = true;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            AjustarDistribucion();
            CargarPerfil();
        }

        private void frmPerfilUsuario_Resize(object sender, EventArgs e)
        {
            AjustarDistribucion();
        }

        private void AjustarDistribucion()
        {
            if (tlpContenido.ColumnStyles.Count < 2)
            {
                return;
            }

            if (ClientSize.Width < 1100)
            {
                tlpContenido.ColumnStyles[0].SizeType = SizeType.Percent;
                tlpContenido.ColumnStyles[0].Width = 38F;
                tlpContenido.ColumnStyles[1].SizeType = SizeType.Percent;
                tlpContenido.ColumnStyles[1].Width = 62F;
            }
            else
            {
                tlpContenido.ColumnStyles[0].SizeType = SizeType.Percent;
                tlpContenido.ColumnStyles[0].Width = 32F;
                tlpContenido.ColumnStyles[1].SizeType = SizeType.Percent;
                tlpContenido.ColumnStyles[1].Width = 68F;
            }
        }

        private void CargarPerfil()
        {
            DataTable tabla;
            DataRow fila;

            tabla = usuarioModelo.ObtenerUsuarioPorId(idUsuario);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la información del usuario.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            fila = tabla.Rows[0];

            ucPerfil.NombreCompleto = fila["NombreCompleto"].ToString();
            ucPerfil.Rol = fila["TipoUsuario"].ToString();
            ucPerfil.Codigo = fila["Codigo"].ToString();
            ucPerfil.Activo = Convert.ToBoolean(fila["Estado"]);

            lblNombreValor.Text = fila["NombreCompleto"].ToString();
            lblUsuarioValor.Text = fila["NombreUsuario"].ToString();
            lblCodigoValor.Text = fila["Codigo"].ToString();
            lblRolValor.Text = fila["TipoUsuario"].ToString();
            if (Convert.ToBoolean(fila["Estado"]))
            {
                lblEstadoValor.Text = "Activo";
            }
            else
            {
                lblEstadoValor.Text = "Inactivo";
            }
        }

        private bool ValidarCambioContrasena()
        {
            if (string.IsNullOrWhiteSpace(txtContrasenaActual.Text))
            {
                MessageBox.Show("Ingresa tu contraseña actual.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContrasenaActual.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNuevaContrasena.Text))
            {
                MessageBox.Show("Ingresa la nueva contraseña.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNuevaContrasena.Focus();
                return false;
            }

            if (txtNuevaContrasena.Text.Length < 6)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 6 caracteres.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNuevaContrasena.Focus();
                return false;
            }

            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("La confirmación de la contraseña no coincide.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmarContrasena.Focus();
                return false;
            }

            if (txtContrasenaActual.Text == txtNuevaContrasena.Text)
            {
                MessageBox.Show("La nueva contraseña debe ser diferente a la contraseña actual.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNuevaContrasena.Focus();
                return false;
            }

            return true;
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (ValidarCambioContrasena() == false)
            {
                return;
            }

            if (usuarioModelo.ValidarContrasenaActual(idUsuario, txtContrasenaActual.Text) == false)
            {
                MessageBox.Show("La contraseña actual no es correcta.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasenaActual.Clear();
                txtContrasenaActual.Focus();
                return;
            }

            if (usuarioModelo.CambiarContrasena(idUsuario, txtNuevaContrasena.Text))
            {
                MessageBox.Show("La contraseña se actualizó correctamente.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarContrasenas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarContrasenas();
        }

        private void LimpiarContrasenas()
        {
            txtContrasenaActual.Clear();
            txtNuevaContrasena.Clear();
            txtConfirmarContrasena.Clear();
            chkMostrarContrasenas.Checked = false;
            txtContrasenaActual.UseSystemPasswordChar = true;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
        }

        private void chkMostrarContrasenas_CheckedChanged(object sender, EventArgs e)
        {
            bool ocultar;

            ocultar = chkMostrarContrasenas.Checked == false;
            txtContrasenaActual.UseSystemPasswordChar = ocultar;
            txtNuevaContrasena.UseSystemPasswordChar = ocultar;
            txtConfirmarContrasena.UseSystemPasswordChar = ocultar;
        }
    }
}
