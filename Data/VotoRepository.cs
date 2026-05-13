using Dapper;

namespace SistemadeVotaciones.Data
{
    public class VotoRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public VotoRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public void RegistrarVoto(int usuarioId, int? planchaId, bool esNulo, int padronId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                INSERT INTO Votos
                (UsuarioId, PlanchaId, EsNulo, PadronId)
                VALUES
                (@UsuarioId, @PlanchaId, @EsNulo, @PadronId)";

                connection.Execute(sql, new
                {
                    UsuarioId = usuarioId,
                    PlanchaId = planchaId,
                    EsNulo = esNulo,
                    PadronId = padronId
                });

                string sqlUsuario = @"
                UPDATE Usuarios
                SET HaVotado = 1
                WHERE Id = @UsuarioId";

                connection.Execute(sqlUsuario, new { UsuarioId = usuarioId });
            }
        }

        public bool UsuarioYaVoto(int usuarioId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT HaVotado FROM Usuarios WHERE Id = @UsuarioId";

                return connection.QueryFirstOrDefault<bool>(
                    sql,
                    new { UsuarioId = usuarioId }
                );
            }
        }
    }
}