namespace SistemadeVotaciones.Forms
{
    partial class FrmDatosGenerales
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEstado;

        private System.Windows.Forms.Panel cardPadron;
        private System.Windows.Forms.Panel cardEmitidos;
        private System.Windows.Forms.Panel cardNulos;
        private System.Windows.Forms.Panel cardFaltantes;
        private System.Windows.Forms.Panel cardParticipacion;
        private System.Windows.Forms.Panel cardTiempo;
        private System.Windows.Forms.Panel cardValidos;

        private System.Windows.Forms.Label lblTituloPadron;
        private System.Windows.Forms.Label lblTituloEmitidos;
        private System.Windows.Forms.Label lblTituloNulos;
        private System.Windows.Forms.Label lblTituloFaltantes;
        private System.Windows.Forms.Label lblTituloParticipacion;
        private System.Windows.Forms.Label lblTituloTiempo;
        private System.Windows.Forms.Label lblTituloValidos;

        private System.Windows.Forms.Label lblPadron;
        private System.Windows.Forms.Label lblEmitidos;
        private System.Windows.Forms.Label lblNulos;
        private System.Windows.Forms.Label lblFaltantes;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblValidos;

        private System.Windows.Forms.Panel panelGraficoBarras;
        private System.Windows.Forms.Panel panelGraficoParticipacion;

        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.Button btnActualizar;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();

            this.cardPadron = new System.Windows.Forms.Panel();
            this.cardEmitidos = new System.Windows.Forms.Panel();
            this.cardNulos = new System.Windows.Forms.Panel();
            this.cardFaltantes = new System.Windows.Forms.Panel();
            this.cardParticipacion = new System.Windows.Forms.Panel();
            this.cardTiempo = new System.Windows.Forms.Panel();
            this.cardValidos = new System.Windows.Forms.Panel();

            this.lblTituloPadron = new System.Windows.Forms.Label();
            this.lblTituloEmitidos = new System.Windows.Forms.Label();
            this.lblTituloNulos = new System.Windows.Forms.Label();
            this.lblTituloFaltantes = new System.Windows.Forms.Label();
            this.lblTituloParticipacion = new System.Windows.Forms.Label();
            this.lblTituloTiempo = new System.Windows.Forms.Label();
            this.lblTituloValidos = new System.Windows.Forms.Label();

            this.lblPadron = new System.Windows.Forms.Label();
            this.lblEmitidos = new System.Windows.Forms.Label();
            this.lblNulos = new System.Windows.Forms.Label();
            this.lblFaltantes = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblValidos = new System.Windows.Forms.Label();

            this.panelGraficoBarras = new System.Windows.Forms.Panel();
            this.panelGraficoParticipacion = new System.Windows.Forms.Panel();

            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();

            this.cardPadron.SuspendLayout();
            this.cardEmitidos.SuspendLayout();
            this.cardNulos.SuspendLayout();
            this.cardFaltantes.SuspendLayout();
            this.cardParticipacion.SuspendLayout();
            this.cardTiempo.SuspendLayout();
            this.cardValidos.SuspendLayout();

            this.SuspendLayout();

            // FrmDatosGenerales
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Name = "FrmDatosGenerales";
            this.Text = "Datos Generales";
            this.Load += new System.EventHandler(this.FrmDatosGenerales_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 20);
            this.lblTitulo.Text = "Datos Generales";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 70);
            this.lblSubtitulo.Text = "Información administrativa, participación, tiempo y gráficos de la votación.";

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblEstado.Location = new System.Drawing.Point(850, 35);
            this.lblEstado.Text = "Estado:";

            // CARD PADRON
            this.cardPadron.BackColor = System.Drawing.Color.White;
            this.cardPadron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPadron.Location = new System.Drawing.Point(40, 115);
            this.cardPadron.Size = new System.Drawing.Size(145, 100);

            this.lblTituloPadron.Text = "PADRÓN";
            this.lblTituloPadron.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloPadron.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloPadron.Location = new System.Drawing.Point(10, 10);
            this.lblTituloPadron.Size = new System.Drawing.Size(125, 22);
            this.lblTituloPadron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPadron.Text = "0";
            this.lblPadron.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPadron.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPadron.Location = new System.Drawing.Point(10, 38);
            this.lblPadron.Size = new System.Drawing.Size(125, 42);
            this.lblPadron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CARD EMITIDOS
            this.cardEmitidos.BackColor = System.Drawing.Color.White;
            this.cardEmitidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardEmitidos.Location = new System.Drawing.Point(200, 115);
            this.cardEmitidos.Size = new System.Drawing.Size(145, 100);

            this.lblTituloEmitidos.Text = "EMITIDOS";
            this.lblTituloEmitidos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloEmitidos.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloEmitidos.Location = new System.Drawing.Point(10, 10);
            this.lblTituloEmitidos.Size = new System.Drawing.Size(125, 22);
            this.lblTituloEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblEmitidos.Text = "0";
            this.lblEmitidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmitidos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblEmitidos.Location = new System.Drawing.Point(10, 38);
            this.lblEmitidos.Size = new System.Drawing.Size(125, 42);
            this.lblEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CARD VALIDOS
            this.cardValidos.BackColor = System.Drawing.Color.White;
            this.cardValidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardValidos.Location = new System.Drawing.Point(360, 115);
            this.cardValidos.Size = new System.Drawing.Size(145, 100);

            this.lblTituloValidos.Text = "VÁLIDOS";
            this.lblTituloValidos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloValidos.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloValidos.Location = new System.Drawing.Point(10, 10);
            this.lblTituloValidos.Size = new System.Drawing.Size(125, 22);
            this.lblTituloValidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblValidos.Text = "0";
            this.lblValidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValidos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblValidos.Location = new System.Drawing.Point(10, 38);
            this.lblValidos.Size = new System.Drawing.Size(125, 42);
            this.lblValidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CARD NULOS
            this.cardNulos.BackColor = System.Drawing.Color.White;
            this.cardNulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNulos.Location = new System.Drawing.Point(520, 115);
            this.cardNulos.Size = new System.Drawing.Size(145, 100);

            this.lblTituloNulos.Text = "NULOS";
            this.lblTituloNulos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloNulos.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloNulos.Location = new System.Drawing.Point(10, 10);
            this.lblTituloNulos.Size = new System.Drawing.Size(125, 22);
            this.lblTituloNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNulos.Text = "0";
            this.lblNulos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNulos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblNulos.Location = new System.Drawing.Point(10, 38);
            this.lblNulos.Size = new System.Drawing.Size(125, 42);
            this.lblNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CARD FALTANTES
            this.cardFaltantes.BackColor = System.Drawing.Color.White;
            this.cardFaltantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardFaltantes.Location = new System.Drawing.Point(680, 115);
            this.cardFaltantes.Size = new System.Drawing.Size(145, 100);

            this.lblTituloFaltantes.Text = "FALTAN";
            this.lblTituloFaltantes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloFaltantes.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloFaltantes.Location = new System.Drawing.Point(10, 10);
            this.lblTituloFaltantes.Size = new System.Drawing.Size(125, 22);
            this.lblTituloFaltantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFaltantes.Text = "0";
            this.lblFaltantes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFaltantes.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFaltantes.Location = new System.Drawing.Point(10, 38);
            this.lblFaltantes.Size = new System.Drawing.Size(125, 42);
            this.lblFaltantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CARD PARTICIPACION
            this.cardParticipacion.BackColor = System.Drawing.Color.White;
            this.cardParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardParticipacion.Location = new System.Drawing.Point(840, 115);
            this.cardParticipacion.Size = new System.Drawing.Size(145, 100);

            this.lblTituloParticipacion.Text = "% PART.";
            this.lblTituloParticipacion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloParticipacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloParticipacion.Location = new System.Drawing.Point(10, 10);
            this.lblTituloParticipacion.Size = new System.Drawing.Size(125, 22);
            this.lblTituloParticipacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblParticipacion.Text = "0%";
            this.lblParticipacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblParticipacion.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblParticipacion.Location = new System.Drawing.Point(10, 38);
            this.lblParticipacion.Size = new System.Drawing.Size(125, 42);
            this.lblParticipacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CARD TIEMPO
            this.cardTiempo.BackColor = System.Drawing.Color.White;
            this.cardTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTiempo.Location = new System.Drawing.Point(1000, 115);
            this.cardTiempo.Size = new System.Drawing.Size(145, 100);

            this.lblTituloTiempo.Text = "TIEMPO";
            this.lblTituloTiempo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloTiempo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloTiempo.Location = new System.Drawing.Point(10, 10);
            this.lblTituloTiempo.Size = new System.Drawing.Size(125, 22);
            this.lblTituloTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTiempo.Text = "00:00";
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTiempo.Location = new System.Drawing.Point(10, 38);
            this.lblTiempo.Size = new System.Drawing.Size(125, 42);
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelGraficoBarras
            this.panelGraficoBarras.BackColor = System.Drawing.Color.White;
            this.panelGraficoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraficoBarras.Location = new System.Drawing.Point(40, 240);
            this.panelGraficoBarras.Size = new System.Drawing.Size(720, 210);
            this.panelGraficoBarras.AutoScroll = true;

            // panelGraficoParticipacion
            this.panelGraficoParticipacion.BackColor = System.Drawing.Color.White;
            this.panelGraficoParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraficoParticipacion.Location = new System.Drawing.Point(780, 240);
            this.panelGraficoParticipacion.Size = new System.Drawing.Size(365, 210);

            // dgvPosiciones
            this.dgvPosiciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosiciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosiciones.Location = new System.Drawing.Point(40, 470);
            this.dgvPosiciones.Size = new System.Drawing.Size(880, 145);
            this.dgvPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosiciones.RowHeadersVisible = false;
            this.dgvPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(940, 525);
            this.btnActualizar.Size = new System.Drawing.Size(205, 45);
            this.btnActualizar.Text = "ACTUALIZAR DATOS";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // Add controls to cards
            this.cardPadron.Controls.Add(this.lblTituloPadron);
            this.cardPadron.Controls.Add(this.lblPadron);

            this.cardEmitidos.Controls.Add(this.lblTituloEmitidos);
            this.cardEmitidos.Controls.Add(this.lblEmitidos);

            this.cardValidos.Controls.Add(this.lblTituloValidos);
            this.cardValidos.Controls.Add(this.lblValidos);

            this.cardNulos.Controls.Add(this.lblTituloNulos);
            this.cardNulos.Controls.Add(this.lblNulos);

            this.cardFaltantes.Controls.Add(this.lblTituloFaltantes);
            this.cardFaltantes.Controls.Add(this.lblFaltantes);

            this.cardParticipacion.Controls.Add(this.lblTituloParticipacion);
            this.cardParticipacion.Controls.Add(this.lblParticipacion);

            this.cardTiempo.Controls.Add(this.lblTituloTiempo);
            this.cardTiempo.Controls.Add(this.lblTiempo);

            // Add controls to form
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblEstado);

            this.Controls.Add(this.cardPadron);
            this.Controls.Add(this.cardEmitidos);
            this.Controls.Add(this.cardValidos);
            this.Controls.Add(this.cardNulos);
            this.Controls.Add(this.cardFaltantes);
            this.Controls.Add(this.cardParticipacion);
            this.Controls.Add(this.cardTiempo);

            this.Controls.Add(this.panelGraficoBarras);
            this.Controls.Add(this.panelGraficoParticipacion);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.btnActualizar);

            this.cardPadron.ResumeLayout(false);
            this.cardEmitidos.ResumeLayout(false);
            this.cardValidos.ResumeLayout(false);
            this.cardNulos.ResumeLayout(false);
            this.cardFaltantes.ResumeLayout(false);
            this.cardParticipacion.ResumeLayout(false);
            this.cardTiempo.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}