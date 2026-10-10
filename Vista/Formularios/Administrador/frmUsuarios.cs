using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmUsuarios : Form
    {
        private Usuario usuarioModelo;
        private int idUsuarioSeleccionado;

        public frmUsuarios()
        {
            InitializeComponent();
            usuarioModelo = new Usuario();
            idUsuarioSeleccionado = 0;
            EstilosFormulario.AplicarFormularioCrud(this, pnlEncabezado, lblTitulo, lblModo, pnlFormulario, dgvUsuarios, btnNuevo, btnGuardar, btnEliminar);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            if (Conexion.ProbarConexion() == false)
            {
                return;
            }

            CargarTiposUsuario();
            CargarUsuarios();
            LimpiarFormulario();
        }

        private void CargarTiposUsuario()
        {
            DataTable tipos;

            tipos = usuarioModelo.ObtenerTiposUsuario();
            cboTipoUsuario.DataSource = tipos;
            cboTipoUsuario.DisplayMember = "Nombre";
            cboTipoUsuario.ValueMember = "IdTipoUsuario";
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = usuarioModelo.ObtenerUsuarios();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            if (dgvUsuarios.Columns.Contains("IdUsuario"))
            {
                dgvUsuarios.Columns["IdUsuario"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("IdTipoUsuario"))
            {
                dgvUsuarios.Columns["IdTipoUsuario"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("Codigo"))
            {
                dgvUsuarios.Columns["Codigo"].HeaderText = "Código";
            }

            if (dgvUsuarios.Columns.Contains("NombreUsuario"))
            {
                dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
            }

            if (dgvUsuarios.Columns.Contains("NombreCompleto"))
            {
                dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre completo";
            }

            if (dgvUsuarios.Columns.Contains("TipoUsuario"))
            {
                dgvUsuarios.Columns["TipoUsuario"].HeaderText = "Rol";
            }

            if (dgvUsuarios.Columns.Contains("Estado"))
            {
                dgvUsuarios.Columns["Estado"].HeaderText = "Activo";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool guardado;
            bool cambiarContrasena;

            if (ValidarCampos() == false)
            {
                return;
            }

            usuarioModelo.IdUsuario = idUsuarioSeleccionado;
            usuarioModelo.Codigo = txtCodigo.Text.Trim();
            usuarioModelo.NombreUsuario = txtNombreUsuario.Text.Trim();
            usuarioModelo.Contrasena = txtContrasena.Text;
            usuarioModelo.NombreCompleto = txtNombreCompleto.Text.Trim();
            usuarioModelo.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);
            usuarioModelo.Estado = chkEstado.Checked;

            if (idUsuarioSeleccionado == 0)
            {
                guardado = usuarioModelo.Insertar();
            }
            else
            {
                cambiarContrasena = string.IsNullOrWhiteSpace(txtContrasena.Text) == false;
                guardado = usuarioModelo.Modificar(cambiarContrasena);
            }

            if (guardado)
            {
                MessageBox.Show("La información fue guardada correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                LimpiarFormulario();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("Ingrese el nombre completo.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCompleto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return false;
            }

            if (idUsuarioSeleccionado == 0 && string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese la contraseña.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            if (cboTipoUsuario.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el rol.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            usuarioModelo.IdUsuario = idUsuarioSeleccionado;

            if (usuarioModelo.Eliminar())
            {
                MessageBox.Show("El usuario fue eliminado.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                LimpiarFormulario();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvUsuarios.Rows[e.RowIndex];
            idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
            txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            txtNombreUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
            txtNombreCompleto.Text = fila.Cells["NombreCompleto"].Value.ToString();
            cboTipoUsuario.SelectedValue = Convert.ToInt32(fila.Cells["IdTipoUsuario"].Value);
            chkEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            txtContrasena.Clear();
            lblModo.Text = "Editando usuario";
        }

        private void LimpiarFormulario()
        {
            idUsuarioSeleccionado = 0;
            txtCodigo.Clear();
            txtNombreCompleto.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            chkEstado.Checked = true;

            if (cboTipoUsuario.Items.Count > 0)
            {
                cboTipoUsuario.SelectedIndex = 0;
            }

            lblModo.Text = "Nuevo usuario";
            txtCodigo.Focus();
        }
    }
}
