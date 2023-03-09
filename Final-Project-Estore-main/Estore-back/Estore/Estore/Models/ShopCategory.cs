using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class ShopCategory
    {
        public int Id { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsNewCollection { get; set; }
        public bool IsBestnewDeal { get; set; }
        [Required] [StringLength(63)]
        public string BrandName { get; set; }
        [StringLength(100)]
        public string Img { get; set; }



    }
}
