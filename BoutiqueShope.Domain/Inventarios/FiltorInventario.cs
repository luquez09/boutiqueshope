using System;

namespace BoutiqueShope.Domain.Inventarios
{
    public class FiltorInventario
    {
        public int productoId { get; set; }
        public int variacionId { get; set; }
        public int almacenId { get; set; }
        public int usuarioId { get; set; }
        public string tipoMovimiento { get; set; }
        public string documentoOrigen { get; set; }
    }
}
