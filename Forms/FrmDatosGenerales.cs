using System;
using System.Drawing;
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
            int votosValidos = totalVotos - votosNulos;
            int faltantes = totalUsuarios - totalVotos;

            double porcentajeParticipacion = totalUsuarios > 0
                ? (totalVotos * 100.0) / totalUsuarios
                : 0;

            lblPadron.Text = totalUsuarios.ToString();
            lblEmitidos.Text = totalVotos.ToString();
            lblNulos.Text = votosNulos.ToString();
            lblFaltantes.Text = faltantes.ToString();
            lblParticipacion.Text = porcentajeParticipacion.ToString("0.00") + "%";
            lblValidos.Text = votosValidos.ToString();

            int segundos = _configRepository.ObtenerSegundosRestantes();

            if (segundos <= 0)
            {
                lblTiempo.Text = "Cerrada";
                lblEstado.Text = "Estado: Votación cerrada";
            }
            else
            {
                TimeSpan tiempo = TimeSpan.FromSeconds(segundos);
                lblTiempo.Text = tiempo.Minutes.ToString("00") + ":" + tiempo.Seconds.ToString("00");
                lblEstado.Text = "Estado: Votación abierta";
            }

            dgvPosiciones.DataSource = null;
            dgvPosiciones.DataSource = _resultadoRepository.ObtenerResultadosPorPlancha();

            CrearGraficoBarras();
            CrearGraficoParticipacion(totalUsuarios, totalVotos, faltantes);
        }

        private void CrearGraficoBarras()
        {
            panelGraficoBarras.Controls.Clear();

            var resultados = _resultadoRepository.ObtenerResultadosPorPlancha();

            int y = 15;
            int maxBarra = 350;
            int totalVotos = _resultadoRepository.ObtenerTotalVotos();

            Label titulo = new Label();
            titulo.Text = "Votos por plancha";
            titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(44, 62, 80);
            titulo.Location = new Point(15, y);
            titulo.Size = new Size(400, 25);
            panelGraficoBarras.Controls.Add(titulo);

            y += 40;

            foreach (dynamic item in resultados)
            {
                string nombre = item.Nombre;
                int votos = item.TotalVotos;

                double porcentaje = totalVotos > 0 ? (votos * 100.0) / totalVotos : 0;
                int anchoBarra = totalVotos > 0 ? (int)((votos * maxBarra) / totalVotos) : 0;

                Label lblNombre = new Label();
                lblNombre.Text = nombre;
                lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                lblNombre.ForeColor = Color.FromArgb(44, 62, 80);
                lblNombre.Location = new Point(15, y);
                lblNombre.Size = new Size(160, 25);

                Panel barraFondo = new Panel();
                barraFondo.BackColor = Color.FromArgb(230, 230, 230);
                barraFondo.Location = new Point(180, y + 3);
                barraFondo.Size = new Size(maxBarra, 18);

                Panel barra = new Panel();
                barra.BackColor = Color.FromArgb(41, 128, 185);
                barra.Location = new Point(0, 0);
                barra.Size = new Size(anchoBarra, 18);

                Label lblPorcentaje = new Label();
                lblPorcentaje.Text = votos + " votos - " + porcentaje.ToString("0.00") + "%";
                lblPorcentaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                lblPorcentaje.ForeColor = Color.DimGray;
                lblPorcentaje.Location = new Point(545, y);
                lblPorcentaje.Size = new Size(170, 25);

                barraFondo.Controls.Add(barra);
                panelGraficoBarras.Controls.Add(lblNombre);
                panelGraficoBarras.Controls.Add(barraFondo);
                panelGraficoBarras.Controls.Add(lblPorcentaje);

                y += 35;
            }
        }

        private void CrearGraficoParticipacion(int totalUsuarios, int totalVotos, int faltantes)
        {
            panelGraficoParticipacion.Controls.Clear();

            Label titulo = new Label();
            titulo.Text = "Participación electoral";
            titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(44, 62, 80);
            titulo.Location = new Point(15, 15);
            titulo.Size = new Size(300, 25);
            panelGraficoParticipacion.Controls.Add(titulo);

            int maxBarra = 420;

            int anchoVotaron = totalUsuarios > 0 ? (int)((totalVotos * maxBarra) / totalUsuarios) : 0;
            int anchoFaltan = totalUsuarios > 0 ? (int)((faltantes * maxBarra) / totalUsuarios) : 0;

            Label lblVotaron = new Label();
            lblVotaron.Text = "Ya votaron";
            lblVotaron.Location = new Point(15, 65);
            lblVotaron.Size = new Size(120, 25);
            lblVotaron.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            Panel fondoVotaron = new Panel();
            fondoVotaron.BackColor = Color.FromArgb(230, 230, 230);
            fondoVotaron.Location = new Point(140, 68);
            fondoVotaron.Size = new Size(maxBarra, 18);

            Panel barraVotaron = new Panel();
            barraVotaron.BackColor = Color.FromArgb(39, 174, 96);
            barraVotaron.Size = new Size(anchoVotaron, 18);

            Label lblFaltan = new Label();
            lblFaltan.Text = "Faltan";
            lblFaltan.Location = new Point(15, 110);
            lblFaltan.Size = new Size(120, 25);
            lblFaltan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            Panel fondoFaltan = new Panel();
            fondoFaltan.BackColor = Color.FromArgb(230, 230, 230);
            fondoFaltan.Location = new Point(140, 113);
            fondoFaltan.Size = new Size(maxBarra, 18);

            Panel barraFaltan = new Panel();
            barraFaltan.BackColor = Color.FromArgb(192, 57, 43);
            barraFaltan.Size = new Size(anchoFaltan, 18);

            fondoVotaron.Controls.Add(barraVotaron);
            fondoFaltan.Controls.Add(barraFaltan);

            panelGraficoParticipacion.Controls.Add(lblVotaron);
            panelGraficoParticipacion.Controls.Add(fondoVotaron);
            panelGraficoParticipacion.Controls.Add(lblFaltan);
            panelGraficoParticipacion.Controls.Add(fondoFaltan);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}