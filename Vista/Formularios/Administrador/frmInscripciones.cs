using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmInscripciones : Form
    {
        private Inscripcion inscripcionModelo;
        private Usuario usuarioModelo;
        private Materia materiaModelo;
        private int idInscripcionSeleccionada;

        public frmInscripciones()
        {
            InitializeComponent();
            inscripcionModelo = new Inscripcion();
            usuarioModelo = new Usuario();
            materiaModelo = new Materia();
            idInscripcionSeleccionada = 0;
            EstilosFormulario.AplicarFormularioCrud(this, pnlEncabezado, lblTitulo, lblModo, pnlFormulario, dgvInscripciones, btnNuevo, btnGuardar, btnEliminar);
        }

        private void frmInscripciones_Load(object sender, EventArgs e)
        {
            if (Conexion.ProbarConexion() == false)
            {
                return;
            }

            CargarEstudiantes();
            CargarMaterias();
            CargarInscripciones();
            LimpiarFormulario();
        }

        private void CargarEstudiantes()
        {
            DataTable estudiantes;

            estudiantes = usuarioModelo.ObtenerUsuariosPorTipo("Estudiante");
            cboEstudiante.DataSource = estudiantes;
            cboEstudiante.DisplayMember = "NombreCompleto";
            cboEstudiante.ValueMember = "IdUsuario";
        }

        private void CargarMaterias()
        {
            DataTable materias;

            materias = materiaModelo.ObtenerMaterias();
            cboMateria.DataSource = materias;
            cboMateria.DisplayMember = "Nombre";
            cboMateria.ValueMember = "IdMateria";
        }

        private void CargarInscripciones()
        {
            dgvInscripciones.DataSource = inscripcionModelo.ObtenerInscripciones();

            if (dgvInscripciones.Columns.Contains("IdInscripcion"))
            {
                dgvInscripciones.Columns["IdInscripcion"].Visible = false;
            }

            if (dgvInscripciones.Columns.Contains("IdEstudiante"))
            {
                dgvInscripciones.Columns["IdEstudiante"].Visible = false;
            }

            if (dgvInscripciones.Columns.Contains("IdMateria"))
            {
                dgvInscripciones.Columns["IdMateria"].Visible = false;
            }

            if (dgvInscripciones.Columns.Contains("Descripcion"))
            {
                dgvInscripciones.Columns["Descripcion"].Visible = false;
            }
        }

        private bool ValidarCampos()
        {
            if (cboEstudiante.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el estudiante.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboMateria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione la materia.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool guardado;

            if (ValidarCampos() == false)
            {
                return;
            }

            inscripcionModelo.IdInscripcion = idInscripcionSeleccionada;
            inscripcionModelo.IdEstudiante = Convert.ToInt32(cboEstudiante.SelectedValue);
            inscripcionModelo.IdMateria = Convert.ToInt32(cboMateria.SelectedValue);

            if (inscripcionModelo.Existe())
            {
                MessageBox.Show("El estudiante ya está inscrito en esa materia.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idInscripcionSeleccionada == 0)
            {
                guardado = inscripcionModelo.Insertar();
            }
            else
            {
                guardado = inscripcionModelo.Modificar();
            }

            if (guardado)
            {
                MessageBox.Show("La inscripción fue guardada correctamente.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInscripciones();
                LimpiarFormulario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (idInscripcionSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una inscripción.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar la inscripción seleccionada?", "Inscripciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            inscripcionModelo.IdInscripcion = idInscripcionSeleccionada;

            if (inscripcionModelo.Eliminar())
            {
                MessageBox.Show("La inscripción fue eliminada.", "Inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInscripciones();
                LimpiarFormulario();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvInscripciones.Rows[e.RowIndex];
            idInscripcionSeleccionada = Convert.ToInt32(fila.Cells["IdInscripcion"].Value);
            cboEstudiante.SelectedValue = Convert.ToInt32(fila.Cells["IdEstudiante"].Value);
            cboMateria.SelectedValue = Convert.ToInt32(fila.Cells["IdMateria"].Value);
            lblModo.Text = "Editando inscripción";
        }

        private void LimpiarFormulario()
        {
            idInscripcionSeleccionada = 0;

            if (cboEstudiante.Items.Count > 0)
            {
                cboEstudiante.SelectedIndex = 0;
            }

            if (cboMateria.Items.Count > 0)
            {
                cboMateria.SelectedIndex = 0;
            }

            lblModo.Text = "Nueva inscripción";
            cboEstudiante.Focus();
        }
    }
}
