using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estore.Models
{
    public class FilterCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public IEnumerable<FilterItems> FilterItems { get; set; }

        [NotMapped]
        public string Float { get; set; }
    }
}
