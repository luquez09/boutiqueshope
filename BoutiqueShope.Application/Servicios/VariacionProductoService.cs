using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;
using BoutiqueShope.Infrastructure.Repositories;

namespace BoutiqueShope.Application.Servicios
{
    public class VariacionProductoService
    {

        private readonly VariacionProductoRepository _repo;

        public VariacionProductoService()
        {
            _repo = new VariacionProductoRepository();
        }


        public async Task<Response<ProductoVariacion>> ListarAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Response<ProductoVariacion>> ObtenerPorIdAsync(int id)
        {
            if (id <= 0)
                return Response<ProductoVariacion>.Fail("El ID proporcionado no es válido");

            return await _repo.GetByIdAsync(id);
        }

        public async Task<Response<ProductoVariacion>> ObtenerPorIdProductoAsync(int id)
        {
            if (id <= 0)
                return Response<ProductoVariacion>.Fail("El ID proporcionado no es válido");

            return await _repo.GetByIdProductoAsync(id);
        }

        // ============================
        // CREAR ProductoVariacion
        // ============================
        public async Task<Response<ProductoVariacion>> CrearAsync(ProductoVariacion productoVariacion)
        {
            string resultErrors = string.Empty;

            if (!validateDataVariacion(productoVariacion, resultErrors))
                return Response<ProductoVariacion>.Fail(resultErrors);

            return await _repo.InsertAsync(productoVariacion);
        }

        // ============================
        // EDITAR ProductoVariacion
        // ============================
        public async Task<Response<ProductoVariacion>> EditarAsync(ProductoVariacion productoVariacion)
        {
            string resultErrors = string.Empty;

            if (!validateDataVariacion(productoVariacion, resultErrors))
                return Response<ProductoVariacion>.Fail(resultErrors);

            return await _repo.UpdateAsync(productoVariacion);
        }
        public async Task<Response<ProductoVariacion>> SaveVariacionesAsync(List<ProductoVariacion> productoVariaciones)
        {
            string resultErrors = "";

            for (int i = 0; i < productoVariaciones.Count; i++)
            {
                if (!validateDataVariacion(productoVariaciones[i], resultErrors))
                    return Response<ProductoVariacion>.Fail(resultErrors);
                
            }

            return await _repo.SaveVariacionesAsync(productoVariaciones);
        }

        public async Task<Response<ProductoVariacion>> EliminarAsync(int id)
        {
            if (id <= 0)
                return Response<ProductoVariacion>.Fail("Error al identificar la variacion del producto, seleccione uno de la lista.");

            return await _repo.DeleteAsync(id);
        }

        private bool validateDataVariacion(ProductoVariacion productoVariacion, string resultErrors)
        {

            if (string.IsNullOrWhiteSpace(productoVariacion.Talla)) resultErrors += "Error la talla es requerida. \n";
            if (string.IsNullOrWhiteSpace(productoVariacion.Color)) resultErrors += "Error el color es requerida. \n";
            if (productoVariacion.PrecioVenta == 0) resultErrors += "Error precio de venta es requerida. \n";
            if (productoVariacion.Costo == 0) resultErrors += "Error el costo es requerida.";

            if (!string.IsNullOrEmpty(resultErrors)) return false;

            return true;
        }


    }
}
