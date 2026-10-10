using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmPrincipalEstudiante : Form
    {
        private Form formularioActivo;
        private int idEstudianteLogueado;
        private Usuario usuarioModelo;

        public frmPrincipalEstudiante()
        {
            InitializeComponent();
            usuarioModelo = new Usuario();
            idEstudianteLogueado = 4;

            if (Sesion.UsuarioActual != null)
            {
                idEstudianteLogueado = Sesion.UsuarioActual.IdUsuario;
            }

            CargarRecursos();
            CargarDatosEstudiante();
        }

        public frmPrincipalEstudiante(int idEstudiante) : this()
        {
            idEstudianteLogueado = idEstudiante;
            CargarDatosEstudiante();
        }

        private void frmPrincipalEstudiante_Load(object sender, EventArgs e)
        {
            AjustarNavegacion();
            MostrarInicio();
        }

        private void frmPrincipalEstudiante_Resize(object sender, EventArgs e)
        {
            AjustarNavegacion();
        }

        private void CargarDatosEstudiante()
        {
            DataTable tabla;

            if (Sesion.UsuarioActual != null && Sesion.UsuarioActual.IdUsuario == idEstudianteLogueado)
            {
                lblNombreEstudiante.Text = Sesion.UsuarioActual.NombreCompleto;
                lblRolSuperior.Text = "Estudiante";
                lblRolLateral.Text = "Estudiante";
                return;
            }

            tabla = usuarioModelo.ObtenerUsuarioPorId(idEstudianteLogueado);

            if (tabla.Rows.Count > 0)
            {
                lblNombreEstudiante.Text = tabla.Rows[0]["NombreCompleto"].ToString();
                lblRolSuperior.Text = tabla.Rows[0]["TipoUsuario"].ToString();
                lblRolLateral.Text = tabla.Rows[0]["TipoUsuario"].ToString();
            }
            else
            {
                lblNombreEstudiante.Text = "Estudiante";
                lblRolSuperior.Text = "Estudiante";
                lblRolLateral.Text = "Estudiante";
            }
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

        private void MostrarInicio()
        {
            frmPanelEstudiante formulario;

            formulario = new frmPanelEstudiante(idEstudianteLogueado);
            formulario.VerMaterias += new EventHandler(formularioPanel_VerMaterias);
            formulario.VerCalificaciones += new EventHandler(formularioPanel_VerCalificaciones);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucInicio);
        }

        private void MostrarMaterias()
        {
            frmMateriasEstudiante formulario;

            formulario = new frmMateriasEstudiante(idEstudianteLogueado);
            formulario.VerCalificaciones += new EventHandler(formularioMaterias_VerCalificaciones);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucMaterias);
        }

        private void MostrarCalificaciones(int idMateria)
        {
            frmCalificacionesEstudiante formulario;

            formulario = new frmCalificacionesEstudiante(idEstudianteLogueado, idMateria);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucCalificaciones);
        }

        private void formularioPanel_VerMaterias(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        private void formularioPanel_VerCalificaciones(object sender, EventArgs e)
        {
            frmPanelEstudiante formulario;

            formulario = sender as frmPanelEstudiante;

            if (formulario == null)
            {
                return;
            }

            MostrarCalificaciones(formulario.IdMateriaSeleccionada);
        }

        private void formularioMaterias_VerCalificaciones(object sender, EventArgs e)
        {
            frmMateriasEstudiante formulario;

            formulario = sender as frmMateriasEstudiante;

            if (formulario == null)
            {
                return;
            }

            MostrarCalificaciones(formulario.IdMateriaSeleccionada);
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
            menuActivo.Seleccionado = true;
        }
    }
}
