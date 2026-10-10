namespace Vista
{
    partial class UCFilaUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpFila;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private Vista.UCChipEstado ucEstado;
        private System.Windows.Forms.TableLayoutPanel tlpAcciones;
        private Vista.UCBotonAccion ucVer;
        private Vista.UCBotonAccion ucEditar;
        private Vista.UCBotonAccion ucEliminar;
        private System.Windows.Forms.Panel pnlLinea;

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
            this.tlpFila = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ucEstado = new Vista.UCChipEstado();
            this.tlpAcciones = new System.Windows.Forms.TableLayoutPanel();
            this.ucVer = new Vista.UCBotonAccion();
            this.ucEditar = new Vista.UCBotonAccion();
            this.ucEliminar = new Vista.UCBotonAccion();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.tlpFila.SuspendLayout();
            this.tlpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFila
            // 
            this.tlpFila.ColumnCount = 6;
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFila.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpFila.Controls.Add(this.lblNombre, 1, 0);
            this.tlpFila.Controls.Add(this.lblRol, 2, 0);
            this.tlpFila.Controls.Add(this.lblUsuario, 3, 0);
            this.tlpFila.Controls.Add(this.ucEstado, 4, 0);
            this.tlpFila.Controls.Add(this.tlpAcciones, 5, 0);
            this.tlpFila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFila.Location = new System.Drawing.Point(0, 0);
            this.tlpFila.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFila.Name = "tlpFila";
            this.tlpFila.RowCount = 1;
            this.tlpFila.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFila.Size = new System.Drawing.Size(1130, 50);
            this.tlpFila.TabIndex = 0;
            this.tlpFila.MouseEnter += new System.EventHandler(this.Fila_MouseEnter);
            this.tlpFila.MouseLeave += new System.EventHandler(this.Fila_MouseLeave);
            // 
            // labels
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCodigo.ForeColor = ColoresInterfaz.Negro;
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(14, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "2023001";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.MouseEnter += new System.EventHandler(this.Fila_MouseEnter);
            this.lblCodigo.MouseLeave += new System.EventHandler(this.Fila_MouseLeave);
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombre.ForeColor = ColoresInterfaz.Negro;
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ana María López";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.MouseEnter += new System.EventHandler(this.Fila_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.Fila_MouseLeave);
            this.lblRol.AutoEllipsis = true;
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRol.ForeColor = ColoresInterfaz.Negro;
            this.lblRol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Estudiante";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRol.MouseEnter += new System.EventHandler(this.Fila_MouseEnter);
            this.lblRol.MouseLeave += new System.EventHandler(this.Fila_MouseLeave);
            this.lblUsuario.AutoEllipsis = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUsuario.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "est01";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.MouseEnter += new System.EventHandler(this.Fila_MouseEnter);
            this.lblUsuario.MouseLeave += new System.EventHandler(this.Fila_MouseLeave);
            // 
            // ucEstado
            // 
            this.ucEstado.Activo = true;
            this.ucEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ucEstado.Name = "ucEstado";
            this.ucEstado.Size = new System.Drawing.Size(70, 24);
            this.ucEstado.TabIndex = 4;
            // 
            // tlpAcciones
            // 
            this.tlpAcciones.ColumnCount = 3;
            this.tlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAcciones.Controls.Add(this.ucVer, 0, 0);
            this.tlpAcciones.Controls.Add(this.ucEditar, 1, 0);
            this.tlpAcciones.Controls.Add(this.ucEliminar, 2, 0);
            this.tlpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAcciones.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tlpAcciones.Name = "tlpAcciones";
            this.tlpAcciones.RowCount = 1;
            this.tlpAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAcciones.TabIndex = 5;
            // 
            // action buttons
            // 
            this.ucVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucVer.ArchivoIcono = "action_eye.png";
            this.ucVer.Margin = new System.Windows.Forms.Padding(0);
            this.ucVer.Name = "ucVer";
            this.ucVer.Size = new System.Drawing.Size(30, 30);
            this.ucVer.TabIndex = 0;
            this.ucVer.AccionClick += new System.EventHandler(this.ucVer_AccionClick);
            this.ucEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucEditar.ArchivoIcono = "action_edit.png";
            this.ucEditar.Margin = new System.Windows.Forms.Padding(0);
            this.ucEditar.Name = "ucEditar";
            this.ucEditar.Size = new System.Drawing.Size(30, 30);
            this.ucEditar.TabIndex = 1;
            this.ucEditar.AccionClick += new System.EventHandler(this.ucEditar_AccionClick);
            this.ucEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucEliminar.ArchivoIcono = "action_delete.png";
            this.ucEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.ucEliminar.Name = "ucEliminar";
            this.ucEliminar.Size = new System.Drawing.Size(30, 30);
            this.ucEliminar.TabIndex = 2;
            this.ucEliminar.AccionClick += new System.EventHandler(this.ucEliminar_AccionClick);
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(236, 240, 244);
            this.pnlLinea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLinea.Location = new System.Drawing.Point(0, 49);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(1130, 1);
            this.pnlLinea.TabIndex = 1;
            // 
            // UCFilaUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlLinea);
            this.Controls.Add(this.tlpFila);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(650, 50);
            this.Name = "UCFilaUsuario";
            this.Size = new System.Drawing.Size(1130, 50);
            this.tlpFila.ResumeLayout(false);
            this.tlpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
