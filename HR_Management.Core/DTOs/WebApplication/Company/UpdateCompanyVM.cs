

namespace HR_Management.Core.DTOs.WebApplication.Company
{
    public class UpdateCompanyVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
    }
}
