using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application
{
    public class UsuarioService 
    {
        private readonly UsuarioRepository _repo;

        public UsuarioService()
        {
            _repo = new UsuarioRepository();
        }

        public async Task<Response<Usuario>> ListarAsync()
        {
            return await _repo.GetAllAsync();
        }

        // ============================
        // OBTENER POR ID
        // ============================
        public async Task<Response<Usuario>> ObtenerPorIdAsync(int id)
        {
            if (id <= 0)
                return Response<Usuario>.Fail("El ID proporcionado no es válido");

            return await _repo.GetByIdAsync(id);
        }

        // ============================
        // CREAR USUARIO
        // ============================
        public async Task<Response<Usuario>> CrearAsync(Usuario u)
        {
            if (string.IsNullOrWhiteSpace(u.Nombre))
                return Response<Usuario>.Fail("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(u.Username))
                return Response<Usuario>.Fail("El nombre de usuario es obligatorio");

            if (string.IsNullOrWhiteSpace(u.PasswordHash))
                return Response<Usuario>.Fail("La contraseña es obligatoria");


            return await _repo.InsertAsync(u);
        }

        // ============================
        // EDITAR USUARIO
        // ============================
        public async Task<Response<Usuario>> EditarAsync(Usuario u)
        {
            string errorsCheck = "";

            if (u.Id <= 0)
                errorsCheck += "El ID del usuario no es válido. \n";

            if (string.IsNullOrWhiteSpace(u.Nombre))
                errorsCheck += "El nombre es obligatorio. \n";

            if (string.IsNullOrWhiteSpace(u.Username))
                errorsCheck += "El nombre de usuario es obligatorio. ";

            if (!string.IsNullOrEmpty(errorsCheck))
                return Response<Usuario>.Fail(errorsCheck);

            return await _repo.UpdateAsync(u);
        }

        public async Task<Response<Usuario>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Usuario>.Fail("Error al identificar el usuario, seleccione uno de la lista.");

            return await _repo.DeleteAsync(id);
        }
    }
}

