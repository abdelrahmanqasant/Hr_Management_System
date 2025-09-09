using HR_Management.Core.Entities.Leaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.DTOs.WebApplication.LeaveRequest
{
    public class UpdateLeaveRequestStatus
    {
        public int Id { get; set; }
        public LeaveRequestStatus Status { get; set; }
        public string? ManagerComment { get; set; }
    }
}
