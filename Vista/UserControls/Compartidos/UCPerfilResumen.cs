using System.Windows.Forms;

namespace Vista
{
    public partial class UCPerfilResumen : UserControl
    {
        public UCPerfilResumen()
        {
            InitializeComponent();
            picPerfil.Image = RecursosVisuales.CargarImagen("icon_user.png");
        }

        public string NombreCompleto
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public string Rol
        {
            get { return lblRol.Text; }
            set { lblRol.Text = value; }
        }

        public string Codigo
        {
            get { return lblCodigo.Text; }
            set { lblCodigo.Text = "Código: " + value; }
        }

        public bool Activo
        {
            set
            {
                if (value)
                {
                    lblEstado.Text = "Activo";
                    lblEstado.BackColor = ColoresInterfaz.VerdeFondo;
                    lblEstado.ForeColor = ColoresInterfaz.VerdeTexto;
                }
                else
                {
                    lblEstado.Text = "Inactivo";
                    lblEstado.BackColor = ColoresInterfaz.AmarilloFondo;
                    lblEstado.ForeColor = ColoresInterfaz.AmarilloTexto;
                }
            }
        }
    }
}
