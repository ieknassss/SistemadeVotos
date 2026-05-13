using Microsoft.Data.SqlClient;
using System.Data;


namespace SistemadeVotaciones.Data
{
    public class DbConnectionFactory
    {
        private readonly string connectionString =
            "Server=IEKNA\\SQLEXPRESS;Database=SistemaVotacionesDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}