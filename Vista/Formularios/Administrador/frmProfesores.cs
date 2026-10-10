using System;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmProfesores : Form
    {
        private Usuario usuarioModelo;
        private int idUsuarioSeleccionado;
        private int idTipoUsuario;

        public frmProfesores()
        {
            InitializeComponent();
            usuarioModelo = new Usuario();
            idUsuarioSeleccionado = 0;
            idTipoUsuario = 0;
            EstilosFormulario.AplicarFormularioCrud(this, pnlEncabezado, lblTitulo, lblModo, pnlFormulario, dgvUsuarios, btnNuevo, btnGuardar, btnEliminar);
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            if (Conexion.ProbarConexion() == false)
            {
                return;
            }

            idTipoUsuario = usuarioModelo.ObtenerIdTipoUsuario("Profesor");
            CargarUsuarios();
            LimpiarFormulario();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = usuarioModelo.ObtenerUsuariosPorTipo("Profesor");
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

            if (dgvUsuarios.Columns.Contains("TipoUsuario"))
            {
                dgvUsuarios.Columns["TipoUsuario"].Visible = false;
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

            if (idTipoUsuario == 0)
            {
                MessageBox.Show("No se encontró el tipo de usuario Profesor.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuarioModelo.IdUsuario = idUsuarioSeleccionado;
            usuarioModelo.Codigo = txtCodigo.Text.Trim();
            usuarioModelo.NombreUsuario = txtNombreUsuario.Text.Trim();
            usuarioModelo.Contrasena = txtContrasena.Text;
            usuarioModelo.NombreCompleto = txtNombreCompleto.Text.Trim();
            usuarioModelo.IdTipoUsuario = idTipoUsuario;
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
                MessageBox.Show("La información fue guardada correctamente.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                LimpiarFormulario();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("Ingrese el nombre completo.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (idUsuarioSeleccionado == 0 && string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese la contraseña.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Profesores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            usuarioModelo.IdUsuario = idUsuarioSeleccionado;

            if (usuarioModelo.Eliminar())
            {
                MessageBox.Show("El registro fue eliminado.", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            chkEstado.Checked = Convert.ToBoolean(fila.Cells["Estado"].Value);
            txtContrasena.Clear();
            lblModo.Text = "Editando registro";
        }

        private void LimpiarFormulario()
        {
            idUsuarioSeleccionado = 0;
            txtCodigo.Clear();
            txtNombreCompleto.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            chkEstado.Checked = true;
            lblModo.Text = "Nuevo registro";
            txtCodigo.Focus();
        }
    }
}
