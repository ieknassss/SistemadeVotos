namespace SistemadeVotaciones.Forms
{
    partial class FrmCandidatos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelListado;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblPlancha;
        private System.Windows.Forms.Label lblFoto;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtCurso;

        private System.Windows.Forms.ComboBox cmbPlancha;
        private System.Windows.Forms.PictureBox picFoto;

        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.DataGridView dgvCandidatos;

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
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblPlancha = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();

            this.cmbPlancha = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();

            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.dgvCandidatos = new System.Windows.Forms.DataGridView();

            this.panelFormulario.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();

            this.SuspendLayout();

            // FrmCandidatos
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Name = "FrmCandidatos";
            this.Text = "Candidatos";
            this.Load += new System.EventHandler(this.FrmCandidatos_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 25);
            this.lblTitulo.Text = "Registro de Candidatos";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitulo.Text = "Agrega candidatos, puestos, cursos y fotografías por plancha electoral.";

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
            this.lblNombre.Location = new System.Drawing.Point(35, 30);
            this.lblNombre.Text = "Nombre del candidato";

            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre.Location = new System.Drawing.Point(35, 55);
            this.txtNombre.Size = new System.Drawing.Size(420, 27);

            // lblPuesto
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPuesto.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPuesto.Location = new System.Drawing.Point(35, 105);
            this.lblPuesto.Text = "Puesto";

            // txtPuesto
            this.txtPuesto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPuesto.Location = new System.Drawing.Point(35, 130);
            this.txtPuesto.Size = new System.Drawing.Size(200, 27);

            // lblCurso
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurso.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblCurso.Location = new System.Drawing.Point(255, 105);
            this.lblCurso.Text = "Curso";

            // txtCurso
            this.txtCurso.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurso.Location = new System.Drawing.Point(255, 130);
            this.txtCurso.Size = new System.Drawing.Size(200, 27);

            // lblPlancha
            this.lblPlancha.AutoSize = true;
            this.lblPlancha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlancha.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPlancha.Location = new System.Drawing.Point(35, 180);
            this.lblPlancha.Text = "Plancha";

            // cmbPlancha
            this.cmbPlancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlancha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPlancha.Location = new System.Drawing.Point(35, 205);
            this.cmbPlancha.Size = new System.Drawing.Size(420, 28);

            // lblFoto
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFoto.Location = new System.Drawing.Point(35, 255);
            this.lblFoto.Text = "Foto del candidato";

            // picFoto
            this.picFoto.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(35, 285);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(130, 120);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabStop = false;

            // btnSeleccionarFoto
            this.btnSeleccionarFoto.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarFoto.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarFoto.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarFoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(190, 325);
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(265, 40);
            this.btnSeleccionarFoto.Text = "SELECCIONAR FOTO";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = false;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(35, 430);
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnEliminar
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(255, 430);
            this.btnEliminar.Size = new System.Drawing.Size(200, 40);
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // dgvCandidatos
            this.dgvCandidatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidatos.Location = new System.Drawing.Point(20, 20);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.Size = new System.Drawing.Size(520, 450);
            this.dgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatos.RowHeadersVisible = false;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatos_CellClick);

            // panelFormulario controls
            this.panelFormulario.Controls.Add(this.lblNombre);
            this.panelFormulario.Controls.Add(this.txtNombre);

            this.panelFormulario.Controls.Add(this.lblPuesto);
            this.panelFormulario.Controls.Add(this.txtPuesto);

            this.panelFormulario.Controls.Add(this.lblCurso);
            this.panelFormulario.Controls.Add(this.txtCurso);

            this.panelFormulario.Controls.Add(this.lblPlancha);
            this.panelFormulario.Controls.Add(this.cmbPlancha);

            this.panelFormulario.Controls.Add(this.lblFoto);
            this.panelFormulario.Controls.Add(this.picFoto);
            this.panelFormulario.Controls.Add(this.btnSeleccionarFoto);

            this.panelFormulario.Controls.Add(this.btnGuardar);
            this.panelFormulario.Controls.Add(this.btnEliminar);

            // panelListado controls
            this.panelListado.Controls.Add(this.dgvCandidatos);

            // form controls
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelListado);

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();

            this.panelListado.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}