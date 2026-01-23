using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class AlmacenService
    {
        private readonly AlmacenRepository _repo;
        public AlmacenService()
        {
            _repo = new AlmacenRepository();
        }

        public Task<Response<Almacen>> ListarAsync() => _repo.GetAllAsync();
        public Task<Response<Almacen>> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Response<Almacen>> CrearAsync(Almacen a)
        {
            if (string.IsNullOrWhiteSpace(a.Nombre))
                return Response<Almacen>.Fail("El nombre del almacén es obligatorio");

            var tipo = (a.Tipo ?? string.Empty).ToLowerInvariant();
            if (tipo != "bodega" && tipo != "tienda" && tipo != "virtual")
                return Response<Almacen>.Fail("El tipo de almacén no es válido (bodega, tienda, virtual)");

            return await _repo.InsertAsync(a);
        }

        public async Task<Response<Almacen>> EditarAsync(Almacen a)
        {
            if (a.Id <= 0)
                return Response<Almacen>.Fail("El ID no es válido");

            if (string.IsNullOrWhiteSpace(a.Nombre))
                return Response<Almacen>.Fail("El nombre es obligatorio");

            var tipo = (a.Tipo ?? string.Empty).ToLowerInvariant();
            if (tipo != "bodega" && tipo != "tienda" && tipo != "virtual")
                return Response<Almacen>.Fail("El tipo de almacén no es válido (bodega, tienda, virtual)");

            return await _repo.UpdateAsync(a);
        }

        public async Task<Response<Almacen>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Almacen>.Fail("Error al identificar el almacén, seleccione uno de la lista.");

            return await _repo.DeleteAsync(id);
        }
    }
}