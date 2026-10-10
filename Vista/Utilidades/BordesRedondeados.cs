using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public static class BordesRedondeados
    {
        public static GraphicsPath CrearRuta(Rectangle rectangulo, int radio)
        {
            GraphicsPath ruta;
            int diametro;
            Rectangle arco;

            ruta = new GraphicsPath();
            diametro = radio * 2;

            if (diametro > rectangulo.Width)
            {
                diametro = rectangulo.Width;
            }

            if (diametro > rectangulo.Height)
            {
                diametro = rectangulo.Height;
            }

            arco = new Rectangle(rectangulo.X, rectangulo.Y, diametro, diametro);

            ruta.AddArc(arco, 180, 90);
            arco.X = rectangulo.Right - diametro;
            ruta.AddArc(arco, 270, 90);
            arco.Y = rectangulo.Bottom - diametro;
            ruta.AddArc(arco, 0, 90);
            arco.X = rectangulo.Left;
            ruta.AddArc(arco, 90, 90);
            ruta.CloseFigure();

            return ruta;
        }

        public static void AplicarRegion(Control control, int radio)
        {
            Rectangle rectangulo;

            if (control.Width <= 0 || control.Height <= 0)
            {
                return;
            }

            rectangulo = new Rectangle(0, 0, control.Width - 1, control.Height - 1);

            using (GraphicsPath ruta = CrearRuta(rectangulo, radio))
            {
                control.Region = new Region(ruta);
            }
        }
    }
}
