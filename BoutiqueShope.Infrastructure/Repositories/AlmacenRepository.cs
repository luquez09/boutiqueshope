using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class AlmacenRepository : GenericRepository<Almacen>
    {
        protected override string TableName => "almacen";

        protected override Almacen Map(NpgsqlDataReader reader)
        {
            return new Almacen
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"] is DBNull ? string.Empty : reader["nombre"].ToString(),
                Tipo = reader["tipo"] is DBNull ? string.Empty : reader["tipo"].ToString(),
                Direccion = reader["direccion"] is DBNull ? string.Empty : reader["direccion"].ToString(),
                Telefono = reader["telefono"] is DBNull ? string.Empty : reader["telefono"].ToString(),
                ResponsableId = reader["responsable_id"] is DBNull ? (int?)null : Convert.ToInt32(reader["responsable_id"]),
                Activo = Convert.ToBoolean(reader["activo"]),
                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO almacen (nombre, tipo, direccion, telefono, responsable_id, activo, fecha_creacion)
                     VALUES (@nombre, @tipo, @direccion, @telefono, @responsable_id, @activo, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE almacen SET nombre=@nombre, tipo=@tipo, direccion=@direccion, telefono=@telefono,
                     responsable_id=@responsable_id, activo=@activo
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Almacen entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@tipo", entity.Tipo ?? string.Empty);
            cmd.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(entity.Direccion) ? (object)DBNull.Value : entity.Direccion);
            cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(entity.Telefono) ? (object)DBNull.Value : entity.Telefono);
            cmd.Parameters.AddWithValue("@responsable_id", entity.ResponsableId.HasValue ? (object)entity.ResponsableId.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Almacen entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@tipo", entity.Tipo ?? string.Empty);
            cmd.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(entity.Direccion) ? (object)DBNull.Value : entity.Direccion);
            cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(entity.Telefono) ? (object)DBNull.Value : entity.Telefono);
            cmd.Parameters.AddWithValue("@responsable_id", entity.ResponsableId.HasValue ? (object)entity.ResponsableId.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }
    }
}