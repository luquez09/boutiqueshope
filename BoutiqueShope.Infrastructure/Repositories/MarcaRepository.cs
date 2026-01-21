using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class MarcaRepository : GenericRepository<Marca>
    {
        protected override string TableName => "marca";

        protected override Marca Map(NpgsqlDataReader reader)
        {
            return new Marca
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
            return @"INSERT INTO marca (nombre, activo, descripcion, fecha_creacion)
                     VALUES (@nombre, @activo, @descripcion, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE marca SET nombre=@nombre, activo=@activo, descripcion=@descripcion
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Marca entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", entity.Descripcion);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Marca entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", entity.Descripcion);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }
    }
}
