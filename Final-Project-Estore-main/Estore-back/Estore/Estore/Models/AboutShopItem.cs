using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class AboutShopItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Img { get; set; }
        public virtual AboutShopInfo Info { get; set; }
        public int AboutShopInfoId { get; set; }
    }
}
