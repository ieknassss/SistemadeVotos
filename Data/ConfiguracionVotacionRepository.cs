using Dapper;

namespace SistemadeVotaciones.Data
{
    public class ConfiguracionVotacionRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public ConfiguracionVotacionRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public bool VotacionEstaActiva()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT COUNT(*)
                FROM ConfiguracionVotacion
                WHERE Activa = 1
                AND GETDATE() BETWEEN FechaInicio AND FechaCierre";

                return connection.ExecuteScalar<int>(sql) > 0;
            }
        }

        public int ObtenerSegundosRestantes()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                SELECT TOP 1 DATEDIFF(SECOND, GETDATE(), FechaCierre)
                FROM ConfiguracionVotacion
                WHERE Activa = 1
                ORDER BY Id DESC";

                int segundos = connection.ExecuteScalar<int>(sql);

                return segundos < 0 ? 0 : segundos;
            }
        }
    }
}