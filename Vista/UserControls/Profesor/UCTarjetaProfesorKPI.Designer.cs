namespace Vista
{
    partial class UCTarjetaProfesorKPI
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlAcento;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlIcono;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.TableLayoutPanel tlpTextos;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDetalle;

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
            this.pnlAcento = new System.Windows.Forms.Panel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIcono = new System.Windows.Forms.Panel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.tlpTextos = new System.Windows.Forms.TableLayoutPanel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.tlpContenido.SuspendLayout();
            this.pnlIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.tlpTextos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcento
            // 
            this.pnlAcento.BackColor = ColoresInterfaz.AzulOscuro;
            this.pnlAcento.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcento.Location = new System.Drawing.Point(0, 0);
            this.pnlAcento.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAcento.Name = "pnlAcento";
            this.pnlAcento.Size = new System.Drawing.Size(5, 108);
            this.pnlAcento.TabIndex = 0;
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.pnlIcono, 0, 0);
            this.tlpContenido.Controls.Add(this.tlpTextos, 1, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(5, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(275, 108);
            this.tlpContenido.TabIndex = 1;
            // 
            // pnlIcono
            // 
            this.pnlIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIcono.BackColor = ColoresInterfaz.CelesteClaro;
            this.pnlIcono.Controls.Add(this.picIcono);
            this.pnlIcono.Location = new System.Drawing.Point(19, 25);
            this.pnlIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIcono.Name = "pnlIcono";
            this.pnlIcono.Padding = new System.Windows.Forms.Padding(11);
            this.pnlIcono.Size = new System.Drawing.Size(48, 48);
            this.pnlIcono.TabIndex = 0;
            this.pnlIcono.Resize += new System.EventHandler(this.pnlIcono_Resize);
            // 
            // picIcono
            // 
            this.picIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcono.Location = new System.Drawing.Point(11, 11);
            this.picIcono.Margin = new System.Windows.Forms.Padding(0);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(26, 26);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // tlpTextos
            // 
            this.tlpTextos.ColumnCount = 1;
            this.tlpTextos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextos.Controls.Add(this.lblValor, 0, 0);
            this.tlpTextos.Controls.Add(this.lblTitulo, 0, 1);
            this.tlpTextos.Controls.Add(this.lblDetalle, 0, 2);
            this.tlpTextos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTextos.Location = new System.Drawing.Point(76, 10);
            this.tlpTextos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTextos.Name = "tlpTextos";
            this.tlpTextos.RowCount = 3;
            this.tlpTextos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlpTextos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpTextos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpTextos.Size = new System.Drawing.Size(189, 88);
            this.tlpTextos.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoEllipsis = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblValor.ForeColor = ColoresInterfaz.Negro;
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(181, 38);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "0";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = ColoresInterfaz.Negro;
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Indicador";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoEllipsis = true;
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblDetalle.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(181, 25);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "Detalle";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // UCTarjetaProfesorKPI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContenido);
            this.Controls.Add(this.pnlAcento);
            this.MinimumSize = new System.Drawing.Size(170, 100);
            this.Name = "UCTarjetaProfesorKPI";
            this.Size = new System.Drawing.Size(280, 108);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCTarjetaProfesorKPI_Paint);
            this.tlpContenido.ResumeLayout(false);
            this.pnlIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.tlpTextos.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
