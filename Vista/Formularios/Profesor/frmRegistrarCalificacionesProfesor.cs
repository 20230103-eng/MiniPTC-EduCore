using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmRegistrarCalificacionesProfesor : Form
    {
        private const string nombreEvaluacion = "Calificación del periodo";
        private int idProfesorLogueado;
        private int idMateriaInicial;
        private Materia materiaModelo;
        private Calificacion calificacionModelo;

        public event EventHandler VolverMaterias;

        public frmRegistrarCalificacionesProfesor()
        {
            InitializeComponent();
            idProfesorLogueado = 2;
            idMateriaInicial = 0;
            materiaModelo = new Materia();
            calificacionModelo = new Calificacion();
            ConfigurarVista();
        }

        public frmRegistrarCalificacionesProfesor(int idProfesor, int idMateria) : this()
        {
            idProfesorLogueado = idProfesor;
            idMateriaInicial = idMateria;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Registro de calificaciones";
            ucEncabezado.Subtitulo = "Selecciona una materia y un período. La columna Nota es la única editable.";
            EstilosFormulario.AplicarGrid(dgvCalificaciones);
            EstilosFormulario.AplicarBotonPrimario(btnGuardar);
            EstilosFormulario.AplicarBotonEliminar(btnEliminar);
            EstilosFormulario.AplicarBotonSecundario(btnVolver);
        }

        private void frmRegistrarCalificacionesProfesor_Load(object sender, EventArgs e)
        {
            CargarPeriodos();
            CargarMaterias();
            SeleccionarMateriaInicial();
            CargarEstudiantes();
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

        private void SeleccionarMateriaInicial()
        {
            int i;
            DataRowView fila;

            if (idMateriaInicial == 0)
            {
                return;
            }

            for (i = 0; i < cboMateria.Items.Count; i++)
            {
                fila = cboMateria.Items[i] as DataRowView;

                if (fila != null && Convert.ToInt32(fila["IdMateria"]) == idMateriaInicial)
                {
                    cboMateria.SelectedIndex = i;
                    return;
                }
            }
        }

        private void CargarEstudiantes()
        {
            int idMateria;
            int periodo;
            DataTable tabla;

            if (cboMateria.SelectedValue == null || cboPeriodo.SelectedItem == null)
            {
                dgvCalificaciones.DataSource = null;
                lblResumen.Text = "Selecciona una materia y un período.";
                return;
            }

            if (int.TryParse(cboMateria.SelectedValue.ToString(), out idMateria) == false)
            {
                return;
            }

            periodo = Convert.ToInt32(cboPeriodo.SelectedItem);
            tabla = calificacionModelo.ObtenerEstudiantesPorMateria(
                idProfesorLogueado,
                idMateria,
                periodo,
                nombreEvaluacion);

            dgvCalificaciones.DataSource = tabla;
            ConfigurarColumnas();
            lblResumen.Text = dgvCalificaciones.Rows.Count.ToString() + " estudiantes en la materia seleccionada";
        }

        private void ConfigurarColumnas()
        {
            DataGridViewColumn columna;

            columna = dgvCalificaciones.Columns["IdInscripcion"];
            if (columna != null)
            {
                columna.Visible = false;
            }

            columna = dgvCalificaciones.Columns["IdCalificacion"];
            if (columna != null)
            {
                columna.Visible = false;
            }

            columna = dgvCalificaciones.Columns["Codigo"];
            if (columna != null)
            {
                columna.HeaderText = "Carnet / ID";
                columna.ReadOnly = true;
            }

            columna = dgvCalificaciones.Columns["Estudiante"];
            if (columna != null)
            {
                columna.ReadOnly = true;
            }

            columna = dgvCalificaciones.Columns["Nota"];
            if (columna != null)
            {
                columna.HeaderText = "Nota";
                columna.ReadOnly = false;
            }
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                CargarEstudiantes();
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                CargarEstudiantes();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int periodo;
            int cantidadGuardada;
            bool exito;
            DataGridViewRow fila;

            if (cboPeriodo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un período.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            periodo = Convert.ToInt32(cboPeriodo.SelectedItem);
            cantidadGuardada = 0;
            exito = true;

            foreach (DataGridViewRow filaActual in dgvCalificaciones.Rows)
            {
                fila = filaActual;

                if (fila.IsNewRow)
                {
                    continue;
                }

                if (GuardarFila(fila, periodo, ref cantidadGuardada) == false)
                {
                    exito = false;
                    break;
                }
            }

            if (exito == false)
            {
                return;
            }

            if (cantidadGuardada == 0)
            {
                MessageBox.Show("Ingresa al menos una nota antes de guardar.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Las calificaciones se guardaron correctamente.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEstudiantes();
        }

        private bool GuardarFila(DataGridViewRow fila, int periodo, ref int cantidadGuardada)
        {
            string textoNota;
            decimal nota;
            int idCalificacion;
            Calificacion calificacion;
            bool guardado;

            if (fila.Cells["Nota"].Value == null || fila.Cells["Nota"].Value == DBNull.Value)
            {
                return true;
            }

            textoNota = fila.Cells["Nota"].Value.ToString().Trim();

            if (string.IsNullOrWhiteSpace(textoNota))
            {
                return true;
            }

            if (decimal.TryParse(textoNota, out nota) == false || nota < 0 || nota > 10)
            {
                MessageBox.Show("La nota de " + fila.Cells["Estudiante"].Value.ToString() + " debe estar entre 0.00 y 10.00.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            idCalificacion = 0;

            if (fila.Cells["IdCalificacion"].Value != null && fila.Cells["IdCalificacion"].Value != DBNull.Value)
            {
                idCalificacion = Convert.ToInt32(fila.Cells["IdCalificacion"].Value);
            }

            calificacion = new Calificacion();
            calificacion.IdCalificacion = idCalificacion;
            calificacion.IdInscripcion = Convert.ToInt32(fila.Cells["IdInscripcion"].Value);
            calificacion.Periodo = periodo;
            calificacion.NombreEvaluacion = nombreEvaluacion;
            calificacion.Nota = nota;
            calificacion.Observacion = "";

            if (idCalificacion == 0)
            {
                guardado = calificacion.Insertar();
            }
            else
            {
                guardado = calificacion.Modificar();
            }

            if (guardado)
            {
                cantidadGuardada = cantidadGuardada + 1;
            }

            return guardado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            object valorId;
            int idCalificacion;
            DialogResult respuesta;
            Calificacion calificacion;

            if (dgvCalificaciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un estudiante.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            valorId = dgvCalificaciones.CurrentRow.Cells["IdCalificacion"].Value;

            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("El estudiante seleccionado todavía no tiene una nota registrada para este período.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            idCalificacion = Convert.ToInt32(valorId);
            respuesta = MessageBox.Show("¿Deseas eliminar la nota del estudiante seleccionado?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            calificacion = new Calificacion();
            calificacion.IdCalificacion = idCalificacion;

            if (calificacion.Eliminar())
            {
                MessageBox.Show("La nota se eliminó correctamente.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstudiantes();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (VolverMaterias != null)
            {
                VolverMaterias(this, EventArgs.Empty);
            }
        }
    }
}
