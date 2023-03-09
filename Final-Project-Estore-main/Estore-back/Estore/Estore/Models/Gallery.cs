using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        [Required][StringLength(255)]
        public string Image { get; set; }
    }
}
