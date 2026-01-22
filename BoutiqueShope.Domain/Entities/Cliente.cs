using System;

namespace BoutiqueShope.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public bool Activo { get; set; }
        public decimal TotalCompras { get; set; }
        public DateTime? UltimaCompra { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}