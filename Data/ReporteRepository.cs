using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace SistemadeVotaciones.Data
{
    public class ReporteRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public ReporteRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public dynamic ObtenerPlanchaGanadora()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT TOP 1
                    p.Nombre,
                    p.Siglas,
                    COUNT(v.Id) AS TotalVotos
                FROM Votos v
                INNER JOIN Planchas p
                    ON v.PlanchaId = p.Id
                WHERE v.EsNulo = 0
                GROUP BY p.Nombre, p.Siglas
                ORDER BY TotalVotos DESC";

                return connection.QueryFirstOrDefault(sql);
            }
        }

        public List<dynamic> ObtenerResultadosGenerales()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT
                    p.Nombre,
                    p.Siglas,
                    COUNT(v.Id) AS TotalVotos
                FROM Votos v
                INNER JOIN Planchas p
                    ON v.PlanchaId = p.Id
                WHERE v.EsNulo = 0
                GROUP BY p.Nombre, p.Siglas
                ORDER BY TotalVotos DESC";

                return connection.Query<dynamic>(sql).ToList();
            }
        }

        public List<dynamic> ObtenerIntegrantesPlancha()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT
                    p.Nombre AS Plancha,
                    c.Nombre,
                    c.Puesto,
                    c.Curso
                FROM Candidatos c
                INNER JOIN Planchas p
                    ON c.PlanchaId = p.Id
                ORDER BY p.Nombre";

                return connection.Query<dynamic>(sql).ToList();
            }
        }

        public List<dynamic> ObtenerParticipantes()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT
                    Nombre,
                    Apellido,
                    UsuarioLogin,
                    Rol,
                    HaVotado
                FROM Usuarios
                ORDER BY Nombre";

                return connection.Query<dynamic>(sql).ToList();
            }
        }
    }
}