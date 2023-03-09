using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}
