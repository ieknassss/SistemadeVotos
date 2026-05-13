using Dapper;
using SistemadeVotaciones.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SistemadeVotaciones.Data
{
    public class CandidatoRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public CandidatoRepository()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        public List<Candidato> ObtenerCandidatos()
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT * FROM Candidatos ORDER BY Id DESC";
                return connection.Query<Candidato>(sql).ToList();
            }
        }

        public void GuardarCandidato(Candidato candidato)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
                INSERT INTO Candidatos
                (Nombre, Puesto, Curso, Foto, PlanchaId)
                VALUES
                (@Nombre, @Puesto, @Curso, @Foto, @PlanchaId)";

                connection.Execute(sql, candidato);
            }
        }

        public void ActualizarCandidato(Candidato candidato)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
        UPDATE Candidatos
        SET
            Nombre = @Nombre,
            Puesto = @Puesto,
            Curso = @Curso,
            Foto = @Foto,
            PlanchaId = @PlanchaId
        WHERE Id = @Id";

                connection.Execute(sql, candidato);
            }
        }

        public List<Candidato> ObtenerCandidatosPorPlancha(int planchaId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = @"
        SELECT *
        FROM Candidatos
        WHERE PlanchaId = @PlanchaId
        ORDER BY Id ASC";

                return connection.Query<Candidato>(
                    sql,
                    new { PlanchaId = planchaId }
                ).ToList();
            }
        }

        public void EliminarCandidato(int id)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM Candidatos WHERE Id = @Id";

                connection.Execute(sql, new { Id = id });
            }
        }
    }
}