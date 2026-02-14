using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Inventario;
using BoutiqueShope.Infrastructure.Implementations;
using BoutiqueShope.Infrastructure.Interfaces;

namespace BoutiqueShope.Application.Servicios.Inventario
{
    public class AjusteInventarioService
    {
        private ValidacionCampos validacionCampos = new ValidacionCampos();
        private AjusteInventarioImpl _ajusteInventario = new AjusteInventarioImpl();

        public async Task<Response<AjusteInventario>> RealizarAjusteAsync(AjusteInventario ajusteInventario)
        {
            List<string> errores = new List<string>();
            string error = string.Empty;
            //Validamos que los datos sean correctos
            error = validacionCampos.ValidacionCampoNumerico("Cantidad", ajusteInventario.Cantidad);
            if (!string.IsNullOrEmpty(error))
                errores.Add(error);

            error = validacionCampos.ValidacionCampoNumerico("CostoUnitario", ajusteInventario.CostoUnitario);
            if (!string.IsNullOrEmpty(error))
                errores.Add(error);

            if (errores.Count > 0)
                return Response<AjusteInventario>.Fail(string.Join("; ", errores), "400");

            return await _ajusteInventario.RegistrarAjusteInventario(ajusteInventario);
        }
    }
}
