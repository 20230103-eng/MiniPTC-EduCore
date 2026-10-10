using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmMateriasEstudiante : Form
    {
        private int idEstudianteLogueado;
        private Materia materiaModelo;
        private Calificacion calificacionModelo;

        public event EventHandler VerCalificaciones;
        public int IdMateriaSeleccionada { get; private set; }

        public frmMateriasEstudiante()
        {
            InitializeComponent();
            materiaModelo = new Materia();
            calificacionModelo = new Calificacion();
            idEstudianteLogueado = 4;
            ConfigurarVista();
        }

        public frmMateriasEstudiante(int idEstudiante) : this()
        {
            idEstudianteLogueado = idEstudiante;
        }

        private void ConfigurarVista()
        {
            ucEncabezado.Titulo = "Mis materias";
            ucEncabezado.Subtitulo = "Consulta las materias en las que estás inscrito y revisa sus calificaciones.";
            ucBuscar.TextoVacio = "Buscar por código, materia o profesor";
            EstilosFormulario.AplicarGrid(dgvMaterias);
            EstilosFormulario.AplicarBotonSecundario(btnVerCalificaciones);
        }

        private void frmMateriasEstudiante_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            DataTable tabla;
            DataTable calificaciones;
            int i;
            int idMateria;

            tabla = materiaModelo.ObtenerMateriasPorEstudiante(idEstudianteLogueado, ucBuscar.Texto);
            calificaciones = calificacionModelo.ObtenerCalificacionesPorEstudiante(idEstudianteLogueado);

            if (tabla.Columns.Contains("Promedio") == false)
            {
                tabla.Columns.Add("Promedio", typeof(string));
            }

            for (i = 0; i < tabla.Rows.Count; i++)
            {
                idMateria = Convert.ToInt32(tabla.Rows[i]["IdMateria"]);
                tabla.Rows[i]["Promedio"] = ObtenerPromedioMateria(calificaciones, idMateria);
            }

            dgvMaterias.DataSource = tabla;
            ConfigurarColumnas();
            lblCantidad.Text = tabla.Rows.Count.ToString() + " materias inscritas";
        }

        private string ObtenerPromedioMateria(DataTable calificaciones, int idMateria)
        {
            int i;
            int cantidad;
            decimal suma;
            decimal nota;
            decimal promedio;

            cantidad = 0;
            suma = 0;

            for (i = 0; i < calificaciones.Rows.Count; i++)
            {
                if (Convert.ToInt32(calificaciones.Rows[i]["IdMateria"]) == idMateria && calificaciones.Rows[i]["Nota"] != DBNull.Value)
                {
                    nota = Convert.ToDecimal(calificaciones.Rows[i]["Nota"]);
                    suma = suma + nota;
                    cantidad = cantidad + 1;
                }
            }

            if (cantidad == 0)
            {
                return "--";
            }

            promedio = suma / cantidad;
            return promedio.ToString("0.00");
        }

        private void ConfigurarColumnas()
        {
            if (dgvMaterias.Columns["IdMateria"] != null)
            {
                dgvMaterias.Columns["IdMateria"].Visible = false;
            }

            if (dgvMaterias.Columns["Codigo"] != null)
            {
                dgvMaterias.Columns["Codigo"].HeaderText = "Código";
                dgvMaterias.Columns["Codigo"].FillWeight = 22;
            }

            if (dgvMaterias.Columns["Nombre"] != null)
            {
                dgvMaterias.Columns["Nombre"].HeaderText = "Materia";
                dgvMaterias.Columns["Nombre"].FillWeight = 40;
            }

            if (dgvMaterias.Columns["Profesor"] != null)
            {
                dgvMaterias.Columns["Profesor"].HeaderText = "Profesor";
                dgvMaterias.Columns["Profesor"].FillWeight = 38;
            }

            if (dgvMaterias.Columns["Promedio"] != null)
            {
                dgvMaterias.Columns["Promedio"].HeaderText = "Promedio";
                dgvMaterias.Columns["Promedio"].FillWeight = 18;
                dgvMaterias.Columns["Promedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMaterias.Columns["Estado"] != null)
            {
                dgvMaterias.Columns["Estado"].HeaderText = "Activa";
                dgvMaterias.Columns["Estado"].FillWeight = 16;
            }
        }

        private void ucBuscar_TextoCambiado(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnVerCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirCalificaciones();
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            AbrirCalificaciones();
        }

        private void AbrirCalificaciones()
        {
            if (dgvMaterias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una materia para consultar sus calificaciones.", "Mis materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IdMateriaSeleccionada = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["IdMateria"].Value);

            if (VerCalificaciones != null)
            {
                VerCalificaciones(this, EventArgs.Empty);
            }
        }
    }
}
