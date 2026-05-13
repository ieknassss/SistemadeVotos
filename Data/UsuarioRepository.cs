using Dapper;
using SistemadeVotaciones.Entities;
using System.Collections.Generic;
using System.Linq;

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

                return connection.QueryFirstOrDefault<Usuario>(sql, new
                {
                    UsuarioLogin = usuarioLogin,
                    Clave = clave
                });
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT * FROM Usuarios ORDER BY Id DESC";
                return connection.Query<Usuario>(sql).ToList();
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                INSERT INTO Usuarios
                (Nombre, Apellido, Curso, Seccion, Matricula, UsuarioLogin, Clave, Rol, PadronId, PlanchaId, HaVotado)
                VALUES
                (@Nombre, @Apellido, @Curso, @Seccion, @Matricula, @UsuarioLogin, @Clave, @Rol, @PadronId, @PlanchaId, @HaVotado)";

                connection.Execute(sql, usuario);
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                UPDATE Usuarios SET
                    Nombre = @Nombre,
                    Apellido = @Apellido,
                    Curso = @Curso,
                    Seccion = @Seccion,
                    Matricula = @Matricula,
                    UsuarioLogin = @UsuarioLogin,
                    Clave = @Clave,
                    Rol = @Rol
                WHERE Id = @Id";

                connection.Execute(sql, usuario);
            }
        }

        public void EliminarUsuario(int id)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM Usuarios WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}