using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaMateriaProfesor : UserControl
    {
        private int idMateria;

        public event EventHandler CalificarClick;

        public UCTarjetaMateriaProfesor()
        {
            InitializeComponent();
            ConfigurarBoton();
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

        public int CantidadEstudiantes
        {
            set
            {
                if (value == 1)
                {
                    lblEstudiantes.Text = "1 estudiante inscrito";
                }
                else
                {
                    lblEstudiantes.Text = value.ToString() + " estudiantes inscritos";
                }
            }
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

        private void ConfigurarBoton()
        {
            EstilosFormulario.AplicarBotonPrimario(btnCalificar);
            btnCalificar.Image = RecursosVisuales.CargarImagen("icon_edit.png", 16, 16);
            btnCalificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalificar.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (CalificarClick != null)
            {
                CalificarClick(this, EventArgs.Empty);
            }
        }

        private void UCTarjetaMateriaProfesor_Paint(object sender, PaintEventArgs e)
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
