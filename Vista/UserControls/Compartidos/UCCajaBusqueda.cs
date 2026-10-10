using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCCajaBusqueda : UserControl
    {
        private string textoVacio;
        private bool mostrandoTextoVacio;
        private bool actualizandoTexto;

        public event EventHandler TextoCambiado;

        public UCCajaBusqueda()
        {
            InitializeComponent();
            picBuscar.Image = RecursosVisuales.CargarImagen("action_search.png");
            textoVacio = "Buscar registro";
            MostrarTextoVacio();
        }

        public string Texto
        {
            get
            {
                if (mostrandoTextoVacio)
                {
                    return "";
                }

                return txtBuscar.Text;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MostrarTextoVacio();
                }
                else
                {
                    actualizandoTexto = true;
                    mostrandoTextoVacio = false;
                    txtBuscar.ForeColor = ColoresInterfaz.Negro;
                    txtBuscar.Text = value;
                    actualizandoTexto = false;
                }
            }
        }

        public string TextoVacio
        {
            get { return textoVacio; }
            set
            {
                textoVacio = value;

                if (mostrandoTextoVacio)
                {
                    MostrarTextoVacio();
                }
            }
        }

        public void Enfocar()
        {
            txtBuscar.Focus();
        }

        private void MostrarTextoVacio()
        {
            actualizandoTexto = true;
            mostrandoTextoVacio = true;
            txtBuscar.ForeColor = ColoresInterfaz.TextoSecundario;
            txtBuscar.Text = textoVacio;
            txtBuscar.SelectionStart = 0;
            actualizandoTexto = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (actualizandoTexto)
            {
                return;
            }

            if (TextoCambiado != null)
            {
                TextoCambiado(this, EventArgs.Empty);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (mostrandoTextoVacio)
            {
                actualizandoTexto = true;
                mostrandoTextoVacio = false;
                txtBuscar.Clear();
                txtBuscar.ForeColor = ColoresInterfaz.Negro;
                actualizandoTexto = false;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MostrarTextoVacio();
            }
        }

        private void UCCajaBusqueda_Resize(object sender, EventArgs e)
        {
            BordesRedondeados.AplicarRegion(this, 7);
            Invalidate();
        }

        private void UCCajaBusqueda_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangulo;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangulo = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath ruta = BordesRedondeados.CrearRuta(rectangulo, 7))
            using (Pen lapiz = new Pen(ColoresInterfaz.Borde, 1))
            {
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }
    }
}
