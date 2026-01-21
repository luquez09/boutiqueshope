using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class MarcaService
    {
        private readonly MarcaRepository _repo;
        public MarcaService()
        {
            _repo = new MarcaRepository();
        }

        public Task<Response<Marca>> ListarAsync() => _repo.GetAllAsync();
        public Task<Response<Marca>> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);
        public async Task<Response<Marca>> CrearAsync(Marca m)
        {
            if (string.IsNullOrWhiteSpace(m.Nombre))
                return Response<Marca>.Fail("El nombre de la marca es obligatorio");

            return await _repo.InsertAsync(m);
        }

        public async Task<Response<Marca>> EditarAsync(Marca m)
        {
            if (m.Id <= 0)
                return Response<Marca>.Fail("El ID no es válido");

            if (string.IsNullOrWhiteSpace(m.Nombre))
                return Response<Marca>.Fail("El nombre es obligatorio");

            return await _repo.UpdateAsync(m);
        }

        public async Task<Response<Marca>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Marca>.Fail("Error al identificar la marca, seleccione uno de la lista.");

            return await  _repo.DeleteAsync(id);
        }
    }
}
