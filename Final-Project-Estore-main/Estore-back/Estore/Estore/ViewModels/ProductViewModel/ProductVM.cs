using Estore.Models;
using Estore.ViewModels.BasketViewModel;
using System.Collections.Generic;

namespace Estore.ViewModels.ProductViewModel
{
    public class ProductVM
    {
        public virtual Subscribe Subscribe { get; set; }
        public virtual IEnumerable<ShopMethod> ShopMethods { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<ProductCategory>ProductCategories { get; set; }
        public virtual Product Product { get; set; }
        public virtual BasketVM Basket { get; set; }
        public virtual List<BasketVM> Baskets { get; set; }

    }
}
