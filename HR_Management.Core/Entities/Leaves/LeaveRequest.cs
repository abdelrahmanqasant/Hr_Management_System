namespace HR_Management.Core.Entities.Leaves
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Reason { get; set; } = string.Empty;
        public LeaveRequestStatus Status { get; set; } = LeaveRequestStatus.Pending;
        public int NumberOfDays { get; set;  }
    }
}
