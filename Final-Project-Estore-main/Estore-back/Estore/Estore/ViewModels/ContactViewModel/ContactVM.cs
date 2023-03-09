using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.ContactViewModel
{
    public class ContactVM
    {
        public virtual IEnumerable<Gallery> Galleries { get; set; }
        public virtual IEnumerable<ContactInfo> ContactInfos { get; set; }
        public virtual Map Map { get; set; }



    }
}
