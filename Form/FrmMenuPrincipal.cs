using System;
using System.Drawing;
using System.Windows.Forms;
using SistemadeVotaciones.Helpers;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + SessionHelper.UsuarioActual.Nombre + " " + SessionHelper.UsuarioActual.Apellido;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.BringToFront();

            lblRol.Text = "Rol: " + SessionHelper.UsuarioActual.Rol;
            lblRol.ForeColor = Color.White;
            lblRol.BringToFront();

            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            string rol = SessionHelper.UsuarioActual.Rol;

            btnUsuarios.Visible = false;
            btnPlanchas.Visible = false;
            btnVotar.Visible = false;
            btnDatos.Visible = false;
            btnPanel.Visible = false;
            btnReportes.Visible = false;
            btnResultados.Visible = false;

            if (rol == "SuperAdmin")
            {
                btnUsuarios.Visible = true;
                btnPlanchas.Visible = true;
                btnVotar.Visible = true;
                btnDatos.Visible = true;
                btnPanel.Visible = true;
                btnReportes.Visible = true;
                btnResultados.Visible = true;
            }
            else if (rol == "AdminPlancha")
            {
                btnPlanchas.Visible = true;
                btnDatos.Visible = true;
                btnPanel.Visible = true;
                btnResultados.Visible = true;
            }
            else if (rol == "Votante")
            {
                btnVotar.Visible = true;
                btnResultados.Visible = true;
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SessionHelper.UsuarioActual = null;

            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }
    }
}