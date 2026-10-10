using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaMateriaEstudiante : UserControl
    {
        private int idMateria;

        public event EventHandler VerCalificacionesClick;

        public UCTarjetaMateriaEstudiante()
        {
            InitializeComponent();
            EstilosFormulario.AplicarBotonSecundario(btnVerCalificaciones);
            btnVerCalificaciones.Image = RecursosVisuales.CargarImagen("icon_eye.png", 16, 16);
            btnVerCalificaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCalificaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public string Codigo
        {
            get { return lblCodigo.Text; }
            set { lblCodigo.Text = value; }
        }

        public string Materia
        {
            get { return lblMateria.Text; }
            set { lblMateria.Text = value; }
        }

        public string Profesor
        {
            get { return lblProfesor.Text; }
            set { lblProfesor.Text = value; }
        }

        public string Promedio
        {
            get { return lblPromedio.Text; }
            set { lblPromedio.Text = value; }
        }

        public bool Activa
        {
            set
            {
                if (value)
                {
                    lblEstado.Text = "Activa";
                    lblEstado.BackColor = ColoresInterfaz.VerdeFondo;
                    lblEstado.ForeColor = ColoresInterfaz.VerdeTexto;
                }
                else
                {
                    lblEstado.Text = "Inactiva";
                    lblEstado.BackColor = ColoresInterfaz.AmarilloFondo;
                    lblEstado.ForeColor = ColoresInterfaz.AmarilloTexto;
                }
            }
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (VerCalificacionesClick != null)
            {
                VerCalificacionesClick(this, EventArgs.Empty);
            }
        }

        private void UCTarjetaMateriaEstudiante_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangulo;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangulo = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath ruta = BordesRedondeados.CrearRuta(rectangulo, 10))
            using (Pen lapiz = new Pen(ColoresInterfaz.Borde, 1))
            {
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }
    }
}
