using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCChipEstado : UserControl
    {
        private bool activo;

        public UCChipEstado()
        {
            InitializeComponent();
            Activo = true;
        }

        public bool Activo
        {
            get { return activo; }
            set
            {
                activo = value;

                if (activo)
                {
                    lblEstado.Text = "Activo";
                    BackColor = ColoresInterfaz.VerdeFondo;
                    lblEstado.ForeColor = ColoresInterfaz.VerdeTexto;
                }
                else
                {
                    lblEstado.Text = "Inactivo";
                    BackColor = ColoresInterfaz.AmarilloFondo;
                    lblEstado.ForeColor = ColoresInterfaz.AmarilloTexto;
                }
            }
        }

        private void UCChipEstado_Resize(object sender, EventArgs e)
        {
            BordesRedondeados.AplicarRegion(this, 8);
        }
    }
}
