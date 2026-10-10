namespace Vista
{
    partial class UCChipEstado
    {
        private System.ComponentModel.IContainer components = null;
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoEllipsis = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(0, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 24);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Activo";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCChipEstado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ColoresInterfaz.VerdeFondo;
            this.Controls.Add(this.lblEstado);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(64, 24);
            this.Name = "UCChipEstado";
            this.Size = new System.Drawing.Size(72, 24);
            this.Resize += new System.EventHandler(this.UCChipEstado_Resize);
            this.ResumeLayout(false);
        }
    }
}
