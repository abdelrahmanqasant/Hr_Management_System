using HR_Management.Core.Entities;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Infrastructure.RepositoryConcrete
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Employee>>
            GetEmployeesByCompanyAsync
            (int companyId)
        {
            var query = _dbContext.Employees.Include(x => x.Department).ThenInclude(y => y.Company)
                .Include(e=>e.leaveBalances).ThenInclude(v=>v.LeaveType).Include(b=>b.leaveRequests)
                .Where(e => e.Department.CompanyId == companyId);
           

            return await query.ToListAsync();
               
        }   

        public void Update(Employee employee)
        {
            var employeeInDB = _dbContext.Employees.Find(employee.Id);
            if (employeeInDB != null)

            {
                employeeInDB.FullName = employee.FullName;
                employeeInDB.Address = employee.Address;
                employeeInDB.PhoneNumber = employee.PhoneNumber;
                employeeInDB.Salary = employee.Salary;
                employeeInDB.DateOfBirth = employee.DateOfBirth;
                employeeInDB.Department = employee.Department;
                employeeInDB.Email = employee.Email;
                employeeInDB.Title = employee.Title;
                employeeInDB.HireDate = employee.HireDate;
                employeeInDB.leaveBalances = employee.leaveBalances;
                employeeInDB.leaveRequests = employee.leaveRequests;

            }
        }
    }
}
