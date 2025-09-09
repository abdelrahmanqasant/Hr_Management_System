using HR_Management.Core.DTOs.WebApplication.LeaveRequest;
using HR_Management.Core.Entities.Leaves;
using System.Linq.Expressions;


namespace HR_Management.Core.ServiceContract
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<IEnumerable<LeaveRequest>> 
            GetRequestsByEmployeeAsync(Expression<Func<LeaveRequest, bool>>? predicate = null, string? IncludeWord = null);
        void  UpdateLeaveRequest(LeaveRequest editLeaveRequest);
    }
}
