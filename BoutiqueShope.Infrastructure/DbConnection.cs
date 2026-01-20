using System.Configuration;
using Npgsql;

namespace BoutiqueShope.Infrastructure
{
    public class DbConnection
    {

        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;

        public static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            return connection;
        }


    }
}
