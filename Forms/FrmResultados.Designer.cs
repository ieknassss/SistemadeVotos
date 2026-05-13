namespace SistemadeVotaciones.Forms
{
    partial class FrmResultados
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardUsuarios;
        private System.Windows.Forms.Panel cardVotos;
        private System.Windows.Forms.Panel cardNulos;
        private System.Windows.Forms.Panel cardParticipacion;
        private System.Windows.Forms.Panel cardGanadora;

        private System.Windows.Forms.Label lblCardUsuarios;
        private System.Windows.Forms.Label lblCardVotos;
        private System.Windows.Forms.Label lblCardNulos;
        private System.Windows.Forms.Label lblCardParticipacion;
        private System.Windows.Forms.Label lblCardGanadora;

        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label lblVotosEmitidos;
        private System.Windows.Forms.Label lblVotosNulos;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblGanadora;

        private System.Windows.Forms.DataGridView dgvResultados;
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

            this.cardUsuarios = new System.Windows.Forms.Panel();
            this.cardVotos = new System.Windows.Forms.Panel();
            this.cardNulos = new System.Windows.Forms.Panel();
            this.cardParticipacion = new System.Windows.Forms.Panel();
            this.cardGanadora = new System.Windows.Forms.Panel();

            this.lblCardUsuarios = new System.Windows.Forms.Label();
            this.lblCardVotos = new System.Windows.Forms.Label();
            this.lblCardNulos = new System.Windows.Forms.Label();
            this.lblCardParticipacion = new System.Windows.Forms.Label();
            this.lblCardGanadora = new System.Windows.Forms.Label();

            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblVotosEmitidos = new System.Windows.Forms.Label();
            this.lblVotosNulos = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblGanadora = new System.Windows.Forms.Label();

            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();

            this.cardUsuarios.SuspendLayout();
            this.cardVotos.SuspendLayout();
            this.cardNulos.SuspendLayout();
            this.cardParticipacion.SuspendLayout();
            this.cardGanadora.SuspendLayout();

            this.SuspendLayout();

            // FrmResultados
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Name = "FrmResultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 25);
            this.lblTitulo.Text = "Resultados Electorales";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitulo.Text = "Resumen general de votos, participación y plancha ganadora.";

            // cardUsuarios
            this.cardUsuarios.BackColor = System.Drawing.Color.White;
            this.cardUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardUsuarios.Location = new System.Drawing.Point(40, 120);
            this.cardUsuarios.Size = new System.Drawing.Size(190, 115);

            // lblCardUsuarios
            this.lblCardUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardUsuarios.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardUsuarios.Location = new System.Drawing.Point(10, 15);
            this.lblCardUsuarios.Size = new System.Drawing.Size(170, 25);
            this.lblCardUsuarios.Text = "PADRÓN";
            this.lblCardUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTotalUsuarios
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTotalUsuarios.Location = new System.Drawing.Point(10, 50);
            this.lblTotalUsuarios.Size = new System.Drawing.Size(170, 45);
            this.lblTotalUsuarios.Text = "0";
            this.lblTotalUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardVotos
            this.cardVotos.BackColor = System.Drawing.Color.White;
            this.cardVotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardVotos.Location = new System.Drawing.Point(260, 120);
            this.cardVotos.Size = new System.Drawing.Size(190, 115);

            // lblCardVotos
            this.lblCardVotos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardVotos.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardVotos.Location = new System.Drawing.Point(10, 15);
            this.lblCardVotos.Size = new System.Drawing.Size(170, 25);
            this.lblCardVotos.Text = "VOTOS EMITIDOS";
            this.lblCardVotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblVotosEmitidos
            this.lblVotosEmitidos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblVotosEmitidos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblVotosEmitidos.Location = new System.Drawing.Point(10, 50);
            this.lblVotosEmitidos.Size = new System.Drawing.Size(170, 45);
            this.lblVotosEmitidos.Text = "0";
            this.lblVotosEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardNulos
            this.cardNulos.BackColor = System.Drawing.Color.White;
            this.cardNulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNulos.Location = new System.Drawing.Point(480, 120);
            this.cardNulos.Size = new System.Drawing.Size(190, 115);

            // lblCardNulos
            this.lblCardNulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardNulos.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardNulos.Location = new System.Drawing.Point(10, 15);
            this.lblCardNulos.Size = new System.Drawing.Size(170, 25);
            this.lblCardNulos.Text = "VOTOS NULOS";
            this.lblCardNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblVotosNulos
            this.lblVotosNulos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblVotosNulos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblVotosNulos.Location = new System.Drawing.Point(10, 50);
            this.lblVotosNulos.Size = new System.Drawing.Size(170, 45);
            this.lblVotosNulos.Text = "0";
            this.lblVotosNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardParticipacion
            this.cardParticipacion.BackColor = System.Drawing.Color.White;
            this.cardParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardParticipacion.Location = new System.Drawing.Point(700, 120);
            this.cardParticipacion.Size = new System.Drawing.Size(190, 115);

            // lblCardParticipacion
            this.lblCardParticipacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardParticipacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardParticipacion.Location = new System.Drawing.Point(10, 15);
            this.lblCardParticipacion.Size = new System.Drawing.Size(170, 25);
            this.lblCardParticipacion.Text = "PARTICIPACIÓN";
            this.lblCardParticipacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblParticipacion
            this.lblParticipacion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblParticipacion.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblParticipacion.Location = new System.Drawing.Point(10, 50);
            this.lblParticipacion.Size = new System.Drawing.Size(170, 45);
            this.lblParticipacion.Text = "0%";
            this.lblParticipacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cardGanadora
            this.cardGanadora.BackColor = System.Drawing.Color.White;
            this.cardGanadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardGanadora.Location = new System.Drawing.Point(920, 120);
            this.cardGanadora.Size = new System.Drawing.Size(190, 115);

            // lblCardGanadora
            this.lblCardGanadora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardGanadora.ForeColor = System.Drawing.Color.DimGray;
            this.lblCardGanadora.Location = new System.Drawing.Point(10, 15);
            this.lblCardGanadora.Size = new System.Drawing.Size(170, 25);
            this.lblCardGanadora.Text = "GANADORA";
            this.lblCardGanadora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblGanadora
            this.lblGanadora.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblGanadora.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblGanadora.Location = new System.Drawing.Point(10, 45);
            this.lblGanadora.Size = new System.Drawing.Size(170, 60);
            this.lblGanadora.Text = "-";
            this.lblGanadora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvResultados
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.Location = new System.Drawing.Point(40, 270);
            this.dgvResultados.Size = new System.Drawing.Size(1060, 300);
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(880, 590);
            this.btnActualizar.Size = new System.Drawing.Size(220, 40);
            this.btnActualizar.Text = "ACTUALIZAR RESULTADOS";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // Add controls to cards
            this.cardUsuarios.Controls.Add(this.lblCardUsuarios);
            this.cardUsuarios.Controls.Add(this.lblTotalUsuarios);

            this.cardVotos.Controls.Add(this.lblCardVotos);
            this.cardVotos.Controls.Add(this.lblVotosEmitidos);

            this.cardNulos.Controls.Add(this.lblCardNulos);
            this.cardNulos.Controls.Add(this.lblVotosNulos);

            this.cardParticipacion.Controls.Add(this.lblCardParticipacion);
            this.cardParticipacion.Controls.Add(this.lblParticipacion);

            this.cardGanadora.Controls.Add(this.lblCardGanadora);
            this.cardGanadora.Controls.Add(this.lblGanadora);

            // Add controls to form
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.cardUsuarios);
            this.Controls.Add(this.cardVotos);
            this.Controls.Add(this.cardNulos);
            this.Controls.Add(this.cardParticipacion);
            this.Controls.Add(this.cardGanadora);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnActualizar);

            this.cardUsuarios.ResumeLayout(false);
            this.cardVotos.ResumeLayout(false);
            this.cardNulos.ResumeLayout(false);
            this.cardParticipacion.ResumeLayout(false);
            this.cardGanadora.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}