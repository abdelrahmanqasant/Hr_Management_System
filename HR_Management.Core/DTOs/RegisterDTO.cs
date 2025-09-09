using System.ComponentModel.DataAnnotations;

namespace HR_Management.Core.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Person Name Can`t Be Blank ")]
        public string? PersonName { get; set; } = string.Empty;

        [Required(ErrorMessage ="Email Can`t Be Blank ")]
        [EmailAddress(ErrorMessage ="Email Should Be In A Proper Email Address Format ")]
        public string? Email { get; set; } = string.Empty;

        [Phone]
        [Required(ErrorMessage = "Phone Number Can`t Be Blank")]
        public string  PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password Can`t Be Blank")]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage = "Confirm Password Can`t Be Blank")]
        [Compare("Password",ErrorMessage ="PAssword And Confirm Password Must Be Match")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
