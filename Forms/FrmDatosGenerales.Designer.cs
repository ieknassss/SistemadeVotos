namespace SistemadeVotaciones.Forms
{
    partial class FrmDatosGenerales
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardPadron;
        private System.Windows.Forms.Panel cardEmitidos;
        private System.Windows.Forms.Panel cardNulos;
        private System.Windows.Forms.Panel cardFaltantes;
        private System.Windows.Forms.Panel cardParticipacion;
        private System.Windows.Forms.Panel cardTiempo;

        private System.Windows.Forms.Label lblTituloPadron;
        private System.Windows.Forms.Label lblTituloEmitidos;
        private System.Windows.Forms.Label lblTituloNulos;
        private System.Windows.Forms.Label lblTituloFaltantes;
        private System.Windows.Forms.Label lblTituloParticipacion;
        private System.Windows.Forms.Label lblTituloTiempo;

        private System.Windows.Forms.Label lblPadron;
        private System.Windows.Forms.Label lblEmitidos;
        private System.Windows.Forms.Label lblNulos;
        private System.Windows.Forms.Label lblFaltantes;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblTiempo;

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

            this.cardPadron = new System.Windows.Forms.Panel();
            this.cardEmitidos = new System.Windows.Forms.Panel();
            this.cardNulos = new System.Windows.Forms.Panel();
            this.cardFaltantes = new System.Windows.Forms.Panel();
            this.cardParticipacion = new System.Windows.Forms.Panel();
            this.cardTiempo = new System.Windows.Forms.Panel();

            this.lblTituloPadron = new System.Windows.Forms.Label();
            this.lblTituloEmitidos = new System.Windows.Forms.Label();
            this.lblTituloNulos = new System.Windows.Forms.Label();
            this.lblTituloFaltantes = new System.Windows.Forms.Label();
            this.lblTituloParticipacion = new System.Windows.Forms.Label();
            this.lblTituloTiempo = new System.Windows.Forms.Label();

            this.lblPadron = new System.Windows.Forms.Label();
            this.lblEmitidos = new System.Windows.Forms.Label();
            this.lblNulos = new System.Windows.Forms.Label();
            this.lblFaltantes = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();

            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();

            this.cardPadron.SuspendLayout();
            this.cardEmitidos.SuspendLayout();
            this.cardNulos.SuspendLayout();
            this.cardFaltantes.SuspendLayout();
            this.cardParticipacion.SuspendLayout();
            this.cardTiempo.SuspendLayout();

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
            this.lblSubtitulo.Text = "Información general de la votación y posición electoral.";

            // cardPadron
            this.cardPadron.BackColor = System.Drawing.Color.White;
            this.cardPadron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPadron.Location = new System.Drawing.Point(40, 120);
            this.cardPadron.Size = new System.Drawing.Size(170, 120);

            // lblTituloPadron
            this.lblTituloPadron.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloPadron.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloPadron.Location = new System.Drawing.Point(10, 15);
            this.lblTituloPadron.Size = new System.Drawing.Size(150, 25);
            this.lblTituloPadron.Text = "PADRÓN";
            this.lblTituloPadron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblPadron
            this.lblPadron.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPadron.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPadron.Location = new System.Drawing.Point(10, 45);
            this.lblPadron.Size = new System.Drawing.Size(150, 50);
            this.lblPadron.Text = "0";
            this.lblPadron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardEmitidos
            this.cardEmitidos.BackColor = System.Drawing.Color.White;
            this.cardEmitidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardEmitidos.Location = new System.Drawing.Point(230, 120);
            this.cardEmitidos.Size = new System.Drawing.Size(170, 120);

            // lblTituloEmitidos
            this.lblTituloEmitidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloEmitidos.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloEmitidos.Location = new System.Drawing.Point(10, 15);
            this.lblTituloEmitidos.Size = new System.Drawing.Size(150, 25);
            this.lblTituloEmitidos.Text = "VOTOS";
            this.lblTituloEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblEmitidos
            this.lblEmitidos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblEmitidos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblEmitidos.Location = new System.Drawing.Point(10, 45);
            this.lblEmitidos.Size = new System.Drawing.Size(150, 50);
            this.lblEmitidos.Text = "0";
            this.lblEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardNulos
            this.cardNulos.BackColor = System.Drawing.Color.White;
            this.cardNulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNulos.Location = new System.Drawing.Point(420, 120);
            this.cardNulos.Size = new System.Drawing.Size(170, 120);

            // lblTituloNulos
            this.lblTituloNulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloNulos.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloNulos.Location = new System.Drawing.Point(10, 15);
            this.lblTituloNulos.Size = new System.Drawing.Size(150, 25);
            this.lblTituloNulos.Text = "NULOS";
            this.lblTituloNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNulos
            this.lblNulos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNulos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblNulos.Location = new System.Drawing.Point(10, 45);
            this.lblNulos.Size = new System.Drawing.Size(150, 50);
            this.lblNulos.Text = "0";
            this.lblNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardFaltantes
            this.cardFaltantes.BackColor = System.Drawing.Color.White;
            this.cardFaltantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardFaltantes.Location = new System.Drawing.Point(610, 120);
            this.cardFaltantes.Size = new System.Drawing.Size(170, 120);

            // lblTituloFaltantes
            this.lblTituloFaltantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloFaltantes.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloFaltantes.Location = new System.Drawing.Point(10, 15);
            this.lblTituloFaltantes.Size = new System.Drawing.Size(150, 25);
            this.lblTituloFaltantes.Text = "FALTAN";
            this.lblTituloFaltantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblFaltantes
            this.lblFaltantes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFaltantes.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFaltantes.Location = new System.Drawing.Point(10, 45);
            this.lblFaltantes.Size = new System.Drawing.Size(150, 50);
            this.lblFaltantes.Text = "0";
            this.lblFaltantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardParticipacion
            this.cardParticipacion.BackColor = System.Drawing.Color.White;
            this.cardParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardParticipacion.Location = new System.Drawing.Point(800, 120);
            this.cardParticipacion.Size = new System.Drawing.Size(170, 120);

            // lblTituloParticipacion
            this.lblTituloParticipacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloParticipacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloParticipacion.Location = new System.Drawing.Point(10, 15);
            this.lblTituloParticipacion.Size = new System.Drawing.Size(150, 25);
            this.lblTituloParticipacion.Text = "% PART.";
            this.lblTituloParticipacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblParticipacion
            this.lblParticipacion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblParticipacion.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblParticipacion.Location = new System.Drawing.Point(10, 45);
            this.lblParticipacion.Size = new System.Drawing.Size(150, 50);
            this.lblParticipacion.Text = "0%";
            this.lblParticipacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardTiempo
            this.cardTiempo.BackColor = System.Drawing.Color.White;
            this.cardTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTiempo.Location = new System.Drawing.Point(990, 120);
            this.cardTiempo.Size = new System.Drawing.Size(170, 120);

            // lblTituloTiempo
            this.lblTituloTiempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloTiempo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloTiempo.Location = new System.Drawing.Point(10, 15);
            this.lblTituloTiempo.Size = new System.Drawing.Size(150, 25);
            this.lblTituloTiempo.Text = "TIEMPO";
            this.lblTituloTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTiempo
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTiempo.Location = new System.Drawing.Point(10, 45);
            this.lblTiempo.Size = new System.Drawing.Size(150, 50);
            this.lblTiempo.Text = "00:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvPosiciones
            this.dgvPosiciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosiciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosiciones.Location = new System.Drawing.Point(40, 280);
            this.dgvPosiciones.Size = new System.Drawing.Size(1070, 280);
            this.dgvPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosiciones.RowHeadersVisible = false;
            this.dgvPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(900, 585);
            this.btnActualizar.Size = new System.Drawing.Size(210, 40);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // Add controls to cards
            this.cardPadron.Controls.Add(this.lblTituloPadron);
            this.cardPadron.Controls.Add(this.lblPadron);

            this.cardEmitidos.Controls.Add(this.lblTituloEmitidos);
            this.cardEmitidos.Controls.Add(this.lblEmitidos);

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
            this.Controls.Add(this.cardPadron);
            this.Controls.Add(this.cardEmitidos);
            this.Controls.Add(this.cardNulos);
            this.Controls.Add(this.cardFaltantes);
            this.Controls.Add(this.cardParticipacion);
            this.Controls.Add(this.cardTiempo);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.btnActualizar);

            this.cardPadron.ResumeLayout(false);
            this.cardEmitidos.ResumeLayout(false);
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