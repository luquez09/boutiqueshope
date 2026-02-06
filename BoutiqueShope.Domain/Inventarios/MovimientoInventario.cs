using System;

namespace BoutiqueShope.Domain.Inventario
{
    public class MovimientoInventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int? VariacionId { get; set; }
        public int AlmacenId { get; set; }
        public string DocumentoTipo { get; set; }
        public int? DocumentoId { get; set; }
        public string Referencia { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
    }
}
