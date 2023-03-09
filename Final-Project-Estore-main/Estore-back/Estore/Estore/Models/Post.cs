using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Img { get; set; }
    
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<PostTags> PostTags { get; set; }
        public IEnumerable<PostCategories> PostCategories { get; set; }
        public IEnumerable<BlogComments> BlogComments { get; set; }
        public BlogWriter BlogWriter  { get; set; }
        public int BlogWriterId { get; set; }



    }
}
