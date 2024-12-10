using System.ComponentModel.DataAnnotations;

namespace UsersCrud.Models
{
    public class Contacto
    {
        [Key]
        public int ContactoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public required string Nombre { get; set; }        
        
        [Required(ErrorMessage = "El teléfono móvil es obligatorio.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public required string TelefonoMovil { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        public required string Email { get; set; }

        
        public DateTime FechaCreacion { get; set; }

    }
}
