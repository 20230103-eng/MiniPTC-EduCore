using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaEstudianteKPI : UserControl
    {
        private string archivoIcono;
        private Color colorAcento;
        private Color colorIcono;

        public UCTarjetaEstudianteKPI()
        {
            InitializeComponent();
            colorAcento = ColoresInterfaz.AzulOscuro;
            colorIcono = ColoresInterfaz.CelesteClaro;
            pnlAcento.BackColor = colorAcento;
            pnlIcono.BackColor = colorIcono;
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

        public string Detalle
        {
            get { return lblDetalle.Text; }
            set { lblDetalle.Text = value; }
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

        public Color ColorAcento
        {
            get { return colorAcento; }
            set
            {
                colorAcento = value;
                pnlAcento.BackColor = value;
                Invalidate();
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

        private void UCTarjetaEstudianteKPI_Paint(object sender, PaintEventArgs e)
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

        private void pnlIcono_Resize(object sender, EventArgs e)
        {
            int lado;
            int x;
            int y;

            lado = pnlIcono.Width;

            if (pnlIcono.Height < lado)
            {
                lado = pnlIcono.Height;
            }

            if (lado <= 0)
            {
                return;
            }

            x = (pnlIcono.Width - lado) / 2;
            y = (pnlIcono.Height - lado) / 2;

            using (GraphicsPath ruta = new GraphicsPath())
            {
                ruta.AddEllipse(x, y, lado, lado);
                pnlIcono.Region = new Region(ruta);
            }
        }
    }
}
