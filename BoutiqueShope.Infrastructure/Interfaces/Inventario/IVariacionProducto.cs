using System;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Domain.Inventarios;

namespace BoutiqueShope.Infrastructure.Interfaces.Inventario
{
    public interface IVariacionProducto
    {
        Task<Response<ProductoVariacionFilter>> getAllVariacionesProductos(String nombreProducto, String codigoBarra);
    }
}
