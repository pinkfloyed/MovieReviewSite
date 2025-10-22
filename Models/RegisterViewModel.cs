using System.ComponentModel.DataAnnotations;

namespace MovieReviewSite.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }= string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; }= string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }= string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }= string.Empty;

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }= string.Empty;
    }
}