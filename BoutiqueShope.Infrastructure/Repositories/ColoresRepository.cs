using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class ColoresRepository : GenericRepository<Colores>
    {
        protected override string TableName => "colores";

        protected override Colores Map(NpgsqlDataReader reader)
        {
            return new Colores
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"] is DBNull ? string.Empty : reader["nombre"].ToString()
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO colores (nombre)
                     VALUES (@nombre)";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE colores SET nombre=@nombre
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Colores entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Colores entity)
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
