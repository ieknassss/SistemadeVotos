using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using SistemadeVotaciones.Data;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmPanelElectoral : Form
    {
        private readonly DbConnectionFactory _connectionFactory;
        private readonly ResultadoRepository _resultadoRepository;
        private readonly ConfiguracionVotacionRepository _configRepository;

        public FrmPanelElectoral()
        {
            InitializeComponent();

            _connectionFactory = new DbConnectionFactory();
            _resultadoRepository = new ResultadoRepository();
            _configRepository = new ConfiguracionVotacionRepository();
        }

        private void FrmPanelElectoral_Load(object sender, EventArgs e)
        {
            CargarPanel();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPanel();
        }

        private void CargarPanel()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                var resultados = _resultadoRepository.ObtenerResultadosPorPlancha();

                int totalVotos = _resultadoRepository.ObtenerTotalVotos();
                int totalUsuarios = _resultadoRepository.ObtenerTotalUsuarios();

                int usuariosQueVotaron = connection.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM Usuarios WHERE HaVotado = 1");

                int totalPlanchas = connection.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM Planchas");

                int totalCandidatos = connection.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM Candidatos");

                int faltantes = totalUsuarios - totalVotos;

                lblUsuariosVotaron.Text = "Usuarios que votaron: " + usuariosQueVotaron;
                lblVotosRegistrados.Text = "Votos registrados: " + totalVotos;
                lblFaltantes.Text = "Faltantes: " + faltantes;
                lblTotalPlanchas.Text = "Planchas: " + totalPlanchas;
                lblTotalCandidatos.Text = "Candidatos: " + totalCandidatos;

                if (usuariosQueVotaron == totalVotos)
                {
                    lblValidacion.Text = "Validación: sistema correcto";
                    lblValidacion.ForeColor = Color.FromArgb(39, 174, 96);
                }
                else
                {
                    lblValidacion.Text = "Validación: revisar inconsistencia";
                    lblValidacion.ForeColor = Color.FromArgb(192, 57, 43);
                }

                int segundos = _configRepository.ObtenerSegundosRestantes();

                if (segundos <= 0)
                {
                    lblEstado.Text = "Estado: Cerrada";
                    lblTiempo.Text = "Tiempo: 00:00";
                }
                else
                {
                    TimeSpan tiempo = TimeSpan.FromSeconds(segundos);
                    lblEstado.Text = "Estado: Activa";
                    lblTiempo.Text = "Tiempo: " + tiempo.Minutes.ToString("00") + ":" + tiempo.Seconds.ToString("00");
                }

                var ultimoVoto = connection.QueryFirstOrDefault<dynamic>(
                    @"SELECT TOP 1 FechaVoto
                      FROM Votos
                      ORDER BY FechaVoto DESC");

                if (ultimoVoto != null)
                {
                    lblUltimoVoto.Text = "Último voto: " +
                        Convert.ToDateTime(ultimoVoto.FechaVoto).ToString("hh:mm:ss tt");
                }
                else
                {
                    lblUltimoVoto.Text = "Último voto: sin votos";
                }

                double porcentajeParticipacion = totalUsuarios > 0
                    ? (totalVotos * 100.0) / totalUsuarios
                    : 0;

                progressParticipacion.Value = Math.Min((int)porcentajeParticipacion, 100);
                lblParticipacion.Text = "Participación: " + porcentajeParticipacion.ToString("0.00") + "%";

                dgvMonitor.DataSource = null;
                dgvMonitor.DataSource = resultados;

                CrearRankingVisual(resultados, totalVotos);
                CalcularLiderazgo(resultados);
            }
        }

        private void CalcularLiderazgo(dynamic resultados)
        {
            var lista = ((System.Collections.Generic.IEnumerable<dynamic>)resultados).ToList();

            if (lista.Count == 0)
            {
                lblLider.Text = "Líder actual: sin datos";
                lblSegundo.Text = "Segundo lugar: -";
                lblDiferencia.Text = "Diferencia: 0 votos";
                lblAlerta.Text = "No hay planchas registradas.";
                return;
            }

            lblLider.Text = "Líder actual: " + lista[0].Nombre;

            if (lista.Count == 1)
            {
                lblSegundo.Text = "Segundo lugar: -";
                lblDiferencia.Text = "Diferencia: " + lista[0].TotalVotos + " votos";
                lblAlerta.Text = "Solo existe una plancha.";
                lblAlerta.ForeColor = Color.FromArgb(39, 174, 96);
                return;
            }

            lblSegundo.Text = "Segundo lugar: " + lista[1].Nombre;

            int diferencia = lista[0].TotalVotos - lista[1].TotalVotos;

            lblDiferencia.Text = "Diferencia: " + diferencia + " votos";

            if (diferencia == 0)
            {
                lblAlerta.Text = "Empate detectado.";
                lblAlerta.ForeColor = Color.FromArgb(192, 57, 43);
            }
            else
            {
                lblAlerta.Text = "Liderazgo estable.";
                lblAlerta.ForeColor = Color.FromArgb(39, 174, 96);
            }
        }

        private void CrearRankingVisual(dynamic resultados, int totalVotos)
        {
            panelRanking.Controls.Clear();

            int y = 20;
            int maxBarra = 400;

            foreach (dynamic item in resultados)
            {
                string nombre = item.Nombre;
                int votos = item.TotalVotos;

                double porcentaje = totalVotos > 0 ? (votos * 100.0) / totalVotos : 0;
                int ancho = totalVotos > 0 ? (int)((votos * maxBarra) / totalVotos) : 0;

                Label lblNombre = new Label();
                lblNombre.Text = nombre;
                lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                lblNombre.Location = new Point(15, y);
                lblNombre.Size = new Size(150, 25);

                Panel fondo = new Panel();
                fondo.BackColor = Color.FromArgb(230, 230, 230);
                fondo.Location = new Point(170, y + 4);
                fondo.Size = new Size(maxBarra, 18);

                Panel barra = new Panel();
                barra.BackColor = Color.FromArgb(41, 128, 185);
                barra.Size = new Size(ancho, 18);

                Label lblDatos = new Label();
                lblDatos.Text = votos + " votos - " + porcentaje.ToString("0.00") + "%";
                lblDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                lblDatos.ForeColor = Color.DimGray;
                lblDatos.Location = new Point(585, y);
                lblDatos.Size = new Size(180, 25);

                fondo.Controls.Add(barra);

                panelRanking.Controls.Add(lblNombre);
                panelRanking.Controls.Add(fondo);
                panelRanking.Controls.Add(lblDatos);

                y += 38;
            }
        }
    }
}