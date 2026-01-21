using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class CategoriaRepository : GenericRepository<Categoria>
    {
        protected override string TableName => "categoria";

        protected override Categoria Map(NpgsqlDataReader reader)
        {
            return new Categoria
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"].ToString(),
                Descripcion = reader["descripcion"].ToString(),
                Activo = Convert.ToBoolean(reader["activo"]),
                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO categoria (nombre, activo, descripcion, fecha_creacion)
                     VALUES (@nombre, @activo, @descripcion, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE categoria SET nombre=@nombre, activo=@activo, descripcion=@descripcion
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Categoria entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", entity.Descripcion);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Categoria entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", entity.Descripcion);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }
    }
}
