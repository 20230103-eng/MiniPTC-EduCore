using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmMateriasEstudiante : Form
    {
        private int idEstudianteLogueado;
        private Materia materiaModelo;
        private Calificacion calificacionModelo;

        public event EventHandler VerCalificaciones;
        public int IdMateriaSeleccionada { get; private set; }

        public frmMateriasEstudiante()
        {
            InitializeComponent();
            materiaModelo = new Materia();
            calificacionModelo = new Calificacion();
            idEstudianteLogueado = 4;
            ConfigurarVista();
        }

        public frmMateriasEstudiante(int idEstudiante) : this()
        {
            idEstudianteLogueado = idEstudiante;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Mis materias";
            ucEncabezado.Subtitulo = "Consulta las materias en las que estás inscrito y revisa sus calificaciones.";
            ucBuscar.TextoVacio = "Buscar por código, materia o profesor";
            EstilosFormulario.AplicarGrid(dgvMaterias);
            EstilosFormulario.AplicarBotonSecundario(btnVerCalificaciones);

            ucKpiTotal.Titulo = "Materias";
            ucKpiTotal.Detalle = "Materias inscritas";
            ucKpiTotal.ArchivoIcono = "kpi_book.png";
            ucKpiTotal.ColorAcento = ColoresInterfaz.AzulOscuro;
            ucKpiTotal.ColorIcono = Color.FromArgb(235, 244, 252);

            ucKpiAprobadas.Titulo = "Aprobadas";
            ucKpiAprobadas.Detalle = "Promedio de 6 o más";
            ucKpiAprobadas.ArchivoIcono = "action_eye.png";
            ucKpiAprobadas.ColorAcento = Color.FromArgb(87, 153, 112);
            ucKpiAprobadas.ColorIcono = ColoresInterfaz.VerdeFondo;

            ucKpiDesaprobadas.Titulo = "Desaprobadas";
            ucKpiDesaprobadas.Detalle = "Promedio menor a 6";
            ucKpiDesaprobadas.ArchivoIcono = "icon_grades.png";
            ucKpiDesaprobadas.ColorAcento = ColoresInterfaz.Coral;
            ucKpiDesaprobadas.ColorIcono = Color.FromArgb(255, 235, 229);

            ucKpiEnCurso.Titulo = "En curso";
            ucKpiEnCurso.Detalle = "Sin notas todavía";
            ucKpiEnCurso.ArchivoIcono = "icon_book.png";
            ucKpiEnCurso.ColorAcento = ColoresInterfaz.AzulClaro;
            ucKpiEnCurso.ColorIcono = ColoresInterfaz.CelesteClaro;
        }

        private void frmMateriasEstudiante_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            DataTable tabla;
            DataTable tablaCompleta;
            DataTable calificaciones;

            tabla = materiaModelo.ObtenerMateriasPorEstudiante(idEstudianteLogueado, ucBuscar.Texto);
            tablaCompleta = materiaModelo.ObtenerMateriasPorEstudiante(idEstudianteLogueado, "");
            calificaciones = calificacionModelo.ObtenerCalificacionesPorEstudiante(idEstudianteLogueado);

            AgregarPromedios(tabla, calificaciones);
            AgregarPromedios(tablaCompleta, calificaciones);

            dgvMaterias.DataSource = tabla;
            ConfigurarColumnas();
            CargarIndicadores(tablaCompleta);
            lblCantidad.Text = tabla.Rows.Count.ToString() + " materias mostradas";
        }

        private void AgregarPromedios(DataTable tabla, DataTable calificaciones)
        {
            int i;
            int idMateria;

            if (tabla.Columns.Contains("Promedio") == false)
            {
                tabla.Columns.Add("Promedio", typeof(string));
            }

            for (i = 0; i < tabla.Rows.Count; i++)
            {
                idMateria = Convert.ToInt32(tabla.Rows[i]["IdMateria"]);
                tabla.Rows[i]["Promedio"] = ObtenerPromedioMateria(calificaciones, idMateria);
            }
        }

        private void CargarIndicadores(DataTable materias)
        {
            int i;
            int aprobadas;
            int desaprobadas;
            int enCurso;
            decimal promedio;
            string texto;

            aprobadas = 0;
            desaprobadas = 0;
            enCurso = 0;

            for (i = 0; i < materias.Rows.Count; i++)
            {
                texto = materias.Rows[i]["Promedio"].ToString();

                if (texto == "--" || decimal.TryParse(texto, out promedio) == false)
                {
                    enCurso = enCurso + 1;
                }
                else if (promedio >= 6)
                {
                    aprobadas = aprobadas + 1;
                }
                else
                {
                    desaprobadas = desaprobadas + 1;
                }
            }

            ucKpiTotal.Valor = materias.Rows.Count.ToString();
            ucKpiAprobadas.Valor = aprobadas.ToString();
            ucKpiDesaprobadas.Valor = desaprobadas.ToString();
            ucKpiEnCurso.Valor = enCurso.ToString();
        }

        private string ObtenerPromedioMateria(DataTable calificaciones, int idMateria)
        {
            int i;
            int cantidad;
            decimal suma;
            decimal nota;
            decimal promedio;

            cantidad = 0;
            suma = 0;

            for (i = 0; i < calificaciones.Rows.Count; i++)
            {
                if (Convert.ToInt32(calificaciones.Rows[i]["IdMateria"]) == idMateria && calificaciones.Rows[i]["Nota"] != DBNull.Value)
                {
                    nota = Convert.ToDecimal(calificaciones.Rows[i]["Nota"]);
                    suma = suma + nota;
                    cantidad = cantidad + 1;
                }
            }

            if (cantidad == 0)
            {
                return "--";
            }

            promedio = suma / cantidad;
            return promedio.ToString("0.00");
        }

        private void ConfigurarColumnas()
        {
            if (dgvMaterias.Columns["IdMateria"] != null)
            {
                dgvMaterias.Columns["IdMateria"].Visible = false;
            }

            if (dgvMaterias.Columns["Codigo"] != null)
            {
                dgvMaterias.Columns["Codigo"].HeaderText = "Código";
                dgvMaterias.Columns["Codigo"].FillWeight = 22;
            }

            if (dgvMaterias.Columns["Nombre"] != null)
            {
                dgvMaterias.Columns["Nombre"].HeaderText = "Materia";
                dgvMaterias.Columns["Nombre"].FillWeight = 40;
            }

            if (dgvMaterias.Columns["Profesor"] != null)
            {
                dgvMaterias.Columns["Profesor"].HeaderText = "Profesor";
                dgvMaterias.Columns["Profesor"].FillWeight = 38;
            }

            if (dgvMaterias.Columns["Promedio"] != null)
            {
                dgvMaterias.Columns["Promedio"].HeaderText = "Promedio";
                dgvMaterias.Columns["Promedio"].FillWeight = 18;
                dgvMaterias.Columns["Promedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMaterias.Columns["Estado"] != null)
            {
                dgvMaterias.Columns["Estado"].HeaderText = "Activa";
                dgvMaterias.Columns["Estado"].FillWeight = 16;
            }
        }

        private void ucBuscar_TextoCambiado(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirCalificaciones();
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            AbrirCalificaciones();
        }

        private void AbrirCalificaciones()
        {
            if (dgvMaterias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una materia para consultar sus calificaciones.", "Mis materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IdMateriaSeleccionada = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["IdMateria"].Value);

            if (VerCalificaciones != null)
            {
                VerCalificaciones(this, EventArgs.Empty);
            }
        }
    }
}
