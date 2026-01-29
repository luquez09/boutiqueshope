using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class VariacionProductoRepository : GenericRepository<ProductoVariacion>
    {
        protected override string TableName => "producto_variacion";
        //protected abstract void MapInsertParameters(NpgsqlCommand cmd, T entity);
        public async Task<Response<ProductoVariacion>> GetByIdProductoAsync(int id)
        {
            try
            {
                var lista = new List<ProductoVariacion>();
                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    string sql = $"SELECT * FROM {TableName} WHERE producto_id=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                                lista.Add(Map(dr));
                            return Response<ProductoVariacion>.SuccessList(lista);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<ProductoVariacion>.Fail("Error al consultar registro - Producto Variacion", ex.Message);
            }
        }

        public async Task<Response<ProductoVariacion>> SaveVariacionesAsync(List<ProductoVariacion> variaciones)
        {
            try
            {
                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var tx = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in variaciones)
                            {
                                string sql = item.Id == 0
                                    ? GetInsertSql()
                                    : GetUpdateParameterSql();

                                using (var cmd = new NpgsqlCommand(sql, conn, tx))
                                {
                                    if (item.Id == 0)
                                        MapInsertParameters(cmd, item);
                                    else
                                        MapUpdateParameters(cmd, item);

                                    await cmd.ExecuteNonQueryAsync();
                                }
                            }

                            // Si todo salió bien, confirmamos
                            tx.Commit();
                            return Response<ProductoVariacion>
                                .Success("Todos los registros fueron procesados correctamente", null);
                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            return Response<ProductoVariacion>
                                .Fail("Error al procesar el listado", ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<ProductoVariacion>
                    .Fail("Error de conexión", ex.Message);
            }
        }

        protected override ProductoVariacion Map(NpgsqlDataReader dr)
        {
            return new ProductoVariacion
            {
                Id = dr.GetInt32(dr.GetOrdinal("id")),
                ProductoId = dr.GetInt32(dr.GetOrdinal("producto_id")),
                Talla = dr.GetString(dr.GetOrdinal("talla")),
                Color = dr.GetString(dr.GetOrdinal("color")),
                Cantidad = dr.GetInt32(dr.GetOrdinal("cantidad")),
                CodigoBarras = dr.GetString(dr.GetOrdinal("codigo_barras")),
                PrecioVenta = dr.GetInt32(dr.GetOrdinal("precio_venta")),
                Costo = dr.GetInt32(dr.GetOrdinal("costo")),
                Activo = dr.GetBoolean(dr.GetOrdinal("activo")),
                FechaCreacion = dr.GetDateTime(dr.GetOrdinal("fecha_creacion"))
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO producto_variacion (producto_id, talla, color, cantidad, codigo_barras, precio_venta, costo, activo, fecha_creacion)
                    VALUES(@productoId, @talla, @color, @cantidad, @codigo_barras, @precio_venta, @costo, @activo, NOW())";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE producto_variacion SET
                                    talla=@talla,
                                    color=@color,
                                    cantidad=@cantidad,
                                    codigo_barras=@codigo_barras,
                                    precio_venta=@precio_venta,
                                    costo=@costo,
                                    activo=@activo
                            WHERE id=@id";
        }

        protected override string GetUpdateParameterSql()
        {
            return @"UPDATE producto_variacion SET  cantidad=@cantidad,
                                                    precio_venta=@precio_venta,
                                                    costo=@costo,
                                                    activo=@activo
                                                    WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, ProductoVariacion entity)
        {
            cmd.Parameters.AddWithValue("@productoId", entity.ProductoId);
            cmd.Parameters.AddWithValue("@talla", entity.Talla);
            cmd.Parameters.AddWithValue("@color", entity.Color);
            cmd.Parameters.AddWithValue("@cantidad", entity.Cantidad);
            cmd.Parameters.AddWithValue("@codigo_barras", entity.CodigoBarras);
            cmd.Parameters.AddWithValue("@codigo_sku", entity.CodigoBarras);
            cmd.Parameters.AddWithValue("@precio_venta", entity.PrecioVenta);
            cmd.Parameters.AddWithValue("@costo", entity.Costo);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, ProductoVariacion entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@productoId", entity.ProductoId);
            cmd.Parameters.AddWithValue("@talla", entity.Talla);
            cmd.Parameters.AddWithValue("@color", entity.Color);
            cmd.Parameters.AddWithValue("@cantidad", entity.Cantidad);
            cmd.Parameters.AddWithValue("@codigo_barras", entity.CodigoBarras); 
            cmd.Parameters.AddWithValue("@precio_venta", entity.PrecioVenta);
            cmd.Parameters.AddWithValue("@costo", entity.Costo);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
        }
    }
}
