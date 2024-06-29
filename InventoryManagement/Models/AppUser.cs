using Microsoft.AspNetCore.Identity;

namespace InventoryManagement.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
    }
}
