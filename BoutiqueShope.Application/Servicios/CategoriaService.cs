using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class CategoriaService
    {
        private readonly CategoriaRepository _repo;
        public CategoriaService()
        {
            _repo = new CategoriaRepository();
        }

        public Task<Response<Categoria>> ListarAsync() => _repo.GetAllAsync();
        public Task<Response<Categoria>> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Response<Categoria>> CrearAsync(Categoria c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                return Response<Categoria>.Fail("El nombre de la categoría es obligatorio");

            return await _repo.InsertAsync(c);
        }

        public async Task<Response<Categoria>> EditarAsync(Categoria c)
        {
            if (c.Id <= 0)
                return Response<Categoria>.Fail("El ID no es válido");

            if (string.IsNullOrWhiteSpace(c.Nombre))
                return Response<Categoria>.Fail("El nombre es obligatorio");

            return await _repo.UpdateAsync(c);
        }

        public async Task<Response<Categoria>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Categoria>.Fail("Error al identificar la categoría, seleccione uno de la lista.");

            return await _repo.DeleteAsync(id);
        }
    }
}
