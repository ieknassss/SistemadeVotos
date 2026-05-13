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
        private readonly CandidatoRepository _candidatoRepository;
        private readonly ConfiguracionVotacionRepository _configRepository;

        public FrmVotacion()
        {
            InitializeComponent();

            _planchaRepository = new PlanchaRepository();
            _votoRepository = new VotoRepository();
            _candidatoRepository = new CandidatoRepository();
            _configRepository = new ConfiguracionVotacionRepository();
        }

        private void FrmVotacion_Load(object sender, EventArgs e)
        {
            CargarPlanchas();
            timerVotacion.Start();
            ActualizarTiempo();
        }

        private void CargarPlanchas()
        {
            flowPlanchas.Controls.Clear();

            btnVotoNulo.Enabled = true;

            if (!_configRepository.VotacionEstaActiva())
            {
                lblEstado.Text = "La votación está cerrada. Ya no puedes votar.";
                btnVotoNulo.Enabled = false;
                return;
            }

            bool yaVoto = _votoRepository.UsuarioYaVoto(SessionHelper.UsuarioActual.Id);

            if (yaVoto)
            {
                lblEstado.Text = "Ya realizaste tu voto. No puedes votar nuevamente.";
                btnVotoNulo.Enabled = false;
                return;
            }

            lblEstado.Text = "Selecciona una plancha o realiza voto nulo.";

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
            card.Width = 300;
            card.Height = 430;
            card.BackColor = Color.White;
            card.Margin = new Padding(15);
            card.BorderStyle = BorderStyle.FixedSingle;

            PictureBox logo = new PictureBox();
            logo.Width = 120;
            logo.Height = 90;
            logo.Location = new Point(90, 15);
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
            lblNombre.Location = new Point(10, 115);
            lblNombre.Size = new Size(280, 30);

            Label lblSiglas = new Label();
            lblSiglas.Text = plancha.Siglas;
            lblSiglas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSiglas.ForeColor = Color.DimGray;
            lblSiglas.TextAlign = ContentAlignment.MiddleCenter;
            lblSiglas.Location = new Point(10, 145);
            lblSiglas.Size = new Size(280, 25);

            FlowLayoutPanel panelCandidatos = new FlowLayoutPanel();
            panelCandidatos.Location = new Point(15, 180);
            panelCandidatos.Size = new Size(270, 170);
            panelCandidatos.AutoScroll = true;
            panelCandidatos.BackColor = Color.FromArgb(245, 245, 245);

            List<Candidato> candidatos = _candidatoRepository.ObtenerCandidatosPorPlancha(plancha.Id);

            foreach (Candidato candidato in candidatos)
            {
                Panel candidatoCard = CrearMiniCardCandidato(candidato);
                panelCandidatos.Controls.Add(candidatoCard);
            }

            Button btnVotar = new Button();
            btnVotar.Text = "VOTAR";
            btnVotar.BackColor = Color.FromArgb(41, 128, 185);
            btnVotar.ForeColor = Color.White;
            btnVotar.FlatStyle = FlatStyle.Flat;
            btnVotar.FlatAppearance.BorderSize = 0;
            btnVotar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVotar.Location = new Point(45, 365);
            btnVotar.Size = new Size(210, 45);

            btnVotar.Click += (s, e) =>
            {
                RegistrarVoto(plancha.Id, false);
            };

            card.Controls.Add(logo);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblSiglas);
            card.Controls.Add(panelCandidatos);
            card.Controls.Add(btnVotar);

            return card;
        }

        private Panel CrearMiniCardCandidato(Candidato candidato)
        {
            Panel panel = new Panel();
            panel.Width = 250;
            panel.Height = 70;
            panel.BackColor = Color.White;
            panel.Margin = new Padding(8);

            PictureBox foto = new PictureBox();
            foto.Width = 55;
            foto.Height = 55;
            foto.Location = new Point(8, 8);
            foto.SizeMode = PictureBoxSizeMode.Zoom;
            foto.BackColor = Color.FromArgb(236, 240, 241);

            if (!string.IsNullOrEmpty(candidato.Foto))
            {
                foto.ImageLocation = candidato.Foto;
            }

            Label lblNombre = new Label();
            lblNombre.Text = candidato.Nombre;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(44, 62, 80);
            lblNombre.Location = new Point(70, 8);
            lblNombre.Size = new Size(170, 25);

            Label lblPuesto = new Label();
            lblPuesto.Text = candidato.Puesto + " - " + candidato.Curso;
            lblPuesto.Font = new Font("Segoe UI", 8F);
            lblPuesto.ForeColor = Color.DimGray;
            lblPuesto.Location = new Point(70, 35);
            lblPuesto.Size = new Size(170, 25);

            panel.Controls.Add(foto);
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(lblPuesto);

            return panel;
        }

        private void RegistrarVoto(int? planchaId, bool esNulo)
        {
            if (!_configRepository.VotacionEstaActiva())
            {
                MessageBox.Show("La votación ya fue cerrada.");
                CargarPlanchas();
                return;
            }

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

                MessageBox.Show("Voto registrado correctamente.");

                CargarPlanchas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el voto: " + ex.Message);
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            RegistrarVoto(null, true);
        }

        private void timerVotacion_Tick(object sender, EventArgs e)
        {
            ActualizarTiempo();
        }

        private void ActualizarTiempo()
        {
            int segundosRestantes = _configRepository.ObtenerSegundosRestantes();

            if (segundosRestantes <= 0)
            {
                lblTiempo.Text = "Tiempo agotado";
                timerVotacion.Stop();

                flowPlanchas.Controls.Clear();
                lblEstado.Text = "La votación está cerrada.";
                btnVotoNulo.Enabled = false;

                return;
            }

            TimeSpan tiempo = TimeSpan.FromSeconds(segundosRestantes);

            lblTiempo.Text = "Tiempo: " +
                             tiempo.Minutes.ToString("00") +
                             ":" +
                             tiempo.Seconds.ToString("00");
        }
    }
}