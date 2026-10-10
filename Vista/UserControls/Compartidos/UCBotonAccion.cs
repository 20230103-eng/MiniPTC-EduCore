using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCBotonAccion : UserControl
    {
        private string archivoIcono;

        public event EventHandler AccionClick;

        public UCBotonAccion()
        {
            InitializeComponent();
        }

        public string ArchivoIcono
        {
            get { return archivoIcono; }
            set
            {
                archivoIcono = value;
                picIcono.Image = RecursosVisuales.CargarImagen(archivoIcono);
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (AccionClick != null)
            {
                AccionClick(this, EventArgs.Empty);
            }
        }

        private void UCBotonAccion_Resize(object sender, EventArgs e)
        {
            BordesRedondeados.AplicarRegion(this, 6);
            Invalidate();
        }

        private void UCBotonAccion_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangulo;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangulo = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath ruta = BordesRedondeados.CrearRuta(rectangulo, 6))
            using (Pen lapiz = new Pen(ColoresInterfaz.Borde, 1))
            {
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }
    }
}
