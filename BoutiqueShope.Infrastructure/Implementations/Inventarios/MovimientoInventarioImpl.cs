using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Domain.Inventarios;
using BoutiqueShope.Infrastructure.Interfaces;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Implementations
{

    public class MovimientoInventarioImpl : IMovimientoInventario
    {
        public async Task<Response<MovimientoInventario>> GetAllMovimientoForIds(FiltorInventario filtorInventario)
        {
            try
            {
                var lista = new List<MovimientoInventario>();

                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();
                    string sqlConsult = "SELECT * FROM get_movimientos_inventario(@producto_id, @variacion_id, @almacen_id, @tipo_movimiento, @documento_origen, @fecha_inicio, @fecha_fin)";
                    using (var cmd = new NpgsqlCommand(sqlConsult, conn))
                    {
                        cmd.Parameters.AddWithValue("@producto_id", (object)filtorInventario.productoId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@variacion_id", (object)filtorInventario.variacionId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@almacen_id", (object)filtorInventario.almacenId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@tipo_movimiento", (object)filtorInventario.tipoMovimiento ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@documento_origen", (object)filtorInventario.documentoOrigen ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@fecha_inicio", (object)filtorInventario.fechaInicio ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@fecha_fin", (object)filtorInventario.fechaFin ?? DBNull.Value);

                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                lista.Add(MapEntity(dr));
                            }
                            return Response<MovimientoInventario>.SuccessList(lista);
                        }
                    }
                }
            }
            catch (NpgsqlException nex)
            {
                return Response<MovimientoInventario>.Fail("Error consulta: " + nex.Message);
            }
            catch (Exception ex)
            {
                return Response<MovimientoInventario>.Fail("Error al obtener listado: " + ex.Message);
            }
        }

        private MovimientoInventario MapEntity(NpgsqlDataReader dr)
        {
            return new MovimientoInventario
            {
                Id = dr.GetInt32(dr.GetOrdinal("id")),
                Fecha = dr.GetDateTime(dr.GetOrdinal("fecha")),
                Producto = dr.GetString(dr.GetOrdinal("producto")),
                Variacion = dr.GetString(dr.GetOrdinal("variacion")),
                Almacen = dr.GetString(dr.GetOrdinal("almacen")),
                TipoMovimiento = dr.GetString(dr.GetOrdinal("tipo_movimiento")),
                Documento = dr.GetString(dr.GetOrdinal("documento")),
                Cantidad = dr.GetInt32(dr.GetOrdinal("cantidad")),
                CostoUnitario = dr.GetDecimal(dr.GetOrdinal("costo_unitario")),
                CostoTotal = dr.GetDecimal(dr.GetOrdinal("costo_total")),
                Usuario = dr.GetString(dr.GetOrdinal("usuario"))
            };
        }

        protected void MapConsultParameters(NpgsqlCommand cmd, FiltorInventario filter)
        {
            cmd.Parameters.AddWithValue("producto_id", (object)filter.productoId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("variacion_id", (object)filter.variacionId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("almacen_id", (object)filter.almacenId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("tipo_movimiento", (object)filter.tipoMovimiento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("documento_origen", (object)filter.documentoOrigen ?? DBNull.Value);
        }
    }
}
