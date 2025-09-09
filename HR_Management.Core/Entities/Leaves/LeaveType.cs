

namespace HR_Management.Core.Entities.Leaves
{
    public class LeaveType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDaysPerYear { get; set; }
        public bool isPaid { get; set; }
        public IEnumerable<LeaveBalance> LeaveBalances { get; set; } = new List<LeaveBalance>();
        public IEnumerable<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    }
}
