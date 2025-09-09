using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.DTOs.WebApplication.Employee
{
    public class EmployeesListVM
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }
        public string DepartmentName { get; set; } = string.Empty;


        public decimal Salary { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        public int TotalLeaveRemaining { get; set; } 



    }
}
