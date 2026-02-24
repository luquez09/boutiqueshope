using System;

namespace BoutiqueShope.Domain.Entities
{
    public class ProductoVariacion
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public string CodigoBarras { get; set; }
        public string CodigoSku { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public int Impuesto { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string NombreVariacion => $"{Talla} - {Color}";
    }
}
