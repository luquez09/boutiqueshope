using System.Threading.Tasks;
using BoutiqueShope.Domain.Inventario;

namespace BoutiqueShope.Infrastructure.Interfaces
{
    public interface IMovimientoInventario
    {

        Task RegistrarEntradaAsync(MovimientoInventario movimientoInventario);

    }
}
