
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
                    using (var tx = conn.BeginTransaction()) // Transacción asíncrona
                    {
                        try
                        {
                            string querySql = @"CALL registrar_ajuste(@producto_id, @variacion_id, @almacen_id, @documento_tipo, @tipo_movimiento, @cantidad, @costo_unitario, @motivo, @usuario_id)";

                            using (var cmd = new NpgsqlCommand(querySql, conn))
                            {
                                cmd.Parameters.AddWithValue("producto_id", (object)ajusteInventario.ProductoId ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("variacion_id", (object)ajusteInventario.VariacionId ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("almacen_id", (object)ajusteInventario.AlmacenId ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("documento_tipo", (object)ajusteInventario.DocumentoTipo ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("tipo_movimiento", (object)ajusteInventario.TipoMovimiento ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("cantidad", (object)ajusteInventario.Cantidad ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("costo_unitario", (object)ajusteInventario.CostoUnitario ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("motivo", (object)ajusteInventario.Motivo ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("usuario_id", (object)ajusteInventario.idUsuario ?? DBNull.Value);

                                await cmd.ExecuteNonQueryAsync();
                            }

                            await tx.CommitAsync();
                            return Response<AjusteInventario>.Success("Registro creado correctamente");
                        }
                        catch ( NpgsqlException sqlex)
                        {
                            return Response<AjusteInventario>.Fail("Error en la base de datos \n\n " + sqlex.Message
                                + "\n" +  sqlex.ErrorCode
                                + "\n" + sqlex.InnerException, sqlex.ErrorCode.ToString());
                        }
                        catch (Exception ex)
                        {
                            await tx.RollbackAsync();
                            // Captura el error específico de la lógica del procedimiento (ej. stock insuficiente)
                            return Response<AjusteInventario>.Fail("Error en la transacción: \n" + ex.Message, ex.InnerException.ToString());
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                return Response<AjusteInventario>.Fail("Error de conexión o base de datos: \n" + ex.Message, ex.Message);
            }
            catch (Exception ex)
            {
                return Response<AjusteInventario>.Fail("Error inesperado: \n" + ex.Message, ex.Message);
            }
        }
    }
}
