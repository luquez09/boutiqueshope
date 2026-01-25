using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class ProductoService
    {
        private readonly ProductoRepository _repo;
        public ProductoService()
        {
            _repo = new ProductoRepository();
        }

        public Task<Response<Producto>> ListarAsync() => _repo.GetAllAsync();
        public Task<Response<Producto>> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Response<Producto>> CrearAsync(Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                return Response<Producto>.Fail("El nombre del producto es obligatorio");

            if (p.CategoriaId <= 0)
                return Response<Producto>.Fail("La categoría es obligatoria");

            if (p.ProveedorId <= 0)
                return Response<Producto>.Fail("El proveedor es obligatorio");

            if (p.MarcaId <= 0)
                return Response<Producto>.Fail("La marca es obligatoria");

            return await _repo.InsertAsync(p);
        }

        public async Task<Response<Producto>> EditarAsync(Producto p)
        {
            if (p.Id <= 0)
                return Response<Producto>.Fail("El ID no es válido");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                return Response<Producto>.Fail("El nombre es obligatorio");

            if (p.CategoriaId <= 0)
                return Response<Producto>.Fail("La categoría es obligatoria");

            if (p.ProveedorId <= 0)
                return Response<Producto>.Fail("El proveedor es obligatorio");

            if (p.MarcaId <= 0)
                return Response<Producto>.Fail("La marca es obligatoria");

            return await _repo.UpdateAsync(p);
        }

        public async Task<Response<Producto>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<Producto>.Fail("Error al identificar el producto, seleccione uno de la lista.");

            return await _repo.DeleteAsync(id);
        }
    }
}
