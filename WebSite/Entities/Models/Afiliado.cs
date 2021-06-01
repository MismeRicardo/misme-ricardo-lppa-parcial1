using System.ComponentModel.DataAnnotations;

namespace WebSite.Entities.Models
{
    public class Afiliado: IdentityBase
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Cuit { get; set; }

        public string NombreCompleto => Nombre + " " + Apellido;
    }
}