using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class BestCollectionModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(63)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Leftimg { get; set; }
        [Required]
        [StringLength(100)]
        public string Modelimg { get; set; }
        public virtual IEnumerable<BestCollectionitems> Collectionitems { get; set; }

    }
}
