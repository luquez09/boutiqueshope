using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Domain.Inventarios;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>
    {
        protected override string TableName => "producto";

        public async Task<Response<Producto>> BuscarProducto(String nombreProducto)
        {
            try
            {
                var lista = new List<Producto>();
                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    string sql = "SELECT * FROM producto p WHERE p.nombre ILIKE @nombreProducto";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreProducto", $"%{nombreProducto}%");

                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                                lista.Add(Map(dr));

                            return Response<Producto>.SuccessList(lista);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<Producto>.Fail("Error al consultar registro - Producto busqueda", ex.Message);
            }
        }


        protected override Producto Map(NpgsqlDataReader reader)
        {
            return new Producto
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"] is DBNull ? string.Empty : reader["nombre"].ToString(),
                Descripcion = reader["descripcion"] is DBNull ? string.Empty : reader["descripcion"].ToString(),
                ProveedorId = Convert.ToInt32(reader["proveedor_id"]),
                CategoriaId = reader["categoria_id"] is DBNull ? 0 : Convert.ToInt32(reader["categoria_id"]),
                MarcaId = Convert.ToInt32(reader["marca_id"]),
                CodigoSku = reader["codigo_sku"] is DBNull ? string.Empty : reader["codigo_sku"].ToString(),
                Tipo = reader["tipo"] is DBNull ? string.Empty : reader["tipo"].ToString(),
                Activo = reader["activo"] is DBNull ? true : Convert.ToBoolean(reader["activo"]),
                FechaCreacion = reader["fecha_creacion"] is DBNull ? DateTime.MinValue : Convert.ToDateTime(reader["fecha_creacion"])
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO producto (nombre, descripcion, proveedor_id, categoria_id, marca_id, codigo_sku, tipo, activo, fecha_creacion)
                     VALUES (@nombre, @descripcion, @proveedor_id, @categoria_id, @marca_id, @codigo_sku, @tipo, @activo, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE producto SET
                        nombre=@nombre,
                        descripcion=@descripcion,
                        proveedor_id=@proveedor_id,
                        categoria_id=@categoria_id,
                        marca_id=@marca_id,
                        codigo_sku=@codigo_sku,
                        activo=@activo,
                        tipo=@tipo
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Producto entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrEmpty(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
            cmd.Parameters.AddWithValue("@proveedor_id",  entity.ProveedorId);
            cmd.Parameters.AddWithValue("@categoria_id", entity.CategoriaId);
            cmd.Parameters.AddWithValue("@marca_id",entity.MarcaId);
            cmd.Parameters.AddWithValue("@codigo_sku", string.IsNullOrEmpty(entity.CodigoSku) ? (object)DBNull.Value : entity.CodigoSku);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
            cmd.Parameters.AddWithValue("@tipo", entity.Tipo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Producto entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrEmpty(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
            cmd.Parameters.AddWithValue("@proveedor_id", entity.ProveedorId);
            cmd.Parameters.AddWithValue("@categoria_id", entity.CategoriaId);
            cmd.Parameters.AddWithValue("@marca_id", entity.MarcaId);
            cmd.Parameters.AddWithValue("@codigo_sku", string.IsNullOrEmpty(entity.CodigoSku) ? (object)DBNull.Value : entity.CodigoSku);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
            cmd.Parameters.AddWithValue("@tipo", entity.Tipo);
        }

        protected override string GetUpdateParameterSql()
        {
            throw new NotImplementedException();
        }
    }
}
