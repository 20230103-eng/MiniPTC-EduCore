using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPanelAdministrador : Form
    {
        private Usuario usuarioModelo;
        private Materia materiaModelo;
        private Calificacion calificacionModelo;
        private DataTable usuarios;

        public event EventHandler AbrirUsuarios;

        public frmPanelAdministrador()
        {
            InitializeComponent();
            usuarioModelo = new Usuario();
            materiaModelo = new Materia();
            calificacionModelo = new Calificacion();
            ConfigurarBotones();
        }

        private void frmPanelAdministrador_Load(object sender, EventArgs e)
        {
            ucTipo.CargarTipos();

            if (Conexion.ProbarConexion())
            {
                CargarIndicadores();
                CargarUsuarios();
            }
        }

        private void CargarIndicadores()
        {
            ucEstudiantes.Valor = usuarioModelo.ContarPorTipo("Estudiante").ToString();
            ucProfesores.Valor = usuarioModelo.ContarPorTipo("Profesor").ToString();
            ucMaterias.Valor = materiaModelo.Contar().ToString();
            ucCalificaciones.Valor = calificacionModelo.Contar().ToString();
        }

        private void CargarUsuarios()
        {
            usuarios = usuarioModelo.ObtenerUsuarios();
            ucTablaUsuarios.CargarUsuarios(usuarios);
        }

        private void AplicarFiltro()
        {
            ucTablaUsuarios.AplicarFiltro(ucBuscar.Texto, ucTipo.TipoSeleccionado);
        }

        private void ucBuscar_TextoCambiado(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void ucTipo_SeleccionCambiada(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void ucTablaUsuarios_VerUsuario(object sender, UsuarioTablaEventArgs e)
        {
            AbrirGestionUsuarios();
        }

        private void ucTablaUsuarios_EditarUsuario(object sender, UsuarioTablaEventArgs e)
        {
            AbrirGestionUsuarios();
        }

        private void ucTablaUsuarios_EliminarUsuario(object sender, UsuarioTablaEventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show(
                "¿Deseas eliminar este usuario?",
                "Usuarios",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                usuarioModelo.IdUsuario = e.IdUsuario;

                if (usuarioModelo.Eliminar())
                {
                    CargarIndicadores();
                    CargarUsuarios();
                    AplicarFiltro();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ucBuscar.Texto = "";
            ucTipo.CargarTipos();
            AplicarFiltro();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            AbrirGestionUsuarios();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            AbrirGestionUsuarios();
        }

        private void AbrirGestionUsuarios()
        {
            if (AbrirUsuarios != null)
            {
                AbrirUsuarios(this, EventArgs.Empty);
            }
        }

        private void ConfigurarBotones()
        {
            btnGuardarCambios.Image = RecursosVisuales.CargarImagen("action_save.png", 18, 18);
            btnGuardarCambios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarCambios.TextImageRelation = TextImageRelation.ImageBeforeText;

            btnNuevoRegistro.Image = RecursosVisuales.CargarImagen("action_plus.png", 18, 18);
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;

            BordesRedondeados.AplicarRegion(btnCancelar, 6);
            BordesRedondeados.AplicarRegion(btnGuardarCambios, 6);
            BordesRedondeados.AplicarRegion(btnNuevoRegistro, 6);
        }
    }
}
