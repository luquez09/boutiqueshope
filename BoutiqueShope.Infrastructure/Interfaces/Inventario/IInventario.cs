
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;

namespace BoutiqueShope.Infrastructure.Interfaces
{
    public interface IInventario
    {
        Task<Response<InventarioDomain>> GetInventarioForIds(int idProducto, int idVariacion, int idAlmacen);
    }
}
