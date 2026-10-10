namespace Vista
{
    partial class frmInscripciones
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
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvInscripciones;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

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
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboEstudiante = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.tlpPagina.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.tlpEncabezadoContenido.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.SuspendLayout();
            //
            // tlpPagina
            //
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.pnlEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFormulario, 0, 1);
            this.tlpPagina.Controls.Add(this.dgvInscripciones, 0, 2);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 3;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Size = new System.Drawing.Size(1617, 941);
            this.tlpPagina.TabIndex = 0;
            //
            // pnlEncabezado
            //
            this.pnlEncabezado.Controls.Add(this.tlpEncabezadoContenido);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado.Location = new System.Drawing.Point(30, 24);
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1557, 84);
            this.pnlEncabezado.TabIndex = 0;
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
            this.tlpEncabezadoContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezadoContenido.Name = "tlpEncabezadoContenido";
            this.tlpEncabezadoContenido.RowCount = 2;
            this.tlpEncabezadoContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpEncabezadoContenido.Size = new System.Drawing.Size(1557, 84);
            this.tlpEncabezadoContenido.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1214, 74);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inscripciones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblModo
            //
            this.lblModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModo.AutoEllipsis = true;
            this.lblModo.Location = new System.Drawing.Point(1374, 22);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(180, 30);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Nueva inscripción";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlLineaTitulo
            //
            this.pnlLineaTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlLineaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.pnlLineaTitulo.Location = new System.Drawing.Point(2, 77);
            this.pnlLineaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pnlLineaTitulo.Name = "pnlLineaTitulo";
            this.pnlLineaTitulo.Size = new System.Drawing.Size(54, 4);
            this.pnlLineaTitulo.TabIndex = 2;
            //
            // pnlFormulario
            //
            this.pnlFormulario.Controls.Add(this.tlpCampos);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(30, 108);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(24, 18, 24, 14);
            this.pnlFormulario.Size = new System.Drawing.Size(1557, 170);
            this.pnlFormulario.TabIndex = 1;
            //
            // tlpCampos
            //
            this.tlpCampos.ColumnCount = 4;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.Controls.Add(this.lblEstudiante, 0, 0);
            this.tlpCampos.Controls.Add(this.lblMateria, 1, 0);
            this.tlpCampos.Controls.Add(this.cboEstudiante, 0, 1);
            this.tlpCampos.Controls.Add(this.cboMateria, 1, 1);
            this.tlpCampos.Controls.Add(this.flpAcciones, 1, 2);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(24, 18);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 3;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpCampos.Size = new System.Drawing.Size(1509, 138);
            this.tlpCampos.TabIndex = 0;
            //
            // lblEstudiante
            //
            this.lblEstudiante.AutoEllipsis = true;
            this.lblEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstudiante.Location = new System.Drawing.Point(0, 0);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(363, 24);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblMateria
            //
            this.lblMateria.AutoEllipsis = true;
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Location = new System.Drawing.Point(377, 0);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(363, 24);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cboEstudiante
            //
            this.cboEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstudiante.FormattingEnabled = true;
            this.cboEstudiante.Location = new System.Drawing.Point(0, 24);
            this.cboEstudiante.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.cboEstudiante.Name = "cboEstudiante";
            this.cboEstudiante.Size = new System.Drawing.Size(363, 28);
            this.cboEstudiante.TabIndex = 2;
            //
            // cboMateria
            //
            this.cboMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(377, 24);
            this.cboMateria.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(363, 28);
            this.cboMateria.TabIndex = 3;
            //
            // flpAcciones
            //
            this.tlpCampos.SetColumnSpan(this.flpAcciones, 3);
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnNuevo);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(377, 64);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpAcciones.Size = new System.Drawing.Size(1132, 74);
            this.flpAcciones.TabIndex = 4;
            this.flpAcciones.WrapContents = false;
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(1014, 8);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 38);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(886, 8);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnNuevo
            //
            this.btnNuevo.Location = new System.Drawing.Point(758, 8);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 38);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            //
            // dgvInscripciones
            //
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscripciones.ColumnHeadersHeight = 29;
            this.dgvInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripciones.Location = new System.Drawing.Point(30, 292);
            this.dgvInscripciones.Margin = new System.Windows.Forms.Padding(0);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.RowHeadersVisible = false;
            this.dgvInscripciones.RowHeadersWidth = 51;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(1557, 627);
            this.dgvInscripciones.TabIndex = 2;
            this.dgvInscripciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripciones_CellClick);
            //
            // frmInscripciones
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "frmInscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.frmInscripciones_Load);
            this.tlpPagina.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.tlpEncabezadoContenido.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
