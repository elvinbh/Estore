using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.HomeViewModel
{
    public class HomeVM
    {
        public virtual IEnumerable<Gallery> Galleries { get; set; }
        public virtual IEnumerable<ShopMethod>ShopMethods { get; set; }
        public virtual LatestSubscribe LatestSubscribe { get; set; }
        public virtual BestCollectionModel BestCollection { get; set; }
        public virtual BestProduct BestProduct { get; set; }
        public virtual IEnumerable<ShopCategory> ShopCategories { get; set; }
        public virtual IEnumerable<HomeSlider> HomeSliders { get; set; }




    }
}
