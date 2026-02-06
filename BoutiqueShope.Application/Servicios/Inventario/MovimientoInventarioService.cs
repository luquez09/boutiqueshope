using System.Threading.Tasks;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Infrastructure.Interfaces;

namespace BoutiqueShope.Application.Servicios.Ventas
{
    public class MovimientoInventarioService
    {

        private readonly IMovimientoInventario _repo;

        public MovimientoInventarioService(IMovimientoInventario movimientoInventarioRepository)
        {
            _repo = movimientoInventarioRepository;
        }

        public async Task RegistrarEntradaAsync(MovimientoInventario movimientoInventario)
        {
            await _repo.RegistrarEntradaAsync(movimientoInventario);
        }

    }
}
