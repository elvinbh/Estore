using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class AboutVideo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Img { get; set; }
        [Required]
        [StringLength(255)]
        public string Video { get; set; }
        public virtual AboutText Text { get; set; }
        public int AboutTextId { get; set; }
    }
}
