using System;
using System.Windows.Forms;
using SistemadeVotaciones.Data;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmResultados : Form
    {
        private readonly ResultadoRepository _resultadoRepository;

        public FrmResultados()
        {
            InitializeComponent();
            _resultadoRepository = new ResultadoRepository();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            CargarResultados();
        }

        private void CargarResultados()
        {
            int totalUsuarios = _resultadoRepository.ObtenerTotalUsuarios();
            int totalVotos = _resultadoRepository.ObtenerTotalVotos();
            int votosNulos = _resultadoRepository.ObtenerVotosNulos();

            double porcentajeParticipacion = 0;

            if (totalUsuarios > 0)
            {
                porcentajeParticipacion = (totalVotos * 100.0) / totalUsuarios;
            }

            lblTotalUsuarios.Text = totalUsuarios.ToString();
            lblVotosEmitidos.Text = totalVotos.ToString();
            lblVotosNulos.Text = votosNulos.ToString();
            lblParticipacion.Text = porcentajeParticipacion.ToString("0.00") + "%";

            string ganadora = _resultadoRepository.ObtenerPlanchaGanadora();

            if (string.IsNullOrEmpty(ganadora))
            {
                lblGanadora.Text = "Sin votos todavía";
            }
            else
            {
                lblGanadora.Text = ganadora;
            }

            dgvResultados.DataSource = null;
            dgvResultados.DataSource = _resultadoRepository.ObtenerResultadosPorPlancha();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarResultados();
        }
    }
}