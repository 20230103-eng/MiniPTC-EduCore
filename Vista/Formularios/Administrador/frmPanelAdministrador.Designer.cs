namespace Vista
{
    partial class frmPanelAdministrador
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpIndicadores;
        private Vista.UCTarjetaKPI ucEstudiantes;
        private Vista.UCTarjetaKPI ucProfesores;
        private Vista.UCTarjetaKPI ucMaterias;
        private Vista.UCTarjetaKPI ucCalificaciones;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private Vista.UCCajaBusqueda ucBuscar;
        private Vista.UCSelectorTipo ucTipo;
        private Vista.UCTablaUsuarios ucTablaUsuarios;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnNuevoRegistro;

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
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.ucEncabezado = new Vista.UCEncabezadoPagina();
            this.tlpIndicadores = new System.Windows.Forms.TableLayoutPanel();
            this.ucEstudiantes = new Vista.UCTarjetaKPI();
            this.ucProfesores = new Vista.UCTarjetaKPI();
            this.ucMaterias = new Vista.UCTarjetaKPI();
            this.ucCalificaciones = new Vista.UCTarjetaKPI();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.ucBuscar = new Vista.UCCajaBusqueda();
            this.ucTipo = new Vista.UCSelectorTipo();
            this.ucTablaUsuarios = new Vista.UCTablaUsuarios();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpPagina.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            this.tlpIndicadores.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPagina
            // 
            this.tlpPagina.BackColor = System.Drawing.Color.White;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.tlpResumen, 0, 0);
            this.tlpPagina.Controls.Add(this.tlpFiltros, 0, 1);
            this.tlpPagina.Controls.Add(this.ucTablaUsuarios, 0, 2);
            this.tlpPagina.Controls.Add(this.flpAcciones, 0, 3);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 26, 30, 22);
            this.tlpPagina.RowCount = 4;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPagina.Size = new System.Drawing.Size(1617, 941);
            this.tlpPagina.TabIndex = 0;
            // 
            // tlpResumen
            // 
            this.tlpResumen.ColumnCount = 2;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlpResumen.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpResumen.Controls.Add(this.tlpIndicadores, 1, 0);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResumen.Location = new System.Drawing.Point(30, 26);
            this.tlpResumen.Margin = new System.Windows.Forms.Padding(0);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 1;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Size = new System.Drawing.Size(1557, 132);
            this.tlpResumen.TabIndex = 0;
            // 
            // ucEncabezado
            // 
            this.ucEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.ucEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.ucEncabezado.Location = new System.Drawing.Point(0, 32);
            this.ucEncabezado.Margin = new System.Windows.Forms.Padding(0, 0, 26, 0);
            this.ucEncabezado.Name = "ucEncabezado";
            this.ucEncabezado.Size = new System.Drawing.Size(409, 68);
            this.ucEncabezado.Subtitulo = "";
            this.ucEncabezado.TabIndex = 0;
            this.ucEncabezado.Titulo = "Panel de Administración";
            // 
            // tlpIndicadores
            // 
            this.tlpIndicadores.ColumnCount = 4;
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.Controls.Add(this.ucEstudiantes, 0, 0);
            this.tlpIndicadores.Controls.Add(this.ucProfesores, 1, 0);
            this.tlpIndicadores.Controls.Add(this.ucMaterias, 2, 0);
            this.tlpIndicadores.Controls.Add(this.ucCalificaciones, 3, 0);
            this.tlpIndicadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndicadores.Location = new System.Drawing.Point(435, 0);
            this.tlpIndicadores.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIndicadores.Name = "tlpIndicadores";
            this.tlpIndicadores.RowCount = 1;
            this.tlpIndicadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndicadores.Size = new System.Drawing.Size(1122, 132);
            this.tlpIndicadores.TabIndex = 1;
            // 
            // KPI controls
            // 
            this.ucEstudiantes.ArchivoIcono = "kpi_students.png";
            this.ucEstudiantes.ColorIcono = ColoresInterfaz.CelesteClaro;
            this.ucEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEstudiantes.Margin = new System.Windows.Forms.Padding(5, 17, 8, 17);
            this.ucEstudiantes.Name = "ucEstudiantes";
            this.ucEstudiantes.TabIndex = 0;
            this.ucEstudiantes.Titulo = "Estudiantes";
            this.ucEstudiantes.Valor = "0";
            this.ucProfesores.ArchivoIcono = "kpi_professors.png";
            this.ucProfesores.ColorIcono = System.Drawing.Color.FromArgb(221, 249, 252);
            this.ucProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProfesores.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.ucProfesores.Name = "ucProfesores";
            this.ucProfesores.TabIndex = 1;
            this.ucProfesores.Titulo = "Profesores";
            this.ucProfesores.Valor = "0";
            this.ucMaterias.ArchivoIcono = "kpi_book.png";
            this.ucMaterias.ColorIcono = System.Drawing.Color.FromArgb(235, 244, 252);
            this.ucMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMaterias.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.ucMaterias.Name = "ucMaterias";
            this.ucMaterias.TabIndex = 2;
            this.ucMaterias.Titulo = "Materias";
            this.ucMaterias.Valor = "0";
            this.ucCalificaciones.ArchivoIcono = "kpi_grades.png";
            this.ucCalificaciones.ColorIcono = System.Drawing.Color.FromArgb(255, 235, 229);
            this.ucCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalificaciones.Margin = new System.Windows.Forms.Padding(8, 17, 5, 17);
            this.ucCalificaciones.Name = "ucCalificaciones";
            this.ucCalificaciones.TabIndex = 3;
            this.ucCalificaciones.Titulo = "Calificaciones";
            this.ucCalificaciones.Valor = "0";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 4;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.ucBuscar, 0, 0);
            this.tlpFiltros.Controls.Add(this.ucTipo, 2, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(30, 158);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 1;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Size = new System.Drawing.Size(1557, 64);
            this.tlpFiltros.TabIndex = 1;
            // 
            // ucBuscar
            // 
            this.ucBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.ucBuscar.Location = new System.Drawing.Point(0, 11);
            this.ucBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.ucBuscar.Name = "ucBuscar";
            this.ucBuscar.Size = new System.Drawing.Size(320, 42);
            this.ucBuscar.TabIndex = 0;
            this.ucBuscar.TextoVacio = "Buscar registro";
            this.ucBuscar.TextoCambiado += new System.EventHandler(this.ucBuscar_TextoCambiado);
            // 
            // ucTipo
            // 
            this.ucTipo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.ucTipo.Location = new System.Drawing.Point(348, 11);
            this.ucTipo.Margin = new System.Windows.Forms.Padding(0);
            this.ucTipo.Name = "ucTipo";
            this.ucTipo.Size = new System.Drawing.Size(285, 42);
            this.ucTipo.TabIndex = 1;
            this.ucTipo.SeleccionCambiada += new System.EventHandler(this.ucTipo_SeleccionCambiada);
            // 
            // ucTablaUsuarios
            // 
            this.ucTablaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTablaUsuarios.Location = new System.Drawing.Point(30, 222);
            this.ucTablaUsuarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucTablaUsuarios.Name = "ucTablaUsuarios";
            this.ucTablaUsuarios.Size = new System.Drawing.Size(1557, 643);
            this.ucTablaUsuarios.TabIndex = 2;
            this.ucTablaUsuarios.VerUsuario += new System.EventHandler<Vista.UsuarioTablaEventArgs>(this.ucTablaUsuarios_VerUsuario);
            this.ucTablaUsuarios.EditarUsuario += new System.EventHandler<Vista.UsuarioTablaEventArgs>(this.ucTablaUsuarios_EditarUsuario);
            this.ucTablaUsuarios.EliminarUsuario += new System.EventHandler<Vista.UsuarioTablaEventArgs>(this.ucTablaUsuarios_EliminarUsuario);
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnNuevoRegistro);
            this.flpAcciones.Controls.Add(this.btnGuardarCambios);
            this.flpAcciones.Controls.Add(this.btnCancelar);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(30, 875);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpAcciones.Size = new System.Drawing.Size(1557, 44);
            this.flpAcciones.TabIndex = 3;
            this.flpAcciones.WrapContents = false;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.BackColor = ColoresInterfaz.AzulOscuro;
            this.btnNuevoRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoRegistro.FlatAppearance.BorderSize = 0;
            this.btnNuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoRegistro.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRegistro.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnNuevoRegistro.Size = new System.Drawing.Size(150, 42);
            this.btnNuevoRegistro.TabIndex = 0;
            this.btnNuevoRegistro.Text = "Nuevo registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = false;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = ColoresInterfaz.Coral;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnGuardarCambios.Size = new System.Drawing.Size(164, 42);
            this.btnGuardarCambios.TabIndex = 1;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = ColoresInterfaz.AzulClaro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = ColoresInterfaz.AzulOscuro;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPanelAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 620);
            this.Name = "frmPanelAdministrador";
            this.Text = "Panel de Administración";
            this.Load += new System.EventHandler(this.frmPanelAdministrador_Load);
            this.tlpPagina.ResumeLayout(false);
            this.tlpResumen.ResumeLayout(false);
            this.tlpIndicadores.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
