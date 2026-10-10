namespace Vista
{
    partial class frmCalificacionesEstudiante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private Vista.UCCajaBusqueda ucBuscar;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.TableLayoutPanel tlpIndicadores;
        private Vista.UCTarjetaEstudianteKPI ucKpiCantidad;
        private Vista.UCTarjetaEstudianteKPI ucKpiPromedio;
        private Vista.UCTarjetaEstudianteKPI ucKpiMejor;
        private Vista.UCTarjetaEstudianteKPI ucKpiProgreso;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.DataGridView dgvCalificaciones;

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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.ucBuscar = new Vista.UCCajaBusqueda();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.tlpIndicadores = new System.Windows.Forms.TableLayoutPanel();
            this.ucKpiCantidad = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiPromedio = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiMejor = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiProgreso = new Vista.UCTarjetaEstudianteKPI();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.tlpPagina.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.tlpIndicadores.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPagina
            // 
            this.tlpPagina.BackColor = ColoresInterfaz.Fondo;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFiltros, 0, 1);
            this.tlpPagina.Controls.Add(this.tlpIndicadores, 0, 2);
            this.tlpPagina.Controls.Add(this.tlpResumen, 0, 3);
            this.tlpPagina.Controls.Add(this.dgvCalificaciones, 0, 4);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 24);
            this.tlpPagina.RowCount = 5;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Size = new System.Drawing.Size(1617, 941);
            this.tlpPagina.TabIndex = 0;
            // 
            // ucEncabezado
            // 
            this.ucEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEncabezado.Location = new System.Drawing.Point(30, 24);
            this.ucEncabezado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.ucEncabezado.Name = "ucEncabezado";
            this.ucEncabezado.Size = new System.Drawing.Size(1557, 76);
            this.ucEncabezado.Subtitulo = "";
            this.ucEncabezado.TabIndex = 0;
            this.ucEncabezado.Titulo = "Mis calificaciones";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Controls.Add(this.tlpFiltros);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(30, 108);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(18, 12, 18, 12);
            this.pnlFiltros.Size = new System.Drawing.Size(1557, 108);
            this.pnlFiltros.TabIndex = 1;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 4;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpFiltros.Controls.Add(this.lblBuscar, 0, 0);
            this.tlpFiltros.Controls.Add(this.lblMateria, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblPeriodo, 2, 0);
            this.tlpFiltros.Controls.Add(this.ucBuscar, 0, 1);
            this.tlpFiltros.Controls.Add(this.cboMateria, 1, 1);
            this.tlpFiltros.Controls.Add(this.cboPeriodo, 2, 1);
            this.tlpFiltros.Controls.Add(this.btnRestablecer, 3, 1);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(18, 12);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Size = new System.Drawing.Size(1521, 84);
            this.tlpFiltros.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = ColoresInterfaz.Negro;
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(596, 28);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMateria
            // 
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMateria.ForeColor = ColoresInterfaz.Negro;
            this.lblMateria.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(413, 28);
            this.lblMateria.TabIndex = 1;
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
            this.lblPeriodo.Size = new System.Drawing.Size(201, 28);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Período";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ucBuscar
            // 
            this.ucBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBuscar.Location = new System.Drawing.Point(0, 34);
            this.ucBuscar.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.ucBuscar.Name = "ucBuscar";
            this.ucBuscar.Size = new System.Drawing.Size(596, 44);
            this.ucBuscar.TabIndex = 3;
            this.ucBuscar.Texto = "";
            this.ucBuscar.TextoVacio = "Buscar evaluación, materia o profesor";
            this.ucBuscar.TextoCambiado += new System.EventHandler(this.ucBuscar_TextoCambiado);
            // 
            // cboMateria
            // 
            this.cboMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(608, 38);
            this.cboMateria.Margin = new System.Windows.Forms.Padding(0, 10, 12, 10);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(413, 28);
            this.cboMateria.TabIndex = 4;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(1033, 38);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(0, 10, 12, 10);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(201, 28);
            this.cboPeriodo.TabIndex = 5;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestablecer.Location = new System.Drawing.Point(1329, 37);
            this.btnRestablecer.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(192, 38);
            this.btnRestablecer.TabIndex = 6;
            this.btnRestablecer.Text = "Restablecer filtros";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // tlpIndicadores
            // 
            this.tlpIndicadores.ColumnCount = 4;
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.Controls.Add(this.ucKpiCantidad, 0, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiProgreso, 1, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiPromedio, 2, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiMejor, 3, 0);
            this.tlpIndicadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndicadores.Location = new System.Drawing.Point(30, 226);
            this.tlpIndicadores.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIndicadores.Name = "tlpIndicadores";
            this.tlpIndicadores.RowCount = 1;
            this.tlpIndicadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndicadores.Size = new System.Drawing.Size(1557, 132);
            this.tlpIndicadores.TabIndex = 2;
            // 
            // ucKpiCantidad
            // 
            this.ucKpiCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiCantidad.Location = new System.Drawing.Point(0, 8);
            this.ucKpiCantidad.Margin = new System.Windows.Forms.Padding(0, 8, 10, 8);
            this.ucKpiCantidad.Name = "ucKpiCantidad";
            this.ucKpiCantidad.Size = new System.Drawing.Size(379, 116);
            this.ucKpiCantidad.TabIndex = 0;
            // 
            // ucKpiProgreso
            // 
            this.ucKpiProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiProgreso.Location = new System.Drawing.Point(399, 8);
            this.ucKpiProgreso.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.ucKpiProgreso.Name = "ucKpiProgreso";
            this.ucKpiProgreso.Size = new System.Drawing.Size(369, 116);
            this.ucKpiProgreso.TabIndex = 1;
            // 
            // ucKpiPromedio
            // 
            this.ucKpiPromedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiPromedio.Location = new System.Drawing.Point(788, 8);
            this.ucKpiPromedio.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.ucKpiPromedio.Name = "ucKpiPromedio";
            this.ucKpiPromedio.Size = new System.Drawing.Size(369, 116);
            this.ucKpiPromedio.TabIndex = 2;
            // 
            // ucKpiMejor
            // 
            this.ucKpiMejor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiMejor.Location = new System.Drawing.Point(1177, 8);
            this.ucKpiMejor.Margin = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.ucKpiMejor.Name = "ucKpiMejor";
            this.ucKpiMejor.Size = new System.Drawing.Size(380, 116);
            this.ucKpiMejor.TabIndex = 3;
            // 
            // tlpResumen
            // 
            this.tlpResumen.ColumnCount = 1;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Controls.Add(this.lblResumen, 0, 0);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResumen.Location = new System.Drawing.Point(30, 358);
            this.tlpResumen.Margin = new System.Windows.Forms.Padding(0);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 1;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Size = new System.Drawing.Size(1557, 48);
            this.tlpResumen.TabIndex = 3;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoEllipsis = true;
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblResumen.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblResumen.Margin = new System.Windows.Forms.Padding(0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(1557, 48);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "0 calificaciones encontradas";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalificaciones.Location = new System.Drawing.Point(30, 406);
            this.dgvCalificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersVisible = false;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.Size = new System.Drawing.Size(1557, 511);
            this.dgvCalificaciones.TabIndex = 4;
            // 
            // frmCalificacionesEstudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.Fondo;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 620);
            this.Name = "frmCalificacionesEstudiante";
            this.Text = "Mis calificaciones";
            this.Load += new System.EventHandler(this.frmCalificacionesEstudiante_Load);
            this.tlpPagina.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpIndicadores.ResumeLayout(false);
            this.tlpResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
