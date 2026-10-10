using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmCalificacionesEstudiante : Form
    {
        private int idEstudianteLogueado;
        private int idMateriaInicial;
        private Calificacion calificacionModelo;
        private Materia materiaModelo;
        private DataTable tablaCalificaciones;
        private bool cargandoFiltros;

        public frmCalificacionesEstudiante()
        {
            InitializeComponent();
            idEstudianteLogueado = 4;
            idMateriaInicial = 0;
            calificacionModelo = new Calificacion();
            materiaModelo = new Materia();
            tablaCalificaciones = new DataTable();
            cargandoFiltros = false;
            ConfigurarVista();
        }

        public frmCalificacionesEstudiante(int idEstudiante, int idMateria) : this()
        {
            idEstudianteLogueado = idEstudiante;
            idMateriaInicial = idMateria;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Mis calificaciones";
            ucEncabezado.Subtitulo = "Consulta tus evaluaciones y filtra los resultados por materia o período.";
            ucBuscar.TextoVacio = "Buscar evaluación, materia o profesor";

            ucKpiCantidad.Titulo = "Calificaciones";
            ucKpiCantidad.Detalle = "Resultados visibles";
            ucKpiCantidad.ArchivoIcono = "kpi_grades.png";
            ucKpiCantidad.ColorAcento = ColoresInterfaz.AzulOscuro;
            ucKpiCantidad.ColorIcono = Color.FromArgb(235, 244, 252);

            ucKpiProgreso.Titulo = "Progreso";
            ucKpiProgreso.Detalle = "Materias con calificaciones";
            ucKpiProgreso.ArchivoIcono = "kpi_book.png";
            ucKpiProgreso.ColorAcento = ColoresInterfaz.AzulClaro;
            ucKpiProgreso.ColorIcono = ColoresInterfaz.CelesteClaro;

            ucKpiPromedio.Titulo = "Promedio";
            ucKpiPromedio.Detalle = "Promedio de resultados visibles";
            ucKpiPromedio.ArchivoIcono = "icon_grades.png";
            ucKpiPromedio.ColorAcento = ColoresInterfaz.Coral;
            ucKpiPromedio.ColorIcono = Color.FromArgb(255, 235, 229);

            ucKpiMejor.Titulo = "Mejor nota";
            ucKpiMejor.Detalle = "Resultado más alto visible";
            ucKpiMejor.ArchivoIcono = "action_eye.png";
            ucKpiMejor.ColorAcento = Color.FromArgb(87, 153, 112);
            ucKpiMejor.ColorIcono = ColoresInterfaz.VerdeFondo;

            EstilosFormulario.AplicarGrid(dgvCalificaciones);
            EstilosFormulario.AplicarBotonSecundario(btnRestablecer);
        }

        private void frmCalificacionesEstudiante_Load(object sender, EventArgs e)
        {
            cargandoFiltros = true;
            CargarMaterias();
            CargarPeriodos();
            SeleccionarMateriaInicial();
            cargandoFiltros = false;

            tablaCalificaciones = calificacionModelo.ObtenerCalificacionesPorEstudiante(idEstudianteLogueado);
            CargarProgresoGeneral();
            AplicarFiltros();
        }

        private void CargarMaterias()
        {
            DataTable materias;
            DataTable opciones;
            DataRow fila;
            int i;

            materias = materiaModelo.ObtenerMateriasPorEstudiante(idEstudianteLogueado, "");
            opciones = new DataTable();
            opciones.Columns.Add("IdMateria", typeof(int));
            opciones.Columns.Add("Nombre", typeof(string));

            fila = opciones.NewRow();
            fila["IdMateria"] = 0;
            fila["Nombre"] = "Todas las materias";
            opciones.Rows.Add(fila);

            for (i = 0; i < materias.Rows.Count; i++)
            {
                fila = opciones.NewRow();
                fila["IdMateria"] = Convert.ToInt32(materias.Rows[i]["IdMateria"]);
                fila["Nombre"] = materias.Rows[i]["Nombre"].ToString();
                opciones.Rows.Add(fila);
            }

            cboMateria.DisplayMember = "Nombre";
            cboMateria.ValueMember = "IdMateria";
            cboMateria.DataSource = opciones;
        }

        private void CargarPeriodos()
        {
            cboPeriodo.Items.Clear();
            cboPeriodo.Items.Add("Todos");
            cboPeriodo.Items.Add("1");
            cboPeriodo.Items.Add("2");
            cboPeriodo.Items.Add("3");
            cboPeriodo.SelectedIndex = 0;
        }

        private void SeleccionarMateriaInicial()
        {
            int i;
            DataRowView fila;

            if (idMateriaInicial == 0)
            {
                cboMateria.SelectedIndex = 0;
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

            cboMateria.SelectedIndex = 0;
        }


        private void CargarProgresoGeneral()
        {
            DataTable materias;
            int totalMaterias;
            int materiasConCalificacion;
            int i;
            int j;
            int idMateria;
            bool tieneCalificacion;
            decimal progreso;

            materias = materiaModelo.ObtenerMateriasPorEstudiante(idEstudianteLogueado, "");
            totalMaterias = materias.Rows.Count;
            materiasConCalificacion = 0;

            for (i = 0; i < materias.Rows.Count; i++)
            {
                idMateria = Convert.ToInt32(materias.Rows[i]["IdMateria"]);
                tieneCalificacion = false;

                for (j = 0; j < tablaCalificaciones.Rows.Count; j++)
                {
                    if (Convert.ToInt32(tablaCalificaciones.Rows[j]["IdMateria"]) == idMateria &&
                        tablaCalificaciones.Rows[j]["Nota"] != DBNull.Value)
                    {
                        tieneCalificacion = true;
                        break;
                    }
                }

                if (tieneCalificacion)
                {
                    materiasConCalificacion = materiasConCalificacion + 1;
                }
            }

            progreso = 0;

            if (totalMaterias > 0)
            {
                progreso = materiasConCalificacion * 100M / totalMaterias;
            }

            ucKpiProgreso.Valor = progreso.ToString("0") + "%";
        }

        private void AplicarFiltros()
        {
            DataTable filtrada;
            DataRow fila;
            int i;
            int idMateriaFiltro;
            int periodoFiltro;
            string texto;
            bool coincideMateria;
            bool coincidePeriodo;
            bool coincideTexto;
            string textoFila;

            if (tablaCalificaciones == null)
            {
                return;
            }

            filtrada = tablaCalificaciones.Clone();
            idMateriaFiltro = 0;
            periodoFiltro = 0;
            texto = ucBuscar.Texto.Trim().ToLower();

            if (cboMateria.SelectedValue != null)
            {
                int.TryParse(cboMateria.SelectedValue.ToString(), out idMateriaFiltro);
            }

            if (cboPeriodo.SelectedItem != null && cboPeriodo.SelectedItem.ToString() != "Todos")
            {
                int.TryParse(cboPeriodo.SelectedItem.ToString(), out periodoFiltro);
            }

            for (i = 0; i < tablaCalificaciones.Rows.Count; i++)
            {
                fila = tablaCalificaciones.Rows[i];
                coincideMateria = idMateriaFiltro == 0 || Convert.ToInt32(fila["IdMateria"]) == idMateriaFiltro;
                coincidePeriodo = periodoFiltro == 0 || Convert.ToInt32(fila["Periodo"]) == periodoFiltro;

                textoFila = fila["Materia"].ToString() + " " + fila["Profesor"].ToString() + " " + fila["NombreEvaluacion"].ToString();
                textoFila = textoFila.ToLower();
                coincideTexto = string.IsNullOrWhiteSpace(texto) || textoFila.Contains(texto);

                if (coincideMateria && coincidePeriodo && coincideTexto)
                {
                    filtrada.ImportRow(fila);
                }
            }

            dgvCalificaciones.DataSource = filtrada;
            ConfigurarColumnas();
            CargarIndicadores(filtrada);
        }

        private void ConfigurarColumnas()
        {
            if (dgvCalificaciones.Columns["IdCalificacion"] != null)
            {
                dgvCalificaciones.Columns["IdCalificacion"].Visible = false;
            }

            if (dgvCalificaciones.Columns["IdMateria"] != null)
            {
                dgvCalificaciones.Columns["IdMateria"].Visible = false;
            }

            if (dgvCalificaciones.Columns["CodigoMateria"] != null)
            {
                dgvCalificaciones.Columns["CodigoMateria"].HeaderText = "Código";
                dgvCalificaciones.Columns["CodigoMateria"].FillWeight = 16;
            }

            if (dgvCalificaciones.Columns["Materia"] != null)
            {
                dgvCalificaciones.Columns["Materia"].HeaderText = "Materia";
                dgvCalificaciones.Columns["Materia"].FillWeight = 28;
            }

            if (dgvCalificaciones.Columns["Profesor"] != null)
            {
                dgvCalificaciones.Columns["Profesor"].HeaderText = "Profesor";
                dgvCalificaciones.Columns["Profesor"].FillWeight = 26;
            }

            if (dgvCalificaciones.Columns["Periodo"] != null)
            {
                dgvCalificaciones.Columns["Periodo"].HeaderText = "Período";
                dgvCalificaciones.Columns["Periodo"].FillWeight = 12;
                dgvCalificaciones.Columns["Periodo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvCalificaciones.Columns["NombreEvaluacion"] != null)
            {
                dgvCalificaciones.Columns["NombreEvaluacion"].HeaderText = "Evaluación";
                dgvCalificaciones.Columns["NombreEvaluacion"].FillWeight = 28;
            }

            if (dgvCalificaciones.Columns["Nota"] != null)
            {
                dgvCalificaciones.Columns["Nota"].HeaderText = "Nota";
                dgvCalificaciones.Columns["Nota"].FillWeight = 12;
                dgvCalificaciones.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCalificaciones.Columns["Nota"].DefaultCellStyle.Format = "0.00";
            }

            if (dgvCalificaciones.Columns["Observacion"] != null)
            {
                dgvCalificaciones.Columns["Observacion"].HeaderText = "Observación";
                dgvCalificaciones.Columns["Observacion"].FillWeight = 26;
            }
        }

        private void CargarIndicadores(DataTable tabla)
        {
            int i;
            int cantidad;
            decimal suma;
            decimal nota;
            decimal promedio;
            decimal mejorNota;

            cantidad = 0;
            suma = 0;
            mejorNota = 0;

            for (i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i]["Nota"] != DBNull.Value)
                {
                    nota = Convert.ToDecimal(tabla.Rows[i]["Nota"]);
                    suma = suma + nota;
                    cantidad = cantidad + 1;

                    if (cantidad == 1 || nota > mejorNota)
                    {
                        mejorNota = nota;
                    }
                }
            }

            promedio = 0;

            if (cantidad > 0)
            {
                promedio = suma / cantidad;
            }

            ucKpiCantidad.Valor = cantidad.ToString();
            ucKpiPromedio.Valor = promedio.ToString("0.00");
            ucKpiMejor.Valor = mejorNota.ToString("0.00");
            lblResumen.Text = cantidad.ToString() + " calificaciones encontradas";
        }

        private void ucBuscar_TextoCambiado(object sender, EventArgs e)
        {
            if (cargandoFiltros)
            {
                return;
            }

            AplicarFiltros();
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros)
            {
                return;
            }

            AplicarFiltros();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros)
            {
                return;
            }

            AplicarFiltros();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            cargandoFiltros = true;
            ucBuscar.Texto = "";
            cboMateria.SelectedIndex = 0;
            cboPeriodo.SelectedIndex = 0;
            cargandoFiltros = false;
            AplicarFiltros();
        }
    }
}
