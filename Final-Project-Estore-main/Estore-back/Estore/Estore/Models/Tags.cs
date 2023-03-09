using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Tags
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Name { get; set; }
        public IEnumerable<PostTags> PostTags{get; set;}
    }
}
