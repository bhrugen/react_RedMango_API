using Microsoft.AspNetCore.Identity;

namespace RedMango_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
