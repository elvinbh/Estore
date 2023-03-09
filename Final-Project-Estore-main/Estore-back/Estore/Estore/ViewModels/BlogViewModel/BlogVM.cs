using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.BlogViewModel
{
    public class BlogVM
    {
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }
        public virtual IEnumerable<Tags> Tags { get; set; }
        public virtual IEnumerable<InstagramFeed> InstagramFeeds { get; set; }
        public virtual IEnumerable<PostTags> PostTags { get; set; }
        public virtual IEnumerable<PostCategories> PostCategories { get; set; }
        public virtual IEnumerable<BlogComments> BlogComments { get; set; }
        public virtual Post Post { get; set; }
        public virtual BlogComments BlogComment { get; set; }
       




    }
}
