using System;
using System.Windows.Forms;
using SistemadeVotaciones.Data;
using SistemadeVotaciones.Helpers;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioRepository _usuarioRepository;

        public FrmLogin()
        {
            InitializeComponent();

            _usuarioRepository = new UsuarioRepository();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (usuario == "" || clave == "")
            {
                MessageBox.Show(
                    "Debes completar todos los campos.",
                    "Sistema de Votaciones",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            var usuarioEncontrado = _usuarioRepository.Login(usuario, clave);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            SessionHelper.UsuarioActual = usuarioEncontrado;

            MessageBox.Show(
                "Bienvenida/o " + usuarioEncontrado.Nombre,
                "Inicio de sesión correcto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            FrmMenuPrincipal menu = new FrmMenuPrincipal();

            menu.Show();

            this.Hide();
        }
    }
}