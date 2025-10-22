using Microsoft.AspNetCore.Identity;

namespace MovieReviewSite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
