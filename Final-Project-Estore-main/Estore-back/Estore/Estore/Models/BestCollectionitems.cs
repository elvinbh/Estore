using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class BestCollectionitems
    {
        public int Id { get; set; }
        [Required]
        [StringLength(63)]
        public string ProductName { get; set; }
        [Required][StringLength(100)]
        public string Img { get; set; }
        public virtual BestCollectionModel Model { get; set; }
        public int BestCollectionModelId { get; set; }


    }
}
