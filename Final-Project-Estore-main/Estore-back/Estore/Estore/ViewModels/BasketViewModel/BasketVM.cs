using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.BasketViewModel
{
    public class BasketVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainImage { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual IEnumerable<Product> Products{ get; set; }
       


    }
}
