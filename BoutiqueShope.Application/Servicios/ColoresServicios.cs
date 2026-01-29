using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class ColoresServicios
    {
        private readonly ColoresRepository _coloresRepository;

        public ColoresServicios()
        {
            _coloresRepository = new ColoresRepository();
        }

        public async Task<Response<Colores>> listarAsync()
        {
            return await _coloresRepository.GetAllAsync();
        }

        public async Task<Response<Colores>> CrearAsync(Colores colores)
        {
            if (string.IsNullOrEmpty(colores.Nombre))
                return Response<Colores>.Fail("El nombre del color es obligatorio.");

            return await _coloresRepository.InsertAsync(colores);
        }

        public async Task<Response<Colores>> EditarAsync(Colores colores)
        {
            string errorsCheck = "";

            if (colores.Id <= 0)
                errorsCheck += "El ID del color no es válido. \n";

            if (string.IsNullOrEmpty(colores.Nombre))
                errorsCheck += "El nombre del color es obligatorio. \n";

            if (!string.IsNullOrEmpty(errorsCheck))
                return Response<Colores>.Fail(errorsCheck.Trim());

            return await _coloresRepository.UpdateAsync(colores);
        }

        public async Task<Response<Colores>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Colores>.Fail("El ID proporcionado no es válido");
            return await _coloresRepository.DeleteAsync(id);
        }
    }
}
