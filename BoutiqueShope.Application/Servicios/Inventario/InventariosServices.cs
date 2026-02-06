using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Infrastructure.Implementations.Inventarios;

namespace BoutiqueShope.Application.Servicios.Inventario
{
    public class InventariosServices
    {
        private InventarioImpl _repo = new InventarioImpl();

        public async Task<Response<InventarioDomain>> GetInventarioForIds(int idProducto, int idAlmacen, int idVariacion)
        {
            return await _repo.GetInventarioForIds(idProducto, idAlmacen, idVariacion);
        }
    }
}
