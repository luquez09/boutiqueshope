using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>
    {
        protected override string TableName => "cliente";

        protected override Cliente Map(NpgsqlDataReader reader)
        {
            return new Cliente
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"].ToString(),
                Cedula = reader["cedula"] is DBNull ? string.Empty : reader["cedula"].ToString(),
                Telefono = reader["telefono"] is DBNull ? string.Empty : reader["telefono"].ToString(),
                Email = reader["email"] is DBNull ? string.Empty : reader["email"].ToString(),
                Direccion = reader["direccion"] is DBNull ? string.Empty : reader["direccion"].ToString(),
                FechaNacimiento = reader["fecha_nacimiento"] is DBNull ? (DateTime?)null : Convert.ToDateTime(reader["fecha_nacimiento"]),
                Genero = reader["genero"] is DBNull ? string.Empty : reader["genero"].ToString(),
                Activo = Convert.ToBoolean(reader["activo"]),
                TotalCompras = reader["total_compras"] is DBNull ? 0m : Convert.ToDecimal(reader["total_compras"]),
                UltimaCompra = reader["ultima_compra"] is DBNull ? (DateTime?)null : Convert.ToDateTime(reader["ultima_compra"]),
                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO cliente
                     (nombre, cedula, telefono, email, direccion, fecha_nacimiento, genero, activo, total_compras, ultima_compra, fecha_creacion)
                     VALUES (@nombre, @cedula, @telefono, @email, @direccion, @fecha_nacimiento, @genero, @activo, @total_compras, @ultima_compra, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE cliente SET
                        nombre=@nombre,
                        cedula=@cedula,
                        telefono=@telefono,
                        email=@email,
                        direccion=@direccion,
                        fecha_nacimiento=@fecha_nacimiento,
                        genero=@genero,
                        activo=@activo,
                        total_compras=@total_compras,
                        ultima_compra=@ultima_compra
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Cliente entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@cedula", string.IsNullOrEmpty(entity.Cedula) ? (object)DBNull.Value : entity.Cedula);
            cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(entity.Telefono) ? (object)DBNull.Value : entity.Telefono);
            cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(entity.Email) ? (object)DBNull.Value : entity.Email);
            cmd.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(entity.Direccion) ? (object)DBNull.Value : entity.Direccion);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento.HasValue ? (object)entity.FechaNacimiento.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@genero", string.IsNullOrEmpty(entity.Genero) ? (object)DBNull.Value : entity.Genero);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
            cmd.Parameters.AddWithValue("@total_compras", entity.TotalCompras);
            cmd.Parameters.AddWithValue("@ultima_compra", entity.UltimaCompra.HasValue ? (object)entity.UltimaCompra.Value : DBNull.Value);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Cliente entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@cedula", string.IsNullOrEmpty(entity.Cedula) ? (object)DBNull.Value : entity.Cedula);
            cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(entity.Telefono) ? (object)DBNull.Value : entity.Telefono);
            cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(entity.Email) ? (object)DBNull.Value : entity.Email);
            cmd.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(entity.Direccion) ? (object)DBNull.Value : entity.Direccion);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento.HasValue ? (object)entity.FechaNacimiento.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@genero", string.IsNullOrEmpty(entity.Genero) ? (object)DBNull.Value : entity.Genero);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
            cmd.Parameters.AddWithValue("@total_compras", entity.TotalCompras);
            cmd.Parameters.AddWithValue("@ultima_compra", entity.UltimaCompra.HasValue ? (object)entity.UltimaCompra.Value : DBNull.Value);
        }
    }
}