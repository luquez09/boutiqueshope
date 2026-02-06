using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Infrastructure.Interfaces;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Implementations.Inventarios
{
    public class InventarioImpl : IInventario
    {
        public async Task<Response<InventarioDomain>> GetInventarioForIds(int idProducto, int idVariacion, int idAlmacen)
        {
            string sql = "SELECT * FROM inventario " +
                         "WHERE producto_id = @producto_id and " +
                         "variacion_id = @variacion_id and " +
                         "almacen_id = @almacen_id";
            try
            {
                var lista = new List<InventarioDomain>();
                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        cmd.Parameters.AddWithValue("producto_id", idProducto);
                        cmd.Parameters.AddWithValue("variacion_id", idVariacion);
                        cmd.Parameters.AddWithValue("almacen_id", idAlmacen);

                        if (await dr.ReadAsync() == true)
                        {
                            var inventario = Map(dr);
                            return Response<InventarioDomain>.Success("Conslta Exitosa", inventario);
                        }
                    }
                    return Response<InventarioDomain>.Fail("Error no se pudo obtener el inventario");
                }
            }
            catch (Exception ex)
            {
                return Response<InventarioDomain>.Fail("Errior al consultar inventario: ", ex.Message);
            }
        }

        private InventarioDomain Map(NpgsqlDataReader reader)
        {
            return new InventarioDomain {
                IdInventario = Convert.ToInt32(reader["id"]),
                productoId = Convert.ToInt32(reader["producto_id"]),
                almacenId = Convert.ToInt32(reader["almacen_id"]),
                variacionId = Convert.ToInt32(reader["variacion_id"]),
                stockActual = reader["stock_actual"] is DBNull ? 0 : Convert.ToInt32(reader["stock_actual"]),
                StockReservado = reader["stock_reservado"] is DBNull ? 0 : Convert.ToInt32(reader["stock_reservado"]),
                StockMinimo = reader["stock_minimo"] is DBNull ? 0 : Convert.ToInt32(reader["stock_minimo"]),
                CostoPromedio = reader["costo_promedio"] is DBNull ? 0 : Convert.ToInt32(reader["costo_promedio"]),
                FechaCreacion = Convert.ToDateTime(reader["ultima_actualizacion"])
            };
        }
    }
}
