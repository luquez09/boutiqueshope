using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class TallaRepository : GenericRepository<Tallas>
    {
        protected override string TableName => "tallas";

        protected override Tallas Map(NpgsqlDataReader reader)
        {
            return new Tallas
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"] is DBNull ? string.Empty : reader["nombre"].ToString()
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO tallas (nombre)
                     VALUES (@nombre)";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE tallas SET nombre=@nombre
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Tallas entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Tallas entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
        }

        protected override string GetUpdateParameterSql()
        {
            return "id=@id, nombre=@nombre";
        }
    }
}
