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

        // ============================
        // LISTAR TODOS
        // ============================
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
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(u.Nombre))
                return Response<Usuario>.Fail("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(u.Username))
                return Response<Usuario>.Fail("El nombre de usuario es obligatorio");

            if (string.IsNullOrWhiteSpace(u.PasswordHash))
                return Response<Usuario>.Fail("La contraseña es obligatoria");

            // Aquí podrías agregar encriptación de contraseña
            // u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(u.PasswordHash);

            return await _repo.InsertAsync(u);
        }

        // ============================
        // EDITAR USUARIO
        // ============================
        public async Task<Response<Usuario>> EditarAsync(Usuario u)
        {
            if (u.Id <= 0)
                return Response<Usuario>.Fail("El ID del usuario no es válido");

            if (string.IsNullOrWhiteSpace(u.Nombre))
                return Response<Usuario>.Fail("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(u.Username))
                return Response<Usuario>.Fail("El nombre de usuario es obligatorio");

            return await _repo.UpdateAsync(u);
        }

        // ============================
        // ELIMINAR USUARIO
        // ============================
        public async Task<Response<Usuario>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Usuario>.Fail("El ID proporcionado no es válido");

            return await _repo.DeleteAsync(id);
        }
    }
}

