using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Estore.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public byte Age { get; set; }
        public bool IsDeleted { get; set; }
        public virtual IEnumerable<Basket> Baskets { get; set; }
    }
}
