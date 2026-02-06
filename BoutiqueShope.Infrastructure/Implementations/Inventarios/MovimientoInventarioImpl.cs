

using System;
using System.Threading.Tasks;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Infrastructure.Interfaces;
using Npgsql;

namespace BoutiqueShope.Infrastructure.Implementations
{

    public class MovimientoInventarioImpl : IMovimientoInventario
    {
        public async Task RegistrarEntradaAsync(MovimientoInventario movimientoInventario)
        {
            try
            {
                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();
                    string sqlProcedure = "CALL registrar_entrada(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";

                    using (var cmd = new NpgsqlCommand(sqlProcedure, conn))
                    {
                        cmd.Parameters.AddWithValue("p1", movimientoInventario.ProductoId);
                        cmd.Parameters.AddWithValue("p2", (object)movimientoInventario.VariacionId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("p3", movimientoInventario.AlmacenId);
                        cmd.Parameters.AddWithValue("p4", movimientoInventario.DocumentoTipo);
                        cmd.Parameters.AddWithValue("p5", (object)movimientoInventario.DocumentoId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("p6", movimientoInventario.Referencia);
                        cmd.Parameters.AddWithValue("p7", movimientoInventario.Cantidad);
                        cmd.Parameters.AddWithValue("p8", movimientoInventario.CostoUnitario);
                        cmd.Parameters.AddWithValue("p9", movimientoInventario.UsuarioId);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar la entrada de inventario: {ex.Message}");
            }
        }
    }
}
