using System;

namespace Estore.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
