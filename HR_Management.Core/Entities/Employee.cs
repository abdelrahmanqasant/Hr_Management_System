using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.Identity;

namespace HR_Management.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }
        public DateTime DateOfBirth { get; set; }

        public decimal Salary { get; set; }

        public int DepartmentId  { get; set; }

        public Department Department  { get; set; }
        public Guid? userId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<LeaveBalance> leaveBalances { get; set; } = new List<LeaveBalance>();
        public ICollection<LeaveRequest> leaveRequests { get; set; } = new List<LeaveRequest>();


    }
}