namespace Vista
{
    partial class frmPerfilUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private Vista.UCEncabezadoPagina ucEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private Vista.UCPerfilResumen ucPerfil;
        private System.Windows.Forms.TableLayoutPanel tlpDerecha;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.TableLayoutPanel tlpInformacion;
        private System.Windows.Forms.Label lblInfoTitulo;
        private System.Windows.Forms.Label lblNombreEtiqueta;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblUsuarioEtiqueta;
        private System.Windows.Forms.Label lblUsuarioValor;
        private System.Windows.Forms.Label lblCodigoEtiqueta;
        private System.Windows.Forms.Label lblCodigoValor;
        private System.Windows.Forms.Label lblRolEtiqueta;
        private System.Windows.Forms.Label lblRolValor;
        private System.Windows.Forms.Label lblEstadoEtiqueta;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Panel pnlSeguridad;
        private System.Windows.Forms.TableLayoutPanel tlpSeguridad;
        private System.Windows.Forms.Label lblSeguridadTitulo;
        private System.Windows.Forms.Label lblSeguridadDescripcion;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtContrasenaActual;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.CheckBox chkMostrarContrasenas;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnCambiarContrasena;
        private System.Windows.Forms.Button btnLimpiar;

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
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.ucPerfil = new Vista.UCPerfilResumen();
            this.tlpDerecha = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.tlpInformacion = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.lblNombreEtiqueta = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblUsuarioEtiqueta = new System.Windows.Forms.Label();
            this.lblUsuarioValor = new System.Windows.Forms.Label();
            this.lblCodigoEtiqueta = new System.Windows.Forms.Label();
            this.lblCodigoValor = new System.Windows.Forms.Label();
            this.lblRolEtiqueta = new System.Windows.Forms.Label();
            this.lblRolValor = new System.Windows.Forms.Label();
            this.lblEstadoEtiqueta = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.pnlSeguridad = new System.Windows.Forms.Panel();
            this.tlpSeguridad = new System.Windows.Forms.TableLayoutPanel();
            this.lblSeguridadTitulo = new System.Windows.Forms.Label();
            this.lblSeguridadDescripcion = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.chkMostrarContrasenas = new System.Windows.Forms.CheckBox();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tlpPagina.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.tlpDerecha.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.tlpInformacion.SuspendLayout();
            this.pnlSeguridad.SuspendLayout();
            this.tlpSeguridad.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.SuspendLayout();
            //
            // tlpPagina
            //
            this.tlpPagina.BackColor = ColoresInterfaz.Fondo;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.ucEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.tlpContenido, 0, 1);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 24);
            this.tlpPagina.RowCount = 2;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // ucEncabezado
            //
            this.ucEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.ucEncabezado.Name = "ucEncabezado";
            this.ucEncabezado.Titulo = "Mi perfil";
            this.ucEncabezado.Subtitulo = "";
            //
            // tlpContenido
            //
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tlpContenido.Controls.Add(this.ucPerfil, 0, 0);
            this.tlpContenido.Controls.Add(this.tlpDerecha, 1, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // ucPerfil
            //
            this.ucPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPerfil.Location = new System.Drawing.Point(0, 12);
            this.ucPerfil.Margin = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.ucPerfil.MinimumSize = new System.Drawing.Size(280, 280);
            this.ucPerfil.Name = "ucPerfil";
            this.ucPerfil.Size = new System.Drawing.Size(470, 304);
            //
            // tlpDerecha
            //
            this.tlpDerecha.ColumnCount = 1;
            this.tlpDerecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecha.Controls.Add(this.pnlInformacion, 0, 0);
            this.tlpDerecha.Controls.Add(this.pnlSeguridad, 0, 1);
            this.tlpDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDerecha.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDerecha.RowCount = 2;
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // pnlInformacion
            //
            this.pnlInformacion.BackColor = System.Drawing.Color.White;
            this.pnlInformacion.Controls.Add(this.tlpInformacion);
            this.pnlInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.pnlInformacion.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            //
            // tlpInformacion
            //
            this.tlpInformacion.ColumnCount = 2;
            this.tlpInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInformacion.Controls.Add(this.lblInfoTitulo, 0, 0);
            this.tlpInformacion.SetColumnSpan(this.lblInfoTitulo, 2);
            this.tlpInformacion.Controls.Add(this.lblNombreEtiqueta, 0, 1);
            this.tlpInformacion.Controls.Add(this.lblNombreValor, 1, 1);
            this.tlpInformacion.Controls.Add(this.lblUsuarioEtiqueta, 0, 2);
            this.tlpInformacion.Controls.Add(this.lblUsuarioValor, 1, 2);
            this.tlpInformacion.Controls.Add(this.lblCodigoEtiqueta, 0, 3);
            this.tlpInformacion.Controls.Add(this.lblCodigoValor, 1, 3);
            this.tlpInformacion.Controls.Add(this.lblRolEtiqueta, 0, 4);
            this.tlpInformacion.Controls.Add(this.lblRolValor, 1, 4);
            this.tlpInformacion.Controls.Add(this.lblEstadoEtiqueta, 0, 5);
            this.tlpInformacion.Controls.Add(this.lblEstadoValor, 1, 5);
            this.tlpInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInformacion.RowCount = 6;
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            //
            // informational labels
            //
            this.lblInfoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitulo.ForeColor = ColoresInterfaz.Negro;
            this.lblInfoTitulo.Text = "Información personal";
            this.lblInfoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombreEtiqueta.Text = "Nombre completo";
            this.lblUsuarioEtiqueta.Text = "Usuario";
            this.lblCodigoEtiqueta.Text = "Código";
            this.lblRolEtiqueta.Text = "Rol";
            this.lblEstadoEtiqueta.Text = "Estado";
            this.lblNombreEtiqueta.AutoEllipsis = true;
            this.lblNombreEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreEtiqueta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblNombreEtiqueta.ForeColor = ColoresInterfaz.Negro;
            this.lblNombreEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuarioEtiqueta.AutoEllipsis = true;
            this.lblUsuarioEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuarioEtiqueta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioEtiqueta.ForeColor = ColoresInterfaz.Negro;
            this.lblUsuarioEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigoEtiqueta.AutoEllipsis = true;
            this.lblCodigoEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoEtiqueta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblCodigoEtiqueta.ForeColor = ColoresInterfaz.Negro;
            this.lblCodigoEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRolEtiqueta.AutoEllipsis = true;
            this.lblRolEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRolEtiqueta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblRolEtiqueta.ForeColor = ColoresInterfaz.Negro;
            this.lblRolEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstadoEtiqueta.AutoEllipsis = true;
            this.lblEstadoEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoEtiqueta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblEstadoEtiqueta.ForeColor = ColoresInterfaz.Negro;
            this.lblEstadoEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombreValor.AutoEllipsis = true;
            this.lblNombreValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreValor.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblNombreValor.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblNombreValor.Text = "-";
            this.lblNombreValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuarioValor.AutoEllipsis = true;
            this.lblUsuarioValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuarioValor.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblUsuarioValor.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblUsuarioValor.Text = "-";
            this.lblUsuarioValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigoValor.AutoEllipsis = true;
            this.lblCodigoValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoValor.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblCodigoValor.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblCodigoValor.Text = "-";
            this.lblCodigoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRolValor.AutoEllipsis = true;
            this.lblRolValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRolValor.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblRolValor.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblRolValor.Text = "-";
            this.lblRolValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstadoValor.AutoEllipsis = true;
            this.lblEstadoValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoValor.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblEstadoValor.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblEstadoValor.Text = "-";
            this.lblEstadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlSeguridad
            //
            this.pnlSeguridad.BackColor = System.Drawing.Color.White;
            this.pnlSeguridad.Controls.Add(this.tlpSeguridad);
            this.pnlSeguridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeguridad.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSeguridad.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            //
            // tlpSeguridad
            //
            this.tlpSeguridad.ColumnCount = 2;
            this.tlpSeguridad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeguridad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeguridad.Controls.Add(this.lblSeguridadTitulo, 0, 0);
            this.tlpSeguridad.SetColumnSpan(this.lblSeguridadTitulo, 2);
            this.tlpSeguridad.Controls.Add(this.lblSeguridadDescripcion, 0, 1);
            this.tlpSeguridad.SetColumnSpan(this.lblSeguridadDescripcion, 2);
            this.tlpSeguridad.Controls.Add(this.lblActual, 0, 2);
            this.tlpSeguridad.Controls.Add(this.lblNueva, 1, 2);
            this.tlpSeguridad.Controls.Add(this.txtContrasenaActual, 0, 3);
            this.tlpSeguridad.Controls.Add(this.txtNuevaContrasena, 1, 3);
            this.tlpSeguridad.Controls.Add(this.lblConfirmar, 0, 4);
            this.tlpSeguridad.SetColumnSpan(this.lblConfirmar, 2);
            this.tlpSeguridad.Controls.Add(this.txtConfirmarContrasena, 0, 5);
            this.tlpSeguridad.SetColumnSpan(this.txtConfirmarContrasena, 2);
            this.tlpSeguridad.Controls.Add(this.chkMostrarContrasenas, 0, 6);
            this.tlpSeguridad.Controls.Add(this.flpAcciones, 1, 6);
            this.tlpSeguridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeguridad.RowCount = 7;
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpSeguridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // security labels
            //
            this.lblSeguridadTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeguridadTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblSeguridadTitulo.ForeColor = ColoresInterfaz.Negro;
            this.lblSeguridadTitulo.Text = "Seguridad";
            this.lblSeguridadTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSeguridadDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeguridadDescripcion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSeguridadDescripcion.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblSeguridadDescripcion.Text = "Protege tu cuenta manteniendo segura tu contraseña.";
            this.lblActual.Text = "Contraseña actual";
            this.lblNueva.Text = "Nueva contraseña";
            this.lblConfirmar.Text = "Confirmar nueva contraseña";
            this.lblActual.AutoEllipsis = true;
            this.lblActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblActual.ForeColor = ColoresInterfaz.Negro;
            this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNueva.AutoEllipsis = true;
            this.lblNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNueva.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblNueva.ForeColor = ColoresInterfaz.Negro;
            this.lblNueva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfirmar.AutoEllipsis = true;
            this.lblConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblConfirmar.ForeColor = ColoresInterfaz.Negro;
            this.lblConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // textboxes
            //
            this.txtContrasenaActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasenaActual.Margin = new System.Windows.Forms.Padding(0, 3, 10, 5);
            this.txtNuevaContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNuevaContrasena.Margin = new System.Windows.Forms.Padding(10, 3, 0, 5);
            this.txtConfirmarContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(0, 3, 0, 5);
            //
            // chkMostrarContrasenas
            //
            this.chkMostrarContrasenas.AutoSize = true;
            this.chkMostrarContrasenas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMostrarContrasenas.Text = "Mostrar contraseñas";
            this.chkMostrarContrasenas.CheckedChanged += new System.EventHandler(this.chkMostrarContrasenas_CheckedChanged);
            //
            // flpAcciones
            //
            this.flpAcciones.Controls.Add(this.btnCambiarContrasena);
            this.flpAcciones.Controls.Add(this.btnLimpiar);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.WrapContents = false;
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 8, 0, 6);
            //
            // buttons
            //
            this.btnCambiarContrasena.Size = new System.Drawing.Size(185, 38);
            this.btnCambiarContrasena.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCambiarContrasena.Text = "Cambiar contraseña";
            this.btnCambiarContrasena.UseVisualStyleBackColor = false;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            this.btnLimpiar.Size = new System.Drawing.Size(105, 38);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // frmPerfilUsuario
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.Fondo;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 620);
            this.Name = "frmPerfilUsuario";
            this.Text = "Mi perfil";
            this.Load += new System.EventHandler(this.frmPerfilUsuario_Load);
            this.Resize += new System.EventHandler(this.frmPerfilUsuario_Resize);
            this.tlpPagina.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.tlpDerecha.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            this.tlpInformacion.ResumeLayout(false);
            this.pnlSeguridad.ResumeLayout(false);
            this.tlpSeguridad.ResumeLayout(false);
            this.tlpSeguridad.PerformLayout();
            this.flpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

    }
}
