namespace SistemadeVotaciones.Forms
{
    partial class FrmVotacion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.FlowLayoutPanel flowPlanchas;
        private System.Windows.Forms.Button btnVotoNulo;

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
            this.flowPlanchas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVotoNulo = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // FrmVotacion
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Name = "FrmVotacion";
            this.Text = "Votación";
            this.Load += new System.EventHandler(this.FrmVotacion_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 25);
            this.lblTitulo.Text = "Módulo de Votación";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitulo.Text = "Selecciona una plancha o realiza un voto nulo. Solo puedes votar una vez.";

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblEstado.Location = new System.Drawing.Point(40, 110);
            this.lblEstado.Text = "";

            // btnVotoNulo
            this.btnVotoNulo.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnVotoNulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotoNulo.FlatAppearance.BorderSize = 0;
            this.btnVotoNulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVotoNulo.ForeColor = System.Drawing.Color.White;
            this.btnVotoNulo.Location = new System.Drawing.Point(850, 55);
            this.btnVotoNulo.Size = new System.Drawing.Size(250, 45);
            this.btnVotoNulo.Text = "VOTAR NULO";
            this.btnVotoNulo.UseVisualStyleBackColor = false;
            this.btnVotoNulo.Click += new System.EventHandler(this.btnVotoNulo_Click);

            // flowPlanchas
            this.flowPlanchas.BackColor = System.Drawing.Color.White;
            this.flowPlanchas.Location = new System.Drawing.Point(40, 145);
            this.flowPlanchas.Name = "flowPlanchas";
            this.flowPlanchas.Size = new System.Drawing.Size(1060, 460);
            this.flowPlanchas.AutoScroll = true;

            // Controles
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnVotoNulo);
            this.Controls.Add(this.flowPlanchas);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}