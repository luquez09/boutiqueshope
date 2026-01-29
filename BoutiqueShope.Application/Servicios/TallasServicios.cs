using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class TallasServicios
    {

        private readonly TallaRepository _repo;

        public TallasServicios()
        {
            _repo = new TallaRepository();
        }

        public async Task<Response<Tallas>> listarAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Response<Tallas>> CrearAsync(Tallas tallas)
        {
            if (string.IsNullOrEmpty(tallas.Nombre))
                return Response<Tallas>.Fail("El nombre de la talla es obligatorio.");

            return await _repo.InsertAsync(tallas);
        }

        public async Task<Response<Tallas>> EditarAsync(Tallas tallas)
        {
            string errorsCheck = "";

            if (tallas.Id <= 0)
                errorsCheck += "El ID de la talla no es válido. \n";

            if (string.IsNullOrEmpty(tallas.Nombre))
                errorsCheck += "El nombre de la talla es obligatorio. \n";

            if (!string.IsNullOrEmpty(errorsCheck))
                return Response<Tallas>.Fail(errorsCheck.Trim());

            return await _repo.UpdateAsync(tallas);
        } 

        public async Task<Response<Tallas>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Tallas>.Fail("El ID proporcionado no es válido");
            return await _repo.DeleteAsync(id);
        }

    }
}
