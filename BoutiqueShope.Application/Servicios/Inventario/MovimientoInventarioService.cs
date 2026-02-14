using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Domain.Inventarios;
using BoutiqueShope.Infrastructure.Implementations;

namespace BoutiqueShope.Application.Servicios.Ventas
{
    public class MovimientoInventarioService
    {
        private readonly MovimientoInventarioImpl _repo = new MovimientoInventarioImpl();

        public async Task<Response<MovimientoInventario>> GetAllMovimientoForIds(FiltorInventario filtorInventario)
        {
            return await _repo.GetAllMovimientoForIds(filtorInventario);
        }
    }
}
