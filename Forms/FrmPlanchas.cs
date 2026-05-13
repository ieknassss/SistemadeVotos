using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using SistemadeVotaciones.Data;
using SistemadeVotaciones.Entities;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmPlanchas : Form
    {
        private readonly PlanchaRepository _planchaRepository;
        private int planchaIdSeleccionada = 0;
        private string rutaLogo = "";

        public FrmPlanchas()
        {
            InitializeComponent();
            _planchaRepository = new PlanchaRepository();
        }

        private void FrmPlanchas_Load(object sender, EventArgs e)
        {
            CargarPlanchas();
        }

        private void CargarPlanchas()
        {
            dgvPlanchas.DataSource = null;
            dgvPlanchas.DataSource = _planchaRepository.ObtenerPlanchas();

            if (dgvPlanchas.Columns["Logo"] != null)
                dgvPlanchas.Columns["Logo"].Visible = false;

            if (dgvPlanchas.Columns["PadronId"] != null)
                dgvPlanchas.Columns["PadronId"].Visible = false;
        }

        private void btnSeleccionarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                rutaLogo = dialogo.FileName;
                picLogo.ImageLocation = rutaLogo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Plancha plancha = new Plancha
            {
                Nombre = txtNombre.Text.Trim(),
                Siglas = txtSiglas.Text.Trim(),
                Logo = rutaLogo,
                PadronId = 1
            };

            _planchaRepository.GuardarPlancha(plancha);

            MessageBox.Show("Plancha guardada correctamente.");
            LimpiarCampos();
            CargarPlanchas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (planchaIdSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una plancha de la tabla.");
                return;
            }

            Plancha plancha = new Plancha
            {
                Id = planchaIdSeleccionada,
                Nombre = txtNombre.Text.Trim(),
                Siglas = txtSiglas.Text.Trim(),
                Logo = rutaLogo,
                PadronId = 1
            };

            _planchaRepository.ActualizarPlancha(plancha);

            MessageBox.Show("Plancha actualizada correctamente.");
            LimpiarCampos();
            CargarPlanchas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (planchaIdSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una plancha de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que deseas eliminar esta plancha?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                _planchaRepository.EliminarPlancha(planchaIdSeleccionada);

                MessageBox.Show("Plancha eliminada correctamente.");
                LimpiarCampos();
                CargarPlanchas();
            }
        }

        private void dgvPlanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvPlanchas.Rows[e.RowIndex];

            planchaIdSeleccionada = Convert.ToInt32(fila.Cells["Id"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtSiglas.Text = fila.Cells["Siglas"].Value.ToString();

            rutaLogo = fila.Cells["Logo"].Value?.ToString();

            if (!string.IsNullOrEmpty(rutaLogo))
            {
                picLogo.ImageLocation = rutaLogo;
            }
            else
            {
                picLogo.Image = null;
            }
        }

        private void LimpiarCampos()
        {
            planchaIdSeleccionada = 0;
            rutaLogo = "";

            txtNombre.Clear();
            txtSiglas.Clear();
            picLogo.Image = null;

            txtNombre.Focus();
        }
    }
}