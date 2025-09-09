using HR_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.ServiceContract
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        void Update(Company company);

    }
}
