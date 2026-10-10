using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public static class EstilosFormulario
    {
        public static void AplicarFormularioCrud(
            Form formulario,
            Panel pnlEncabezado,
            Label lblTitulo,
            Label lblModo,
            Panel pnlFormulario,
            DataGridView dgv,
            Button btnNuevo,
            Button btnGuardar,
            Button btnEliminar)
        {
            formulario.BackColor = Color.White;
            formulario.AutoScaleMode = AutoScaleMode.None;

            pnlEncabezado.BackColor = Color.White;

            lblTitulo.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = ColoresInterfaz.Negro;
            lblTitulo.AutoEllipsis = true;

            lblModo.ForeColor = ColoresInterfaz.AzulOscuro;
            lblModo.BackColor = Color.FromArgb(238, 246, 251);
            lblModo.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblModo.TextAlign = ContentAlignment.MiddleCenter;
            lblModo.AutoEllipsis = true;

            pnlFormulario.BackColor = ColoresInterfaz.Fondo;

            AplicarControlesFormulario(pnlFormulario);
            AplicarGrid(dgv);
            AplicarBotonSecundario(btnNuevo);
            AplicarBotonPrimario(btnGuardar);
            AplicarBotonEliminar(btnEliminar);
        }

        public static void AplicarGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = ColoresInterfaz.Borde;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 247, 251);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColoresInterfaz.Negro;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 8.8F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 247, 251);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColoresInterfaz.Negro;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(251, 252, 253);
            dgv.DefaultCellStyle.ForeColor = ColoresInterfaz.Negro;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 8.8F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 244, 252);
            dgv.DefaultCellStyle.SelectionForeColor = ColoresInterfaz.Negro;
            dgv.DefaultCellStyle.Padding = new Padding(7, 0, 7, 0);
            dgv.RowTemplate.Height = 42;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private static void AplicarControlesFormulario(Control contenedor)
        {
            int i;
            Control control;
            TextBox cajaTexto;
            ComboBox lista;
            Label etiqueta;

            for (i = 0; i < contenedor.Controls.Count; i++)
            {
                control = contenedor.Controls[i];

                cajaTexto = control as TextBox;
                if (cajaTexto != null)
                {
                    cajaTexto.BackColor = Color.White;
                    cajaTexto.BorderStyle = BorderStyle.FixedSingle;
                    cajaTexto.Font = new Font("Segoe UI", 9F);
                    continue;
                }

                lista = control as ComboBox;
                if (lista != null)
                {
                    lista.BackColor = Color.White;
                    lista.FlatStyle = FlatStyle.Flat;
                    lista.Font = new Font("Segoe UI", 9F);
                    continue;
                }

                etiqueta = control as Label;
                if (etiqueta != null)
                {
                    etiqueta.ForeColor = ColoresInterfaz.Negro;
                }

                if (control.HasChildren)
                {
                    AplicarControlesFormulario(control);
                }
            }
        }

        public static void AplicarBotonSecundario(Button boton)
        {
            boton.BackColor = ColoresInterfaz.AzulOscuro;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            AplicarEstiloBaseBoton(boton, 6);
        }

        public static void AplicarBotonPrimario(Button boton)
        {
            boton.BackColor = ColoresInterfaz.Coral;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            AplicarEstiloBaseBoton(boton, 6);
        }

        public static void AplicarBotonEliminar(Button boton)
        {
            boton.BackColor = Color.White;
            boton.ForeColor = ColoresInterfaz.Coral;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.FromArgb(240, 180, 165);
            boton.FlatAppearance.BorderSize = 1;
            boton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            AplicarEstiloBaseBoton(boton, 6);
        }

        private static void AplicarEstiloBaseBoton(Button boton, int radio)
        {
            boton.TextAlign = ContentAlignment.MiddleCenter;
            boton.ImageAlign = ContentAlignment.MiddleLeft;
            boton.UseVisualStyleBackColor = false;
            boton.Resize -= Boton_Resize;
            boton.Resize += Boton_Resize;
            boton.Tag = radio;
            BordesRedondeados.AplicarRegion(boton, radio);
        }

        private static void Boton_Resize(object sender, System.EventArgs e)
        {
            Button boton;
            int radio;

            boton = sender as Button;

            if (boton == null)
            {
                return;
            }

            radio = 6;

            if (boton.Tag != null)
            {
                int.TryParse(boton.Tag.ToString(), out radio);
            }

            if (radio <= 0)
            {
                radio = 6;
            }

            BordesRedondeados.AplicarRegion(boton, radio);
        }
    }
}
