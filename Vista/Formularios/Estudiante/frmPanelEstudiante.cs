using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmPanelEstudiante : Form
    {
        private int idEstudianteLogueado;
        private Materia materiaModelo;
        private Calificacion calificacionModelo;
        private DataTable tablaCalificacionesDashboard;

        public int IdMateriaSeleccionada { get; private set; }
        public event EventHandler VerMaterias;
        public event EventHandler VerCalificaciones;

        public frmPanelEstudiante()
        {
            InitializeComponent();
            idEstudianteLogueado = 4;
            materiaModelo = new Materia();
            calificacionModelo = new Calificacion();
            tablaCalificacionesDashboard = new DataTable();
            ConfigurarVista();
        }

        public frmPanelEstudiante(int idEstudiante) : this()
        {
            idEstudianteLogueado = idEstudiante;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Panel del Estudiante";
            ucEncabezado.Subtitulo = "Consulta tus materias y revisa tus calificaciones desde un solo lugar.";

            ucKpiMaterias.Titulo = "Mis materias";
            ucKpiMaterias.Detalle = "Materias inscritas";
            ucKpiMaterias.ArchivoIcono = "kpi_book.png";
            ucKpiMaterias.ColorAcento = ColoresInterfaz.AzulOscuro;
            ucKpiMaterias.ColorIcono = Color.FromArgb(235, 244, 252);

            ucKpiEstudiantes.Titulo = "Calificaciones";
            ucKpiEstudiantes.Detalle = "Notas registradas";
            ucKpiEstudiantes.ArchivoIcono = "kpi_grades.png";
            ucKpiEstudiantes.ColorAcento = ColoresInterfaz.AzulClaro;
            ucKpiEstudiantes.ColorIcono = ColoresInterfaz.CelesteClaro;

            ucKpiCalificaciones.Titulo = "Promedio general";
            ucKpiCalificaciones.Detalle = "Calculado con tus notas";
            ucKpiCalificaciones.ArchivoIcono = "icon_grades.png";
            ucKpiCalificaciones.ColorAcento = ColoresInterfaz.Coral;
            ucKpiCalificaciones.ColorIcono = Color.FromArgb(255, 235, 229);

            ucKpiPromedio.Titulo = "Mejor nota";
            ucKpiPromedio.Detalle = "Calificación más alta";
            ucKpiPromedio.ArchivoIcono = "action_eye.png";
            ucKpiPromedio.ColorAcento = Color.FromArgb(87, 153, 112);
            ucKpiPromedio.ColorIcono = ColoresInterfaz.VerdeFondo;

            lblTituloMaterias.Text = "Mis materias";
            lblTituloActividad.Text = "Calificaciones recientes";
            lblSinMaterias.Text = "No hay materias inscritas.";
            lblSinActividad.Text = "Todavía no hay calificaciones registradas.";
            ucBuscarActividad.TextoVacio = "Buscar materia o evaluación";

            EstilosFormulario.AplicarBotonSecundario(btnVerMaterias);
            EstilosFormulario.AplicarBotonPrimario(btnVerCalificaciones);

            flpMaterias.SizeChanged += new EventHandler(flpMaterias_SizeChanged);
        }

        private void frmPanelEstudiante_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null && Sesion.UsuarioActual.IdUsuario == idEstudianteLogueado)
            {
                ucEncabezado.Titulo = "Bienvenido, " + Sesion.UsuarioActual.NombreCompleto;
            }

            CargarDashboard();
        }

        private void CargarDashboard()
        {
            DataTable materias;
            DataTable calificaciones;

            materias = materiaModelo.ObtenerMateriasPorEstudiante(idEstudianteLogueado, "");
            calificaciones = calificacionModelo.ObtenerCalificacionesPorEstudiante(idEstudianteLogueado);
            tablaCalificacionesDashboard = calificaciones;

            CargarIndicadores(materias, calificaciones);
            CargarTarjetasMaterias(materias, calificaciones);
            AplicarFiltroActividad();
        }

        private void CargarIndicadores(DataTable materias, DataTable calificaciones)
        {
            int i;
            int cantidadNotas;
            decimal suma;
            decimal nota;
            decimal promedio;
            decimal mejorNota;

            cantidadNotas = 0;
            suma = 0;
            mejorNota = 0;

            for (i = 0; i < calificaciones.Rows.Count; i++)
            {
                if (calificaciones.Rows[i]["Nota"] != DBNull.Value)
                {
                    nota = Convert.ToDecimal(calificaciones.Rows[i]["Nota"]);
                    suma = suma + nota;
                    cantidadNotas = cantidadNotas + 1;

                    if (cantidadNotas == 1 || nota > mejorNota)
                    {
                        mejorNota = nota;
                    }
                }
            }

            promedio = 0;

            if (cantidadNotas > 0)
            {
                promedio = suma / cantidadNotas;
            }

            ucKpiMaterias.Valor = materias.Rows.Count.ToString();
            ucKpiEstudiantes.Valor = cantidadNotas.ToString();
            ucKpiCalificaciones.Valor = promedio.ToString("0.00");
            ucKpiPromedio.Valor = mejorNota.ToString("0.00");
        }

        private void CargarTarjetasMaterias(DataTable materias, DataTable calificaciones)
        {
            int i;
            int idMateria;
            UCTarjetaMateriaEstudiante tarjeta;

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
                tarjeta = new UCTarjetaMateriaEstudiante();
                tarjeta.IdMateria = idMateria;
                tarjeta.Codigo = materias.Rows[i]["Codigo"].ToString();
                tarjeta.Materia = materias.Rows[i]["Nombre"].ToString();
                tarjeta.Profesor = "Profesor: " + materias.Rows[i]["Profesor"].ToString();
                tarjeta.Promedio = ObtenerTextoPromedioMateria(calificaciones, idMateria);
                tarjeta.Activa = Convert.ToBoolean(materias.Rows[i]["Estado"]);
                tarjeta.Margin = new Padding(0, 0, 14, 14);
                tarjeta.Width = ObtenerAnchoTarjetaMateria();
                tarjeta.VerCalificacionesClick += new EventHandler(tarjeta_VerCalificacionesClick);

                flpMaterias.Controls.Add(tarjeta);
            }
        }

        private string ObtenerTextoPromedioMateria(DataTable calificaciones, int idMateria)
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
                return "Promedio: --";
            }

            promedio = suma / cantidad;
            return "Promedio: " + promedio.ToString("0.00");
        }

        private int ObtenerAnchoTarjetaMateria()
        {
            int anchoDisponible;
            int ancho;

            anchoDisponible = flpMaterias.ClientSize.Width - flpMaterias.Padding.Horizontal - 22;

            if (anchoDisponible >= 700)
            {
                ancho = (anchoDisponible - 14) / 2;
            }
            else
            {
                ancho = anchoDisponible;
            }

            if (ancho < 340)
            {
                ancho = 340;
            }

            return ancho;
        }

        private void flpMaterias_SizeChanged(object sender, EventArgs e)
        {
            int i;
            int ancho;
            UCTarjetaMateriaEstudiante tarjeta;

            ancho = ObtenerAnchoTarjetaMateria();

            for (i = 0; i < flpMaterias.Controls.Count; i++)
            {
                tarjeta = flpMaterias.Controls[i] as UCTarjetaMateriaEstudiante;

                if (tarjeta != null)
                {
                    tarjeta.Width = ancho;
                }
            }
        }

        private void CargarCalificacionesRecientes(DataTable calificaciones)
        {
            int i;
            int cantidadMostrar;
            UCCalificacionEstudiante tarjeta;
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
                tarjeta = new UCCalificacionEstudiante();
                tarjeta.Materia = calificaciones.Rows[i]["Materia"].ToString();
                detalle = calificaciones.Rows[i]["NombreEvaluacion"].ToString();
                detalle = detalle + " • Período " + calificaciones.Rows[i]["Periodo"].ToString();
                tarjeta.Detalle = detalle;
                tarjeta.Nota = Convert.ToDecimal(calificaciones.Rows[i]["Nota"]);
                tarjeta.Margin = new Padding(0, 0, 0, 10);
                tarjeta.Width = ObtenerAnchoActividad();

                flpActividad.Controls.Add(tarjeta);
            }
        }


        private void AplicarFiltroActividad()
        {
            DataTable filtrada;
            DataRow fila;
            string texto;
            string textoFila;
            int i;

            if (tablaCalificacionesDashboard == null)
            {
                return;
            }

            texto = ucBuscarActividad.Texto.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                CargarCalificacionesRecientes(tablaCalificacionesDashboard);
                return;
            }

            filtrada = tablaCalificacionesDashboard.Clone();

            for (i = 0; i < tablaCalificacionesDashboard.Rows.Count; i++)
            {
                fila = tablaCalificacionesDashboard.Rows[i];
                textoFila = fila["Materia"].ToString() + " " + fila["NombreEvaluacion"].ToString();
                textoFila = textoFila.ToLower();

                if (textoFila.Contains(texto))
                {
                    filtrada.ImportRow(fila);
                }
            }

            CargarCalificacionesRecientes(filtrada);
        }

        private void ucBuscarActividad_TextoCambiado(object sender, EventArgs e)
        {
            AplicarFiltroActividad();
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
            int ancho;
            UCCalificacionEstudiante tarjeta;

            ancho = ObtenerAnchoActividad();

            for (i = 0; i < flpActividad.Controls.Count; i++)
            {
                tarjeta = flpActividad.Controls[i] as UCCalificacionEstudiante;

                if (tarjeta != null)
                {
                    tarjeta.Width = ancho;
                }
            }
        }

        private void tarjeta_VerCalificacionesClick(object sender, EventArgs e)
        {
            UCTarjetaMateriaEstudiante tarjeta;

            tarjeta = sender as UCTarjetaMateriaEstudiante;

            if (tarjeta == null)
            {
                return;
            }

            IdMateriaSeleccionada = tarjeta.IdMateria;

            if (VerCalificaciones != null)
            {
                VerCalificaciones(this, EventArgs.Empty);
            }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            IdMateriaSeleccionada = 0;

            if (VerCalificaciones != null)
            {
                VerCalificaciones(this, EventArgs.Empty);
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
