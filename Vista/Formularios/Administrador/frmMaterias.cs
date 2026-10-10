using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmMaterias : Form
    {
        private Materia materiaModelo;
        private Usuario usuarioModelo;
        private int idMateriaSeleccionada;

        public frmMaterias()
        {
            InitializeComponent();
            materiaModelo = new Materia();
            usuarioModelo = new Usuario();
            idMateriaSeleccionada = 0;
            EstilosFormulario.AplicarFormularioCrud(this, pnlEncabezado, lblTitulo, lblModo, pnlFormulario, dgvMaterias, btnNuevo, btnGuardar, btnEliminar);
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            if (Conexion.ProbarConexion() == false)
            {
                return;
            }

            CargarProfesores();
            CargarMaterias();
            LimpiarFormulario();
        }

        private void CargarProfesores()
        {
            DataTable profesores;

            profesores = usuarioModelo.ObtenerUsuariosPorTipo("Profesor");
            cboProfesor.DataSource = profesores;
            cboProfesor.DisplayMember = "NombreCompleto";
            cboProfesor.ValueMember = "IdUsuario";
        }

        private void CargarMaterias()
        {
            dgvMaterias.DataSource = materiaModelo.ObtenerMaterias();

            if (dgvMaterias.Columns.Contains("IdMateria"))
            {
                dgvMaterias.Columns["IdMateria"].Visible = false;
            }

            if (dgvMaterias.Columns.Contains("IdProfesor"))
            {
                dgvMaterias.Columns["IdProfesor"].Visible = false;
            }

            if (dgvMaterias.Columns.Contains("Codigo"))
            {
                dgvMaterias.Columns["Codigo"].HeaderText = "Código";
            }

            if (dgvMaterias.Columns.Contains("Estado"))
            {
                dgvMaterias.Columns["Estado"].HeaderText = "Activo";
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código de la materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboProfesor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el profesor.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            materiaModelo.IdMateria = idMateriaSeleccionada;
            materiaModelo.Codigo = txtCodigo.Text.Trim();
            materiaModelo.Nombre = txtNombre.Text.Trim();
            materiaModelo.IdProfesor = Convert.ToInt32(cboProfesor.SelectedValue);
            materiaModelo.Estado = chkEstado.Checked;

            if (idMateriaSeleccionada == 0)
            {
                guardado = materiaModelo.Insertar();
            }
            else
            {
                guardado = materiaModelo.Modificar();
            }

            if (guardado)
            {
                MessageBox.Show("La materia fue guardada correctamente.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMaterias();
                LimpiarFormulario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (idMateriaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar la materia seleccionada?", "Materias", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            materiaModelo.IdMateria = idMateriaSeleccionada;

            if (materiaModelo.Eliminar())
            {
                MessageBox.Show("La materia fue eliminada.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMaterias();
                LimpiarFormulario();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvMaterias.Rows[e.RowIndex];
            idMateriaSeleccionada = Convert.ToInt32(fila.Cells["IdMateria"].Value);
            txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            cboProfesor.SelectedValue = Convert.ToInt32(fila.Cells["IdProfesor"].Value);
            chkEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            lblModo.Text = "Editando materia";
        }

        private void LimpiarFormulario()
        {
            idMateriaSeleccionada = 0;
            txtCodigo.Clear();
            txtNombre.Clear();
            chkEstado.Checked = true;

            if (cboProfesor.Items.Count > 0)
            {
                cboProfesor.SelectedIndex = 0;
            }

            lblModo.Text = "Nueva materia";
            txtCodigo.Focus();
        }
    }
}
