using Estore.Models;
using Estore.ViewModels.BasketViewModel;
using System.Collections.Generic;

namespace Estore.ViewModels.CartViewModel
{
    public class CartVM
    {
        public Product Product { get; set; }
        public List<BasketVM>Baskets { get; set; }
    }
}
