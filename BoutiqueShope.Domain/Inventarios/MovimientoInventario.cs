using System;

namespace BoutiqueShope.Domain.Inventario
{
    public class MovimientoInventario
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        // Producto
        public string Producto { get; set; }
        public string Variacion { get; set; }

        // Almacén
        public string Almacen { get; set; }

        // Movimiento
        public string TipoMovimiento { get; set; }

        // Documento origen
        public string Documento { get; set; }   // Ej: "venta #1023"

        // Cantidades y costos
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal CostoTotal { get; set; }

        // Usuario
        public string Usuario { get; set; }
    }
}
