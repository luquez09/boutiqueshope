using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class ProveedorRepository : GenericRepository<Proveedor>
    {
        protected override string TableName => "proveedor";

        protected override Proveedor Map(NpgsqlDataReader reader)
        {
            return new Proveedor
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"].ToString(),
                Nit = reader["nit"].ToString(),
                Telefono = reader["telefono"].ToString(),
                Email = reader["email"].ToString(),
                Direccion = reader["direccion"].ToString(),
                ContactoNombre = reader["contacto_nombre"].ToString(),
                ContactoTelefono = reader["contacto_telefono"].ToString(),
                Activo = Convert.ToBoolean(reader["activo"]),
                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO proveedor 
                     (nombre, nit, telefono, email, direccion, contacto_nombre, contacto_telefono, activo, fecha_creacion)
                     VALUES (@nombre, @nit, @telefono, @email, @direccion, @contacto_nombre, @contacto_telefono, @activo, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE proveedor SET 
                        nombre=@nombre,
                        nit=@nit,
                        telefono=@telefono,
                        email=@email,
                        direccion=@direccion,
                        contacto_nombre=@contacto_nombre,
                        contacto_telefono=@contacto_telefono,
                        activo=@activo
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Proveedor entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@nit", entity.Nit ?? string.Empty);
            cmd.Parameters.AddWithValue("@telefono", entity.Telefono ?? string.Empty);
            cmd.Parameters.AddWithValue("@email", entity.Email ?? string.Empty);
            cmd.Parameters.AddWithValue("@direccion", entity.Direccion ?? string.Empty);
            cmd.Parameters.AddWithValue("@contacto_nombre", entity.ContactoNombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@contacto_telefono", entity.ContactoTelefono ?? string.Empty);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Proveedor entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@nit", entity.Nit ?? string.Empty);
            cmd.Parameters.AddWithValue("@telefono", entity.Telefono ?? string.Empty);
            cmd.Parameters.AddWithValue("@email", entity.Email ?? string.Empty);
            cmd.Parameters.AddWithValue("@direccion", entity.Direccion ?? string.Empty);
            cmd.Parameters.AddWithValue("@contacto_nombre", entity.ContactoNombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@contacto_telefono", entity.ContactoTelefono ?? string.Empty);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }
    }
}