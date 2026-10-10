namespace Vista
{
    partial class UCTablaUsuarios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Panel pnlFilas;
        private System.Windows.Forms.Label lblSinRegistros;

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
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.pnlFilas = new System.Windows.Forms.Panel();
            this.lblSinRegistros = new System.Windows.Forms.Label();
            this.tlpEncabezado.SuspendLayout();
            this.pnlFilas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.BackColor = System.Drawing.Color.FromArgb(240, 247, 251);
            this.tlpEncabezado.ColumnCount = 6;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEncabezado.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpEncabezado.Controls.Add(this.lblNombre, 1, 0);
            this.tlpEncabezado.Controls.Add(this.lblRol, 2, 0);
            this.tlpEncabezado.Controls.Add(this.lblUsuario, 3, 0);
            this.tlpEncabezado.Controls.Add(this.lblEstado, 4, 0);
            this.tlpEncabezado.Controls.Add(this.lblAcciones, 5, 0);
            this.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezado.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 1;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1130, 42);
            this.tlpEncabezado.TabIndex = 0;
            // 
            // header labels
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = ColoresInterfaz.Negro;
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(14, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = ColoresInterfaz.Negro;
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRol.AutoEllipsis = true;
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = ColoresInterfaz.Negro;
            this.lblRol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Text = "Rol";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.AutoEllipsis = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = ColoresInterfaz.Negro;
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.AutoEllipsis = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = ColoresInterfaz.Negro;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAcciones.AutoEllipsis = true;
            this.lblAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAcciones.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAcciones.ForeColor = ColoresInterfaz.Negro;
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Text = "Acciones";
            this.lblAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilas
            // 
            this.pnlFilas.AutoScroll = true;
            this.pnlFilas.BackColor = System.Drawing.Color.White;
            this.pnlFilas.Controls.Add(this.lblSinRegistros);
            this.pnlFilas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilas.Location = new System.Drawing.Point(0, 42);
            this.pnlFilas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFilas.Name = "pnlFilas";
            this.pnlFilas.Size = new System.Drawing.Size(1130, 334);
            this.pnlFilas.TabIndex = 1;
            this.pnlFilas.Resize += new System.EventHandler(this.pnlFilas_Resize);
            // 
            // lblSinRegistros
            // 
            this.lblSinRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSinRegistros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSinRegistros.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblSinRegistros.Location = new System.Drawing.Point(0, 0);
            this.lblSinRegistros.Name = "lblSinRegistros";
            this.lblSinRegistros.Size = new System.Drawing.Size(1130, 334);
            this.lblSinRegistros.TabIndex = 0;
            this.lblSinRegistros.Text = "No hay registros para mostrar";
            this.lblSinRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCTablaUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlFilas);
            this.Controls.Add(this.tlpEncabezado);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(650, 250);
            this.Name = "UCTablaUsuarios";
            this.Size = new System.Drawing.Size(1130, 376);
            this.Resize += new System.EventHandler(this.UCTablaUsuarios_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCTablaUsuarios_Paint);
            this.tlpEncabezado.ResumeLayout(false);
            this.pnlFilas.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
