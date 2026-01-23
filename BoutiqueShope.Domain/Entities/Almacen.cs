using System;

namespace BoutiqueShope.Domain.Entities
{
    public class Almacen
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int? ResponsableId { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}