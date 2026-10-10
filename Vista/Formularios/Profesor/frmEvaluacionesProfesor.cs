using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmEvaluacionesProfesor : Form
    {
        private int idProfesorLogueado;
        private int idEvaluacionSeleccionada;
        private Materia materiaModelo;
        private Evaluacion evaluacionModelo;

        public event EventHandler IrCalificaciones;
        public int IdMateriaSeleccionada { get; private set; }

        public frmEvaluacionesProfesor()
        {
            InitializeComponent();
            idProfesorLogueado = 2;
            idEvaluacionSeleccionada = 0;
            materiaModelo = new Materia();
            evaluacionModelo = new Evaluacion();
            ConfigurarVista();
        }

        public frmEvaluacionesProfesor(int idProfesor) : this()
        {
            idProfesorLogueado = idProfesor;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Evaluaciones";
            ucEncabezado.Subtitulo = "Crea y administra las evaluaciones de tus materias antes de registrar las notas.";

            EstilosFormulario.AplicarGrid(dgvEvaluaciones);
            EstilosFormulario.AplicarBotonSecundario(btnNuevo);
            EstilosFormulario.AplicarBotonPrimario(btnGuardar);
            EstilosFormulario.AplicarBotonEliminar(btnEliminar);
            EstilosFormulario.AplicarBotonSecundario(btnIrCalificaciones);
        }

        private void frmEvaluacionesProfesor_Load(object sender, EventArgs e)
        {
            CargarPeriodos();
            CargarMaterias();
            CargarEvaluaciones();
            LimpiarFormulario();
        }

        private void CargarPeriodos()
        {
            cboPeriodo.Items.Clear();
            cboPeriodo.Items.Add(1);
            cboPeriodo.Items.Add(2);
            cboPeriodo.Items.Add(3);
            cboPeriodo.SelectedIndex = 0;
        }

        private void CargarMaterias()
        {
            DataTable tabla;

            tabla = materiaModelo.ObtenerMateriasPorProfesor(idProfesorLogueado, "");
            cboMateria.DisplayMember = "Nombre";
            cboMateria.ValueMember = "IdMateria";
            cboMateria.DataSource = tabla;
        }

        private void CargarEvaluaciones()
        {
            DataTable tabla;

            tabla = evaluacionModelo.ObtenerPorProfesor(idProfesorLogueado);
            dgvEvaluaciones.DataSource = tabla;
            ConfigurarColumnas();
            lblCantidad.Text = tabla.Rows.Count.ToString() + " evaluaciones";
        }

        private void ConfigurarColumnas()
        {
            if (dgvEvaluaciones.Columns["IdEvaluacion"] != null)
            {
                dgvEvaluaciones.Columns["IdEvaluacion"].Visible = false;
            }

            if (dgvEvaluaciones.Columns["IdMateria"] != null)
            {
                dgvEvaluaciones.Columns["IdMateria"].Visible = false;
            }

            if (dgvEvaluaciones.Columns["Codigo"] != null)
            {
                dgvEvaluaciones.Columns["Codigo"].HeaderText = "Código";
                dgvEvaluaciones.Columns["Codigo"].FillWeight = 18;
            }

            if (dgvEvaluaciones.Columns["Materia"] != null)
            {
                dgvEvaluaciones.Columns["Materia"].HeaderText = "Materia";
                dgvEvaluaciones.Columns["Materia"].FillWeight = 35;
            }

            if (dgvEvaluaciones.Columns["Periodo"] != null)
            {
                dgvEvaluaciones.Columns["Periodo"].HeaderText = "Período";
                dgvEvaluaciones.Columns["Periodo"].FillWeight = 16;
                dgvEvaluaciones.Columns["Periodo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvEvaluaciones.Columns["Nombre"] != null)
            {
                dgvEvaluaciones.Columns["Nombre"].HeaderText = "Evaluación";
                dgvEvaluaciones.Columns["Nombre"].FillWeight = 35;
            }

            if (dgvEvaluaciones.Columns["Estado"] != null)
            {
                dgvEvaluaciones.Columns["Estado"].HeaderText = "Activa";
                dgvEvaluaciones.Columns["Estado"].FillWeight = 16;
            }
        }

        private bool ValidarCampos()
        {
            if (cboMateria.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una materia.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cboPeriodo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un período.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe el nombre de la evaluación.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
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

            evaluacionModelo.IdEvaluacion = idEvaluacionSeleccionada;
            evaluacionModelo.IdMateria = Convert.ToInt32(cboMateria.SelectedValue);
            evaluacionModelo.Periodo = Convert.ToInt32(cboPeriodo.SelectedItem);
            evaluacionModelo.Nombre = txtNombre.Text.Trim();
            evaluacionModelo.Estado = chkEstado.Checked;

            if (idEvaluacionSeleccionada == 0)
            {
                guardado = evaluacionModelo.Insertar(idProfesorLogueado);
            }
            else
            {
                guardado = evaluacionModelo.Modificar(idProfesorLogueado);
            }

            if (guardado)
            {
                MessageBox.Show("La evaluación se guardó correctamente.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEvaluaciones();
                LimpiarFormulario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (idEvaluacionSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una evaluación.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            respuesta = MessageBox.Show("¿Deseas eliminar la evaluación seleccionada?", "Evaluaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            evaluacionModelo.IdEvaluacion = idEvaluacionSeleccionada;

            if (evaluacionModelo.Eliminar(idProfesorLogueado))
            {
                MessageBox.Show("La evaluación se eliminó correctamente.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEvaluaciones();
                LimpiarFormulario();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnIrCalificaciones_Click(object sender, EventArgs e)
        {
            if (cboMateria.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una materia.", "Evaluaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IdMateriaSeleccionada = Convert.ToInt32(cboMateria.SelectedValue);

            if (IrCalificaciones != null)
            {
                IrCalificaciones(this, EventArgs.Empty);
            }
        }

        private void dgvEvaluaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvEvaluaciones.Rows[e.RowIndex];
            idEvaluacionSeleccionada = Convert.ToInt32(fila.Cells["IdEvaluacion"].Value);
            cboMateria.SelectedValue = Convert.ToInt32(fila.Cells["IdMateria"].Value);
            cboPeriodo.SelectedItem = Convert.ToInt32(fila.Cells["Periodo"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            lblModo.Text = "Editando evaluación";
        }

        private void LimpiarFormulario()
        {
            idEvaluacionSeleccionada = 0;
            txtNombre.Clear();
            chkEstado.Checked = true;

            if (cboPeriodo.Items.Count > 0)
            {
                cboPeriodo.SelectedIndex = 0;
            }

            if (cboMateria.Items.Count > 0)
            {
                cboMateria.SelectedIndex = 0;
            }

            lblModo.Text = "Nueva evaluación";
        }
    }
}
