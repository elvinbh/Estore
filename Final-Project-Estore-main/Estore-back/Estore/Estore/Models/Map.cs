using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Map
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Url)][StringLength(500)]
        public string GoogleMap { get; set; }
    }
}
