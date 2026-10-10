namespace Vista
{
    partial class UCTarjetaKPI
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlIcono;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTitulo;

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
            this.pnlIcono = new System.Windows.Forms.Panel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpContenido.SuspendLayout();
            this.pnlIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.pnlIcono, 0, 0);
            this.tlpContenido.Controls.Add(this.lblValor, 1, 0);
            this.tlpContenido.Controls.Add(this.lblTitulo, 1, 1);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(12, 10);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 2;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tlpContenido.Size = new System.Drawing.Size(224, 78);
            this.tlpContenido.TabIndex = 0;
            // 
            // pnlIcono
            // 
            this.pnlIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIcono.BackColor = ColoresInterfaz.CelesteClaro;
            this.pnlIcono.Controls.Add(this.picIcono);
            this.pnlIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIcono.Name = "pnlIcono";
            this.tlpContenido.SetRowSpan(this.pnlIcono, 2);
            this.pnlIcono.Size = new System.Drawing.Size(46, 46);
            this.pnlIcono.TabIndex = 0;
            this.pnlIcono.Resize += new System.EventHandler(this.pnlIcono_Resize);
            // 
            // picIcono
            // 
            this.picIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcono.Location = new System.Drawing.Point(10, 10);
            this.picIcono.Name = "picIcono";
            this.picIcono.Padding = new System.Windows.Forms.Padding(10);
            this.picIcono.Size = new System.Drawing.Size(46, 46);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoEllipsis = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = ColoresInterfaz.Negro;
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "0";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Indicador";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // UCTarjetaKPI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContenido);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(168, 92);
            this.Name = "UCTarjetaKPI";
            this.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Size = new System.Drawing.Size(248, 98);
            this.Resize += new System.EventHandler(this.UCTarjetaKPI_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCTarjetaKPI_Paint);
            this.tlpContenido.ResumeLayout(false);
            this.pnlIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
