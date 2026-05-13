using Dapper;
using SistemadeVotaciones.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SistemadeVotaciones.Data
{
    public class PlanchaRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public PlanchaRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public List<Plancha> ObtenerPlanchas()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT * FROM Planchas ORDER BY Id DESC";
                return connection.Query<Plancha>(sql).ToList();
            }
        }

        public void GuardarPlancha(Plancha plancha)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                INSERT INTO Planchas
                (Nombre, Siglas, Logo, PadronId)
                VALUES
                (@Nombre, @Siglas, @Logo, @PadronId)";

                connection.Execute(sql, plancha);
            }
        }

        public void ActualizarPlancha(Plancha plancha)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                UPDATE Planchas SET
                    Nombre = @Nombre,
                    Siglas = @Siglas,
                    Logo = @Logo,
                    PadronId = @PadronId
                WHERE Id = @Id";

                connection.Execute(sql, plancha);
            }
        }

        public void EliminarPlancha(int id)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM Planchas WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}