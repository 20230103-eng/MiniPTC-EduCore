namespace Vista
{
    partial class UCEncabezadoPagina
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
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
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.tlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpContenido.Controls.Add(this.lblSubtitulo, 0, 1);
            this.tlpContenido.Controls.Add(this.pnlLinea, 0, 2);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 3;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpContenido.Size = new System.Drawing.Size(600, 68);
            this.tlpContenido.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = ColoresInterfaz.Negro;
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título página";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoEllipsis = true;
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtitulo.Visible = false;
            // 
            // pnlLinea
            // 
            this.pnlLinea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlLinea.BackColor = ColoresInterfaz.Coral;
            this.pnlLinea.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(54, 4);
            this.pnlLinea.TabIndex = 2;
            // 
            // UCEncabezadoPagina
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpContenido);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(240, 68);
            this.Name = "UCEncabezadoPagina";
            this.Size = new System.Drawing.Size(600, 68);
            this.tlpContenido.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
