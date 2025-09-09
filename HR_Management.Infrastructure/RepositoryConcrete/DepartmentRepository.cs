using HR_Management.Core.Entities;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using HR_Management.Infrastructure.RepositoryConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.Services
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly AppDbContext _dbContext;

        public DepartmentRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update(Department  department)
        {
            Department? departmentInDb = _dbContext.Departments.FirstOrDefault(c => c.Id == department.Id);
            if (departmentInDb != null)
            {
                departmentInDb.Name = department.Name;
                departmentInDb.CreatedAt = DateTime.Now;
                departmentInDb.Description = department.Description;
                

            }
        }
    }
}
