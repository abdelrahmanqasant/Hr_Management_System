using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.ServiceContract
{
    public interface IUnitOfWork
    {
        ICompanyRepository CompanyRepository { get; }

        IDepartmentRepository DepartmentRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }

        ILeaveTypeRepository LeaveTypeRepository { get; }
        ILeaveRequestRepository LeaveRequestRepository { get; }
        ILeaveBalanceRepository LeaveBalanceRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
