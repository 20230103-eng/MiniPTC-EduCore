namespace Vista
{
    partial class UCActividadProfesor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlIcono;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.TableLayoutPanel tlpTextos;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblNota;

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
            this.tlpTextos = new System.Windows.Forms.TableLayoutPanel();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.tlpContenido.SuspendLayout();
            this.pnlIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.tlpTextos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 3;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpContenido.Controls.Add(this.pnlIcono, 0, 0);
            this.tlpContenido.Controls.Add(this.tlpTextos, 1, 0);
            this.tlpContenido.Controls.Add(this.lblNota, 2, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(430, 72);
            this.tlpContenido.TabIndex = 0;
            // 
            // pnlIcono
            // 
            this.pnlIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIcono.BackColor = System.Drawing.Color.FromArgb(238, 246, 251);
            this.pnlIcono.Controls.Add(this.picIcono);
            this.pnlIcono.Location = new System.Drawing.Point(16, 17);
            this.pnlIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIcono.Name = "pnlIcono";
            this.pnlIcono.Padding = new System.Windows.Forms.Padding(8);
            this.pnlIcono.Size = new System.Drawing.Size(36, 36);
            this.pnlIcono.TabIndex = 0;
            // 
            // picIcono
            // 
            this.picIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcono.Location = new System.Drawing.Point(8, 8);
            this.picIcono.Margin = new System.Windows.Forms.Padding(0);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(20, 20);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // tlpTextos
            // 
            this.tlpTextos.ColumnCount = 1;
            this.tlpTextos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextos.Controls.Add(this.lblEstudiante, 0, 0);
            this.tlpTextos.Controls.Add(this.lblDetalle, 0, 1);
            this.tlpTextos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTextos.Location = new System.Drawing.Point(64, 8);
            this.tlpTextos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTextos.Name = "tlpTextos";
            this.tlpTextos.RowCount = 2;
            this.tlpTextos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpTextos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpTextos.Size = new System.Drawing.Size(286, 56);
            this.tlpTextos.TabIndex = 1;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoEllipsis = true;
            this.lblEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstudiante.ForeColor = ColoresInterfaz.Negro;
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(0, 4, 8, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(278, 25);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoEllipsis = true;
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDetalle.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 4);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(278, 27);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "Materia • Evaluación";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNota.BackColor = ColoresInterfaz.VerdeFondo;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNota.ForeColor = ColoresInterfaz.VerdeTexto;
            this.lblNota.Location = new System.Drawing.Point(362, 19);
            this.lblNota.Margin = new System.Windows.Forms.Padding(0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(56, 34);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "0.00";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCActividadProfesor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContenido);
            this.MinimumSize = new System.Drawing.Size(220, 72);
            this.Name = "UCActividadProfesor";
            this.Size = new System.Drawing.Size(430, 72);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCActividadProfesor_Paint);
            this.tlpContenido.ResumeLayout(false);
            this.pnlIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.tlpTextos.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
