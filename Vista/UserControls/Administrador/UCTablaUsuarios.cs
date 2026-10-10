using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista
{
    public class UsuarioTablaEventArgs : EventArgs
    {
        private int idUsuario;

        public UsuarioTablaEventArgs(int id)
        {
            idUsuario = id;
        }

        public int IdUsuario
        {
            get { return idUsuario; }
        }
    }

    public partial class UCTablaUsuarios : UserControl
    {
        private DataTable usuarios;
        private string textoFiltro;
        private string tipoFiltro;

        public event EventHandler<UsuarioTablaEventArgs> VerUsuario;
        public event EventHandler<UsuarioTablaEventArgs> EditarUsuario;
        public event EventHandler<UsuarioTablaEventArgs> EliminarUsuario;

        public UCTablaUsuarios()
        {
            InitializeComponent();
            textoFiltro = "";
            tipoFiltro = "Todos";
        }

        public void CargarUsuarios(DataTable tabla)
        {
            usuarios = tabla;
            MostrarFilas();
        }

        public void AplicarFiltro(string texto, string tipo)
        {
            textoFiltro = texto.Trim().ToLower();
            tipoFiltro = tipo;
            MostrarFilas();
        }

        private void MostrarFilas()
        {
            int i;
            int posicionY;
            int cantidadMostrada;
            DataRow fila;
            string codigo;
            string nombre;
            string usuario;
            string rol;
            bool estado;
            bool coincideTexto;
            bool coincideTipo;
            UCFilaUsuario controlFila;

            pnlFilas.SuspendLayout();
            pnlFilas.Controls.Clear();
            posicionY = 0;
            cantidadMostrada = 0;

            if (usuarios != null)
            {
                for (i = 0; i < usuarios.Rows.Count; i++)
                {
                    fila = usuarios.Rows[i];
                    codigo = fila["Codigo"].ToString();
                    nombre = fila["NombreCompleto"].ToString();
                    usuario = fila["NombreUsuario"].ToString();
                    rol = fila["TipoUsuario"].ToString();
                    estado = Convert.ToBoolean(fila["Estado"]);

                    coincideTexto = CoincideConTexto(codigo, nombre, usuario, rol);
                    coincideTipo = tipoFiltro == "Todos" || tipoFiltro == rol;

                    if (coincideTexto && coincideTipo)
                    {
                        controlFila = new UCFilaUsuario();
                        controlFila.IdUsuario = Convert.ToInt32(fila["IdUsuario"]);
                        controlFila.Codigo = codigo;
                        controlFila.Nombre = nombre;
                        controlFila.Usuario = usuario;
                        controlFila.Rol = rol;
                        controlFila.Activo = estado;
                        controlFila.Height = 50;
                        controlFila.Left = 0;
                        controlFila.Top = posicionY;
                        controlFila.Width = ObtenerAnchoFila();
                        controlFila.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        controlFila.VerClick += new EventHandler(Fila_VerClick);
                        controlFila.EditarClick += new EventHandler(Fila_EditarClick);
                        controlFila.EliminarClick += new EventHandler(Fila_EliminarClick);
                        pnlFilas.Controls.Add(controlFila);
                        posicionY = posicionY + controlFila.Height;
                        cantidadMostrada = cantidadMostrada + 1;
                    }
                }
            }

            if (cantidadMostrada == 0)
            {
                lblSinRegistros = new Label();
                lblSinRegistros.Dock = DockStyle.Fill;
                lblSinRegistros.Font = new Font("Segoe UI", 9F);
                lblSinRegistros.ForeColor = ColoresInterfaz.TextoSecundario;
                lblSinRegistros.Text = "No hay registros para mostrar";
                lblSinRegistros.TextAlign = ContentAlignment.MiddleCenter;
                pnlFilas.Controls.Add(lblSinRegistros);
            }

            pnlFilas.AutoScrollMinSize = new Size(0, posicionY);
            pnlFilas.ResumeLayout();
            pnlFilas.PerformLayout();
            AjustarAnchoFilas();
        }

        private bool CoincideConTexto(string codigo, string nombre, string usuario, string rol)
        {
            if (textoFiltro == "")
            {
                return true;
            }

            if (codigo.ToLower().Contains(textoFiltro))
            {
                return true;
            }

            if (nombre.ToLower().Contains(textoFiltro))
            {
                return true;
            }

            if (usuario.ToLower().Contains(textoFiltro))
            {
                return true;
            }

            if (rol.ToLower().Contains(textoFiltro))
            {
                return true;
            }

            return false;
        }

        private int ObtenerAnchoFila()
        {
            int ancho;

            ancho = pnlFilas.ClientSize.Width;

            if (pnlFilas.VerticalScroll.Visible)
            {
                ancho = ancho - SystemInformation.VerticalScrollBarWidth;
            }

            if (ancho < 650)
            {
                ancho = 650;
            }

            return ancho;
        }

        private void pnlFilas_Resize(object sender, EventArgs e)
        {
            AjustarAnchoFilas();
        }

        private void AjustarAnchoFilas()
        {
            int i;
            int ancho;
            UCFilaUsuario fila;

            ancho = ObtenerAnchoFila();

            for (i = 0; i < pnlFilas.Controls.Count; i++)
            {
                fila = pnlFilas.Controls[i] as UCFilaUsuario;

                if (fila != null)
                {
                    fila.Width = ancho;
                }
            }
        }

        private void Fila_VerClick(object sender, EventArgs e)
        {
            UCFilaUsuario fila;

            fila = sender as UCFilaUsuario;

            if (fila != null && VerUsuario != null)
            {
                VerUsuario(this, new UsuarioTablaEventArgs(fila.IdUsuario));
            }
        }

        private void Fila_EditarClick(object sender, EventArgs e)
        {
            UCFilaUsuario fila;

            fila = sender as UCFilaUsuario;

            if (fila != null && EditarUsuario != null)
            {
                EditarUsuario(this, new UsuarioTablaEventArgs(fila.IdUsuario));
            }
        }

        private void Fila_EliminarClick(object sender, EventArgs e)
        {
            UCFilaUsuario fila;

            fila = sender as UCFilaUsuario;

            if (fila != null && EliminarUsuario != null)
            {
                EliminarUsuario(this, new UsuarioTablaEventArgs(fila.IdUsuario));
            }
        }

        private void UCTablaUsuarios_Resize(object sender, EventArgs e)
        {
            BordesRedondeados.AplicarRegion(this, 8);
            Invalidate();
        }

        private void UCTablaUsuarios_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangulo;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangulo = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath ruta = BordesRedondeados.CrearRuta(rectangulo, 8))
            using (Pen lapiz = new Pen(ColoresInterfaz.Borde, 1))
            {
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }
    }
}
