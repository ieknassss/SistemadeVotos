namespace SistemadeVotaciones.Forms
{
    partial class FrmPanelElectoral
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Label lblLider;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblUltimoVoto;
        private System.Windows.Forms.Label lblUsuariosVotaron;
        private System.Windows.Forms.Label lblVotosRegistrados;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Label lblFaltantes;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Label lblTotalPlanchas;
        private System.Windows.Forms.Label lblTotalCandidatos;

        private System.Windows.Forms.ProgressBar progressParticipacion;
        private System.Windows.Forms.Panel panelRanking;
        private System.Windows.Forms.DataGridView dgvMonitor;
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

            this.lblLider = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblUltimoVoto = new System.Windows.Forms.Label();
            this.lblUsuariosVotaron = new System.Windows.Forms.Label();
            this.lblVotosRegistrados = new System.Windows.Forms.Label();
            this.lblValidacion = new System.Windows.Forms.Label();
            this.lblFaltantes = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.lblTotalPlanchas = new System.Windows.Forms.Label();
            this.lblTotalCandidatos = new System.Windows.Forms.Label();

            this.progressParticipacion = new System.Windows.Forms.ProgressBar();
            this.panelRanking = new System.Windows.Forms.Panel();
            this.dgvMonitor = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).BeginInit();
            this.SuspendLayout();

            // FrmPanelElectoral
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Name = "FrmPanelElectoral";
            this.Text = "Panel Electoral";
            this.Load += new System.EventHandler(this.FrmPanelElectoral_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Text = "Panel Electoral";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(35, 68);
            this.lblSubtitulo.Text = "Monitoreo avanzado, validación y liderazgo electoral.";

            // lblLider
            this.lblLider.AutoSize = true;
            this.lblLider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLider.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblLider.Location = new System.Drawing.Point(35, 115);
            this.lblLider.Text = "Líder actual: -";

            // lblSegundo
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSegundo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSegundo.Location = new System.Drawing.Point(35, 145);
            this.lblSegundo.Text = "Segundo lugar: -";

            // lblDiferencia
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiferencia.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblDiferencia.Location = new System.Drawing.Point(35, 175);
            this.lblDiferencia.Text = "Diferencia: 0 votos";

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblEstado.Location = new System.Drawing.Point(300, 115);
            this.lblEstado.Text = "Estado: -";

            // lblTiempo
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTiempo.Location = new System.Drawing.Point(300, 145);
            this.lblTiempo.Text = "Tiempo: 00:00";

            // lblUltimoVoto
            this.lblUltimoVoto.AutoSize = true;
            this.lblUltimoVoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUltimoVoto.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblUltimoVoto.Location = new System.Drawing.Point(300, 175);
            this.lblUltimoVoto.Text = "Último voto: -";

            // lblUsuariosVotaron
            this.lblUsuariosVotaron.AutoSize = true;
            this.lblUsuariosVotaron.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosVotaron.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblUsuariosVotaron.Location = new System.Drawing.Point(540, 115);
            this.lblUsuariosVotaron.Text = "Usuarios que votaron: 0";

            // lblVotosRegistrados
            this.lblVotosRegistrados.AutoSize = true;
            this.lblVotosRegistrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVotosRegistrados.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblVotosRegistrados.Location = new System.Drawing.Point(540, 145);
            this.lblVotosRegistrados.Text = "Votos registrados: 0";

            // lblValidacion
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValidacion.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblValidacion.Location = new System.Drawing.Point(540, 175);
            this.lblValidacion.Text = "Validación: -";

            // lblFaltantes
            this.lblFaltantes.AutoSize = true;
            this.lblFaltantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFaltantes.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFaltantes.Location = new System.Drawing.Point(35, 215);
            this.lblFaltantes.Text = "Faltantes: 0";

            // lblParticipacion
            this.lblParticipacion.AutoSize = true;
            this.lblParticipacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblParticipacion.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblParticipacion.Location = new System.Drawing.Point(300, 215);
            this.lblParticipacion.Text = "Participación: 0%";

            // lblTotalPlanchas
            this.lblTotalPlanchas.AutoSize = true;
            this.lblTotalPlanchas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlanchas.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTotalPlanchas.Location = new System.Drawing.Point(540, 215);
            this.lblTotalPlanchas.Text = "Planchas: 0";

            // lblTotalCandidatos
            this.lblTotalCandidatos.AutoSize = true;
            this.lblTotalCandidatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCandidatos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTotalCandidatos.Location = new System.Drawing.Point(700, 215);
            this.lblTotalCandidatos.Text = "Candidatos: 0";

            // lblAlerta
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlerta.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblAlerta.Location = new System.Drawing.Point(35, 250);
            this.lblAlerta.Text = "Estado del liderazgo";

            // progressParticipacion
            this.progressParticipacion.Location = new System.Drawing.Point(300, 250);
            this.progressParticipacion.Size = new System.Drawing.Size(250, 25);

            // panelRanking
            this.panelRanking.BackColor = System.Drawing.Color.White;
            this.panelRanking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRanking.Location = new System.Drawing.Point(35, 295);
            this.panelRanking.Size = new System.Drawing.Size(810, 190);
            this.panelRanking.AutoScroll = true;

            // dgvMonitor
            this.dgvMonitor.Visible = false;

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(620, 505);
            this.btnActualizar.Size = new System.Drawing.Size(225, 40);
            this.btnActualizar.Text = "ACTUALIZAR PANEL";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // Controls
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);

            this.Controls.Add(this.lblLider);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblUltimoVoto);
            this.Controls.Add(this.lblUsuariosVotaron);
            this.Controls.Add(this.lblVotosRegistrados);
            this.Controls.Add(this.lblValidacion);
            this.Controls.Add(this.lblFaltantes);
            this.Controls.Add(this.lblParticipacion);
            this.Controls.Add(this.lblTotalPlanchas);
            this.Controls.Add(this.lblTotalCandidatos);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.progressParticipacion);
            this.Controls.Add(this.panelRanking);
            this.Controls.Add(this.dgvMonitor);
            this.Controls.Add(this.btnActualizar);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}