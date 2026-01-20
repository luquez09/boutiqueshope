using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Interfaces;
using Npgsql;

namespace BoutiqueShope.Infrastructure
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        protected abstract string TableName { get; }
        protected abstract T Map(NpgsqlDataReader reader);
        protected abstract void MapInsertParameters(NpgsqlCommand cmd, T entity);
        protected abstract void MapUpdateParameters(NpgsqlCommand cmd, T entity);

        public async Task<Response<T>> GetAllAsync()
        {
            try
            {
                var lista = new List<T>();

                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    string sql = $"SELECT * FROM {TableName}";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                            lista.Add(Map(dr));
                    }
                }

                return Response<T>.SuccessList(lista);
            }
            catch (Exception ex)
            {
                return Response<T>.Fail("Error al obtener listado", ex.Message);
            }
        }

        public async Task<Response<T>> GetByIdAsync(int id)
        {
            try
            {
                using (var conn = DbConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    string sql = $"SELECT * FROM {TableName} WHERE id=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            if (await dr.ReadAsync())
                            {
                                var entity = Map(dr);
                                return Response<T>.Success("Consulta exitosa", entity);
                            }
                        }
                    }
                }

                return Response<T>.Fail("No se encontró el registro solicitado");
            }
            catch (Exception ex)
            {
                return Response<T>.Fail("Error al consultar registro", ex.Message);
            }
        }

        public async Task<Response<T>> InsertAsync(T entity)
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
                            string sql = GetInsertSql();

                            using (var cmd = new NpgsqlCommand(sql, conn, tx))
                            {
                                MapInsertParameters(cmd, entity);
                                await cmd.ExecuteNonQueryAsync();
                            }

                            tx.Commit();
                            return Response<T>.Success("Registro creado correctamente", entity);
                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            return Response<T>.Fail("Error al insertar registro", ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<T>.Fail("Error de conexión", ex.Message);
            }
        }

        public async Task<Response<T>> UpdateAsync(T entity)
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
                            string sql = GetUpdateSql();

                            using (var cmd = new NpgsqlCommand(sql, conn, tx))
                            {
                                MapUpdateParameters(cmd, entity);
                                await cmd.ExecuteNonQueryAsync();
                            }

                            tx.Commit();
                            return Response<T>.Success("Registro actualizado correctamente", entity);
                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            return Response<T>.Fail("Error al actualizar registro", ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<T>.Fail("Error de conexión", ex.Message);
            }
        }

        public async Task<Response<T>> DeleteAsync(int id)
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
                            string sql = $"DELETE FROM {TableName} WHERE id=@id";

                            using (var cmd = new NpgsqlCommand(sql, conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                await cmd.ExecuteNonQueryAsync();
                            }

                            tx.Commit();
                            return Response<T>.Success("Registro eliminado correctamente");
                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            return Response<T>.Fail("Error al eliminar registro", ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<T>.Fail("Error de conexión", ex.Message);
            }
        }

        protected abstract string GetInsertSql();
        protected abstract string GetUpdateSql();
    }
}
