using System;

namespace BoutiqueShope.Domain.Entities
{
    public class ProductoVariacion
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public string CodigoBarras { get; set; }
        public string CodigoQr { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}