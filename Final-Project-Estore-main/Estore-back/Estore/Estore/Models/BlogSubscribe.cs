using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class BlogSubscribe
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
        public bool EmailStatus { get; set; }

    }
}
