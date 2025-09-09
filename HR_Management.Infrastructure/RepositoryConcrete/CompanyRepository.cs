

using HR_Management.Core.Entities;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using System.Linq.Expressions;

namespace HR_Management.Infrastructure.RepositoryConcrete;

public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
{
    private readonly AppDbContext _dbContext;

    public CompanyRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
  public void Update(Company company)
    {
        var companyInDb = 
            _dbContext.Companies.Find( company.Id);
        if (companyInDb != null)
        {
            companyInDb.Name = company.Name;
            companyInDb.Address = company.Address;
            companyInDb.Departments = company.Departments;
            companyInDb.Industry = company.Industry;

        }
    }
}
