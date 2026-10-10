namespace Vista
{
    partial class frmRegistrarCalificacionesProfesor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.Panel pnlSeleccion;
        private System.Windows.Forms.TableLayoutPanel tlpSeleccion;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.ComboBox cboEvaluacion;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnNuevaEvaluacion;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.TableLayoutPanel tlpEdicion;
        private System.Windows.Forms.Label lblTextoEstudiante;
        private System.Windows.Forms.Label lblEstudianteSeleccionado;
        private System.Windows.Forms.Label lblTextoNota;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.Button btnAplicarNota;
        private System.Windows.Forms.Button btnLimpiarEdicion;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;

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
            this.pnlSeleccion = new System.Windows.Forms.Panel();
            this.tlpSeleccion = new System.Windows.Forms.TableLayoutPanel();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.cboEvaluacion = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnNuevaEvaluacion = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.tlpEdicion = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextoEstudiante = new System.Windows.Forms.Label();
            this.lblEstudianteSeleccionado = new System.Windows.Forms.Label();
            this.lblTextoNota = new System.Windows.Forms.Label();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.btnAplicarNota = new System.Windows.Forms.Button();
            this.btnLimpiarEdicion = new System.Windows.Forms.Button();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tlpPagina.SuspendLayout();
            this.pnlSeleccion.SuspendLayout();
            this.tlpSeleccion.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.tlpEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.flpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPagina
            // 
            this.tlpPagina.BackColor = System.Drawing.Color.White;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlSeleccion, 0, 1);
            this.tlpPagina.Controls.Add(this.tlpResumen, 0, 2);
            this.tlpPagina.Controls.Add(this.pnlEdicion, 0, 3);
            this.tlpPagina.Controls.Add(this.dgvCalificaciones, 0, 4);
            this.tlpPagina.Controls.Add(this.flpAcciones, 0, 5);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 6;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpPagina.Size = new System.Drawing.Size(1617, 941);
            this.tlpPagina.TabIndex = 0;
            // 
            // ucEncabezado
            // 
            this.ucEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEncabezado.Location = new System.Drawing.Point(30, 24);
            this.ucEncabezado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.ucEncabezado.Name = "ucEncabezado";
            this.ucEncabezado.Size = new System.Drawing.Size(1557, 78);
            this.ucEncabezado.Subtitulo = "";
            this.ucEncabezado.TabIndex = 0;
            this.ucEncabezado.Titulo = "Registro de calificaciones";
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = ColoresInterfaz.Fondo;
            this.pnlSeleccion.Controls.Add(this.tlpSeleccion);
            this.pnlSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeleccion.Location = new System.Drawing.Point(30, 110);
            this.pnlSeleccion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.Padding = new System.Windows.Forms.Padding(18, 14, 18, 12);
            this.pnlSeleccion.Size = new System.Drawing.Size(1557, 140);
            this.pnlSeleccion.TabIndex = 1;
            // 
            // tlpSeleccion
            // 
            this.tlpSeleccion.ColumnCount = 4;
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpSeleccion.Controls.Add(this.lblMateria, 0, 0);
            this.tlpSeleccion.Controls.Add(this.lblPeriodo, 1, 0);
            this.tlpSeleccion.Controls.Add(this.lblEvaluacion, 2, 0);
            this.tlpSeleccion.Controls.Add(this.cboMateria, 0, 1);
            this.tlpSeleccion.Controls.Add(this.cboPeriodo, 1, 1);
            this.tlpSeleccion.Controls.Add(this.cboEvaluacion, 2, 1);
            this.tlpSeleccion.Controls.Add(this.btnCargar, 3, 1);
            this.tlpSeleccion.Controls.Add(this.lblAyuda, 0, 2);
            this.tlpSeleccion.Controls.Add(this.btnNuevaEvaluacion, 3, 2);
            this.tlpSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeleccion.Location = new System.Drawing.Point(18, 14);
            this.tlpSeleccion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSeleccion.Name = "tlpSeleccion";
            this.tlpSeleccion.RowCount = 3;
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeleccion.Size = new System.Drawing.Size(1521, 114);
            this.tlpSeleccion.TabIndex = 0;
            this.tlpSeleccion.SetColumnSpan(this.lblAyuda, 3);
            // 
            // lblMateria
            // 
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMateria.ForeColor = ColoresInterfaz.Negro;
            this.lblMateria.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(566, 28);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPeriodo.ForeColor = ColoresInterfaz.Negro;
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(200, 28);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Período";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluacion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEvaluacion.ForeColor = ColoresInterfaz.Negro;
            this.lblEvaluacion.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(474, 28);
            this.lblEvaluacion.TabIndex = 2;
            this.lblEvaluacion.Text = "Evaluación";
            this.lblEvaluacion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboMateria
            // 
            this.cboMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Margin = new System.Windows.Forms.Padding(0, 4, 12, 4);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(566, 28);
            this.cboMateria.TabIndex = 3;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(0, 4, 12, 4);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(200, 28);
            this.cboPeriodo.TabIndex = 4;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // cboEvaluacion
            // 
            this.cboEvaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEvaluacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEvaluacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboEvaluacion.FormattingEnabled = true;
            this.cboEvaluacion.Margin = new System.Windows.Forms.Padding(0, 4, 12, 4);
            this.cboEvaluacion.Name = "cboEvaluacion";
            this.cboEvaluacion.Size = new System.Drawing.Size(474, 28);
            this.cboEvaluacion.TabIndex = 5;
            this.cboEvaluacion.SelectedIndexChanged += new System.EventHandler(this.cboEvaluacion_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCargar.Location = new System.Drawing.Point(1325, 31);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(196, 40);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar estudiantes";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnNuevaEvaluacion
            // 
            this.btnNuevaEvaluacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevaEvaluacion.Location = new System.Drawing.Point(1325, 77);
            this.btnNuevaEvaluacion.Margin = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.btnNuevaEvaluacion.Name = "btnNuevaEvaluacion";
            this.btnNuevaEvaluacion.Size = new System.Drawing.Size(196, 32);
            this.btnNuevaEvaluacion.TabIndex = 7;
            this.btnNuevaEvaluacion.Text = "Nueva evaluación";
            this.btnNuevaEvaluacion.UseVisualStyleBackColor = false;
            this.btnNuevaEvaluacion.Click += new System.EventHandler(this.btnNuevaEvaluacion_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAyuda.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(1269, 36);
            this.lblAyuda.TabIndex = 8;
            this.lblAyuda.Text = "Selecciona una evaluación, carga los estudiantes y luego asigna o modifica la nota del estudiante seleccionado.";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tlpResumen
            // 
            this.tlpResumen.ColumnCount = 2;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpResumen.Controls.Add(this.lblResumen, 0, 0);
            this.tlpResumen.Controls.Add(this.lblPromedio, 1, 0);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResumen.Location = new System.Drawing.Point(30, 260);
            this.tlpResumen.Margin = new System.Windows.Forms.Padding(0);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 1;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Size = new System.Drawing.Size(1557, 52);
            this.tlpResumen.TabIndex = 2;
            // 
            // lblResumen
            // 
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblResumen.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblResumen.Margin = new System.Windows.Forms.Padding(0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(1387, 52);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "Selecciona una evaluación.";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = ColoresInterfaz.AzulOscuro;
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(170, 52);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Promedio: 0.00";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.BackColor = ColoresInterfaz.Fondo;
            this.pnlEdicion.Controls.Add(this.tlpEdicion);
            this.pnlEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdicion.Location = new System.Drawing.Point(30, 322);
            this.pnlEdicion.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.pnlEdicion.Size = new System.Drawing.Size(1557, 68);
            this.pnlEdicion.TabIndex = 3;
            // 
            // tlpEdicion
            // 
            this.tlpEdicion.ColumnCount = 6;
            this.tlpEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEdicion.Controls.Add(this.lblTextoEstudiante, 0, 0);
            this.tlpEdicion.Controls.Add(this.lblEstudianteSeleccionado, 1, 0);
            this.tlpEdicion.Controls.Add(this.lblTextoNota, 2, 0);
            this.tlpEdicion.Controls.Add(this.nudNota, 3, 0);
            this.tlpEdicion.Controls.Add(this.btnAplicarNota, 4, 0);
            this.tlpEdicion.Controls.Add(this.btnLimpiarEdicion, 5, 0);
            this.tlpEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEdicion.Location = new System.Drawing.Point(18, 12);
            this.tlpEdicion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEdicion.Name = "tlpEdicion";
            this.tlpEdicion.RowCount = 1;
            this.tlpEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEdicion.Size = new System.Drawing.Size(1521, 48);
            this.tlpEdicion.TabIndex = 0;
            // 
            // lblTextoEstudiante
            // 
            this.lblTextoEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextoEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblTextoEstudiante.ForeColor = ColoresInterfaz.Negro;
            this.lblTextoEstudiante.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTextoEstudiante.Name = "lblTextoEstudiante";
            this.lblTextoEstudiante.Size = new System.Drawing.Size(218, 28);
            this.lblTextoEstudiante.TabIndex = 0;
            this.lblTextoEstudiante.Text = "Estudiante seleccionado";
            this.lblTextoEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstudianteSeleccionado
            // 
            this.lblEstudianteSeleccionado.AutoEllipsis = true;
            this.lblEstudianteSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstudianteSeleccionado.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblEstudianteSeleccionado.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblEstudianteSeleccionado.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblEstudianteSeleccionado.Name = "lblEstudianteSeleccionado";
            this.lblEstudianteSeleccionado.Size = new System.Drawing.Size(520, 28);
            this.lblEstudianteSeleccionado.TabIndex = 1;
            this.lblEstudianteSeleccionado.Text = "Selecciona un estudiante en la tabla.";
            this.lblEstudianteSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextoNota
            // 
            this.lblTextoNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextoNota.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblTextoNota.ForeColor = ColoresInterfaz.Negro;
            this.lblTextoNota.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTextoNota.Name = "lblTextoNota";
            this.lblTextoNota.Size = new System.Drawing.Size(111, 28);
            this.lblTextoNota.TabIndex = 2;
            this.lblTextoNota.Text = "Nota";
            this.lblTextoNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNota
            // 
            this.nudNota.DecimalPlaces = 2;
            this.nudNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNota.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudNota.Location = new System.Drawing.Point(871, 0);
            this.nudNota.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.nudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(170, 27);
            this.nudNota.TabIndex = 3;
            this.nudNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudNota_KeyDown);
            // 
            // btnAplicarNota
            // 
            this.btnAplicarNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAplicarNota.Location = new System.Drawing.Point(1053, 0);
            this.btnAplicarNota.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAplicarNota.Name = "btnAplicarNota";
            this.btnAplicarNota.Size = new System.Drawing.Size(218, 28);
            this.btnAplicarNota.TabIndex = 4;
            this.btnAplicarNota.Text = "Aplicar nota";
            this.btnAplicarNota.UseVisualStyleBackColor = false;
            this.btnAplicarNota.Click += new System.EventHandler(this.btnAplicarNota_Click);
            // 
            // btnLimpiarEdicion
            // 
            this.btnLimpiarEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiarEdicion.Location = new System.Drawing.Point(1281, 0);
            this.btnLimpiarEdicion.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarEdicion.Name = "btnLimpiarEdicion";
            this.btnLimpiarEdicion.Size = new System.Drawing.Size(240, 28);
            this.btnLimpiarEdicion.TabIndex = 5;
            this.btnLimpiarEdicion.Text = "Limpiar nota";
            this.btnLimpiarEdicion.UseVisualStyleBackColor = false;
            this.btnLimpiarEdicion.Click += new System.EventHandler(this.btnLimpiarEdicion_Click);
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalificaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCalificaciones.Location = new System.Drawing.Point(30, 394);
            this.dgvCalificaciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.dgvCalificaciones.MultiSelect = false;
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersVisible = false;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.Size = new System.Drawing.Size(1557, 449);
            this.dgvCalificaciones.TabIndex = 4;
            this.dgvCalificaciones.SelectionChanged += new System.EventHandler(this.dgvCalificaciones_SelectionChanged);
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnVolver);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(30, 853);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flpAcciones.Size = new System.Drawing.Size(1557, 66);
            this.flpAcciones.TabIndex = 5;
            this.flpAcciones.WrapContents = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1357, 12);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar calificaciones";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1197, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar nota";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1007, 12);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 40);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver a mis materias";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistrarCalificacionesProfesor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "frmRegistrarCalificacionesProfesor";
            this.Text = "Registro de calificaciones";
            this.Load += new System.EventHandler(this.frmRegistrarCalificacionesProfesor_Load);
            this.Resize += new System.EventHandler(this.frmRegistrarCalificacionesProfesor_Resize);
            this.tlpPagina.ResumeLayout(false);
            this.pnlSeleccion.ResumeLayout(false);
            this.tlpSeleccion.ResumeLayout(false);
            this.tlpResumen.ResumeLayout(false);
            this.pnlEdicion.ResumeLayout(false);
            this.tlpEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.flpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
