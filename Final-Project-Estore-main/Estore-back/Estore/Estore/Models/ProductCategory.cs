using System.Collections.Generic;

namespace Estore.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable< Product> Products{ get; set; }

    }
}
