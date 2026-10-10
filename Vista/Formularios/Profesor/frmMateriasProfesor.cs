using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmMateriasProfesor : Form
    {
        private int idProfesorLogueado;
        private Materia materiaModelo;

        public event EventHandler RegistrarCalificaciones;

        public int IdMateriaSeleccionada { get; private set; }

        public frmMateriasProfesor()
        {
            InitializeComponent();
            materiaModelo = new Materia();
            idProfesorLogueado = 2;
            ConfigurarVista();
        }

        public frmMateriasProfesor(int idProfesor) : this()
        {
            idProfesorLogueado = idProfesor;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Mis materias";
            ucEncabezado.Subtitulo = "Consulta las materias que tienes asignadas y registra sus calificaciones.";
            ucBuscar.TextoVacio = "Buscar por código o materia";
            EstilosFormulario.AplicarGrid(dgvMaterias);
            EstilosFormulario.AplicarBotonPrimario(btnRegistrarCalificaciones);
        }

        private void frmMateriasProfesor_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            DataTable tabla;

            tabla = materiaModelo.ObtenerMateriasPorProfesor(idProfesorLogueado, ucBuscar.Texto);
            dgvMaterias.DataSource = tabla;

            if (dgvMaterias.Columns["IdMateria"] != null)
            {
                dgvMaterias.Columns["IdMateria"].Visible = false;
            }

            if (dgvMaterias.Columns["IdProfesor"] != null)
            {
                dgvMaterias.Columns["IdProfesor"].Visible = false;
            }

            if (dgvMaterias.Columns["Codigo"] != null)
            {
                dgvMaterias.Columns["Codigo"].HeaderText = "Código";
            }

            if (dgvMaterias.Columns["Nombre"] != null)
            {
                dgvMaterias.Columns["Nombre"].HeaderText = "Materia";
            }

            if (dgvMaterias.Columns["Estado"] != null)
            {
                dgvMaterias.Columns["Estado"].HeaderText = "Activa";
            }

            lblCantidad.Text = dgvMaterias.Rows.Count.ToString() + " materias asignadas";
        }

        private void ucBuscar_TextoCambiado(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnRegistrarCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirRegistroCalificaciones();
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            AbrirRegistroCalificaciones();
        }

        private void AbrirRegistroCalificaciones()
        {
            if (dgvMaterias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una materia para registrar calificaciones.", "Mis materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IdMateriaSeleccionada = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["IdMateria"].Value);

            if (RegistrarCalificaciones != null)
            {
                RegistrarCalificaciones(this, EventArgs.Empty);
            }
        }
    }
}
