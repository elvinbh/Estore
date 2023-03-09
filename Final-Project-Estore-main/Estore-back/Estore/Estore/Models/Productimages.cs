namespace Estore.Models
{
    public class Productimages
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
