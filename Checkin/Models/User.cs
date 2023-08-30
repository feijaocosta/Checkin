using Microsoft.AspNetCore.Identity;

namespace Checkin.Models
{
    public class User : IdentityUser
    {
        public int id { get; set; }
        public string? Username { get; set; }
    }
}
