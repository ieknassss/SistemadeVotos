using System;
using System.Windows.Forms;
using SistemadeVotaciones.Data;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmDatosGenerales : Form
    {
        private readonly ResultadoRepository _resultadoRepository;
        private readonly ConfiguracionVotacionRepository _configRepository;

        public FrmDatosGenerales()
        {
            InitializeComponent();

            _resultadoRepository = new ResultadoRepository();
            _configRepository = new ConfiguracionVotacionRepository();
        }

        private void FrmDatosGenerales_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            int totalUsuarios = _resultadoRepository.ObtenerTotalUsuarios();
            int totalVotos = _resultadoRepository.ObtenerTotalVotos();
            int votosNulos = _resultadoRepository.ObtenerVotosNulos();

            int faltantes = totalUsuarios - totalVotos;

            double porcentajeParticipacion = 0;

            if (totalUsuarios > 0)
            {
                porcentajeParticipacion =
                    (totalVotos * 100.0) / totalUsuarios;
            }

            lblPadron.Text = totalUsuarios.ToString();
            lblEmitidos.Text = totalVotos.ToString();
            lblNulos.Text = votosNulos.ToString();
            lblFaltantes.Text = faltantes.ToString();

            lblParticipacion.Text =
                porcentajeParticipacion.ToString("0.00") + "%";

            int segundos = _configRepository.ObtenerSegundosRestantes();

            if (segundos <= 0)
            {
                lblTiempo.Text = "Votación cerrada";
            }
            else
            {
                TimeSpan tiempo = TimeSpan.FromSeconds(segundos);

                lblTiempo.Text =
                    tiempo.Minutes.ToString("00") +
                    ":" +
                    tiempo.Seconds.ToString("00");
            }

            dgvPosiciones.DataSource = null;
            dgvPosiciones.DataSource =
                _resultadoRepository.ObtenerResultadosPorPlancha();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}