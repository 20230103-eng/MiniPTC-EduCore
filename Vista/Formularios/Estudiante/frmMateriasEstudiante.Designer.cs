namespace Vista
{
    partial class frmMateriasEstudiante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpIndicadores;
        private Vista.UCTarjetaEstudianteKPI ucKpiTotal;
        private Vista.UCTarjetaEstudianteKPI ucKpiAprobadas;
        private Vista.UCTarjetaEstudianteKPI ucKpiDesaprobadas;
        private Vista.UCTarjetaEstudianteKPI ucKpiEnCurso;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private Vista.UCCajaBusqueda ucBuscar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnVerCalificaciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpPagina = new System.Windows.Forms.TableLayoutPanel();
            this.ucEncabezado = new Vista.UCEncabezadoPagina();
            this.tlpIndicadores = new System.Windows.Forms.TableLayoutPanel();
            this.ucKpiTotal = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiAprobadas = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiDesaprobadas = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiEnCurso = new Vista.UCTarjetaEstudianteKPI();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.ucBuscar = new Vista.UCCajaBusqueda();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.tlpPagina.SuspendLayout();
            this.tlpIndicadores.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.flpAcciones.SuspendLayout();
            this.SuspendLayout();
            //
            // tlpPagina
            //
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.tlpIndicadores, 0, 1);
            this.tlpPagina.Controls.Add(this.tlpFiltros, 0, 2);
            this.tlpPagina.Controls.Add(this.dgvMaterias, 0, 3);
            this.tlpPagina.Controls.Add(this.flpAcciones, 0, 4);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 5;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPagina.Size = new System.Drawing.Size(1617, 941);
            this.tlpPagina.TabIndex = 0;
            //
            // ucEncabezado
            //
            this.ucEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEncabezado.Location = new System.Drawing.Point(30, 24);
            this.ucEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.ucEncabezado.Name = "ucEncabezado";
            this.ucEncabezado.Size = new System.Drawing.Size(1557, 84);
            this.ucEncabezado.Subtitulo = "";
            this.ucEncabezado.TabIndex = 0;
            this.ucEncabezado.Titulo = "Mis materias";
            //
            // tlpIndicadores
            //
            this.tlpIndicadores.ColumnCount = 4;
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.Controls.Add(this.ucKpiTotal, 0, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiAprobadas, 1, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiDesaprobadas, 2, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiEnCurso, 3, 0);
            this.tlpIndicadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndicadores.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.tlpIndicadores.RowCount = 1;
            this.tlpIndicadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // ucKpiTotal
            //
            this.ucKpiTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiTotal.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ucKpiTotal.Name = "ucKpiTotal";
            //
            // ucKpiAprobadas
            //
            this.ucKpiAprobadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiAprobadas.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.ucKpiAprobadas.Name = "ucKpiAprobadas";
            //
            // ucKpiDesaprobadas
            //
            this.ucKpiDesaprobadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiDesaprobadas.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.ucKpiDesaprobadas.Name = "ucKpiDesaprobadas";
            //
            // ucKpiEnCurso
            //
            this.ucKpiEnCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiEnCurso.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ucKpiEnCurso.Name = "ucKpiEnCurso";
            //
            // tlpFiltros
            //
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.ucBuscar, 0, 0);
            this.tlpFiltros.Controls.Add(this.lblCantidad, 1, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(30, 240);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 1;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Size = new System.Drawing.Size(1557, 72);
            this.tlpFiltros.TabIndex = 1;
            //
            // ucBuscar
            //
            this.ucBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ucBuscar.Location = new System.Drawing.Point(0, 15);
            this.ucBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.ucBuscar.Name = "ucBuscar";
            this.ucBuscar.Size = new System.Drawing.Size(330, 42);
            this.ucBuscar.TabIndex = 0;
            this.ucBuscar.Texto = "";
            this.ucBuscar.TextoVacio = "Buscar por código o materia";
            this.ucBuscar.TextoCambiado += new System.EventHandler(this.ucBuscar_TextoCambiado);
            //
            // lblCantidad
            //
            this.lblCantidad.AutoEllipsis = true;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblCantidad.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "0 materias inscritas";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // dgvMaterias
            //
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(30, 312);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(1557, 675);
            this.dgvMaterias.TabIndex = 2;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellDoubleClick);
            //
            // flpAcciones
            //
            this.flpAcciones.Controls.Add(this.btnVerCalificaciones);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(30, 867);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flpAcciones.Size = new System.Drawing.Size(1557, 52);
            this.flpAcciones.TabIndex = 3;
            //
            // btnVerCalificaciones
            //
            this.btnVerCalificaciones.Location = new System.Drawing.Point(1337, 10);
            this.btnVerCalificaciones.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(220, 38);
            this.btnVerCalificaciones.TabIndex = 0;
            this.btnVerCalificaciones.Text = "Ver calificaciones";
            this.btnVerCalificaciones.UseVisualStyleBackColor = false;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.btnVerCalificaciones_Click);
            //
            // frmMateriasEstudiante
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "frmMateriasEstudiante";
            this.Text = "Mis materias";
            this.Load += new System.EventHandler(this.frmMateriasEstudiante_Load);
            this.tlpPagina.ResumeLayout(false);
            this.tlpIndicadores.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.flpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
