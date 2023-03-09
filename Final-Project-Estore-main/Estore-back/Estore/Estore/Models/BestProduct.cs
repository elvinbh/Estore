using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class BestProduct
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Backgroundimg { get; set; }
        [Required]
        [StringLength(100)]
        public string Modelimg { get; set; }
        [Required]
        [StringLength(100)]
        public string Img { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(30)]
        public string Productname { get; set; }


    }
}
