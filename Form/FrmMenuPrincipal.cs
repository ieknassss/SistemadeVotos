using System;
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
            lblUsuario.Text = "Usuario: " + SessionHelper.UsuarioActual.Nombre;
            lblRol.Text = "Rol: " + SessionHelper.UsuarioActual.Rol;

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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SessionHelper.UsuarioActual = null;

            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}