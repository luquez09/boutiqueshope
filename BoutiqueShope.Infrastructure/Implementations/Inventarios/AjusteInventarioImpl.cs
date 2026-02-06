
using System;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Infrastructure.Interfaces;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Implementations
{
    public class AjusteInventarioImpl : IAjusteInventario
    {
        public async Task<Response<AjusteInventario>> RegistrarAjusteInventario(AjusteInventario ajusteInventario)
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
                                string querySql = "CALL registrar_ajuste(" +
                            "@producto_id," +
                            "@variacion_id," +
                            "@almacen_id," +
                            "@documento_tipo," +
                            "@tipo_movimiento," +
                            "@cantidad," +
                            "@costo_unitario," +
                            "@motivo," +
                            "@usuario_id)";

                            using (var cmd = new NpgsqlCommand(querySql, conn))
                            {
                                cmd.Parameters.AddWithValue("producto_id", ajusteInventario.ProductoId);
                                cmd.Parameters.AddWithValue("variacion_id", ajusteInventario.VariacionId);
                                cmd.Parameters.AddWithValue("almacen_id", ajusteInventario.AlmacenId);
                                cmd.Parameters.AddWithValue("documento_tipo", ajusteInventario.DocumentoTipo);
                                cmd.Parameters.AddWithValue("tipo_movimiento", ajusteInventario.TipoMovimiento);
                                cmd.Parameters.AddWithValue("cantidad", ajusteInventario.Cantidad);
                                cmd.Parameters.AddWithValue("costo_unitario", ajusteInventario.CostoUnitario);
                                cmd.Parameters.AddWithValue("motivo", ajusteInventario.Motivo);
                                cmd.Parameters.AddWithValue("usuario_id", ajusteInventario.idUsuario);
                                await cmd.ExecuteNonQueryAsync();
                            }

                            tx.Commit();
                            return Response<AjusteInventario>.Success("Registro creado correctamente");
                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            return Response<AjusteInventario>.Fail("Error al insertar registro", ex.Message);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                return Response<AjusteInventario>.Fail("Error en base de datos", ex.Message);
            }
            catch (Exception ex)
            {
                return Response<AjusteInventario>.Fail("Error general", ex.Message);
            }
        }
    }
}
