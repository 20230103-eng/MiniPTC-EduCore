namespace Vista
{
    partial class UCPerfilResumen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label lblEstado;

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
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.pnlEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlAvatar, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblNombre, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblRol, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblCodigo, 0, 3);
            this.tlpPrincipal.Controls.Add(this.pnlEstado, 0, 4);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(1, 1);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(356, 302);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Controls.Add(this.picPerfil);
            this.pnlAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvatar.Location = new System.Drawing.Point(24, 20);
            this.pnlAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Padding = new System.Windows.Forms.Padding(0);
            this.pnlAvatar.Size = new System.Drawing.Size(308, 112);
            this.pnlAvatar.TabIndex = 0;
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = ColoresInterfaz.CelesteClaro;
            this.picPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPerfil.Location = new System.Drawing.Point(118, 16);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(72, 72);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 0;
            this.picPerfil.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = ColoresInterfaz.Negro;
            this.lblNombre.Location = new System.Drawing.Point(24, 132);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(308, 52);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del usuario";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRol
            // 
            this.lblRol.AutoEllipsis = true;
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = ColoresInterfaz.AzulOscuro;
            this.lblRol.Location = new System.Drawing.Point(24, 184);
            this.lblRol.Margin = new System.Windows.Forms.Padding(0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(308, 30);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblCodigo.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblCodigo.Location = new System.Drawing.Point(24, 214);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(308, 34);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEstado
            // 
            this.pnlEstado.Controls.Add(this.lblEstado);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstado.Location = new System.Drawing.Point(24, 248);
            this.pnlEstado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Padding = new System.Windows.Forms.Padding(0);
            this.pnlEstado.Size = new System.Drawing.Size(308, 34);
            this.pnlEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = ColoresInterfaz.VerdeFondo;
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = ColoresInterfaz.VerdeTexto;
            this.lblEstado.Location = new System.Drawing.Point(109, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(90, 26);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Activo";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPerfilResumen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.Borde;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(300, 260);
            this.Name = "UCPerfilResumen";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(358, 304);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.pnlEstado.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
