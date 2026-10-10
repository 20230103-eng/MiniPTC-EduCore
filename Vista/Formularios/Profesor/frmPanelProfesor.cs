using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPanelProfesor : Form
    {
        private int idProfesorLogueado;
        private Materia materiaModelo;
        private Inscripcion inscripcionModelo;
        private Calificacion calificacionModelo;

        public int IdMateriaSeleccionada { get; private set; }
        public event EventHandler RegistrarCalificaciones;
        public event EventHandler VerMaterias;

        public frmPanelProfesor()
        {
            InitializeComponent();
            idProfesorLogueado = 2;
            materiaModelo = new Materia();
            inscripcionModelo = new Inscripcion();
            calificacionModelo = new Calificacion();
            ConfigurarVista();
        }

        public frmPanelProfesor(int idProfesor) : this()
        {
            idProfesorLogueado = idProfesor;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Panel del Profesor";
            ucEncabezado.Subtitulo = "Consulta tus materias, estudiantes y actividad de calificaciones.";

            ucKpiMaterias.Titulo = "Mis materias";
            ucKpiMaterias.Detalle = "Materias asignadas";
            ucKpiMaterias.ArchivoIcono = "kpi_book.png";
            ucKpiMaterias.ColorAcento = ColoresInterfaz.AzulOscuro;
            ucKpiMaterias.ColorIcono = Color.FromArgb(235, 244, 252);

            ucKpiEstudiantes.Titulo = "Estudiantes";
            ucKpiEstudiantes.Detalle = "Estudiantes únicos";
            ucKpiEstudiantes.ArchivoIcono = "kpi_students.png";
            ucKpiEstudiantes.ColorAcento = ColoresInterfaz.AzulClaro;
            ucKpiEstudiantes.ColorIcono = ColoresInterfaz.CelesteClaro;

            ucKpiCalificaciones.Titulo = "Calificaciones";
            ucKpiCalificaciones.Detalle = "Notas registradas";
            ucKpiCalificaciones.ArchivoIcono = "kpi_grades.png";
            ucKpiCalificaciones.ColorAcento = ColoresInterfaz.Coral;
            ucKpiCalificaciones.ColorIcono = Color.FromArgb(255, 235, 229);

            ucKpiPromedio.Titulo = "Promedio";
            ucKpiPromedio.Detalle = "Promedio de tus notas";
            ucKpiPromedio.ArchivoIcono = "icon_grades.png";
            ucKpiPromedio.ColorAcento = Color.FromArgb(87, 153, 112);
            ucKpiPromedio.ColorIcono = ColoresInterfaz.VerdeFondo;

            EstilosFormulario.AplicarBotonSecundario(btnVerMaterias);
            EstilosFormulario.AplicarBotonPrimario(btnRegistrarCalificaciones);
        }

        private void frmPanelProfesor_Load(object sender, EventArgs e)
        {
            CargarDashboard();
        }

        private void CargarDashboard()
        {
            DataTable materias;
            DataTable inscripciones;
            DataTable calificaciones;

            materias = materiaModelo.ObtenerMateriasPorProfesor(idProfesorLogueado, "");
            inscripciones = inscripcionModelo.ObtenerInscripcionesPorProfesor(idProfesorLogueado);
            calificaciones = calificacionModelo.ObtenerCalificacionesPorProfesor(idProfesorLogueado);

            CargarIndicadores(materias, inscripciones, calificaciones);
            CargarTarjetasMaterias(materias, inscripciones);
            CargarActividad(calificaciones);
        }

        private void CargarIndicadores(DataTable materias, DataTable inscripciones, DataTable calificaciones)
        {
            List<int> estudiantes;
            int i;
            int idEstudiante;
            decimal sumaNotas;
            int cantidadNotas;
            decimal nota;
            decimal promedio;

            estudiantes = new List<int>();

            for (i = 0; i < inscripciones.Rows.Count; i++)
            {
                idEstudiante = Convert.ToInt32(inscripciones.Rows[i]["IdEstudiante"]);

                if (estudiantes.Contains(idEstudiante) == false)
                {
                    estudiantes.Add(idEstudiante);
                }
            }

            sumaNotas = 0;
            cantidadNotas = 0;

            for (i = 0; i < calificaciones.Rows.Count; i++)
            {
                if (calificaciones.Rows[i]["Nota"] != DBNull.Value)
                {
                    nota = Convert.ToDecimal(calificaciones.Rows[i]["Nota"]);
                    sumaNotas = sumaNotas + nota;
                    cantidadNotas = cantidadNotas + 1;
                }
            }

            promedio = 0;

            if (cantidadNotas > 0)
            {
                promedio = sumaNotas / cantidadNotas;
            }

            ucKpiMaterias.Valor = materias.Rows.Count.ToString();
            ucKpiEstudiantes.Valor = estudiantes.Count.ToString();
            ucKpiCalificaciones.Valor = calificaciones.Rows.Count.ToString();
            ucKpiPromedio.Valor = promedio.ToString("0.00");
        }

        private void CargarTarjetasMaterias(DataTable materias, DataTable inscripciones)
        {
            int i;
            int idMateria;
            int cantidadEstudiantes;
            UCTarjetaMateriaProfesor tarjeta;

            flpMaterias.Controls.Clear();

            if (materias.Rows.Count == 0)
            {
                lblSinMaterias.Visible = true;
                return;
            }

            lblSinMaterias.Visible = false;

            for (i = 0; i < materias.Rows.Count; i++)
            {
                idMateria = Convert.ToInt32(materias.Rows[i]["IdMateria"]);
                cantidadEstudiantes = ContarEstudiantesMateria(inscripciones, idMateria);

                tarjeta = new UCTarjetaMateriaProfesor();
                tarjeta.IdMateria = idMateria;
                tarjeta.Codigo = materias.Rows[i]["Codigo"].ToString();
                tarjeta.Materia = materias.Rows[i]["Nombre"].ToString();
                tarjeta.CantidadEstudiantes = cantidadEstudiantes;
                tarjeta.Activa = Convert.ToBoolean(materias.Rows[i]["Estado"]);
                tarjeta.Margin = new Padding(0, 0, 14, 14);
                tarjeta.CalificarClick += new EventHandler(tarjeta_CalificarClick);

                flpMaterias.Controls.Add(tarjeta);
            }
        }

        private int ContarEstudiantesMateria(DataTable inscripciones, int idMateria)
        {
            int i;
            int cantidad;

            cantidad = 0;

            for (i = 0; i < inscripciones.Rows.Count; i++)
            {
                if (Convert.ToInt32(inscripciones.Rows[i]["IdMateria"]) == idMateria)
                {
                    cantidad = cantidad + 1;
                }
            }

            return cantidad;
        }

        private void CargarActividad(DataTable calificaciones)
        {
            int i;
            int cantidadMostrar;
            UCActividadProfesor actividad;
            string detalle;

            flpActividad.Controls.Clear();

            if (calificaciones.Rows.Count == 0)
            {
                lblSinActividad.Visible = true;
                return;
            }

            lblSinActividad.Visible = false;
            cantidadMostrar = calificaciones.Rows.Count;

            if (cantidadMostrar > 6)
            {
                cantidadMostrar = 6;
            }

            for (i = 0; i < cantidadMostrar; i++)
            {
                actividad = new UCActividadProfesor();
                actividad.Estudiante = calificaciones.Rows[i]["Estudiante"].ToString();
                detalle = calificaciones.Rows[i]["Materia"].ToString();
                detalle = detalle + " • " + calificaciones.Rows[i]["NombreEvaluacion"].ToString();
                detalle = detalle + " • Período " + calificaciones.Rows[i]["Periodo"].ToString();
                actividad.Detalle = detalle;
                actividad.Nota = Convert.ToDecimal(calificaciones.Rows[i]["Nota"]);
                actividad.Margin = new Padding(0, 0, 0, 10);
                actividad.Width = ObtenerAnchoActividad();

                flpActividad.Controls.Add(actividad);
            }
        }

        private int ObtenerAnchoActividad()
        {
            int ancho;

            ancho = flpActividad.ClientSize.Width - 22;

            if (ancho < 220)
            {
                ancho = 220;
            }

            return ancho;
        }

        private void flpActividad_SizeChanged(object sender, EventArgs e)
        {
            int i;
            UCActividadProfesor actividad;
            int ancho;

            ancho = ObtenerAnchoActividad();

            for (i = 0; i < flpActividad.Controls.Count; i++)
            {
                actividad = flpActividad.Controls[i] as UCActividadProfesor;

                if (actividad != null)
                {
                    actividad.Width = ancho;
                }
            }
        }

        private void tarjeta_CalificarClick(object sender, EventArgs e)
        {
            UCTarjetaMateriaProfesor tarjeta;

            tarjeta = sender as UCTarjetaMateriaProfesor;

            if (tarjeta == null)
            {
                return;
            }

            IdMateriaSeleccionada = tarjeta.IdMateria;

            if (RegistrarCalificaciones != null)
            {
                RegistrarCalificaciones(this, EventArgs.Empty);
            }
        }

        private void btnRegistrarCalificaciones_Click(object sender, EventArgs e)
        {
            IdMateriaSeleccionada = 0;

            if (RegistrarCalificaciones != null)
            {
                RegistrarCalificaciones(this, EventArgs.Empty);
            }
        }

        private void btnVerMaterias_Click(object sender, EventArgs e)
        {
            if (VerMaterias != null)
            {
                VerMaterias(this, EventArgs.Empty);
            }
        }

        private void pnlTarjeta_Paint(object sender, PaintEventArgs e)
        {
            Panel panel;
            Rectangle rectangulo;

            panel = sender as Panel;

            if (panel == null)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangulo = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            using (GraphicsPath ruta = BordesRedondeados.CrearRuta(rectangulo, 12))
            using (Pen lapiz = new Pen(ColoresInterfaz.Borde, 1))
            {
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }
    }
}
