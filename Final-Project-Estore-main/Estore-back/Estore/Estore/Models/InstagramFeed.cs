using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class InstagramFeed
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Img { get; set; }
    }
}
