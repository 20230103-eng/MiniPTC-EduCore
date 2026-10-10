using System;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmPrincipalProfesor : Form
    {
        private Form formularioActivo;
        private int idProfesorLogueado;

        public frmPrincipalProfesor()
        {
            InitializeComponent();
            CargarRecursos();
            CargarProfesorActual();
        }

        public frmPrincipalProfesor(int idProfesor) : this()
        {
            idProfesorLogueado = idProfesor;
        }

        private void frmPrincipalProfesor_Load(object sender, EventArgs e)
        {
            AjustarNavegacion();
            MostrarMaterias();
        }

        private void frmPrincipalProfesor_Resize(object sender, EventArgs e)
        {
            AjustarNavegacion();
        }

        private void CargarProfesorActual()
        {
            idProfesorLogueado = 2;

            if (Sesion.UsuarioActual != null)
            {
                idProfesorLogueado = Sesion.UsuarioActual.IdUsuario;
                lblNombreProfesor.Text = Sesion.UsuarioActual.NombreCompleto;
                return;
            }

            lblNombreProfesor.Text = "Profesor";
        }

        private void AjustarNavegacion()
        {
            int anchoLateral;

            anchoLateral = 287;

            if (ClientSize.Width < 1600)
            {
                anchoLateral = 250;
            }

            if (ClientSize.Width < 1250)
            {
                anchoLateral = 220;
            }

            pnlSideNav.Width = anchoLateral;
        }

        private void CargarRecursos()
        {
            picLogo.Image = RecursosVisuales.CargarImagen("LogoAcademico.png");
            picUsuarioSuperior.Image = RecursosVisuales.CargarImagen("icon_user.png");
            picUsuarioLateral.Image = RecursosVisuales.CargarImagen("icon_user.png");

            ucMaterias.ArchivoIcono = "icon_book.png";
            ucCalificaciones.ArchivoIcono = "icon_grades.png";
        }

        private void ucMaterias_BotonClick(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        private void ucCalificaciones_BotonClick(object sender, EventArgs e)
        {
            MostrarCalificaciones(0);
        }

        private void MostrarMaterias()
        {
            frmMateriasProfesor formulario;

            formulario = new frmMateriasProfesor(idProfesorLogueado);
            formulario.RegistrarCalificaciones += new EventHandler(formulario_RegistrarCalificaciones);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucMaterias);
        }

        private void MostrarCalificaciones(int idMateria)
        {
            frmRegistrarCalificacionesProfesor formulario;

            formulario = new frmRegistrarCalificacionesProfesor(idProfesorLogueado, idMateria);
            formulario.VolverMaterias += new EventHandler(formulario_VolverMaterias);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucCalificaciones);
        }

        private void formulario_RegistrarCalificaciones(object sender, EventArgs e)
        {
            frmMateriasProfesor formulario;

            formulario = sender as frmMateriasProfesor;

            if (formulario == null)
            {
                return;
            }

            MostrarCalificaciones(formulario.IdMateriaSeleccionada);
        }

        private void formulario_VolverMaterias(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        private void AbrirFormulario(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo.Dispose();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void SeleccionarMenu(UCBotonMenu menuActivo)
        {
            ucMaterias.Seleccionado = false;
            ucCalificaciones.Seleccionado = false;
            menuActivo.Seleccionado = true;
        }
    }
}
