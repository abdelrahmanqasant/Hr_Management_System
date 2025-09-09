using HR_Management.Core.Entities.Leaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.DTOs.WebApplication.LeaveRequest
{
    public class EditLeaveRequestVM
    {
        public int Id { get; set; }
        public int LeaveTypeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;

      
    }
}
