namespace Vista
{
    partial class frmPrincipalEstudiante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.TableLayoutPanel tlpSuperior;
        private System.Windows.Forms.TableLayoutPanel tlpMarca;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TableLayoutPanel tlpCuenta;
        private System.Windows.Forms.PictureBox picUsuarioSuperior;
        private System.Windows.Forms.Panel pnlDivisorSuperior;
        private System.Windows.Forms.TableLayoutPanel tlpDatosEstudiante;
        private System.Windows.Forms.Label lblRolSuperior;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel pnlSideNav;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private Vista.UCBotonMenu ucInicio;
        private Vista.UCBotonMenu ucMaterias;
        private Vista.UCBotonMenu ucCalificaciones;
        private Vista.UCBotonMenu ucPerfil;
        private Vista.UCBotonMenu ucCerrarSesion;
        private System.Windows.Forms.Panel pnlUsuarioLateral;
        private System.Windows.Forms.TableLayoutPanel tlpUsuarioLateral;
        private System.Windows.Forms.Panel pnlLineaUsuario;
        private System.Windows.Forms.PictureBox picUsuarioLateral;
        private System.Windows.Forms.Label lblRolLateral;
        private System.Windows.Forms.Panel pnlContenido;

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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.tlpSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMarca = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSistema = new System.Windows.Forms.Label();
            this.tlpCuenta = new System.Windows.Forms.TableLayoutPanel();
            this.picUsuarioSuperior = new System.Windows.Forms.PictureBox();
            this.pnlDivisorSuperior = new System.Windows.Forms.Panel();
            this.tlpDatosEstudiante = new System.Windows.Forms.TableLayoutPanel();
            this.lblRolSuperior = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlSideNav = new System.Windows.Forms.Panel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.ucInicio = new Vista.UCBotonMenu();
            this.ucMaterias = new Vista.UCBotonMenu();
            this.ucCalificaciones = new Vista.UCBotonMenu();
            this.ucPerfil = new Vista.UCBotonMenu();
            this.ucCerrarSesion = new Vista.UCBotonMenu();
            this.pnlUsuarioLateral = new System.Windows.Forms.Panel();
            this.tlpUsuarioLateral = new System.Windows.Forms.TableLayoutPanel();
            this.picUsuarioLateral = new System.Windows.Forms.PictureBox();
            this.lblRolLateral = new System.Windows.Forms.Label();
            this.pnlLineaUsuario = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            this.tlpSuperior.SuspendLayout();
            this.tlpMarca.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioSuperior)).BeginInit();
            this.tlpDatosEstudiante.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.pnlSideNav.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.pnlUsuarioLateral.SuspendLayout();
            this.tlpUsuarioLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioLateral)).BeginInit();
            this.SuspendLayout();
            //
            // pnlSuperior
            //
            this.pnlSuperior.BackColor = ColoresInterfaz.Negro;
            this.pnlSuperior.Controls.Add(this.tlpSuperior);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1904, 100);
            this.pnlSuperior.TabIndex = 0;
            //
            // tlpSuperior
            //
            this.tlpSuperior.ColumnCount = 2;
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tlpSuperior.Controls.Add(this.tlpMarca, 0, 0);
            this.tlpSuperior.Controls.Add(this.tlpCuenta, 1, 0);
            this.tlpSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSuperior.Name = "tlpSuperior";
            this.tlpSuperior.RowCount = 1;
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSuperior.Size = new System.Drawing.Size(1904, 100);
            this.tlpSuperior.TabIndex = 0;
            //
            // tlpMarca
            //
            this.tlpMarca.ColumnCount = 2;
            this.tlpMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarca.Controls.Add(this.pnlLogo, 0, 0);
            this.tlpMarca.Controls.Add(this.lblSistema, 1, 0);
            this.tlpMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarca.Location = new System.Drawing.Point(0, 0);
            this.tlpMarca.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMarca.Name = "tlpMarca";
            this.tlpMarca.RowCount = 1;
            this.tlpMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarca.Size = new System.Drawing.Size(1594, 100);
            this.tlpMarca.TabIndex = 0;
            //
            // pnlLogo
            //
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(18, 18, 14, 18);
            this.pnlLogo.Size = new System.Drawing.Size(92, 100);
            this.pnlLogo.TabIndex = 0;
            //
            // picLogo
            //
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(18, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            //
            // lblSistema
            //
            this.lblSistema.AutoEllipsis = true;
            this.lblSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Sistema de Gestión Académica";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // tlpCuenta
            //
            this.tlpCuenta.ColumnCount = 3;
            this.tlpCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuenta.Controls.Add(this.picUsuarioSuperior, 0, 0);
            this.tlpCuenta.Controls.Add(this.pnlDivisorSuperior, 1, 0);
            this.tlpCuenta.Controls.Add(this.tlpDatosEstudiante, 2, 0);
            this.tlpCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCuenta.Location = new System.Drawing.Point(1594, 0);
            this.tlpCuenta.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCuenta.Name = "tlpCuenta";
            this.tlpCuenta.RowCount = 1;
            this.tlpCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuenta.Size = new System.Drawing.Size(310, 100);
            this.tlpCuenta.TabIndex = 1;
            //
            // picUsuarioSuperior
            //
            this.picUsuarioSuperior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUsuarioSuperior.Location = new System.Drawing.Point(11, 34);
            this.picUsuarioSuperior.Name = "picUsuarioSuperior";
            this.picUsuarioSuperior.Size = new System.Drawing.Size(32, 32);
            this.picUsuarioSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuarioSuperior.TabIndex = 0;
            this.picUsuarioSuperior.TabStop = false;
            //
            // pnlDivisorSuperior
            //
            this.pnlDivisorSuperior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDivisorSuperior.BackColor = System.Drawing.Color.FromArgb(92, 108, 131);
            this.pnlDivisorSuperior.Location = new System.Drawing.Point(62, 30);
            this.pnlDivisorSuperior.Name = "pnlDivisorSuperior";
            this.pnlDivisorSuperior.Size = new System.Drawing.Size(1, 40);
            this.pnlDivisorSuperior.TabIndex = 1;
            //
            // tlpDatosEstudiante
            //
            this.tlpDatosEstudiante.ColumnCount = 1;
            this.tlpDatosEstudiante.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosEstudiante.Controls.Add(this.lblRolSuperior, 0, 0);
            this.tlpDatosEstudiante.Controls.Add(this.lblNombreEstudiante, 0, 1);
            this.tlpDatosEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosEstudiante.Location = new System.Drawing.Point(72, 0);
            this.tlpDatosEstudiante.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.tlpDatosEstudiante.Name = "tlpDatosEstudiante";
            this.tlpDatosEstudiante.RowCount = 2;
            this.tlpDatosEstudiante.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosEstudiante.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosEstudiante.Size = new System.Drawing.Size(226, 100);
            this.tlpDatosEstudiante.TabIndex = 2;
            //
            // lblRolSuperior
            //
            this.lblRolSuperior.AutoEllipsis = true;
            this.lblRolSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRolSuperior.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRolSuperior.ForeColor = System.Drawing.Color.FromArgb(190, 201, 215);
            this.lblRolSuperior.Margin = new System.Windows.Forms.Padding(4, 22, 0, 0);
            this.lblRolSuperior.Name = "lblRolSuperior";
            this.lblRolSuperior.TabIndex = 0;
            this.lblRolSuperior.Text = "Estudiante";
            this.lblRolSuperior.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblNombreEstudiante
            //
            this.lblNombreEstudiante.AutoEllipsis = true;
            this.lblNombreEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblNombreEstudiante.Margin = new System.Windows.Forms.Padding(4, 0, 0, 22);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.TabIndex = 1;
            this.lblNombreEstudiante.Text = "Estudiante";
            this.lblNombreEstudiante.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            // pnlCuerpo
            //
            this.pnlCuerpo.Controls.Add(this.pnlContenido);
            this.pnlCuerpo.Controls.Add(this.pnlSideNav);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 100);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1904, 941);
            this.pnlCuerpo.TabIndex = 1;
            //
            // pnlContenido
            //
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(287, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1617, 941);
            this.pnlContenido.TabIndex = 1;
            //
            // pnlSideNav
            //
            this.pnlSideNav.BackColor = ColoresInterfaz.AzulOscuro;
            this.pnlSideNav.Controls.Add(this.tlpMenu);
            this.pnlSideNav.Controls.Add(this.pnlUsuarioLateral);
            this.pnlSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNav.Location = new System.Drawing.Point(0, 0);
            this.pnlSideNav.Name = "pnlSideNav";
            this.pnlSideNav.Size = new System.Drawing.Size(287, 941);
            this.pnlSideNav.TabIndex = 0;
            //
            // tlpMenu
            //
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Controls.Add(this.ucInicio, 0, 0);
            this.tlpMenu.Controls.Add(this.ucMaterias, 0, 1);
            this.tlpMenu.Controls.Add(this.ucCalificaciones, 0, 2);
            this.tlpMenu.Controls.Add(this.ucPerfil, 0, 3);
            this.tlpMenu.Controls.Add(this.ucCerrarSesion, 0, 4);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 5;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMenu.Size = new System.Drawing.Size(287, 320);
            this.tlpMenu.TabIndex = 0;
            //
            // ucInicio
            // 
            this.ucInicio.ArchivoIcono = "icon_home.png";
            this.ucInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInicio.Location = new System.Drawing.Point(0, 0);
            this.ucInicio.Margin = new System.Windows.Forms.Padding(0);
            this.ucInicio.Name = "ucInicio";
            this.ucInicio.Seleccionado = false;
            this.ucInicio.Size = new System.Drawing.Size(287, 64);
            this.ucInicio.TabIndex = 0;
            this.ucInicio.Texto = "Inicio";
            this.ucInicio.BotonClick += new System.EventHandler(this.ucInicio_BotonClick);
            // 
            // ucMaterias
            //
            this.ucMaterias.ArchivoIcono = "icon_book.png";
            this.ucMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMaterias.Location = new System.Drawing.Point(0, 64);
            this.ucMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.ucMaterias.Name = "ucMaterias";
            this.ucMaterias.Seleccionado = false;
            this.ucMaterias.Size = new System.Drawing.Size(287, 64);
            this.ucMaterias.TabIndex = 1;
            this.ucMaterias.Texto = "Mis materias";
            this.ucMaterias.BotonClick += new System.EventHandler(this.ucMaterias_BotonClick);
            //
            // ucCalificaciones
            //
            this.ucCalificaciones.ArchivoIcono = "icon_grades.png";
            this.ucCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalificaciones.Location = new System.Drawing.Point(0, 128);
            this.ucCalificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.ucCalificaciones.Name = "ucCalificaciones";
            this.ucCalificaciones.Seleccionado = false;
            this.ucCalificaciones.Size = new System.Drawing.Size(287, 64);
            this.ucCalificaciones.TabIndex = 2;
            this.ucCalificaciones.Texto = "Calificaciones";
            this.ucCalificaciones.BotonClick += new System.EventHandler(this.ucCalificaciones_BotonClick);
            //
            // ucPerfil
            //
            this.ucPerfil.ArchivoIcono = "icon_user.png";
            this.ucPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPerfil.Location = new System.Drawing.Point(0, 192);
            this.ucPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.ucPerfil.Name = "ucPerfil";
            this.ucPerfil.Seleccionado = false;
            this.ucPerfil.Size = new System.Drawing.Size(287, 64);
            this.ucPerfil.TabIndex = 3;
            this.ucPerfil.Texto = "Mi perfil";
            this.ucPerfil.BotonClick += new System.EventHandler(this.ucPerfil_BotonClick);
            //
            // ucCerrarSesion
            //
            this.ucCerrarSesion.ArchivoIcono = "icon_delete.png";
            this.ucCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCerrarSesion.Location = new System.Drawing.Point(0, 256);
            this.ucCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.ucCerrarSesion.Name = "ucCerrarSesion";
            this.ucCerrarSesion.Seleccionado = false;
            this.ucCerrarSesion.Size = new System.Drawing.Size(287, 64);
            this.ucCerrarSesion.TabIndex = 4;
            this.ucCerrarSesion.Texto = "Cerrar sesión";
            this.ucCerrarSesion.BotonClick += new System.EventHandler(this.ucCerrarSesion_BotonClick);
            //
            // pnlUsuarioLateral
            //
            this.pnlUsuarioLateral.Controls.Add(this.tlpUsuarioLateral);
            this.pnlUsuarioLateral.Controls.Add(this.pnlLineaUsuario);
            this.pnlUsuarioLateral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuarioLateral.Location = new System.Drawing.Point(0, 855);
            this.pnlUsuarioLateral.Name = "pnlUsuarioLateral";
            this.pnlUsuarioLateral.Padding = new System.Windows.Forms.Padding(16, 0, 12, 0);
            this.pnlUsuarioLateral.Size = new System.Drawing.Size(287, 86);
            this.pnlUsuarioLateral.TabIndex = 1;
            //
            // tlpUsuarioLateral
            //
            this.tlpUsuarioLateral.ColumnCount = 2;
            this.tlpUsuarioLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpUsuarioLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuarioLateral.Controls.Add(this.picUsuarioLateral, 0, 0);
            this.tlpUsuarioLateral.Controls.Add(this.lblRolLateral, 1, 0);
            this.tlpUsuarioLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarioLateral.Location = new System.Drawing.Point(16, 1);
            this.tlpUsuarioLateral.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUsuarioLateral.Name = "tlpUsuarioLateral";
            this.tlpUsuarioLateral.RowCount = 1;
            this.tlpUsuarioLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuarioLateral.Size = new System.Drawing.Size(259, 85);
            this.tlpUsuarioLateral.TabIndex = 1;
            //
            // picUsuarioLateral
            //
            this.picUsuarioLateral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUsuarioLateral.Location = new System.Drawing.Point(8, 29);
            this.picUsuarioLateral.Name = "picUsuarioLateral";
            this.picUsuarioLateral.Size = new System.Drawing.Size(28, 28);
            this.picUsuarioLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuarioLateral.TabIndex = 0;
            this.picUsuarioLateral.TabStop = false;
            //
            // lblRolLateral
            //
            this.lblRolLateral.AutoEllipsis = true;
            this.lblRolLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRolLateral.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRolLateral.ForeColor = System.Drawing.Color.White;
            this.lblRolLateral.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblRolLateral.Name = "lblRolLateral";
            this.lblRolLateral.TabIndex = 1;
            this.lblRolLateral.Text = "Estudiante";
            this.lblRolLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlLineaUsuario
            //
            this.pnlLineaUsuario.BackColor = System.Drawing.Color.FromArgb(96, 130, 166);
            this.pnlLineaUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineaUsuario.Location = new System.Drawing.Point(16, 0);
            this.pnlLineaUsuario.Name = "pnlLineaUsuario";
            this.pnlLineaUsuario.Size = new System.Drawing.Size(259, 1);
            this.pnlLineaUsuario.TabIndex = 0;
            //
            // frmPrincipalEstudiante
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "frmPrincipalEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Académica - Estudiante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipalEstudiante_Load);
            this.Resize += new System.EventHandler(this.frmPrincipalEstudiante_Resize);
            this.pnlSuperior.ResumeLayout(false);
            this.tlpSuperior.ResumeLayout(false);
            this.tlpMarca.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpCuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioSuperior)).EndInit();
            this.tlpDatosEstudiante.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlSideNav.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.pnlUsuarioLateral.ResumeLayout(false);
            this.tlpUsuarioLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioLateral)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
