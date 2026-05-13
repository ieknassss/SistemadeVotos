namespace SistemadeVotaciones.Forms
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelListado;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblRol;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;

        private System.Windows.Forms.ComboBox cmbRol;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.DataGridView dgvUsuarios;

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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();

            this.cmbRol = new System.Windows.Forms.ComboBox();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.dgvUsuarios = new System.Windows.Forms.DataGridView();

            this.panelFormulario.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();

            this.SuspendLayout();

            // FrmUsuarios
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 25);
            this.lblTitulo.Text = "Registro de Usuarios";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitulo.Text = "Administra votantes, administradores de plancha y super administradores.";

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

            // Labels
            System.Windows.Forms.Label[] labels =
            {
                lblNombre, lblApellido, lblCurso, lblSeccion,
                lblMatricula, lblUsuario, lblClave, lblRol
            };

            foreach (var lbl in labels)
            {
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            }

            lblNombre.Text = "Nombre";
            lblApellido.Text = "Apellido";
            lblCurso.Text = "Curso";
            lblSeccion.Text = "Sección";
            lblMatricula.Text = "Matrícula";
            lblUsuario.Text = "Usuario";
            lblClave.Text = "Contraseña";
            lblRol.Text = "Rol";

            lblNombre.Location = new System.Drawing.Point(30, 30);
            lblApellido.Location = new System.Drawing.Point(260, 30);

            lblCurso.Location = new System.Drawing.Point(30, 105);
            lblSeccion.Location = new System.Drawing.Point(260, 105);

            lblMatricula.Location = new System.Drawing.Point(30, 180);
            lblUsuario.Location = new System.Drawing.Point(260, 180);

            lblClave.Location = new System.Drawing.Point(30, 255);
            lblRol.Location = new System.Drawing.Point(260, 255);

            // TextBox
            System.Windows.Forms.TextBox[] textboxes =
            {
                txtNombre, txtApellido, txtCurso, txtSeccion,
                txtMatricula, txtUsuario, txtClave
            };

            foreach (var txt in textboxes)
            {
                txt.Font = new System.Drawing.Font("Segoe UI", 11F);
                txt.Size = new System.Drawing.Size(190, 27);
            }

            txtNombre.Location = new System.Drawing.Point(30, 55);
            txtApellido.Location = new System.Drawing.Point(260, 55);

            txtCurso.Location = new System.Drawing.Point(30, 130);
            txtSeccion.Location = new System.Drawing.Point(260, 130);

            txtMatricula.Location = new System.Drawing.Point(30, 205);
            txtUsuario.Location = new System.Drawing.Point(260, 205);

            txtClave.Location = new System.Drawing.Point(30, 280);
            txtClave.UseSystemPasswordChar = true;

            // cmbRol
            cmbRol.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRol.Location = new System.Drawing.Point(260, 280);
            cmbRol.Size = new System.Drawing.Size(190, 28);

            // btnGuardar
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.Location = new System.Drawing.Point(30, 360);
            btnGuardar.Size = new System.Drawing.Size(420, 45);
            btnGuardar.Text = "GUARDAR USUARIO";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnActualizar
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.ForeColor = System.Drawing.Color.White;
            btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnActualizar.Location = new System.Drawing.Point(30, 420);
            btnActualizar.Size = new System.Drawing.Size(200, 40);
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            btnEliminar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEliminar.Location = new System.Drawing.Point(250, 420);
            btnEliminar.Size = new System.Drawing.Size(200, 40);
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // dgvUsuarios
            dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsuarios.Location = new System.Drawing.Point(20, 20);
            dgvUsuarios.Size = new System.Drawing.Size(520, 450);
            dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            // Agregar controles panelFormulario
            panelFormulario.Controls.Add(lblNombre);
            panelFormulario.Controls.Add(txtNombre);

            panelFormulario.Controls.Add(lblApellido);
            panelFormulario.Controls.Add(txtApellido);

            panelFormulario.Controls.Add(lblCurso);
            panelFormulario.Controls.Add(txtCurso);

            panelFormulario.Controls.Add(lblSeccion);
            panelFormulario.Controls.Add(txtSeccion);

            panelFormulario.Controls.Add(lblMatricula);
            panelFormulario.Controls.Add(txtMatricula);

            panelFormulario.Controls.Add(lblUsuario);
            panelFormulario.Controls.Add(txtUsuario);

            panelFormulario.Controls.Add(lblClave);
            panelFormulario.Controls.Add(txtClave);

            panelFormulario.Controls.Add(lblRol);
            panelFormulario.Controls.Add(cmbRol);

            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(btnActualizar);
            panelFormulario.Controls.Add(btnEliminar);

            // Agregar grid
            panelListado.Controls.Add(dgvUsuarios);

            // Agregar controles al form
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblSubtitulo);
            this.Controls.Add(panelFormulario);
            this.Controls.Add(panelListado);

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();

            this.panelListado.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}