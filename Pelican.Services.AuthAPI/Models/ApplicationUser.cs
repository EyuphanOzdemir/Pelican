using Microsoft.AspNetCore.Identity;

namespace Pelican.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
