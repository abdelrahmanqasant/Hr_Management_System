using HR_Management.Core.Entities;
using Microsoft.AspNetCore.Identity;
namespace HR_Management.Core.Identity
{
    public class ApplicationUser :IdentityUser<Guid>
    {
        public string? PersonName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefrehTokenExpirationDateTime { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
