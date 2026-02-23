using System;

namespace BoutiqueShope.Domain.Inventarios
{
    public class ProductoVariacionFilter
    {
        public int ProductoId { get; set; }
        public String Nombre { get; set; }
        public int VariacionId { get; set; }
        public String Talla { get; set; }
        public String Color { get; set; }
        public String CodigoSku { get; set; }
        public String CodigoBarra { get; set; }
        public Double PrecioVenta { get; set; }
        public Double Impuesto { get; set; }
        public String DisplayPOS => $"{Nombre} ({Color} - {Talla})";
    }
}
