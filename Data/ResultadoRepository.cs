using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace SistemadeVotaciones.Data
{
    public class ResultadoRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public ResultadoRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public int ObtenerTotalUsuarios()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT COUNT(*) FROM Usuarios";
                return connection.ExecuteScalar<int>(sql);
            }
        }

        public int ObtenerTotalVotos()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT COUNT(*) FROM Votos";
                return connection.ExecuteScalar<int>(sql);
            }
        }

        public int ObtenerVotosNulos()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT COUNT(*) FROM Votos WHERE EsNulo = 1";
                return connection.ExecuteScalar<int>(sql);
            }
        }

        public List<dynamic> ObtenerResultadosPorPlancha()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT
                    P.Nombre,
                    P.Siglas,
                    COUNT(V.Id) AS TotalVotos
                FROM Planchas P
                LEFT JOIN Votos V
                    ON P.Id = V.PlanchaId
                GROUP BY
                    P.Nombre,
                    P.Siglas
                ORDER BY TotalVotos DESC";

                return connection.Query(sql).ToList<dynamic>();
            }
        }

        public string ObtenerPlanchaGanadora()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT TOP 1
                    P.Nombre
                FROM Planchas P
                INNER JOIN Votos V
                    ON P.Id = V.PlanchaId
                GROUP BY P.Nombre
                ORDER BY COUNT(V.Id) DESC";

                return connection.ExecuteScalar<string>(sql);
            }
        }
    }
}