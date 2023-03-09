using System;

namespace Estore.Models
{
    public class FilterItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Filterselect { get; set; }
        public bool IsDiscount { get; set; }
        public double Price { get; set; }
        public Nullable<double> DiscountPrice { get; set; }
        public string Productimg { get; set; }
        public FilterCategory Category { get; set; }
        public int FilterCategoryId { get; set; }





    }
}
