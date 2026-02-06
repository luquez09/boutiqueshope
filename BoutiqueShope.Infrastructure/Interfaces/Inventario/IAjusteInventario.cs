using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;

namespace BoutiqueShope.Infrastructure.Interfaces
{
    public interface IAjusteInventario
    {
        Task<Response<AjusteInventario>> RegistrarAjusteInventario(AjusteInventario ajusteInventario);
    }
}
