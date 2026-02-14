using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Domain.Inventarios;

namespace BoutiqueShope.Infrastructure.Interfaces
{
    public interface IMovimientoInventario
    {
        Task<Response<MovimientoInventario>> GetAllMovimientoForIds(FiltorInventario filtorInventario);
    }
}
