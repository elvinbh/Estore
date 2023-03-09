using System.ComponentModel.DataAnnotations;

namespace Estore.Models

{
    public class AboutText
    {
        public int Id { get; set; }

        [Required][StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public virtual AboutVideo AboutVideo  { get; set; }
    }
}
