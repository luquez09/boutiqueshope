using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class ClienteService
    {
        private readonly ClienteRepository _repo;
        public ClienteService()
        {
            _repo = new ClienteRepository();
        }

        public Task<Response<Cliente>> ListarAsync() => _repo.GetAllAsync();
        public Task<Response<Cliente>> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Response<Cliente>> CrearAsync(Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                return Response<Cliente>.Fail("El nombre del cliente es obligatorio");

            if (string.IsNullOrWhiteSpace(c.Cedula))
                return Response<Cliente>.Fail("La Cedula del cliente es obligatorio");

            return await _repo.InsertAsync(c);
        }

        public async Task<Response<Cliente>> EditarAsync(Cliente c)
        {
            if (c.Id <= 0)
                return Response<Cliente>.Fail("El ID no es válido");

            if (string.IsNullOrWhiteSpace(c.Nombre))
                return Response<Cliente>.Fail("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(c.Cedula))
                return Response<Cliente>.Fail("La Cedula del cliente es obligatorio");

            return await _repo.UpdateAsync(c);
        }

        public async Task<Response<Cliente>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Cliente>.Fail("Error al identificar el cliente, seleccione uno del listado.");

            return await _repo.DeleteAsync(id);
        }
    }
}
