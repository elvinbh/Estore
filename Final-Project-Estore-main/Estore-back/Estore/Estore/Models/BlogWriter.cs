using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class BlogWriter
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Img { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [EmailAddress]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [EmailAddress]
        [StringLength(30)]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [EmailAddress]
        [StringLength(512)]
        public string About { get; set; }
        public IEnumerable<Post>Posts { get; set; }


    }
}
