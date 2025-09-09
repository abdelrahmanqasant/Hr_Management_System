using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.DTOs.WebApplication.Employee
{
    public class AddEmployeeVM
    {
        public string FullName { get; set; } = string.Empty; 

        public string Title { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }
        public int DepartmentId { get; set; } 


        public decimal Salary { get; set; }

        public int CompanyId { get; set; } 

    }
}
