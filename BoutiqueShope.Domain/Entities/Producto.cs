using System;

namespace BoutiqueShope.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal PorcentajeGanancia { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockMinimo { get; set; }
        public int? ProveedorId { get; set; }
        public int CategoriaId { get; set; }
        public int? MarcaId { get; set; }
        public string CodigoBarras { get; set; }
        public string CodigoQr { get; set; }
        public bool Activo { get; set; }
        public string codigoSku { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
