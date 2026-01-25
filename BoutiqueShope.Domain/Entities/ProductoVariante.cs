using System;

namespace BoutiqueShope.Domain.Entities
{
    public class ProductoVariante
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
