using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SistemadeVotaciones.Data;
using SistemadeVotaciones.Entities;
using SistemadeVotaciones.Helpers;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmVotacion : Form
    {
        private readonly PlanchaRepository _planchaRepository;
        private readonly VotoRepository _votoRepository;

        public FrmVotacion()
        {
            InitializeComponent();

            _planchaRepository = new PlanchaRepository();
            _votoRepository = new VotoRepository();
        }

        private void FrmVotacion_Load(object sender, EventArgs e)
        {
            CargarPlanchas();
        }

        private void CargarPlanchas()
        {
            flowPlanchas.Controls.Clear();

            bool yaVoto = _votoRepository.UsuarioYaVoto(SessionHelper.UsuarioActual.Id);

            if (yaVoto)
            {
                lblEstado.Text = "Ya realizaste tu voto. No puedes votar nuevamente.";
                btnVotoNulo.Enabled = false;
                return;
            }

            List<Plancha> planchas = _planchaRepository.ObtenerPlanchas();

            foreach (Plancha plancha in planchas)
            {
                Panel card = CrearTarjetaPlancha(plancha);
                flowPlanchas.Controls.Add(card);
            }
        }

        private Panel CrearTarjetaPlancha(Plancha plancha)
        {
            Panel card = new Panel();
            card.Width = 230;
            card.Height = 300;
            card.BackColor = Color.White;
            card.Margin = new Padding(15);
            card.BorderStyle = BorderStyle.FixedSingle;

            PictureBox logo = new PictureBox();
            logo.Width = 160;
            logo.Height = 120;
            logo.Location = new Point(35, 20);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.BackColor = Color.FromArgb(236, 240, 241);

            if (!string.IsNullOrEmpty(plancha.Logo))
            {
                logo.ImageLocation = plancha.Logo;
            }

            Label lblNombre = new Label();
            lblNombre.Text = plancha.Nombre;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(44, 62, 80);
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Location = new Point(10, 155);
            lblNombre.Size = new Size(210, 35);

            Label lblSiglas = new Label();
            lblSiglas.Text = plancha.Siglas;
            lblSiglas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSiglas.ForeColor = Color.DimGray;
            lblSiglas.TextAlign = ContentAlignment.MiddleCenter;
            lblSiglas.Location = new Point(10, 190);
            lblSiglas.Size = new Size(210, 25);

            Button btnVotar = new Button();
            btnVotar.Text = "VOTAR";
            btnVotar.BackColor = Color.FromArgb(41, 128, 185);
            btnVotar.ForeColor = Color.White;
            btnVotar.FlatStyle = FlatStyle.Flat;
            btnVotar.FlatAppearance.BorderSize = 0;
            btnVotar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVotar.Location = new Point(30, 235);
            btnVotar.Size = new Size(170, 40);

            btnVotar.Click += (s, e) =>
            {
                RegistrarVoto(plancha.Id, false);
            };

            card.Controls.Add(logo);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblSiglas);
            card.Controls.Add(btnVotar);

            return card;
        }

        private void RegistrarVoto(int? planchaId, bool esNulo)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás segura/o de realizar este voto? Luego no podrás cambiarlo.",
                "Confirmar voto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                _votoRepository.RegistrarVoto(
                    SessionHelper.UsuarioActual.Id,
                    planchaId,
                    esNulo,
                    SessionHelper.UsuarioActual.PadronId
                );

                SessionHelper.UsuarioActual.HaVotado = true;

                MessageBox.Show(
                    "Voto registrado correctamente.",
                    "Sistema de Votaciones",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarPlanchas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el voto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            RegistrarVoto(null, true);
        }
    }
}