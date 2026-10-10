namespace Vista
{
    partial class frmProfesores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Panel pnlLineaTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.tlpPagina = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.tlpEncabezadoContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.pnlLineaTitulo = new System.Windows.Forms.Panel();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tlpPagina.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.tlpEncabezadoContenido.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPagina
            // 
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.pnlEncabezado, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFormulario, 0, 1);
            this.tlpPagina.Controls.Add(this.dgvUsuarios, 0, 2);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(30, 24, 30, 22);
            this.tlpPagina.RowCount = 3;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Size = new System.Drawing.Size(1617, 941);
            this.tlpPagina.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.tlpEncabezadoContenido);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado.Location = new System.Drawing.Point(30, 24);
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1557, 84);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // tlpEncabezadoContenido
            // 
            this.tlpEncabezadoContenido.ColumnCount = 2;
            this.tlpEncabezadoContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tlpEncabezadoContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpEncabezadoContenido.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpEncabezadoContenido.Controls.Add(this.lblModo, 1, 0);
            this.tlpEncabezadoContenido.Controls.Add(this.pnlLineaTitulo, 0, 1);
            this.tlpEncabezadoContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezadoContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezadoContenido.Name = "tlpEncabezadoContenido";
            this.tlpEncabezadoContenido.RowCount = 2;
            this.tlpEncabezadoContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpEncabezadoContenido.Size = new System.Drawing.Size(1557, 84);
            this.tlpEncabezadoContenido.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1214, 74);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Profesores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModo
            // 
            this.lblModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModo.AutoEllipsis = true;
            this.lblModo.Location = new System.Drawing.Point(1394, 22);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(160, 30);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Nuevo profesor";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLineaTitulo
            // 
            this.pnlLineaTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlLineaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.pnlLineaTitulo.Location = new System.Drawing.Point(2, 77);
            this.pnlLineaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pnlLineaTitulo.Name = "pnlLineaTitulo";
            this.pnlLineaTitulo.Size = new System.Drawing.Size(54, 4);
            this.pnlLineaTitulo.TabIndex = 2;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.tlpCampos);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(30, 108);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(24, 18, 24, 14);
            this.pnlFormulario.Size = new System.Drawing.Size(1557, 170);
            this.pnlFormulario.TabIndex = 1;
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 4;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCampos.Controls.Add(this.lblCodigo, 0, 0);
            this.tlpCampos.Controls.Add(this.lblNombreCompleto, 1, 0);
            this.tlpCampos.Controls.Add(this.lblNombreUsuario, 2, 0);
            this.tlpCampos.Controls.Add(this.lblContrasena, 3, 0);
            this.tlpCampos.Controls.Add(this.txtCodigo, 0, 1);
            this.tlpCampos.Controls.Add(this.txtNombreCompleto, 1, 1);
            this.tlpCampos.Controls.Add(this.txtNombreUsuario, 2, 1);
            this.tlpCampos.Controls.Add(this.txtContrasena, 3, 1);
            this.tlpCampos.Controls.Add(this.chkEstado, 0, 2);
            this.tlpCampos.Controls.Add(this.flpAcciones, 1, 2);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(24, 18);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 3;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpCampos.Size = new System.Drawing.Size(1509, 138);
            this.tlpCampos.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Location = new System.Drawing.Point(0, 0);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(363, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoEllipsis = true;
            this.lblNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreCompleto.Location = new System.Drawing.Point(377, 0);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(363, 24);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre completo";
            this.lblNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoEllipsis = true;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreUsuario.Location = new System.Drawing.Point(754, 0);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(363, 24);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Usuario";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoEllipsis = true;
            this.lblContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContrasena.Location = new System.Drawing.Point(1134, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(372, 24);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            this.lblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Location = new System.Drawing.Point(0, 24);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(363, 27);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreCompleto.Location = new System.Drawing.Point(377, 24);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(363, 27);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreUsuario.Location = new System.Drawing.Point(754, 24);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(363, 27);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasena.Location = new System.Drawing.Point(1131, 24);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(378, 27);
            this.txtContrasena.TabIndex = 7;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // chkEstado
            // 
            this.chkEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(0, 89);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(0);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(73, 24);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Activo";
            // 
            // flpAcciones
            // 
            this.tlpCampos.SetColumnSpan(this.flpAcciones, 3);
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnNuevo);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(377, 64);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpAcciones.Size = new System.Drawing.Size(1132, 74);
            this.flpAcciones.TabIndex = 9;
            this.flpAcciones.WrapContents = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1014, 8);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 38);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(886, 8);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(758, 8);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 38);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeight = 29;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(30, 292);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1557, 627);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // frmProfesores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 941);
            this.Controls.Add(this.tlpPagina);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "frmProfesores";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.frmProfesores_Load);
            this.tlpPagina.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.tlpEncabezadoContenido.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.flpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
