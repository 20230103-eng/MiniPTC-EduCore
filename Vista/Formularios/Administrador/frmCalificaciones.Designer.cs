namespace Vista
{
    partial class frmCalificaciones
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Panel pnlLineaTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.ComboBox cboInscripcion;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.ComboBox cboEvaluacion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.tlpEncabezadoContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.pnlLineaTitulo = new System.Windows.Forms.Panel();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.cboInscripcion = new System.Windows.Forms.ComboBox();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.cboEvaluacion = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.tlpPagina.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.tlpEncabezadoContenido.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPagina
            // 
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.pnlEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFormulario, 0, 1);
            this.tlpPagina.Controls.Add(this.dgvCalificaciones, 0, 2);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 3;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.tlpEncabezadoContenido);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // tlpEncabezadoContenido
            // 
            this.tlpEncabezadoContenido.ColumnCount = 2;
            this.tlpEncabezadoContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tlpEncabezadoContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpEncabezadoContenido.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpEncabezadoContenido.Controls.Add(this.lblModo, 1, 0);
            this.tlpEncabezadoContenido.Controls.Add(this.pnlLineaTitulo, 0, 1);
            this.tlpEncabezadoContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezadoContenido.RowCount = 2;
            this.tlpEncabezadoContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Text = "Calificaciones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModo
            // 
            this.lblModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModo.Size = new System.Drawing.Size(170, 30);
            this.lblModo.Text = "Nueva calificación";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLineaTitulo
            // 
            this.pnlLineaTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlLineaTitulo.BackColor = ColoresInterfaz.Coral;
            this.pnlLineaTitulo.Size = new System.Drawing.Size(54, 4);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.tlpCampos);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(24, 18, 24, 14);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 4;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.Controls.Add(this.lblInscripcion, 0, 0);
            this.tlpCampos.SetColumnSpan(this.lblInscripcion, 2);
            this.tlpCampos.Controls.Add(this.lblEvaluacion, 2, 0);
            this.tlpCampos.SetColumnSpan(this.lblEvaluacion, 2);
            this.tlpCampos.Controls.Add(this.cboInscripcion, 0, 1);
            this.tlpCampos.SetColumnSpan(this.cboInscripcion, 2);
            this.tlpCampos.Controls.Add(this.cboEvaluacion, 2, 1);
            this.tlpCampos.SetColumnSpan(this.cboEvaluacion, 2);
            this.tlpCampos.Controls.Add(this.lblNota, 0, 2);
            this.tlpCampos.Controls.Add(this.lblObservacion, 1, 2);
            this.tlpCampos.SetColumnSpan(this.lblObservacion, 3);
            this.tlpCampos.Controls.Add(this.txtNota, 0, 3);
            this.tlpCampos.Controls.Add(this.txtObservacion, 1, 3);
            this.tlpCampos.SetColumnSpan(this.txtObservacion, 3);
            this.tlpCampos.Controls.Add(this.lblPromedio, 0, 4);
            this.tlpCampos.SetColumnSpan(this.lblPromedio, 2);
            this.tlpCampos.Controls.Add(this.flpAcciones, 2, 4);
            this.tlpCampos.SetColumnSpan(this.flpAcciones, 2);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.RowCount = 5;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            // 
            // labels
            // 
            this.lblInscripcion.AutoEllipsis = true;
            this.lblInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInscripcion.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblInscripcion.Text = "Estudiante / Materia";
            this.lblEvaluacion.AutoEllipsis = true;
            this.lblEvaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluacion.Text = "Evaluación";
            this.lblNota.AutoEllipsis = true;
            this.lblNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNota.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblNota.Text = "Nota";
            this.lblObservacion.AutoEllipsis = true;
            this.lblObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObservacion.Text = "Observación";
            // 
            // cboInscripcion
            // 
            this.cboInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboInscripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInscripcion.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.cboInscripcion.SelectedIndexChanged += new System.EventHandler(this.cboInscripcion_SelectedIndexChanged);
            // 
            // cboEvaluacion
            // 
            this.cboEvaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEvaluacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvaluacion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            // 
            // txtNota
            // 
            this.txtNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNota.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            // 
            // lblPromedio
            // 
            this.lblPromedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = ColoresInterfaz.Negro;
            this.lblPromedio.Text = "Promedio: 0.00";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnNuevo);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpAcciones.WrapContents = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnEliminar.Size = new System.Drawing.Size(118, 38);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnGuardar.Size = new System.Drawing.Size(118, 38);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnNuevo.Size = new System.Drawing.Size(118, 38);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersVisible = false;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificaciones_CellClick);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 620);
            this.Name = "frmCalificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            this.tlpPagina.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.tlpEncabezadoContenido.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.flpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
