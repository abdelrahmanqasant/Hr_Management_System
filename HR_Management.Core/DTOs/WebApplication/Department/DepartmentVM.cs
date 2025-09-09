

using HR_Management.Core.DTOs.WebApplication.Employee;

namespace HR_Management.Core.DTOs.WebApplication.Department
{
    public  class DepartmentVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

    public IEnumerable<EmployeesInDepartmentVM> Employees { get; set; }
    }
}
