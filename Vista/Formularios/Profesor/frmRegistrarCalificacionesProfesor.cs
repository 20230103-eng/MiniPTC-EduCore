using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmRegistrarCalificacionesProfesor : Form
    {
        private int idProfesorLogueado;
        private int idMateriaInicial;
        private Materia materiaModelo;
        private Calificacion calificacionModelo;
        private bool cargandoControles;

        public event EventHandler VolverMaterias;

        public frmRegistrarCalificacionesProfesor()
        {
            InitializeComponent();
            idProfesorLogueado = 2;
            idMateriaInicial = 0;
            materiaModelo = new Materia();
            calificacionModelo = new Calificacion();
            cargandoControles = false;
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
            ucEncabezado.Subtitulo = "Carga la evaluación y luego asigna o modifica la nota del estudiante seleccionado.";

            EstilosFormulario.AplicarGrid(dgvCalificaciones);
            EstilosFormulario.AplicarBotonPrimario(btnGuardar);
            EstilosFormulario.AplicarBotonEliminar(btnEliminar);
            EstilosFormulario.AplicarBotonSecundario(btnVolver);
            EstilosFormulario.AplicarBotonSecundario(btnCargar);
            EstilosFormulario.AplicarBotonPrimario(btnAplicarNota);
            EstilosFormulario.AplicarBotonEliminar(btnLimpiarEdicion);

            btnGuardar.Image = RecursosVisuales.CargarImagen("action_save.png", 18, 18);
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;

            btnCargar.Image = RecursosVisuales.CargarImagen("action_search.png", 16, 16);
            btnCargar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargar.TextImageRelation = TextImageRelation.ImageBeforeText;

            nudNota.DecimalPlaces = 2;
            nudNota.Increment = 0.25M;
            nudNota.Minimum = 0;
            nudNota.Maximum = 10;
            nudNota.Enabled = false;

            btnAplicarNota.Enabled = false;
            btnLimpiarEdicion.Enabled = false;
        }

        private void frmRegistrarCalificacionesProfesor_Load(object sender, EventArgs e)
        {
            cargandoControles = true;
            CargarPeriodos();
            CargarMaterias();
            SeleccionarMateriaInicial();
            cargandoControles = false;

            CargarEvaluaciones();
            CargarEstudiantes();
            ReaplicarBordesBotones();
        }

        private void frmRegistrarCalificacionesProfesor_Resize(object sender, EventArgs e)
        {
            ReaplicarBordesBotones();
        }

        private void ReaplicarBordesBotones()
        {
            BordesRedondeados.AplicarRegion(btnCargar, 6);
            BordesRedondeados.AplicarRegion(btnAplicarNota, 6);
            BordesRedondeados.AplicarRegion(btnLimpiarEdicion, 6);
            BordesRedondeados.AplicarRegion(btnGuardar, 6);
            BordesRedondeados.AplicarRegion(btnEliminar, 6);
            BordesRedondeados.AplicarRegion(btnVolver, 6);
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

        private void CargarEvaluaciones()
        {
            int idMateria;
            int periodo;
            DataTable tabla;
            string evaluacionActual;
            int i;
            string nombre;

            if (cboMateria.SelectedValue == null || cboPeriodo.SelectedItem == null)
            {
                cboEvaluacion.Items.Clear();
                cboEvaluacion.Text = "";
                return;
            }

            if (int.TryParse(cboMateria.SelectedValue.ToString(), out idMateria) == false)
            {
                return;
            }

            periodo = Convert.ToInt32(cboPeriodo.SelectedItem);
            evaluacionActual = cboEvaluacion.Text.Trim();
            tabla = calificacionModelo.ObtenerEvaluacionesPorMateria(idProfesorLogueado, idMateria, periodo);

            cargandoControles = true;
            cboEvaluacion.Items.Clear();

            for (i = 0; i < tabla.Rows.Count; i++)
            {
                nombre = tabla.Rows[i]["NombreEvaluacion"].ToString();

                if (string.IsNullOrWhiteSpace(nombre) == false && cboEvaluacion.Items.Contains(nombre) == false)
                {
                    cboEvaluacion.Items.Add(nombre);
                }
            }

            if (string.IsNullOrWhiteSpace(evaluacionActual) == false)
            {
                cboEvaluacion.Text = evaluacionActual;
            }
            else if (cboEvaluacion.Items.Count > 0)
            {
                cboEvaluacion.SelectedIndex = 0;
            }
            else
            {
                cboEvaluacion.Text = "Actividad 1";
            }

            cargandoControles = false;
        }

        private bool ValidarSeleccion()
        {
            if (cboMateria.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una materia.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cboPeriodo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un período.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboEvaluacion.Text))
            {
                MessageBox.Show("Escribe o selecciona el nombre de la evaluación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEvaluacion.Focus();
                return false;
            }

            return true;
        }

        private void CargarEstudiantes()
        {
            int idMateria;
            int periodo;
            DataTable tabla;
            string nombreEvaluacion;

            if (cboMateria.SelectedValue == null || cboPeriodo.SelectedItem == null)
            {
                dgvCalificaciones.DataSource = null;
                lblResumen.Text = "Selecciona una materia y un período.";
                lblPromedio.Text = "Promedio: 0.00";
                ReiniciarPanelEdicion();
                return;
            }

            nombreEvaluacion = cboEvaluacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreEvaluacion))
            {
                dgvCalificaciones.DataSource = null;
                lblResumen.Text = "Escribe o selecciona una evaluación para cargar los estudiantes.";
                lblPromedio.Text = "Promedio: 0.00";
                ReiniciarPanelEdicion();
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
            SeleccionarPrimeraFila();
            CalcularResumen();
            ActualizarPanelEdicion();
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
                columna.FillWeight = 28;
            }

            columna = dgvCalificaciones.Columns["Estudiante"];
            if (columna != null)
            {
                columna.HeaderText = "Estudiante";
                columna.ReadOnly = true;
                columna.FillWeight = 52;
            }

            columna = dgvCalificaciones.Columns["Nota"];
            if (columna != null)
            {
                columna.HeaderText = "Nota";
                columna.ReadOnly = true;
                columna.FillWeight = 20;
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                columna.DefaultCellStyle.BackColor = Color.FromArgb(255, 251, 242);
                columna.DefaultCellStyle.Format = "0.00";
            }
        }

        private void SeleccionarPrimeraFila()
        {
            if (dgvCalificaciones.Rows.Count > 0)
            {
                dgvCalificaciones.ClearSelection();
                dgvCalificaciones.Rows[0].Selected = true;
                dgvCalificaciones.CurrentCell = dgvCalificaciones.Rows[0].Cells["Codigo"];
            }
        }

        private void CalcularResumen()
        {
            int cantidadEstudiantes;
            int cantidadNotas;
            decimal suma;
            decimal nota;
            decimal promedio;
            DataGridViewRow fila;

            cantidadEstudiantes = 0;
            cantidadNotas = 0;
            suma = 0;

            foreach (DataGridViewRow filaActual in dgvCalificaciones.Rows)
            {
                fila = filaActual;

                if (fila.IsNewRow)
                {
                    continue;
                }

                cantidadEstudiantes = cantidadEstudiantes + 1;

                if (fila.Cells["Nota"].Value != null && fila.Cells["Nota"].Value != DBNull.Value)
                {
                    if (decimal.TryParse(fila.Cells["Nota"].Value.ToString(), out nota))
                    {
                        suma = suma + nota;
                        cantidadNotas = cantidadNotas + 1;
                    }
                }
            }

            promedio = 0;

            if (cantidadNotas > 0)
            {
                promedio = suma / cantidadNotas;
            }

            lblResumen.Text = cantidadEstudiantes.ToString() + " estudiantes • " + cantidadNotas.ToString() + " notas ingresadas";
            lblPromedio.Text = "Promedio: " + promedio.ToString("0.00");
        }

        private void ReiniciarPanelEdicion()
        {
            lblEstudianteSeleccionado.Text = "Selecciona un estudiante en la tabla.";
            nudNota.Value = 0;
            nudNota.Enabled = false;
            btnAplicarNota.Enabled = false;
            btnLimpiarEdicion.Enabled = false;
        }

        private void ActualizarPanelEdicion()
        {
            DataGridViewRow fila;
            decimal nota;
            string codigo;
            string estudiante;

            if (dgvCalificaciones.CurrentRow == null)
            {
                ReiniciarPanelEdicion();
                return;
            }

            fila = dgvCalificaciones.CurrentRow;

            if (fila.IsNewRow)
            {
                ReiniciarPanelEdicion();
                return;
            }

            codigo = fila.Cells["Codigo"].Value.ToString();
            estudiante = fila.Cells["Estudiante"].Value.ToString();
            lblEstudianteSeleccionado.Text = codigo + " - " + estudiante;
            nudNota.Enabled = true;
            btnAplicarNota.Enabled = true;
            btnLimpiarEdicion.Enabled = true;

            if (fila.Cells["Nota"].Value != null && fila.Cells["Nota"].Value != DBNull.Value)
            {
                if (decimal.TryParse(fila.Cells["Nota"].Value.ToString(), out nota))
                {
                    if (nota < nudNota.Minimum)
                    {
                        nota = nudNota.Minimum;
                    }

                    if (nota > nudNota.Maximum)
                    {
                        nota = nudNota.Maximum;
                    }

                    nudNota.Value = nota;
                    return;
                }
            }

            nudNota.Value = 0;
        }

        private void AplicarNotaSeleccionada()
        {
            DataGridViewRow fila;
            decimal nota;

            if (dgvCalificaciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un estudiante.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            fila = dgvCalificaciones.CurrentRow;

            if (fila.IsNewRow)
            {
                return;
            }

            nota = nudNota.Value;
            fila.Cells["Nota"].Value = nota.ToString("0.00");
            CalcularResumen();
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoControles)
            {
                return;
            }

            CargarEvaluaciones();
            CargarEstudiantes();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoControles)
            {
                return;
            }

            CargarEvaluaciones();
            CargarEstudiantes();
        }

        private void cboEvaluacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoControles)
            {
                return;
            }

            CargarEstudiantes();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion() == false)
            {
                return;
            }

            CargarEstudiantes();
        }

        private void btnAplicarNota_Click(object sender, EventArgs e)
        {
            AplicarNotaSeleccionada();
        }

        private void btnLimpiarEdicion_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila;

            if (dgvCalificaciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un estudiante.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            fila = dgvCalificaciones.CurrentRow;

            if (fila.IsNewRow)
            {
                return;
            }

            fila.Cells["Nota"].Value = DBNull.Value;
            nudNota.Value = 0;
            CalcularResumen();
        }

        private void nudNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AplicarNotaSeleccionada();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int periodo;
            int cantidadGuardada;
            bool exito;
            DataGridViewRow fila;
            string nombreEvaluacion;

            if (ValidarSeleccion() == false)
            {
                return;
            }

            periodo = Convert.ToInt32(cboPeriodo.SelectedItem);
            nombreEvaluacion = cboEvaluacion.Text.Trim();
            cantidadGuardada = 0;
            exito = true;

            foreach (DataGridViewRow filaActual in dgvCalificaciones.Rows)
            {
                fila = filaActual;

                if (fila.IsNewRow)
                {
                    continue;
                }

                if (GuardarFila(fila, periodo, nombreEvaluacion, ref cantidadGuardada) == false)
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
            CargarEvaluaciones();
            cboEvaluacion.Text = nombreEvaluacion;
            CargarEstudiantes();
        }

        private bool GuardarFila(DataGridViewRow fila, int periodo, string nombreEvaluacion, ref int cantidadGuardada)
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
                MessageBox.Show("El estudiante seleccionado todavía no tiene una nota registrada para esta evaluación.", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                CargarEvaluaciones();
                CargarEstudiantes();
            }
        }

        private void dgvCalificaciones_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarPanelEdicion();
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
