using System;
using BoutiqueShope.Domain.Entities;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>
    {
        protected override string TableName => "producto";

        protected override Producto Map(NpgsqlDataReader reader)
        {
            return new Producto
            {
                Id = Convert.ToInt32(reader["id"]),
                Nombre = reader["nombre"] is DBNull ? string.Empty : reader["nombre"].ToString(),
                Descripcion = reader["descripcion"] is DBNull ? string.Empty : reader["descripcion"].ToString(),
                Costo = reader["costo"] is DBNull ? 0m : Convert.ToDecimal(reader["costo"]),
                PorcentajeGanancia = reader["porcentaje_ganancia"] is DBNull ? 0m : Convert.ToDecimal(reader["porcentaje_ganancia"]),
                PrecioVenta = reader["precio_venta"] is DBNull ? 0m : Convert.ToDecimal(reader["precio_venta"]),
                StockMinimo = reader["stock_minimo"] is DBNull ? 0 : Convert.ToInt32(reader["stock_minimo"]),
                ProveedorId = reader["proveedor_id"] is DBNull ? (int?)null : Convert.ToInt32(reader["proveedor_id"]),
                CategoriaId = reader["categoria_id"] is DBNull ? 0 : Convert.ToInt32(reader["categoria_id"]),
                MarcaId = reader["marca_id"] is DBNull ? (int?)null : Convert.ToInt32(reader["marca_id"]),
                CodigoBarras = reader["codigo_barras"] is DBNull ? string.Empty : reader["codigo_barras"].ToString(),
                CodigoQr = reader["codigo_qr"] is DBNull ? string.Empty : reader["codigo_qr"].ToString(),
                Activo = reader["activo"] is DBNull ? true : Convert.ToBoolean(reader["activo"]),
                codigoSku = reader["codigo"] is DBNull ? string.Empty : reader["codigo"].ToString(),
                FechaCreacion = reader["fecha_creacion"] is DBNull ? DateTime.MinValue : Convert.ToDateTime(reader["fecha_creacion"])
            };
        }

        protected override string GetInsertSql()
        {
            return @"INSERT INTO producto
                     (nombre, descripcion, costo, porcentaje_ganancia, precio_venta, stock_minimo, proveedor_id, categoria_id, marca_id, codigo_barras, codigo_qr, activo, fecha_creacion, codigo)
                     VALUES (@nombre, @descripcion, @costo, @porcentaje_ganancia, @precio_venta, @stock_minimo, @proveedor_id, @categoria_id, @marca_id, @codigo_barras, @codigo_qr, @activo, NOW(), @codigo)";
        }

        protected override string GetUpdateSql()
        {
            return @"UPDATE producto SET
                        nombre=@nombre,
                        descripcion=@descripcion,
                        costo=@costo,
                        porcentaje_ganancia=@porcentaje_ganancia,
                        precio_venta=@precio_venta,
                        stock_minimo=@stock_minimo,
                        proveedor_id=@proveedor_id,
                        categoria_id=@categoria_id,
                        marca_id=@marca_id,
                        codigo_barras=@codigo_barras,
                        codigo_qr=@codigo_qr,
                        activo=@activo,
                        codigo=@codigo
                     WHERE id=@id";
        }

        protected override void MapInsertParameters(NpgsqlCommand cmd, Producto entity)
        {
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrEmpty(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
            cmd.Parameters.AddWithValue("@costo", entity.Costo);
            cmd.Parameters.AddWithValue("@porcentaje_ganancia", entity.PorcentajeGanancia);
            cmd.Parameters.AddWithValue("@precio_venta", entity.PrecioVenta);
            cmd.Parameters.AddWithValue("@stock_minimo", entity.StockMinimo);
            cmd.Parameters.AddWithValue("@proveedor_id", entity.ProveedorId.HasValue ? (object)entity.ProveedorId.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@categoria_id", entity.CategoriaId);
            cmd.Parameters.AddWithValue("@marca_id", entity.MarcaId.HasValue ? (object)entity.MarcaId.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@codigo_barras", string.IsNullOrEmpty(entity.CodigoBarras) ? (object)DBNull.Value : entity.CodigoBarras);
            cmd.Parameters.AddWithValue("@codigo_qr", string.IsNullOrEmpty(entity.CodigoQr) ? (object)DBNull.Value : entity.CodigoQr);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
            cmd.Parameters.AddWithValue("@codigo", entity.codigoSku);
        }

        protected override void MapUpdateParameters(NpgsqlCommand cmd, Producto entity)
        {
            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@nombre", entity.Nombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrEmpty(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
            cmd.Parameters.AddWithValue("@costo", entity.Costo);
            cmd.Parameters.AddWithValue("@porcentaje_ganancia", entity.PorcentajeGanancia);
            cmd.Parameters.AddWithValue("@precio_venta", entity.PrecioVenta);
            cmd.Parameters.AddWithValue("@stock_minimo", entity.StockMinimo);
            cmd.Parameters.AddWithValue("@proveedor_id", entity.ProveedorId.HasValue ? (object)entity.ProveedorId.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@categoria_id", entity.CategoriaId);
            cmd.Parameters.AddWithValue("@marca_id", entity.MarcaId.HasValue ? (object)entity.MarcaId.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@codigo_barras", string.IsNullOrEmpty(entity.CodigoBarras) ? (object)DBNull.Value : entity.CodigoBarras);
            cmd.Parameters.AddWithValue("@codigo_qr", string.IsNullOrEmpty(entity.CodigoQr) ? (object)DBNull.Value : entity.CodigoQr);
            cmd.Parameters.AddWithValue("@activo", entity.Activo);
            cmd.Parameters.AddWithValue("@codigo", entity.codigoSku);
        }
    }
}
