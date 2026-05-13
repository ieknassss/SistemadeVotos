using System;
using System.Windows.Forms;
using SistemadeVotaciones.Data;
using SistemadeVotaciones.Entities;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioRepository _usuarioRepository;
        private int usuarioIdSeleccionado = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
            _usuarioRepository = new UsuarioRepository();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("SuperAdmin");
            cmbRol.Items.Add("AdminPlancha");
            cmbRol.Items.Add("Votante");
            cmbRol.SelectedIndex = 0;

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _usuarioRepository.ObtenerUsuarios();

            dgvUsuarios.Columns["Clave"].Visible = false;
            dgvUsuarios.Columns["PlanchaId"].Visible = false;
            dgvUsuarios.Columns["PadronId"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObtenerDatosFormulario();
            usuario.PadronId = 1;
            usuario.PlanchaId = null;
            usuario.HaVotado = false;

            _usuarioRepository.GuardarUsuario(usuario);

            MessageBox.Show("Usuario guardado correctamente.");
            LimpiarCampos();
            CargarUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (usuarioIdSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla.");
                return;
            }

            Usuario usuario = ObtenerDatosFormulario();
            usuario.Id = usuarioIdSeleccionado;

            _usuarioRepository.ActualizarUsuario(usuario);

            MessageBox.Show("Usuario actualizado correctamente.");
            LimpiarCampos();
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioIdSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que deseas eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                _usuarioRepository.EliminarUsuario(usuarioIdSeleccionado);

                MessageBox.Show("Usuario eliminado correctamente.");
                LimpiarCampos();
                CargarUsuarios();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            usuarioIdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            txtCurso.Text = fila.Cells["Curso"].Value.ToString();
            txtSeccion.Text = fila.Cells["Seccion"].Value.ToString();
            txtMatricula.Text = fila.Cells["Matricula"].Value.ToString();
            txtUsuario.Text = fila.Cells["UsuarioLogin"].Value.ToString();
            txtClave.Text = fila.Cells["Clave"].Value.ToString();
            cmbRol.Text = fila.Cells["Rol"].Value.ToString();
        }

        private Usuario ObtenerDatosFormulario()
        {
            return new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Curso = txtCurso.Text.Trim(),
                Seccion = txtSeccion.Text.Trim(),
                Matricula = txtMatricula.Text.Trim(),
                UsuarioLogin = txtUsuario.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                Rol = cmbRol.Text
            };
        }

        private void LimpiarCampos()
        {
            usuarioIdSeleccionado = 0;

            txtNombre.Clear();
            txtApellido.Clear();
            txtCurso.Clear();
            txtSeccion.Clear();
            txtMatricula.Clear();
            txtUsuario.Clear();
            txtClave.Clear();

            cmbRol.SelectedIndex = 0;
            txtNombre.Focus();
        }
    }
}