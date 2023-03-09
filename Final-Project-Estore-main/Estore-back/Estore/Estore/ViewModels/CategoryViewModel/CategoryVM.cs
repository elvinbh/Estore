using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.CategoryViewModel
{
    public class CategoryVM
    {
        public virtual IEnumerable<Gallery> Galleries { get; set; }
        public virtual IEnumerable<ShopMethod> ShopMethods { get; set; }
        public virtual LatestSubscribe LatestSubscribe { get; set; }

    }
}
