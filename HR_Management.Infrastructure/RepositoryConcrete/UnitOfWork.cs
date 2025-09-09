
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using HR_Management.Infrastructure.RepositoryConcrete;

namespace HR_Management.Core.Services
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public ICompanyRepository CompanyRepository { get; private set; }

        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IEmployeeRepository EmployeeRepository { get; private set; }

        public ILeaveTypeRepository LeaveTypeRepository { get; private set; }

        public ILeaveRequestRepository LeaveRequestRepository { get; private set; }

        public ILeaveBalanceRepository LeaveBalanceRepository { get; private set; }

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            CompanyRepository = new CompanyRepository(dbContext);
            DepartmentRepository = new DepartmentRepository(dbContext);
            EmployeeRepository = new EmployeeRepository(dbContext);

            LeaveTypeRepository = new LeaveTypeRepository(dbContext);
            LeaveBalanceRepository = new LeaveBalanceRepository(dbContext);
            LeaveRequestRepository = new LeaveRequestRepository(dbContext);
        }

     

        public void Dispose()
        {
            _dbContext.Dispose();
        }

      

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
