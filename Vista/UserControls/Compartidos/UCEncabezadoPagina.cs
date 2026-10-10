using System.Windows.Forms;

namespace Vista
{
    public partial class UCEncabezadoPagina : UserControl
    {
        public UCEncabezadoPagina()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Subtitulo
        {
            get { return lblSubtitulo.Text; }
            set
            {
                lblSubtitulo.Text = value;
                lblSubtitulo.Visible = string.IsNullOrWhiteSpace(value) == false;

                if (lblSubtitulo.Visible)
                {
                    tlpContenido.RowStyles[1].Height = 18F;
                    Height = 82;
                }
                else
                {
                    tlpContenido.RowStyles[1].Height = 0F;
                    Height = 68;
                }
            }
        }
    }
}
