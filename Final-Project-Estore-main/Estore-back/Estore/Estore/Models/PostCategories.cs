namespace Estore.Models
{
    public class PostCategories
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
}
}