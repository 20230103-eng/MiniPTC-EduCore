namespace Vista
{
    partial class UCBotonMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlSeleccion;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.Label lblTexto;

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
            this.pnlSeleccion = new System.Windows.Forms.Panel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.tlpContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 3;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.pnlSeleccion, 0, 0);
            this.tlpContenido.Controls.Add(this.picIcono, 1, 0);
            this.tlpContenido.Controls.Add(this.lblTexto, 2, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(287, 56);
            this.tlpContenido.TabIndex = 0;
            this.tlpContenido.Click += new System.EventHandler(this.Control_Click);
            this.tlpContenido.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.tlpContenido.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = ColoresInterfaz.CelesteClaro;
            this.pnlSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeleccion.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.TabIndex = 0;
            this.pnlSeleccion.Visible = false;
            // 
            // picIcono
            // 
            this.picIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picIcono.Location = new System.Drawing.Point(20, 16);
            this.picIcono.Margin = new System.Windows.Forms.Padding(0);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(24, 24);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcono.TabIndex = 1;
            this.picIcono.TabStop = false;
            this.picIcono.Click += new System.EventHandler(this.Control_Click);
            this.picIcono.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.picIcono.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoEllipsis = true;
            this.lblTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 14, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Opción";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTexto.Click += new System.EventHandler(this.Control_Click);
            this.lblTexto.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.lblTexto.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // UCBotonMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.AzulOscuro;
            this.Controls.Add(this.tlpContenido);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(180, 56);
            this.Name = "UCBotonMenu";
            this.Size = new System.Drawing.Size(287, 56);
            this.Click += new System.EventHandler(this.Control_Click);
            this.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.tlpContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
