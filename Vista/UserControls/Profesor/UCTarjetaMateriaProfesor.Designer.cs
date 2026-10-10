namespace Vista
{
    partial class UCTarjetaMateriaProfesor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.TableLayoutPanel tlpCabecera;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.Button btnCalificar;

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
            this.tlpCabecera = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.tlpContenido.SuspendLayout();
            this.tlpCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.tlpCabecera, 0, 0);
            this.tlpContenido.Controls.Add(this.lblMateria, 0, 1);
            this.tlpContenido.Controls.Add(this.lblEstudiantes, 0, 2);
            this.tlpContenido.Controls.Add(this.btnCalificar, 0, 3);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
            this.tlpContenido.RowCount = 4;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpContenido.Size = new System.Drawing.Size(330, 154);
            this.tlpContenido.TabIndex = 0;
            // 
            // tlpCabecera
            // 
            this.tlpCabecera.ColumnCount = 2;
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpCabecera.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpCabecera.Controls.Add(this.lblEstado, 1, 0);
            this.tlpCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabecera.Location = new System.Drawing.Point(18, 14);
            this.tlpCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabecera.Name = "tlpCabecera";
            this.tlpCabecera.RowCount = 1;
            this.tlpCabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.Size = new System.Drawing.Size(294, 28);
            this.tlpCabecera.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = ColoresInterfaz.AzulOscuro;
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(212, 28);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "MAT001";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = ColoresInterfaz.VerdeFondo;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = ColoresInterfaz.VerdeTexto;
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 20);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Activa";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoEllipsis = true;
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMateria.ForeColor = ColoresInterfaz.Negro;
            this.lblMateria.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(294, 38);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Programación I";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoEllipsis = true;
            this.lblEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstudiantes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEstudiantes.ForeColor = ColoresInterfaz.TextoSecundario;
            this.lblEstudiantes.Margin = new System.Windows.Forms.Padding(0, 2, 0, 4);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(294, 30);
            this.lblEstudiantes.TabIndex = 2;
            this.lblEstudiantes.Text = "0 estudiantes inscritos";
            this.lblEstudiantes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCalificar.Location = new System.Drawing.Point(164, 105);
            this.btnCalificar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(130, 34);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // UCTarjetaMateriaProfesor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContenido);
            this.MinimumSize = new System.Drawing.Size(280, 154);
            this.Name = "UCTarjetaMateriaProfesor";
            this.Size = new System.Drawing.Size(330, 154);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCTarjetaMateriaProfesor_Paint);
            this.tlpContenido.ResumeLayout(false);
            this.tlpCabecera.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
