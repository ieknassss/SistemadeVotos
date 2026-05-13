namespace SistemadeVotaciones.Forms
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContenedor;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPlanchas;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnCerrarSesion;

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
            this.panelMenu = new System.Windows.Forms.Panel();

            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnPlanchas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();

            this.panelTop = new System.Windows.Forms.Panel();

            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.panelContenedor = new System.Windows.Forms.Panel();

            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();

            this.SuspendLayout();

            // panelMenu
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);

            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnResultados);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnPanel);
            this.panelMenu.Controls.Add(this.btnDatos);
            this.panelMenu.Controls.Add(this.btnVotar);
            this.panelMenu.Controls.Add(this.btnPlanchas);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnInicio);

            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 650);

            // btnInicio
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Height = 50;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);

            // btnUsuarios
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Height = 45;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);

            // btnPlanchas
            this.btnPlanchas.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnPlanchas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanchas.FlatAppearance.BorderSize = 0;
            this.btnPlanchas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanchas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPlanchas.ForeColor = System.Drawing.Color.White;
            this.btnPlanchas.Height = 45;
            this.btnPlanchas.Text = "Planchas";
            this.btnPlanchas.UseVisualStyleBackColor = false;
            this.btnPlanchas.Click += new System.EventHandler(this.btnPlanchas_Click);

            // btnVotar
            this.btnVotar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnVotar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVotar.FlatAppearance.BorderSize = 0;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVotar.ForeColor = System.Drawing.Color.White;
            this.btnVotar.Height = 45;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);

            // btnDatos
            this.btnDatos.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDatos.ForeColor = System.Drawing.Color.White;
            this.btnDatos.Height = 45;
            this.btnDatos.Text = "Datos Generales";
            this.btnDatos.UseVisualStyleBackColor = false;

            // btnPanel
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.FlatAppearance.BorderSize = 0;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPanel.ForeColor = System.Drawing.Color.White;
            this.btnPanel.Height = 45;
            this.btnPanel.Text = "Panel Electoral";
            this.btnPanel.UseVisualStyleBackColor = false;

            // btnReportes
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Height = 45;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;

            // btnResultados
            this.btnResultados.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnResultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResultados.FlatAppearance.BorderSize = 0;
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnResultados.ForeColor = System.Drawing.Color.White;
            this.btnResultados.Height = 45;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = false;

            // btnCerrarSesion
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Height = 45;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.panelTop.Controls.Add(this.lblRol);
            this.panelTop.Controls.Add(this.lblUsuario);
            this.panelTop.Controls.Add(this.lblTitulo);

            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(880, 70);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Text = "Sistema de Votaciones Escolar";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(600, 15);
            this.lblUsuario.Text = "Usuario:";

            // lblRol
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(600, 40);
            this.lblRol.Text = "Rol:";

            // panelContenedor
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 70);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(880, 580);

            // FrmMenuPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);

            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);

            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);

            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}