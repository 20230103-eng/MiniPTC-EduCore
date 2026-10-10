using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaKPI : UserControl
    {
        private string archivoIcono;
        private Color colorIcono;

        public UCTarjetaKPI()
        {
            InitializeComponent();
            colorIcono = ColoresInterfaz.CelesteClaro;
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Valor
        {
            get { return lblValor.Text; }
            set { lblValor.Text = value; }
        }

        public string ArchivoIcono
        {
            get { return archivoIcono; }
            set
            {
                archivoIcono = value;

                if (picIcono.Image != null)
                {
                    picIcono.Image.Dispose();
                    picIcono.Image = null;
                }

                if (string.IsNullOrWhiteSpace(archivoIcono) == false)
                {
                    picIcono.Image = RecursosVisuales.CargarImagen(archivoIcono);
                }
            }
        }

        public Color ColorIcono
        {
            get { return colorIcono; }
            set
            {
                colorIcono = value;
                pnlIcono.BackColor = value;
            }
        }

        private void UCTarjetaKPI_Resize(object sender, EventArgs e)
        {
            BordesRedondeados.AplicarRegion(this, 10);
            Invalidate();
        }

        private void pnlIcono_Resize(object sender, EventArgs e)
        {
            using (GraphicsPath ruta = new GraphicsPath())
            {
                ruta.AddEllipse(0, 0, pnlIcono.Width, pnlIcono.Height);
                pnlIcono.Region = new Region(ruta);
            }
        }

        private void UCTarjetaKPI_Paint(object sender, PaintEventArgs e)
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
