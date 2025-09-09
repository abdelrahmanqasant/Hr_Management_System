using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
        public int CompanyId { get; set; } 


        [ForeignKey("CompanyId")]
        public Company Company { get; set; } 
        public string Description { get; set; } =string.Empty;
        public DateTime CreatedAt { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

    }
}
