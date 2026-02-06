using System;

namespace BoutiqueShope.Domain.Inventario
{
    public class InventarioDomain
    {
        public int IdInventario { get; set; }
        public int productoId { get; set; }
        public int almacenId { get; set; }
        public int variacionId { get; set; }
        public decimal stockActual { get; set; }
        public decimal StockReservado { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal CostoPromedio { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
