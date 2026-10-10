using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmPrincipalAdministrador : Form
    {
        private Form formularioActivo;

        public frmPrincipalAdministrador()
        {
            InitializeComponent();
            CargarRecursos();
        }

        private void frmPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            AjustarNavegacion();
            MostrarPanelAdministrador();
        }

        private void frmPrincipalAdministrador_Resize(object sender, EventArgs e)
        {
            AjustarNavegacion();
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
        }

        private void ucInicio_BotonClick(object sender, EventArgs e)
        {
            MostrarPanelAdministrador();
        }

        private void ucEstudiantes_BotonClick(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEstudiantes());
            SeleccionarMenu(ucEstudiantes);
        }

        private void ucProfesores_BotonClick(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProfesores());
            SeleccionarMenu(ucProfesores);
        }

        private void ucMaterias_BotonClick(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMaterias());
            SeleccionarMenu(ucMaterias);
        }

        private void ucCalificaciones_BotonClick(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCalificaciones());
            SeleccionarMenu(ucCalificaciones);
        }

        private void ucUsuarios_BotonClick(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios());
            SeleccionarMenu(ucUsuarios);
        }

        private void MostrarPanelAdministrador()
        {
            frmPanelAdministrador formulario;

            formulario = new frmPanelAdministrador();
            formulario.AbrirUsuarios += new EventHandler(formulario_AbrirUsuarios);
            AbrirFormulario(formulario);
            SeleccionarMenu(ucInicio);
        }

        private void formulario_AbrirUsuarios(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios());
            SeleccionarMenu(ucUsuarios);
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
            ucEstudiantes.Seleccionado = false;
            ucProfesores.Seleccionado = false;
            ucMaterias.Seleccionado = false;
            ucCalificaciones.Seleccionado = false;
            ucUsuarios.Seleccionado = false;

            menuActivo.Seleccionado = true;
        }
    }
}
