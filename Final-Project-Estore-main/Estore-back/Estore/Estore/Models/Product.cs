using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int? ProductCategoryId { get; set; }
        public IEnumerable<Productimages> Productimages { get; set; }
        public int Count { get; set; }
        public bool Isdeleted { get; set; }
        [NotMapped]
        public IFormFile[] ProductImagesFile { get; set; }
        public virtual IEnumerable<Basket> Baskets { get; set; }

    }
}
