using System.ComponentModel.DataAnnotations;

namespace Estore.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [Phone][DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        public string Ordernotes { get; set; }
        public string Couponcode { get; set; }


    }
}
