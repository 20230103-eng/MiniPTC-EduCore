using System;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmInicioSesion : Form
    {
        private Usuario usuarioModelo;

        public frmInicioSesion()
        {
            InitializeComponent();
            usuarioModelo = new Usuario();
            ConfigurarVista();
        }

        private void ConfigurarVista()
        {
            picLogo.Image = RecursosVisuales.CargarImagen("LogoAcademico.png");
            EstilosFormulario.AplicarBotonPrimario(btnIngresar);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            AjustarDistribucion();
            txtUsuario.Focus();
        }

        private void frmInicioSesion_Resize(object sender, EventArgs e)
        {
            AjustarDistribucion();
        }

        private void AjustarDistribucion()
        {
            if (ClientSize.Width < 950)
            {
                pnlMarca.Visible = false;
                tlpPrincipal.ColumnStyles[0].Width = 0;
                tlpPrincipal.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlpPrincipal.ColumnStyles[1].SizeType = SizeType.Percent;
                tlpPrincipal.ColumnStyles[1].Width = 100F;
                return;
            }

            pnlMarca.Visible = true;
            tlpPrincipal.ColumnStyles[0].SizeType = SizeType.Percent;
            tlpPrincipal.ColumnStyles[0].Width = 44F;
            tlpPrincipal.ColumnStyles[1].SizeType = SizeType.Percent;
            tlpPrincipal.ColumnStyles[1].Width = 56F;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            string usuarioIngresado;
            string contrasenaIngresada;
            Usuario usuario;

            usuarioIngresado = txtUsuario.Text.Trim();
            contrasenaIngresada = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(usuarioIngresado))
            {
                MessageBox.Show("Ingresa tu usuario.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasenaIngresada))
            {
                MessageBox.Show("Ingresa tu contraseña.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContrasena.Focus();
                return;
            }

            usuario = usuarioModelo.ValidarUsuario(usuarioIngresado, contrasenaIngresada);

            if (usuario == null)
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Clear();
                txtContrasena.Focus();
                return;
            }

            Sesion.UsuarioActual = usuario;
            AbrirPanelSegunRol(usuario);
        }

        private void AbrirPanelSegunRol(Usuario usuario)
        {
            Form formulario;

            formulario = null;

            if (usuario.TipoUsuario == "Administrador")
            {
                formulario = new frmPrincipalAdministrador();
            }
            else if (usuario.TipoUsuario == "Profesor")
            {
                formulario = new frmPrincipalProfesor(usuario.IdUsuario);
            }
            else if (usuario.TipoUsuario == "Estudiante")
            {
                formulario = new frmPrincipalEstudiante(usuario.IdUsuario);
            }

            if (formulario == null)
            {
                MessageBox.Show("El rol de la cuenta no tiene un panel disponible.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Sesion.UsuarioActual = null;
                return;
            }

            Hide();
            formulario.ShowDialog();
            formulario.Dispose();
            Sesion.UsuarioActual = null;
            LimpiarFormulario();
            Show();
            Activate();
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            chkMostrarContrasena.Checked = false;
            txtContrasena.UseSystemPasswordChar = true;
            txtUsuario.Focus();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = chkMostrarContrasena.Checked == false;
        }

    }
}
