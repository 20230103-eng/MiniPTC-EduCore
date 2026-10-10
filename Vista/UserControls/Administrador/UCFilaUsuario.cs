using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaUsuario : UserControl
    {
        private int idUsuario;

        public event EventHandler VerClick;
        public event EventHandler EditarClick;
        public event EventHandler EliminarClick;

        public UCFilaUsuario()
        {
            InitializeComponent();
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Codigo
        {
            get { return lblCodigo.Text; }
            set { lblCodigo.Text = value; }
        }

        public string Nombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public string Rol
        {
            get { return lblRol.Text; }
            set { lblRol.Text = value; }
        }

        public string Usuario
        {
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
        }

        public bool Activo
        {
            get { return ucEstado.Activo; }
            set { ucEstado.Activo = value; }
        }

        private void ucVer_AccionClick(object sender, EventArgs e)
        {
            if (VerClick != null)
            {
                VerClick(this, EventArgs.Empty);
            }
        }

        private void ucEditar_AccionClick(object sender, EventArgs e)
        {
            if (EditarClick != null)
            {
                EditarClick(this, EventArgs.Empty);
            }
        }

        private void ucEliminar_AccionClick(object sender, EventArgs e)
        {
            if (EliminarClick != null)
            {
                EliminarClick(this, EventArgs.Empty);
            }
        }

        private void Fila_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(249, 251, 253);
            tlpFila.BackColor = BackColor;
        }

        private void Fila_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            tlpFila.BackColor = Color.White;
        }
    }
}
