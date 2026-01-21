using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>
    {
        protected override string TableName => "usuarios";

        protected override Usuario Map(NpgsqlDataReader dr)
        {
            return new Usuario
            {
                Id = dr.GetInt32(dr.GetOrdinal("id")),
                Nombre = dr.GetString(dr.GetOrdinal("nombre")),
                Email = dr.IsDBNull(dr.GetOrdinal("email")) ? null : dr.GetString(dr.GetOrdinal("email")),
                Telefono = dr.IsDBNull(dr.GetOrdinal("telefono")) ? null : dr.GetString(dr.GetOrdinal("telefono")),
                Username = dr.GetString(dr.GetOrdinal("username")),
                PasswordHash = dr.GetString(dr.GetOrdinal("password_hash")),
                Activo = dr.GetBoolean(dr.GetOrdinal("activo")),
                FechaCreacion = dr.GetDateTime(dr.GetOrdinal("fecha_creacion"))
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO usuarios(nombre, email, telefono, username, password_hash, activo)
                     VALUES(@nombre, @email, @telefono, @username, @password, @activo)";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE usuarios SET nombre=@nombre, email=@email, telefono=@telefono,
                     username=@username, activo=@activo, password_hash=@password WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Usuario u)
        {
            cmd.Parameters.AddWithValue("@nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@email", (object)u.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@telefono", (object)u.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@username", u.Username);
            cmd.Parameters.AddWithValue("@password", u.PasswordHash);
            cmd.Parameters.AddWithValue("@activo", u.Activo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Usuario u)
        {
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@email", (object)u.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@telefono", (object)u.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@username", u.Username);
            cmd.Parameters.AddWithValue("@password", u.PasswordHash);
            cmd.Parameters.AddWithValue("@activo", u.Activo);
        }
    }
}
