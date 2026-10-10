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
            MostrarInicio();
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

            ucInicio.ArchivoIcono = "icon_home.png";
            ucMaterias.ArchivoIcono = "icon_book.png";
            ucCalificaciones.ArchivoIcono = "icon_grades.png";
            ucEvaluaciones.ArchivoIcono = "icon_edit.png";
            ucPerfil.ArchivoIcono = "icon_user.png";
            ucCerrarSesion.ArchivoIcono = "icon_delete.png";
        }

        private void ucInicio_BotonClick(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void ucMaterias_BotonClick(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        private void ucCalificaciones_BotonClick(object sender, EventArgs e)
        {
            MostrarCalificaciones(0);
        }

        private void ucEvaluaciones_BotonClick(object sender, EventArgs e)
        {
            MostrarEvaluaciones();
        }

        private void ucPerfil_BotonClick(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPerfilUsuario(idProfesorLogueado));
            SeleccionarMenu(ucPerfil);
        }

        private void ucCerrarSesion_BotonClick(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void MostrarInicio()
        {
            frmPanelProfesor formulario;

            formulario = new frmPanelProfesor(idProfesorLogueado);
            formulario.RegistrarCalificaciones += new EventHandler(formularioPanel_RegistrarCalificaciones);
            formulario.VerMaterias += new EventHandler(formularioPanel_VerMaterias);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucInicio);
        }

        private void MostrarMaterias()
        {
            frmMateriasProfesor formulario;

            formulario = new frmMateriasProfesor(idProfesorLogueado);
            formulario.RegistrarCalificaciones += new EventHandler(formulario_RegistrarCalificaciones);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucMaterias);
        }

        private void MostrarEvaluaciones()
        {
            frmEvaluacionesProfesor formulario;

            formulario = new frmEvaluacionesProfesor(idProfesorLogueado);
            formulario.IrCalificaciones += new EventHandler(formularioEvaluaciones_IrCalificaciones);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucEvaluaciones);
        }

        private void MostrarCalificaciones(int idMateria)
        {
            frmRegistrarCalificacionesProfesor formulario;

            formulario = new frmRegistrarCalificacionesProfesor(idProfesorLogueado, idMateria);
            formulario.VolverMaterias += new EventHandler(formulario_VolverMaterias);
            formulario.GestionarEvaluaciones += new EventHandler(formulario_GestionarEvaluaciones);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucCalificaciones);
        }

        private void formularioPanel_RegistrarCalificaciones(object sender, EventArgs e)
        {
            frmPanelProfesor formulario;

            formulario = sender as frmPanelProfesor;

            if (formulario == null)
            {
                return;
            }

            MostrarCalificaciones(formulario.IdMateriaSeleccionada);
        }

        private void formularioPanel_VerMaterias(object sender, EventArgs e)
        {
            MostrarMaterias();
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

        private void formulario_GestionarEvaluaciones(object sender, EventArgs e)
        {
            MostrarEvaluaciones();
        }

        private void formularioEvaluaciones_IrCalificaciones(object sender, EventArgs e)
        {
            frmEvaluacionesProfesor formulario;

            formulario = sender as frmEvaluacionesProfesor;

            if (formulario == null)
            {
                return;
            }

            MostrarCalificaciones(formulario.IdMateriaSeleccionada);
        }

        private void CerrarSesion()
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Deseas cerrar la sesión actual?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            Sesion.UsuarioActual = null;
            Close();
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
            ucInicio.Seleccionado = false;
            ucMaterias.Seleccionado = false;
            ucCalificaciones.Seleccionado = false;
            ucEvaluaciones.Seleccionado = false;
            ucPerfil.Seleccionado = false;
            ucCerrarSesion.Seleccionado = false;
            menuActivo.Seleccionado = true;
        }
    }
}
