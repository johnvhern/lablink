using Microsoft.AspNetCore.Identity;

namespace lablink.app.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? ProfilePicturePath { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool isDeleted { get; set; }
    }
}
