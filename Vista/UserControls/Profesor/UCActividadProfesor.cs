using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCActividadProfesor : UserControl
    {
        public UCActividadProfesor()
        {
            InitializeComponent();
            picIcono.Image = RecursosVisuales.CargarImagen("icon_grades.png");
        }

        public string Estudiante
        {
            get { return lblEstudiante.Text; }
            set { lblEstudiante.Text = value; }
        }

        public string Detalle
        {
            get { return lblDetalle.Text; }
            set { lblDetalle.Text = value; }
        }

        public decimal Nota
        {
            set
            {
                lblNota.Text = value.ToString("0.00");

                if (value >= 7)
                {
                    lblNota.BackColor = ColoresInterfaz.VerdeFondo;
                    lblNota.ForeColor = ColoresInterfaz.VerdeTexto;
                }
                else
                {
                    lblNota.BackColor = ColoresInterfaz.AmarilloFondo;
                    lblNota.ForeColor = ColoresInterfaz.AmarilloTexto;
                }
            }
        }

        private void UCActividadProfesor_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangulo;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangulo = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath ruta = BordesRedondeados.CrearRuta(rectangulo, 8))
            using (Pen lapiz = new Pen(ColoresInterfaz.Borde, 1))
            {
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }
    }
}
