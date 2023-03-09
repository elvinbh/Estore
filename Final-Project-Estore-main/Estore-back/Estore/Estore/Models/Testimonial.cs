using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Img { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(512)]
        public string Text { get; set; }



    }
}
