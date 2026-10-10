namespace Vista
{
    partial class UCTarjetaMateriaEstudiante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.TableLayoutPanel tlpCabecera;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.TableLayoutPanel tlpPie;
        private System.Windows.Forms.Label lblPromedio;
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
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabecera = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.tlpPie = new System.Windows.Forms.TableLayoutPanel();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.tlpContenido.SuspendLayout();
            this.tlpCabecera.SuspendLayout();
            this.tlpPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.tlpCabecera, 0, 0);
            this.tlpContenido.Controls.Add(this.lblMateria, 0, 1);
            this.tlpContenido.Controls.Add(this.lblProfesor, 0, 2);
            this.tlpContenido.Controls.Add(this.tlpPie, 0, 3);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
            this.tlpContenido.RowCount = 4;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(520, 164);
            this.tlpContenido.TabIndex = 0;
            // 
            // tlpCabecera
            // 
            this.tlpCabecera.ColumnCount = 2;
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpCabecera.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpCabecera.Controls.Add(this.lblEstado, 1, 0);
            this.tlpCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabecera.Location = new System.Drawing.Point(18, 14);
            this.tlpCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabecera.Name = "tlpCabecera";
            this.tlpCabecera.RowCount = 1;
            this.tlpCabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.Size = new System.Drawing.Size(484, 30);
            this.tlpCabecera.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.3F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = ColoresInterfaz.AzulOscuro;
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(394, 30);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "MAT001";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.BackColor = ColoresInterfaz.VerdeFondo;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = ColoresInterfaz.VerdeTexto;
            this.lblEstado.Location = new System.Drawing.Point(405, 3);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Activa";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoEllipsis = true;
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMateria.ForeColor = ColoresInterfaz.Negro;
            this.lblMateria.Margin = new System.Windows.Forms.Padding(0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(484, 40);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoEllipsis = true;
            this.lblProfesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfesor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProfesor.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblProfesor.Margin = new System.Windows.Forms.Padding(0);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(484, 34);
            this.lblProfesor.TabIndex = 2;
            this.lblProfesor.Text = "Profesor";
            this.lblProfesor.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tlpPie
            // 
            this.tlpPie.ColumnCount = 2;
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpPie.Controls.Add(this.lblPromedio, 0, 0);
            this.tlpPie.Controls.Add(this.btnVerCalificaciones, 1, 0);
            this.tlpPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPie.Location = new System.Drawing.Point(18, 118);
            this.tlpPie.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPie.Name = "tlpPie";
            this.tlpPie.RowCount = 1;
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.Size = new System.Drawing.Size(484, 32);
            this.tlpPie.TabIndex = 3;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoEllipsis = true;
            this.lblPromedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = ColoresInterfaz.Negro;
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(314, 32);
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio: --";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerCalificaciones.Location = new System.Drawing.Point(324, 0);
            this.btnVerCalificaciones.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(135, 32);
            this.btnVerCalificaciones.TabIndex = 1;
            this.btnVerCalificaciones.Text = "Ver calificaciones";
            this.btnVerCalificaciones.UseVisualStyleBackColor = false;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.btnVerCalificaciones_Click);
            // 
            // UCTarjetaMateriaEstudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContenido);
            this.MinimumSize = new System.Drawing.Size(320, 164);
            this.Name = "UCTarjetaMateriaEstudiante";
            this.Size = new System.Drawing.Size(520, 164);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCTarjetaMateriaEstudiante_Paint);
            this.tlpContenido.ResumeLayout(false);
            this.tlpCabecera.ResumeLayout(false);
            this.tlpPie.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
