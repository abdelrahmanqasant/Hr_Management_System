

using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;

namespace HR_Management.Infrastructure.RepositoryConcrete
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
