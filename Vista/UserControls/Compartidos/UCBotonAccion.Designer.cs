namespace Vista
{
    partial class UCBotonAccion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picIcono;

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
            this.picIcono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcono
            // 
            this.picIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcono.Location = new System.Drawing.Point(8, 8);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(16, 16);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            this.picIcono.Click += new System.EventHandler(this.Control_Click);
            // 
            // UCBotonAccion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picIcono);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "UCBotonAccion";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(32, 32);
            this.Click += new System.EventHandler(this.Control_Click);
            this.Resize += new System.EventHandler(this.UCBotonAccion_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCBotonAccion_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
