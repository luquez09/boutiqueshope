using System;

namespace BoutiqueShope.Domain.Inventario
{
    public class AjusteInventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int VariacionId { get; set; }
        public int AlmacenId { get; set; }
        public string DocumentoTipo { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal CostoTotal { get; set; }
        public string Motivo { get; set; }
        public int idUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
