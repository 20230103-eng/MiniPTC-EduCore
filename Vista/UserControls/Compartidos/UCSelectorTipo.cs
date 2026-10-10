using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCSelectorTipo : UserControl
    {
        public event EventHandler SeleccionCambiada;

        public UCSelectorTipo()
        {
            InitializeComponent();
        }

        public string TipoSeleccionado
        {
            get { return cboTipo.Text; }
        }

        public void CargarTipos()
        {
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Todos");
            cboTipo.Items.Add("Administrador");
            cboTipo.Items.Add("Profesor");
            cboTipo.Items.Add("Estudiante");
            cboTipo.SelectedIndex = 0;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionCambiada != null)
            {
                SeleccionCambiada(this, EventArgs.Empty);
            }
        }
    }
}
