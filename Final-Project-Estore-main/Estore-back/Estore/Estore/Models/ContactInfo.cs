using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        [Required]
        [MinLength(7)]
        [StringLength(100)]
        public string Contactinfo { get; set; }
        [Required][StringLength(100)]
        [MinLength(10)]
        public string ContactText { get; set; }
        [StringLength(64)]
        public string ContactType { get; set; }

    }
}
