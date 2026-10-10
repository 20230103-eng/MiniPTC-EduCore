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
        private int idCalificacionSeleccionada;

        public frmCalificaciones()
        {
            InitializeComponent();
            calificacionModelo = new Calificacion();
            inscripcionModelo = new Inscripcion();
            idCalificacionSeleccionada = 0;
            EstilosFormulario.AplicarFormularioCrud(this, pnlEncabezado, lblTitulo, lblModo, pnlFormulario, dgvCalificaciones, btnNuevo, btnGuardar, btnEliminar);
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            if (Conexion.ProbarConexion() == false)
            {
                return;
            }

            CargarPeriodos();
            CargarInscripciones();
            CargarCalificaciones();
            LimpiarFormulario();
        }

        private void CargarPeriodos()
        {
            cboPeriodo.Items.Clear();
            cboPeriodo.Items.Add("1");
            cboPeriodo.Items.Add("2");
            cboPeriodo.Items.Add("3");
            cboPeriodo.Items.Add("4");
            cboPeriodo.SelectedIndex = 0;
        }

        private void CargarInscripciones()
        {
            DataTable inscripciones;

            inscripciones = inscripcionModelo.ObtenerInscripciones();
            cboInscripcion.DataSource = inscripciones;
            cboInscripcion.DisplayMember = "Descripcion";
            cboInscripcion.ValueMember = "IdInscripcion";
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

            if (dgvCalificaciones.Columns.Contains("NombreEvaluacion"))
            {
                dgvCalificaciones.Columns["NombreEvaluacion"].HeaderText = "Evaluación";
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

            if (string.IsNullOrWhiteSpace(txtEvaluacion.Text))
            {
                MessageBox.Show("Ingrese el nombre de la evaluación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            calificacionModelo.Periodo = Convert.ToInt32(cboPeriodo.Text);
            calificacionModelo.NombreEvaluacion = txtEvaluacion.Text.Trim();
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

        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvCalificaciones.Rows[e.RowIndex];
            idCalificacionSeleccionada = Convert.ToInt32(fila.Cells["IdCalificacion"].Value);
            cboInscripcion.SelectedValue = Convert.ToInt32(fila.Cells["IdInscripcion"].Value);
            cboPeriodo.Text = fila.Cells["Periodo"].Value.ToString();
            txtEvaluacion.Text = fila.Cells["NombreEvaluacion"].Value.ToString();
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
                lblPromedio.Text = "Promedio mostrado: " + promedio.ToString("0.00");
            }
            else
            {
                lblPromedio.Text = "Promedio mostrado: 0.00";
            }
        }

        private void LimpiarFormulario()
        {
            idCalificacionSeleccionada = 0;
            txtEvaluacion.Clear();
            txtNota.Clear();
            txtObservacion.Clear();

            if (cboPeriodo.Items.Count > 0)
            {
                cboPeriodo.SelectedIndex = 0;
            }

            if (cboInscripcion.Items.Count > 0)
            {
                cboInscripcion.SelectedIndex = 0;
            }

            lblModo.Text = "Nueva calificación";
        }
    }
}
