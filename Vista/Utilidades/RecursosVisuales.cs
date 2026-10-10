using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public static class RecursosVisuales
    {
        public static Image CargarImagen(string nombreArchivo)
        {
            string ruta;
            Bitmap imagenTemporal;
            Bitmap imagen;

            ruta = Path.Combine(Application.StartupPath, "Recursos", nombreArchivo);

            if (File.Exists(ruta) == false)
            {
                return null;
            }

            using (FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read))
            {
                imagenTemporal = new Bitmap(archivo);
                imagen = new Bitmap(imagenTemporal);
                imagenTemporal.Dispose();
            }

            return imagen;
        }
        public static Image CargarImagen(string nombreArchivo, int ancho, int alto)
        {
            Image imagenOriginal;
            Bitmap imagenEscalada;

            imagenOriginal = CargarImagen(nombreArchivo);

            if (imagenOriginal == null)
            {
                return null;
            }

            imagenEscalada = new Bitmap(imagenOriginal, new Size(ancho, alto));
            imagenOriginal.Dispose();
            return imagenEscalada;
        }

    }
}
