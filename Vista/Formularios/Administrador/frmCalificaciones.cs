using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmCalificaciones : Form
    {
        private Calificacion calificacionModelo;
        private Inscripcion inscripcionModelo;
        private Evaluacion evaluacionModelo;
        private int idCalificacionSeleccionada;
        private bool cargandoFormulario;

        public frmCalificaciones()
        {
            InitializeComponent();
            calificacionModelo = new Calificacion();
            inscripcionModelo = new Inscripcion();
            evaluacionModelo = new Evaluacion();
            idCalificacionSeleccionada = 0;
            cargandoFormulario = false;
            EstilosFormulario.AplicarFormularioCrud(this, pnlEncabezado, lblTitulo, lblModo, pnlFormulario, dgvCalificaciones, btnNuevo, btnGuardar, btnEliminar);
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            if (Conexion.ProbarConexion() == false)
            {
                return;
            }

            cargandoFormulario = true;
            CargarInscripciones();
            CargarEvaluaciones();
            cargandoFormulario = false;
            CargarCalificaciones();
            LimpiarFormulario();
        }

        private void CargarInscripciones()
        {
            DataTable inscripciones;

            inscripciones = inscripcionModelo.ObtenerInscripciones();
            cboInscripcion.DataSource = inscripciones;
            cboInscripcion.DisplayMember = "Descripcion";
            cboInscripcion.ValueMember = "IdInscripcion";
        }

        private int ObtenerIdMateriaSeleccionada()
        {
            DataRowView fila;

            fila = cboInscripcion.SelectedItem as DataRowView;

            if (fila == null)
            {
                return 0;
            }

            return Convert.ToInt32(fila["IdMateria"]);
        }

        private void CargarEvaluaciones()
        {
            DataTable evaluaciones;
            int idMateria;

            idMateria = ObtenerIdMateriaSeleccionada();

            if (idMateria == 0)
            {
                cboEvaluacion.DataSource = null;
                return;
            }

            evaluaciones = evaluacionModelo.ObtenerPorMateria(idMateria);

            if (evaluaciones.Columns.Contains("Descripcion") == false)
            {
                evaluaciones.Columns.Add("Descripcion", typeof(string));
            }

            foreach (DataRow fila in evaluaciones.Rows)
            {
                fila["Descripcion"] = "Período " + fila["Periodo"].ToString() + " - " + fila["Nombre"].ToString();
            }

            cboEvaluacion.DisplayMember = "Descripcion";
            cboEvaluacion.ValueMember = "IdEvaluacion";
            cboEvaluacion.DataSource = evaluaciones;
        }

        private void CargarCalificaciones()
        {
            dgvCalificaciones.DataSource = calificacionModelo.ObtenerCalificaciones();
            ConfigurarGrid();
            CalcularPromedio();
        }

        private void ConfigurarGrid()
        {
            if (dgvCalificaciones.Columns.Contains("IdCalificacion"))
            {
                dgvCalificaciones.Columns["IdCalificacion"].Visible = false;
            }

            if (dgvCalificaciones.Columns.Contains("IdInscripcion"))
            {
                dgvCalificaciones.Columns["IdInscripcion"].Visible = false;
            }

            if (dgvCalificaciones.Columns.Contains("IdEvaluacion"))
            {
                dgvCalificaciones.Columns["IdEvaluacion"].Visible = false;
            }

            if (dgvCalificaciones.Columns.Contains("NombreEvaluacion"))
            {
                dgvCalificaciones.Columns["NombreEvaluacion"].HeaderText = "Evaluación";
            }

            if (dgvCalificaciones.Columns.Contains("Periodo"))
            {
                dgvCalificaciones.Columns["Periodo"].HeaderText = "Período";
            }

            if (dgvCalificaciones.Columns.Contains("Nota"))
            {
                dgvCalificaciones.Columns["Nota"].HeaderText = "Nota";
            }
        }

        private bool ValidarCampos()
        {
            decimal nota;

            if (cboInscripcion.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el estudiante y la materia.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboEvaluacion.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una evaluación para la materia.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (decimal.TryParse(txtNota.Text, out nota) == false)
            {
                MessageBox.Show("Ingrese una nota válida.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nota < 0 || nota > 10)
            {
                MessageBox.Show("La nota debe estar entre 0 y 10.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            calificacionModelo.IdCalificacion = idCalificacionSeleccionada;
            calificacionModelo.IdInscripcion = Convert.ToInt32(cboInscripcion.SelectedValue);
            calificacionModelo.IdEvaluacion = Convert.ToInt32(cboEvaluacion.SelectedValue);
            calificacionModelo.Nota = Convert.ToDecimal(txtNota.Text);
            calificacionModelo.Observacion = txtObservacion.Text.Trim();

            if (idCalificacionSeleccionada == 0)
            {
                guardado = calificacionModelo.Insertar();
            }
            else
            {
                guardado = calificacionModelo.Modificar();
            }

            if (guardado)
            {
                MessageBox.Show("La calificación fue guardada correctamente.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCalificaciones();
                LimpiarFormulario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (idCalificacionSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una calificación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar la calificación seleccionada?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            calificacionModelo.IdCalificacion = idCalificacionSeleccionada;

            if (calificacionModelo.Eliminar())
            {
                MessageBox.Show("La calificación fue eliminada.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCalificaciones();
                LimpiarFormulario();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void cboInscripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario)
            {
                return;
            }

            CargarEvaluaciones();
        }

        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvCalificaciones.Rows[e.RowIndex];
            idCalificacionSeleccionada = Convert.ToInt32(fila.Cells["IdCalificacion"].Value);

            cargandoFormulario = true;
            cboInscripcion.SelectedValue = Convert.ToInt32(fila.Cells["IdInscripcion"].Value);
            CargarEvaluaciones();
            cboEvaluacion.SelectedValue = Convert.ToInt32(fila.Cells["IdEvaluacion"].Value);
            cargandoFormulario = false;

            txtNota.Text = fila.Cells["Nota"].Value.ToString();
            txtObservacion.Text = fila.Cells["Observacion"].Value.ToString();
            lblModo.Text = "Editando calificación";
        }

        private void CalcularPromedio()
        {
            decimal suma;
            decimal nota;
            decimal promedio;
            int cantidad;

            suma = 0;
            cantidad = 0;

            foreach (DataGridViewRow fila in dgvCalificaciones.Rows)
            {
                if (fila.IsNewRow == false && fila.Cells["Nota"].Value != null && fila.Cells["Nota"].Value != DBNull.Value)
                {
                    nota = Convert.ToDecimal(fila.Cells["Nota"].Value);
                    suma = suma + nota;
                    cantidad = cantidad + 1;
                }
            }

            if (cantidad > 0)
            {
                promedio = suma / cantidad;
                lblPromedio.Text = "Promedio: " + promedio.ToString("0.00");
            }
            else
            {
                lblPromedio.Text = "Promedio: 0.00";
            }
        }

        private void LimpiarFormulario()
        {
            idCalificacionSeleccionada = 0;
            txtNota.Clear();
            txtObservacion.Clear();

            cargandoFormulario = true;

            if (cboInscripcion.Items.Count > 0)
            {
                cboInscripcion.SelectedIndex = 0;
            }

            CargarEvaluaciones();

            if (cboEvaluacion.Items.Count > 0)
            {
                cboEvaluacion.SelectedIndex = 0;
            }

            cargandoFormulario = false;
            lblModo.Text = "Nueva calificación";
        }
    }
}
