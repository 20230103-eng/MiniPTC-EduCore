namespace Vista
{
    partial class frmRegistrarCalificacionesProfesor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label lblResumen;
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tlpPagina.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.flpAcciones.SuspendLayout();
            this.SuspendLayout();
            //
            // tlpPagina
            //
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFiltros, 0, 1);
            this.tlpPagina.Controls.Add(this.dgvCalificaciones, 0, 2);
            this.tlpPagina.Controls.Add(this.flpAcciones, 0, 3);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 4;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
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
            this.ucEncabezado.Titulo = "Registro de calificaciones";
            //
            // pnlFiltros
            //
            this.pnlFiltros.BackColor = ColoresInterfaz.Fondo;
            this.pnlFiltros.Controls.Add(this.tlpFiltros);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(30, 108);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(22, 14, 22, 12);
            this.pnlFiltros.Size = new System.Drawing.Size(1557, 114);
            this.pnlFiltros.TabIndex = 1;
            //
            // tlpFiltros
            //
            this.tlpFiltros.ColumnCount = 3;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.Controls.Add(this.lblMateria, 0, 0);
            this.tlpFiltros.Controls.Add(this.lblPeriodo, 1, 0);
            this.tlpFiltros.Controls.Add(this.cboMateria, 0, 1);
            this.tlpFiltros.Controls.Add(this.cboPeriodo, 1, 1);
            this.tlpFiltros.Controls.Add(this.lblResumen, 2, 1);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(22, 14);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFiltros.Size = new System.Drawing.Size(1513, 88);
            this.tlpFiltros.TabIndex = 0;
            //
            // lblMateria
            //
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMateria.ForeColor = ColoresInterfaz.Negro;
            this.lblMateria.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // cboMateria
            //
            this.cboMateria.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Margin = new System.Windows.Forms.Padding(0, 4, 14, 6);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(627, 28);
            this.cboMateria.TabIndex = 1;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            //
            // lblPeriodo
            //
            this.lblPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeriodo.ForeColor = ColoresInterfaz.Negro;
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Período";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // cboPeriodo
            //
            this.cboPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(0, 4, 14, 6);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(216, 28);
            this.cboPeriodo.TabIndex = 3;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            //
            // lblResumen
            //
            this.lblResumen.AutoEllipsis = true;
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblResumen.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblResumen.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.TabIndex = 4;
            this.lblResumen.Text = "Selecciona una materia y un período.";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // dgvCalificaciones
            //
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalificaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCalificaciones.Location = new System.Drawing.Point(30, 236);
            this.dgvCalificaciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.RowHeadersVisible = false;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.Size = new System.Drawing.Size(1557, 619);
            this.dgvCalificaciones.TabIndex = 2;
            //
            // flpAcciones
            //
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnVolver);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(30, 867);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flpAcciones.Size = new System.Drawing.Size(1557, 52);
            this.flpAcciones.TabIndex = 3;
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(1357, 10);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar calificaciones";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(1197, 10);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar nota";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(1007, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 38);
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
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "frmRegistrarCalificacionesProfesor";
            this.Text = "Registro de calificaciones";
            this.Load += new System.EventHandler(this.frmRegistrarCalificacionesProfesor_Load);
            this.tlpPagina.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.flpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
