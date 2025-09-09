
using System.ComponentModel.DataAnnotations;

namespace HR_Management.Core.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email Can`t Be Blank ")]
        [EmailAddress(ErrorMessage = "Email Should Be In A Proper Email Address Format ")]
        public string? Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password Can`t Be Blank")]
        public string Password { get; set; } = string.Empty;
    }
}
