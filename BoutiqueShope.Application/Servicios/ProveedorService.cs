using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class ProveedorService
    {
        private readonly ProveedorRepository _repo;
        public ProveedorService()
        {
            _repo = new ProveedorRepository();
        }

        public Task<Response<Proveedor>> ListarAsync() => _repo.GetAllAsync();
        public Task<Response<Proveedor>> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Response<Proveedor>> CrearAsync(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                return Response<Proveedor>.Fail("El nombre del proveedor es obligatorio");

            return await _repo.InsertAsync(p);
        }

        public async Task<Response<Proveedor>> EditarAsync(Proveedor p)
        {
            if (p.Id <= 0)
                return Response<Proveedor>.Fail("El ID no es válido");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                return Response<Proveedor>.Fail("El nombre es obligatorio");

            return await _repo.UpdateAsync(p);
        }

        public async Task<Response<Proveedor>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Proveedor>.Fail("Error al identificar el proveedor, seleccione uno de la lista.");

            return await _repo.DeleteAsync(id);
        }
    }
}
