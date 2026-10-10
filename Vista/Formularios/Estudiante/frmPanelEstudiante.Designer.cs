namespace Vista
{
    partial class frmPanelEstudiante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpIndicadores;
        private Vista.UCTarjetaEstudianteKPI ucKpiMaterias;
        private Vista.UCTarjetaEstudianteKPI ucKpiEstudiantes;
        private Vista.UCTarjetaEstudianteKPI ucKpiCalificaciones;
        private Vista.UCTarjetaEstudianteKPI ucKpiPromedio;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpCabeceraMaterias;
        private System.Windows.Forms.Label lblTituloMaterias;
        private System.Windows.Forms.Button btnVerMaterias;
        private System.Windows.Forms.FlowLayoutPanel flpMaterias;
        private System.Windows.Forms.Label lblSinMaterias;
        private System.Windows.Forms.Panel pnlActividad;
        private System.Windows.Forms.TableLayoutPanel tlpActividad;
        private System.Windows.Forms.TableLayoutPanel tlpCabeceraActividad;
        private System.Windows.Forms.Label lblTituloActividad;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.FlowLayoutPanel flpActividad;
        private System.Windows.Forms.Label lblSinActividad;

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
            this.ucKpiMaterias = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiEstudiantes = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiCalificaciones = new Vista.UCTarjetaEstudianteKPI();
            this.ucKpiPromedio = new Vista.UCTarjetaEstudianteKPI();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMaterias = new System.Windows.Forms.Panel();
            this.tlpMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabeceraMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloMaterias = new System.Windows.Forms.Label();
            this.btnVerMaterias = new System.Windows.Forms.Button();
            this.flpMaterias = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSinMaterias = new System.Windows.Forms.Label();
            this.pnlActividad = new System.Windows.Forms.Panel();
            this.tlpActividad = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabeceraActividad = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloActividad = new System.Windows.Forms.Label();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.flpActividad = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSinActividad = new System.Windows.Forms.Label();
            this.tlpPagina.SuspendLayout();
            this.tlpIndicadores.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.pnlMaterias.SuspendLayout();
            this.tlpMaterias.SuspendLayout();
            this.tlpCabeceraMaterias.SuspendLayout();
            this.pnlActividad.SuspendLayout();
            this.tlpActividad.SuspendLayout();
            this.tlpCabeceraActividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPagina
            // 
            this.tlpPagina.BackColor = ColoresInterfaz.Fondo;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.tlpIndicadores, 0, 1);
            this.tlpPagina.Controls.Add(this.tlpContenido, 0, 2);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 24);
            this.tlpPagina.RowCount = 3;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
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
            this.ucEncabezado.Titulo = "Panel del Estudiante";
            // 
            // tlpIndicadores
            // 
            this.tlpIndicadores.ColumnCount = 4;
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.Controls.Add(this.ucKpiMaterias, 0, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiEstudiantes, 1, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiCalificaciones, 2, 0);
            this.tlpIndicadores.Controls.Add(this.ucKpiPromedio, 3, 0);
            this.tlpIndicadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndicadores.Location = new System.Drawing.Point(30, 108);
            this.tlpIndicadores.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIndicadores.Name = "tlpIndicadores";
            this.tlpIndicadores.RowCount = 1;
            this.tlpIndicadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndicadores.Size = new System.Drawing.Size(1557, 136);
            this.tlpIndicadores.TabIndex = 1;
            // 
            // ucKpiMaterias
            // 
            this.ucKpiMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiMaterias.Location = new System.Drawing.Point(0, 8);
            this.ucKpiMaterias.Margin = new System.Windows.Forms.Padding(0, 8, 10, 12);
            this.ucKpiMaterias.Name = "ucKpiMaterias";
            this.ucKpiMaterias.Size = new System.Drawing.Size(379, 116);
            this.ucKpiMaterias.TabIndex = 0;
            // 
            // ucKpiEstudiantes
            // 
            this.ucKpiEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiEstudiantes.Location = new System.Drawing.Point(399, 8);
            this.ucKpiEstudiantes.Margin = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.ucKpiEstudiantes.Name = "ucKpiEstudiantes";
            this.ucKpiEstudiantes.Size = new System.Drawing.Size(369, 116);
            this.ucKpiEstudiantes.TabIndex = 1;
            // 
            // ucKpiCalificaciones
            // 
            this.ucKpiCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiCalificaciones.Location = new System.Drawing.Point(788, 8);
            this.ucKpiCalificaciones.Margin = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.ucKpiCalificaciones.Name = "ucKpiCalificaciones";
            this.ucKpiCalificaciones.Size = new System.Drawing.Size(369, 116);
            this.ucKpiCalificaciones.TabIndex = 2;
            // 
            // ucKpiPromedio
            // 
            this.ucKpiPromedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKpiPromedio.Location = new System.Drawing.Point(1177, 8);
            this.ucKpiPromedio.Margin = new System.Windows.Forms.Padding(10, 8, 0, 12);
            this.ucKpiPromedio.Name = "ucKpiPromedio";
            this.ucKpiPromedio.Size = new System.Drawing.Size(380, 116);
            this.ucKpiPromedio.TabIndex = 3;
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpContenido.Controls.Add(this.pnlMaterias, 0, 0);
            this.tlpContenido.Controls.Add(this.pnlActividad, 1, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(30, 244);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(1557, 673);
            this.tlpContenido.TabIndex = 2;
            // 
            // pnlMaterias
            // 
            this.pnlMaterias.BackColor = System.Drawing.Color.White;
            this.pnlMaterias.Controls.Add(this.tlpMaterias);
            this.pnlMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaterias.Location = new System.Drawing.Point(0, 0);
            this.pnlMaterias.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlMaterias.Name = "pnlMaterias";
            this.pnlMaterias.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.pnlMaterias.Size = new System.Drawing.Size(953, 673);
            this.pnlMaterias.TabIndex = 0;
            this.pnlMaterias.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTarjeta_Paint);
            // 
            // tlpMaterias
            // 
            this.tlpMaterias.ColumnCount = 1;
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.Controls.Add(this.tlpCabeceraMaterias, 0, 0);
            this.tlpMaterias.Controls.Add(this.flpMaterias, 0, 1);
            this.tlpMaterias.Controls.Add(this.lblSinMaterias, 0, 2);
            this.tlpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaterias.Location = new System.Drawing.Point(22, 18);
            this.tlpMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMaterias.Name = "tlpMaterias";
            this.tlpMaterias.RowCount = 3;
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpMaterias.Size = new System.Drawing.Size(909, 637);
            this.tlpMaterias.TabIndex = 0;
            // 
            // tlpCabeceraMaterias
            // 
            this.tlpCabeceraMaterias.ColumnCount = 2;
            this.tlpCabeceraMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabeceraMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpCabeceraMaterias.Controls.Add(this.lblTituloMaterias, 0, 0);
            this.tlpCabeceraMaterias.Controls.Add(this.btnVerMaterias, 1, 0);
            this.tlpCabeceraMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabeceraMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpCabeceraMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabeceraMaterias.Name = "tlpCabeceraMaterias";
            this.tlpCabeceraMaterias.RowCount = 1;
            this.tlpCabeceraMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabeceraMaterias.Size = new System.Drawing.Size(909, 52);
            this.tlpCabeceraMaterias.TabIndex = 0;
            // 
            // lblTituloMaterias
            // 
            this.lblTituloMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloMaterias.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloMaterias.ForeColor = ColoresInterfaz.Negro;
            this.lblTituloMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloMaterias.Name = "lblTituloMaterias";
            this.lblTituloMaterias.Size = new System.Drawing.Size(777, 52);
            this.lblTituloMaterias.TabIndex = 0;
            this.lblTituloMaterias.Text = "Mis materias";
            this.lblTituloMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerMaterias
            // 
            this.btnVerMaterias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVerMaterias.Location = new System.Drawing.Point(783, 9);
            this.btnVerMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerMaterias.Name = "btnVerMaterias";
            this.btnVerMaterias.Size = new System.Drawing.Size(126, 34);
            this.btnVerMaterias.TabIndex = 1;
            this.btnVerMaterias.Text = "Ver todas";
            this.btnVerMaterias.UseVisualStyleBackColor = false;
            this.btnVerMaterias.Click += new System.EventHandler(this.btnVerMaterias_Click);
            // 
            // flpMaterias
            // 
            this.flpMaterias.AutoScroll = true;
            this.flpMaterias.BackColor = System.Drawing.Color.White;
            this.flpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMaterias.Location = new System.Drawing.Point(0, 52);
            this.flpMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.flpMaterias.Name = "flpMaterias";
            this.flpMaterias.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flpMaterias.Size = new System.Drawing.Size(909, 551);
            this.flpMaterias.TabIndex = 1;
            // 
            // lblSinMaterias
            // 
            this.lblSinMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSinMaterias.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSinMaterias.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblSinMaterias.Location = new System.Drawing.Point(0, 603);
            this.lblSinMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.lblSinMaterias.Name = "lblSinMaterias";
            this.lblSinMaterias.Size = new System.Drawing.Size(909, 34);
            this.lblSinMaterias.TabIndex = 2;
            this.lblSinMaterias.Text = "No hay materias inscritas.";
            this.lblSinMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSinMaterias.Visible = false;
            // 
            // pnlActividad
            // 
            this.pnlActividad.BackColor = System.Drawing.Color.White;
            this.pnlActividad.Controls.Add(this.tlpActividad);
            this.pnlActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActividad.Location = new System.Drawing.Point(977, 0);
            this.pnlActividad.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlActividad.Name = "pnlActividad";
            this.pnlActividad.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.pnlActividad.Size = new System.Drawing.Size(580, 673);
            this.pnlActividad.TabIndex = 1;
            this.pnlActividad.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTarjeta_Paint);
            // 
            // tlpActividad
            // 
            this.tlpActividad.ColumnCount = 1;
            this.tlpActividad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActividad.Controls.Add(this.tlpCabeceraActividad, 0, 0);
            this.tlpActividad.Controls.Add(this.flpActividad, 0, 1);
            this.tlpActividad.Controls.Add(this.lblSinActividad, 0, 2);
            this.tlpActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActividad.Location = new System.Drawing.Point(22, 18);
            this.tlpActividad.Margin = new System.Windows.Forms.Padding(0);
            this.tlpActividad.Name = "tlpActividad";
            this.tlpActividad.RowCount = 3;
            this.tlpActividad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpActividad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActividad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpActividad.Size = new System.Drawing.Size(536, 637);
            this.tlpActividad.TabIndex = 0;
            // 
            // tlpCabeceraActividad
            // 
            this.tlpCabeceraActividad.ColumnCount = 2;
            this.tlpCabeceraActividad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabeceraActividad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tlpCabeceraActividad.Controls.Add(this.lblTituloActividad, 0, 0);
            this.tlpCabeceraActividad.Controls.Add(this.btnVerCalificaciones, 1, 0);
            this.tlpCabeceraActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabeceraActividad.Location = new System.Drawing.Point(0, 0);
            this.tlpCabeceraActividad.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabeceraActividad.Name = "tlpCabeceraActividad";
            this.tlpCabeceraActividad.RowCount = 1;
            this.tlpCabeceraActividad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabeceraActividad.Size = new System.Drawing.Size(536, 52);
            this.tlpCabeceraActividad.TabIndex = 0;
            // 
            // lblTituloActividad
            // 
            this.lblTituloActividad.AutoEllipsis = true;
            this.lblTituloActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloActividad.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloActividad.ForeColor = ColoresInterfaz.Negro;
            this.lblTituloActividad.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloActividad.Name = "lblTituloActividad";
            this.lblTituloActividad.Size = new System.Drawing.Size(346, 52);
            this.lblTituloActividad.TabIndex = 0;
            this.lblTituloActividad.Text = "Calificaciones recientes";
            this.lblTituloActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVerCalificaciones.Location = new System.Drawing.Point(352, 9);
            this.btnVerCalificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(184, 34);
            this.btnVerCalificaciones.TabIndex = 1;
            this.btnVerCalificaciones.Text = "Ver calificaciones";
            this.btnVerCalificaciones.UseVisualStyleBackColor = false;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.btnVerCalificaciones_Click);
            // 
            // flpActividad
            // 
            this.flpActividad.AutoScroll = true;
            this.flpActividad.BackColor = System.Drawing.Color.White;
            this.flpActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActividad.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpActividad.Location = new System.Drawing.Point(0, 52);
            this.flpActividad.Margin = new System.Windows.Forms.Padding(0);
            this.flpActividad.Name = "flpActividad";
            this.flpActividad.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flpActividad.Size = new System.Drawing.Size(536, 551);
            this.flpActividad.TabIndex = 1;
            this.flpActividad.WrapContents = false;
            this.flpActividad.SizeChanged += new System.EventHandler(this.flpActividad_SizeChanged);
            // 
            // lblSinActividad
            // 
            this.lblSinActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSinActividad.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSinActividad.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblSinActividad.Location = new System.Drawing.Point(0, 603);
            this.lblSinActividad.Margin = new System.Windows.Forms.Padding(0);
            this.lblSinActividad.Name = "lblSinActividad";
            this.lblSinActividad.Size = new System.Drawing.Size(536, 34);
            this.lblSinActividad.TabIndex = 2;
            this.lblSinActividad.Text = "Todavía no hay calificaciones registradas.";
            this.lblSinActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSinActividad.Visible = false;
            // 
            // frmPanelEstudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.Fondo;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 620);
            this.Name = "frmPanelEstudiante";
            this.Text = "Panel del Estudiante";
            this.Load += new System.EventHandler(this.frmPanelEstudiante_Load);
            this.tlpPagina.ResumeLayout(false);
            this.tlpIndicadores.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.pnlMaterias.ResumeLayout(false);
            this.tlpMaterias.ResumeLayout(false);
            this.tlpCabeceraMaterias.ResumeLayout(false);
            this.pnlActividad.ResumeLayout(false);
            this.tlpActividad.ResumeLayout(false);
            this.tlpCabeceraActividad.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
