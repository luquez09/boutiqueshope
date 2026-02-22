using System;

namespace BoutiqueShope.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ProveedorId { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public string CodigoSku { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
