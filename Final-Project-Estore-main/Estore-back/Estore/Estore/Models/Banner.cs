using System;
using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Banner
    {
        public int Id { get; set; }
        [StringLength(100)]
        public  string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string  Img { get; set; }
    }
}
