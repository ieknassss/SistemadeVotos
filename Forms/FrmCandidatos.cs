using System;
using System.Windows.Forms;
using SistemadeVotaciones.Data;
using SistemadeVotaciones.Entities;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmCandidatos : Form
    {
        private readonly CandidatoRepository _candidatoRepository;
        private readonly PlanchaRepository _planchaRepository;

        private int candidatoIdSeleccionado = 0;
        private string rutaFoto = "";

        public FrmCandidatos()
        {
            InitializeComponent();

            _candidatoRepository = new CandidatoRepository();
            _planchaRepository = new PlanchaRepository();
        }

        private void FrmCandidatos_Load(object sender, EventArgs e)
        {
            CargarPlanchas();
            CargarCandidatos();
        }

        private void CargarPlanchas()
        {
            cmbPlancha.DataSource = _planchaRepository.ObtenerPlanchas();
            cmbPlancha.DisplayMember = "Nombre";
            cmbPlancha.ValueMember = "Id";
        }

        private void CargarCandidatos()
        {
            dgvCandidatos.DataSource = null;
            dgvCandidatos.DataSource = _candidatoRepository.ObtenerCandidatos();

            if (dgvCandidatos.Columns["Foto"] != null)
                dgvCandidatos.Columns["Foto"].Visible = false;
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = dialogo.FileName;
                picFoto.ImageLocation = rutaFoto;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato
            {
                Nombre = txtNombre.Text.Trim(),
                Puesto = txtPuesto.Text.Trim(),
                Curso = txtCurso.Text.Trim(),
                Foto = rutaFoto,
                PlanchaId = Convert.ToInt32(cmbPlancha.SelectedValue)
            };

            _candidatoRepository.GuardarCandidato(candidato);

            MessageBox.Show("Candidato guardado correctamente.");

            LimpiarCampos();
            CargarCandidatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (candidatoIdSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un candidato de la tabla.");
                return;
            }

            Candidato candidato = new Candidato
            {
                Id = candidatoIdSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Puesto = txtPuesto.Text.Trim(),
                Curso = txtCurso.Text.Trim(),
                Foto = rutaFoto,
                PlanchaId = Convert.ToInt32(cmbPlancha.SelectedValue)
            };

            _candidatoRepository.ActualizarCandidato(candidato);

            MessageBox.Show("Candidato actualizado correctamente.");
            LimpiarCampos();
            CargarCandidatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (candidatoIdSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un candidato.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que deseas eliminar este candidato?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                _candidatoRepository.EliminarCandidato(candidatoIdSeleccionado);

                MessageBox.Show("Candidato eliminado correctamente.");

                LimpiarCampos();
                CargarCandidatos();
            }
        }

        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvCandidatos.Rows[e.RowIndex];

            candidatoIdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtPuesto.Text = fila.Cells["Puesto"].Value.ToString();
            txtCurso.Text = fila.Cells["Curso"].Value.ToString();

            cmbPlancha.SelectedValue = Convert.ToInt32(fila.Cells["PlanchaId"].Value);

            rutaFoto = fila.Cells["Foto"].Value?.ToString();

            if (!string.IsNullOrEmpty(rutaFoto))
                picFoto.ImageLocation = rutaFoto;
            else
                picFoto.Image = null;
        }

        private void LimpiarCampos()
        {
            candidatoIdSeleccionado = 0;
            rutaFoto = "";

            txtNombre.Clear();
            txtPuesto.Clear();
            txtCurso.Clear();

            picFoto.Image = null;

            if (cmbPlancha.Items.Count > 0)
                cmbPlancha.SelectedIndex = 0;

            txtNombre.Focus();
        }
    }
}