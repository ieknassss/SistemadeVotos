namespace SistemadeVotaciones.Forms
{
    partial class FrmPlanchas
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelListado;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSiglas;
        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSiglas;

        private System.Windows.Forms.PictureBox picLogo;

        private System.Windows.Forms.Button btnSeleccionarLogo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.DataGridView dgvPlanchas;

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

            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panelListado = new System.Windows.Forms.Panel();

            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSiglas = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSiglas = new System.Windows.Forms.TextBox();

            this.picLogo = new System.Windows.Forms.PictureBox();

            this.btnSeleccionarLogo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.dgvPlanchas = new System.Windows.Forms.DataGridView();

            this.panelFormulario.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanchas)).BeginInit();

            this.SuspendLayout();

            // FrmPlanchas
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Name = "FrmPlanchas";
            this.Text = "Planchas Electorales";
            this.Load += new System.EventHandler(this.FrmPlanchas_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 25);
            this.lblTitulo.Text = "Planchas Electorales";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitulo.Text = "Registra, actualiza y administra las planchas participantes.";

            // panelFormulario
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Location = new System.Drawing.Point(40, 120);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(500, 500);

            // panelListado
            this.panelListado.BackColor = System.Drawing.Color.White;
            this.panelListado.Location = new System.Drawing.Point(570, 120);
            this.panelListado.Name = "panelListado";
            this.panelListado.Size = new System.Drawing.Size(560, 500);

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblNombre.Location = new System.Drawing.Point(35, 35);
            this.lblNombre.Text = "Nombre de la plancha";

            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre.Location = new System.Drawing.Point(35, 65);
            this.txtNombre.Size = new System.Drawing.Size(420, 27);

            // lblSiglas
            this.lblSiglas.AutoSize = true;
            this.lblSiglas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSiglas.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSiglas.Location = new System.Drawing.Point(35, 120);
            this.lblSiglas.Text = "Siglas";

            // txtSiglas
            this.txtSiglas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSiglas.Location = new System.Drawing.Point(35, 150);
            this.txtSiglas.Size = new System.Drawing.Size(420, 27);

            // lblLogo
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblLogo.Location = new System.Drawing.Point(35, 205);
            this.lblLogo.Text = "Logo de la plancha";

            // picLogo
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(35, 235);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;

            // btnSeleccionarLogo
            this.btnSeleccionarLogo.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnSeleccionarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLogo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarLogo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarLogo.Location = new System.Drawing.Point(210, 275);
            this.btnSeleccionarLogo.Size = new System.Drawing.Size(245, 40);
            this.btnSeleccionarLogo.Text = "SELECCIONAR LOGO";
            this.btnSeleccionarLogo.UseVisualStyleBackColor = false;
            this.btnSeleccionarLogo.Click += new System.EventHandler(this.btnSeleccionarLogo_Click);

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(35, 385);
            this.btnGuardar.Size = new System.Drawing.Size(420, 40);
            this.btnGuardar.Text = "GUARDAR PLANCHA";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(35, 440);
            this.btnActualizar.Size = new System.Drawing.Size(200, 40);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(255, 440);
            this.btnEliminar.Size = new System.Drawing.Size(200, 40);
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // dgvPlanchas
            this.dgvPlanchas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanchas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanchas.Location = new System.Drawing.Point(20, 20);
            this.dgvPlanchas.Name = "dgvPlanchas";
            this.dgvPlanchas.Size = new System.Drawing.Size(520, 450);
            this.dgvPlanchas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanchas.RowHeadersVisible = false;
            this.dgvPlanchas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanchas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanchas_CellClick);

            // controles panelFormulario
            this.panelFormulario.Controls.Add(this.lblNombre);
            this.panelFormulario.Controls.Add(this.txtNombre);
            this.panelFormulario.Controls.Add(this.lblSiglas);
            this.panelFormulario.Controls.Add(this.txtSiglas);
            this.panelFormulario.Controls.Add(this.lblLogo);
            this.panelFormulario.Controls.Add(this.picLogo);
            this.panelFormulario.Controls.Add(this.btnSeleccionarLogo);
            this.panelFormulario.Controls.Add(this.btnGuardar);
            this.panelFormulario.Controls.Add(this.btnActualizar);
            this.panelFormulario.Controls.Add(this.btnEliminar);

            // controles panelListado
            this.panelListado.Controls.Add(this.dgvPlanchas);

            // controles form
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelListado);

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelListado.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanchas)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}