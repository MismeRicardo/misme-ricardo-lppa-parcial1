using System.ComponentModel.DataAnnotations;

namespace WebSite.Entities.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}