namespace Vista
{
    partial class frmInicioSesion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.TableLayoutPanel tlpMarca;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Label lblEslogan;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Panel pnlAcceso;
        private System.Windows.Forms.TableLayoutPanel tlpAccesoExterior;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.TableLayoutPanel tlpFormulario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox chkMostrarContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblAyuda;

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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.tlpMarca = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.lblEslogan = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.pnlAcceso = new System.Windows.Forms.Panel();
            this.tlpAccesoExterior = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.tlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pnlMarca.SuspendLayout();
            this.tlpMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlAcceso.SuspendLayout();
            this.tlpAccesoExterior.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.tlpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tlpPrincipal.Controls.Add(this.pnlMarca, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlAcceso, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1200, 720);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = ColoresInterfaz.Negro;
            this.pnlMarca.Controls.Add(this.tlpMarca);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlMarca.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Padding = new System.Windows.Forms.Padding(56);
            this.pnlMarca.Size = new System.Drawing.Size(528, 720);
            this.pnlMarca.TabIndex = 0;
            // 
            // tlpMarca
            // 
            this.tlpMarca.ColumnCount = 1;
            this.tlpMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarca.Controls.Add(this.picLogo, 0, 0);
            this.tlpMarca.Controls.Add(this.lblNombreSistema, 0, 1);
            this.tlpMarca.Controls.Add(this.lblEslogan, 0, 2);
            this.tlpMarca.Controls.Add(this.lblDetalleMarca, 0, 3);
            this.tlpMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarca.Location = new System.Drawing.Point(56, 56);
            this.tlpMarca.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMarca.Name = "tlpMarca";
            this.tlpMarca.RowCount = 5;
            this.tlpMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlpMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarca.Size = new System.Drawing.Size(416, 608);
            this.tlpMarca.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picLogo.Location = new System.Drawing.Point(0, 9);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoEllipsis = true;
            this.lblNombreSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold);
            this.lblNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistema.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(416, 78);
            this.lblNombreSistema.TabIndex = 1;
            this.lblNombreSistema.Text = "Sistema de Gestión Académica";
            this.lblNombreSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEslogan
            // 
            this.lblEslogan.AutoEllipsis = true;
            this.lblEslogan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEslogan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEslogan.ForeColor = ColoresInterfaz.AzulClaro;
            this.lblEslogan.Margin = new System.Windows.Forms.Padding(0);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(416, 54);
            this.lblEslogan.TabIndex = 2;
            this.lblEslogan.Text = "Tu información académica, organizada.";
            this.lblEslogan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalleMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetalleMarca.ForeColor = System.Drawing.Color.FromArgb(205, 216, 228);
            this.lblDetalleMarca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(416, 90);
            this.lblDetalleMarca.TabIndex = 3;
            this.lblDetalleMarca.Text = "Acceso seguro para administradores, profesores y estudiantes.";
            // 
            // pnlAcceso
            // 
            this.pnlAcceso.BackColor = ColoresInterfaz.Fondo;
            this.pnlAcceso.Controls.Add(this.tlpAccesoExterior);
            this.pnlAcceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcceso.Location = new System.Drawing.Point(528, 0);
            this.pnlAcceso.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAcceso.Name = "pnlAcceso";
            this.pnlAcceso.Size = new System.Drawing.Size(672, 720);
            this.pnlAcceso.TabIndex = 1;
            // 
            // tlpAccesoExterior
            // 
            this.tlpAccesoExterior.ColumnCount = 3;
            this.tlpAccesoExterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpAccesoExterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpAccesoExterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpAccesoExterior.Controls.Add(this.pnlTarjeta, 1, 1);
            this.tlpAccesoExterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAccesoExterior.Location = new System.Drawing.Point(0, 0);
            this.tlpAccesoExterior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAccesoExterior.Name = "tlpAccesoExterior";
            this.tlpAccesoExterior.RowCount = 3;
            this.tlpAccesoExterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpAccesoExterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tlpAccesoExterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpAccesoExterior.Size = new System.Drawing.Size(672, 720);
            this.tlpAccesoExterior.TabIndex = 0;
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlTarjeta.Controls.Add(this.tlpFormulario);
            this.pnlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTarjeta.Location = new System.Drawing.Point(100, 115);
            this.pnlTarjeta.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTarjeta.MaximumSize = new System.Drawing.Size(520, 520);
            this.pnlTarjeta.MinimumSize = new System.Drawing.Size(370, 430);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Padding = new System.Windows.Forms.Padding(34, 28, 34, 28);
            this.pnlTarjeta.Size = new System.Drawing.Size(470, 489);
            this.pnlTarjeta.TabIndex = 0;
            // 
            // tlpFormulario
            // 
            this.tlpFormulario.ColumnCount = 1;
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormulario.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpFormulario.Controls.Add(this.lblSubtitulo, 0, 1);
            this.tlpFormulario.Controls.Add(this.lblUsuario, 0, 2);
            this.tlpFormulario.Controls.Add(this.txtUsuario, 0, 3);
            this.tlpFormulario.Controls.Add(this.lblContrasena, 0, 4);
            this.tlpFormulario.Controls.Add(this.txtContrasena, 0, 5);
            this.tlpFormulario.Controls.Add(this.chkMostrarContrasena, 0, 6);
            this.tlpFormulario.Controls.Add(this.btnIngresar, 0, 7);
            this.tlpFormulario.Controls.Add(this.lblAyuda, 0, 8);
            this.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormulario.Location = new System.Drawing.Point(34, 28);
            this.tlpFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFormulario.Name = "tlpFormulario";
            this.tlpFormulario.RowCount = 9;
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormulario.Size = new System.Drawing.Size(402, 433);
            this.tlpFormulario.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = ColoresInterfaz.Negro;
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(402, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(402, 54);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Inicia sesión para continuar al panel correspondiente a tu cuenta.";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = ColoresInterfaz.Negro;
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(402, 28);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(0, 140);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0, 4, 0, 6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(402, 30);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = ColoresInterfaz.Negro;
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(402, 34);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
            this.lblContrasena.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(0, 218);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(0, 4, 0, 6);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(402, 30);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.AutoSize = true;
            this.chkMostrarContrasena.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkMostrarContrasena.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkMostrarContrasena.ForeColor = ColoresInterfaz.TextoSecundario;
            this.chkMostrarContrasena.Location = new System.Drawing.Point(0, 258);
            this.chkMostrarContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(138, 38);
            this.chkMostrarContrasena.TabIndex = 6;
            this.chkMostrarContrasena.Text = "Mostrar contraseña";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIngresar.Location = new System.Drawing.Point(0, 303);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(402, 40);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Iniciar sesión";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAyuda.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(402, 71);
            this.lblAyuda.TabIndex = 8;
            this.lblAyuda.Text = "El sistema identifica el rol de tu cuenta y abre automáticamente el panel autorizado.";
            // 
            // frmInicioSesion
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.Fondo;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Académica - Inicio de sesión";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.Resize += new System.EventHandler(this.frmInicioSesion_Resize);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlMarca.ResumeLayout(false);
            this.tlpMarca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlAcceso.ResumeLayout(false);
            this.tlpAccesoExterior.ResumeLayout(false);
            this.pnlTarjeta.ResumeLayout(false);
            this.tlpFormulario.ResumeLayout(false);
            this.tlpFormulario.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
