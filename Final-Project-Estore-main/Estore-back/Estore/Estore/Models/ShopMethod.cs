using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class ShopMethod
    {
        public int Id { get; set; }
        [Required][StringLength(30)]
        public string MethodName { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }


    }
}
