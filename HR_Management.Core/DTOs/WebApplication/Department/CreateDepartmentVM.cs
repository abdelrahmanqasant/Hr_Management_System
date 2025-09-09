using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.DTOs.WebApplication.Department
{
    public class CreateDepartmentVM
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CompanyId { get; set; }
    
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
