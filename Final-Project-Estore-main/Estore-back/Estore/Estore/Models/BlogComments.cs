using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estore.Models
{
    public class BlogComments
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Name { get; set; }
        [Required] [DataType(DataType.Text)]
        [StringLength(30)]
        public string SurName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)] [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(500)]
        public string Text { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
       
        
    }
}
