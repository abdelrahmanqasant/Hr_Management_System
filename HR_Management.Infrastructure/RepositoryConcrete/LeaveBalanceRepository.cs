using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Infrastructure.RepositoryConcrete
{
    public class LeaveBalanceRepository : GenericRepository<LeaveBalance>, ILeaveBalanceRepository
    {
        public LeaveBalanceRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
