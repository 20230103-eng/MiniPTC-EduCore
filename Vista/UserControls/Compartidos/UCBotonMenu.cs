using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCBotonMenu : UserControl
    {
        private bool seleccionado;
        private string archivoIcono;

        public event EventHandler BotonClick;

        public UCBotonMenu()
        {
            InitializeComponent();
        }

        public string Texto
        {
            get { return lblTexto.Text; }
            set { lblTexto.Text = value; }
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

        public bool Seleccionado
        {
            get { return seleccionado; }
            set
            {
                seleccionado = value;
                ActualizarEstado();
            }
        }

        private void ActualizarEstado()
        {
            if (seleccionado)
            {
                BackColor = ColoresInterfaz.AzulSeleccion;
                pnlSeleccion.Visible = true;
                lblTexto.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            }
            else
            {
                BackColor = ColoresInterfaz.AzulOscuro;
                pnlSeleccion.Visible = false;
                lblTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (BotonClick != null)
            {
                BotonClick(this, EventArgs.Empty);
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (seleccionado == false)
            {
                BackColor = Color.FromArgb(69, 101, 139);
            }
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            ActualizarEstado();
        }
    }
}
