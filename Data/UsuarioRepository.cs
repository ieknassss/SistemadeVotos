using Dapper;
using SistemadeVotaciones.Entities;

namespace SistemadeVotaciones.Data
{
    public class UsuarioRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public UsuarioRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public Usuario Login(string usuarioLogin, string clave)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                    SELECT *
                    FROM Usuarios
                    WHERE UsuarioLogin = @UsuarioLogin
                    AND Clave = @Clave";

                return connection.QueryFirstOrDefault<Usuario>(
                    sql,
                    new
                    {
                        UsuarioLogin = usuarioLogin,
                        Clave = clave
                    }
                );
            }
        }
    }
}