namespace Vista
{
    partial class frmEvaluacionesProfesor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tlpFormulario;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.TableLayoutPanel tlpBarra;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnIrCalificaciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;

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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.tlpBarra = new System.Windows.Forms.TableLayoutPanel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIrCalificaciones = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.tlpPagina.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpFormulario.SuspendLayout();
            this.tlpBarra.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.SuspendLayout();
            //
            // tlpPagina
            //
            this.tlpPagina.BackColor = System.Drawing.Color.White;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFormulario, 0, 1);
            this.tlpPagina.Controls.Add(this.tlpBarra, 0, 2);
            this.tlpPagina.Controls.Add(this.dgvEvaluaciones, 0, 3);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 4;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // ucEncabezado
            //
            this.ucEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.ucEncabezado.Name = "ucEncabezado";
            this.ucEncabezado.Titulo = "Evaluaciones";
            this.ucEncabezado.Subtitulo = "";
            //
            // pnlFormulario
            //
            this.pnlFormulario.BackColor = ColoresInterfaz.Fondo;
            this.pnlFormulario.Controls.Add(this.tlpFormulario);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            //
            // tlpFormulario
            //
            this.tlpFormulario.ColumnCount = 4;
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpFormulario.Controls.Add(this.lblMateria, 0, 0);
            this.tlpFormulario.Controls.Add(this.lblPeriodo, 1, 0);
            this.tlpFormulario.Controls.Add(this.lblNombre, 2, 0);
            this.tlpFormulario.Controls.Add(this.lblEstado, 3, 0);
            this.tlpFormulario.Controls.Add(this.cboMateria, 0, 1);
            this.tlpFormulario.Controls.Add(this.cboPeriodo, 1, 1);
            this.tlpFormulario.Controls.Add(this.txtNombre, 2, 1);
            this.tlpFormulario.Controls.Add(this.chkEstado, 3, 1);
            this.tlpFormulario.Controls.Add(this.lblModo, 0, 2);
            this.tlpFormulario.SetColumnSpan(this.lblModo, 4);
            this.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormulario.RowCount = 3;
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // labels
            //
            this.lblMateria.Text = "Materia";
            this.lblPeriodo.Text = "Período";
            this.lblNombre.Text = "Nombre de la evaluación";
            this.lblEstado.Text = "Estado";
            this.lblMateria.AutoEllipsis = true;
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMateria.ForeColor = ColoresInterfaz.Negro;
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblPeriodo.AutoEllipsis = true;
            this.lblPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPeriodo.ForeColor = ColoresInterfaz.Negro;
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = ColoresInterfaz.Negro;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblEstado.AutoEllipsis = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = ColoresInterfaz.Negro;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // cboMateria
            //
            this.cboMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            //
            // cboPeriodo
            //
            this.cboPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            //
            // txtNombre
            //
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            //
            // chkEstado
            //
            this.chkEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.Text = "Activa";
            //
            // lblModo
            //
            this.lblModo.AutoEllipsis = true;
            this.lblModo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblModo.ForeColor = ColoresInterfaz.AzulOscuro;
            this.lblModo.Text = "Nueva evaluación";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // tlpBarra
            //
            this.tlpBarra.ColumnCount = 2;
            this.tlpBarra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.tlpBarra.Controls.Add(this.lblCantidad, 0, 0);
            this.tlpBarra.Controls.Add(this.flpAcciones, 1, 0);
            this.tlpBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBarra.Margin = new System.Windows.Forms.Padding(0);
            //
            // lblCantidad
            //
            this.lblCantidad.AutoEllipsis = true;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblCantidad.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblCantidad.Text = "0 evaluaciones";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // flpAcciones
            //
            this.flpAcciones.Controls.Add(this.btnIrCalificaciones);
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnNuevo);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 10, 0, 8);
            this.flpAcciones.WrapContents = false;
            //
            // buttons
            //
            this.btnIrCalificaciones.Size = new System.Drawing.Size(175, 38);
            this.btnIrCalificaciones.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIrCalificaciones.Text = "Ir a calificaciones";
            this.btnIrCalificaciones.UseVisualStyleBackColor = false;
            this.btnIrCalificaciones.Click += new System.EventHandler(this.btnIrCalificaciones_Click);
            this.btnEliminar.Size = new System.Drawing.Size(112, 38);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnGuardar.Size = new System.Drawing.Size(112, 38);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnNuevo.Size = new System.Drawing.Size(112, 38);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            //
            // dgvEvaluaciones
            //
            this.dgvEvaluaciones.AllowUserToAddRows = false;
            this.dgvEvaluaciones.AllowUserToDeleteRows = false;
            this.dgvEvaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvaluaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvaluaciones.ReadOnly = true;
            this.dgvEvaluaciones.RowHeadersVisible = false;
            this.dgvEvaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvaluaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvaluaciones_CellClick);
            //
            // frmEvaluacionesProfesor
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "frmEvaluacionesProfesor";
            this.Text = "Evaluaciones";
            this.Load += new System.EventHandler(this.frmEvaluacionesProfesor_Load);
            this.tlpPagina.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.tlpFormulario.ResumeLayout(false);
            this.tlpFormulario.PerformLayout();
            this.tlpBarra.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.ResumeLayout(false);
        }

    }
}
