using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class AboutShopInfo
    {
        public int Id { get; set;}
        [Required][StringLength(100)]
        public string Title { get; set;}
        [Required]
        [StringLength(255)]
        public string Content { get; set;}
       public IEnumerable<AboutShopItem> Items { get; set;}
    }
}
