using HR_Management.Core.DTOs.WebApplication.LeaveRequest;
using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace HR_Management.Infrastructure.RepositoryConcrete
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly AppDbContext _dbContext;

        public LeaveRequestRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<LeaveRequest>> 
            GetRequestsByEmployeeAsync(Expression<Func<LeaveRequest, bool>>? predicate = null, string? IncludeWord = null)
        {
            IQueryable<LeaveRequest> query = _dbContext.LeaveRequests;
            if ((predicate != null))
            {
                query = query.Where(predicate);
            }
            if (IncludeWord != null)
            {
                foreach (var item in IncludeWord.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))

                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public void  UpdateLeaveRequest( LeaveRequest editLeaveRequest)
        {
      var request =  _dbContext.LeaveRequests.FirstOrDefault(x=>x.Id == editLeaveRequest.Id);
             if(request == null)
            {
                 throw new NullReferenceException();
            }
             if(request.Status != LeaveRequestStatus.Pending)
            {
                throw new InvalidOperationException();
            }
             request.StartDate = editLeaveRequest.StartDate;
            request.EndDate = editLeaveRequest.EndDate;
            request.Reason = editLeaveRequest.Reason;
            request.LeaveTypeId = editLeaveRequest.LeaveTypeId;
           
        }
    }
}
