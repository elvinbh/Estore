using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class LatestSubscribe
    {
        public int Id { get; set; }
        [Required][StringLength(30)]
        public string Title { get; set; }
        [Required]
        [StringLength(30)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string BackgroundImg { get; set; }
        [Required]
        [StringLength(100)]
        public string Img { get; set; }


    }
}
