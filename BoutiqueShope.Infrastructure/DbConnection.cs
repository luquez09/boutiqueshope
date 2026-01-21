
using System;
using System.Configuration;
using Npgsql;

namespace BoutiqueShope.Infrastructure
{
    public static class DbConnection
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["PostgresConnection"]?.ConnectionString;

        public static NpgsqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("No se encontró la cadena de conexión 'PostgresConnection' en App.config.");

            return new NpgsqlConnection(_connectionString);
        }
    }
}
