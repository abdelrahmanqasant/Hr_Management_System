

using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.Company;
using HR_Management.Core.Entities;

namespace HR_Management.ServiceLayer.Automappers.WebApplication
{
    public class CompanyMapper : Profile
    {
        public CompanyMapper() 
        {
        CreateMap<Company,CreateCompanyVM>().ReverseMap();
        CreateMap<Company,CompanyVM>().ForMember(x=>x.DepartmentsCount, opt=> opt.MapFrom(src =>src.Departments.Count));
        CreateMap<Company,UpdateCompanyVM>().ReverseMap();
            CreateMap<Company, CompaniesListVM>().ForMember(x => x.DepartmentsCount, opt => opt.MapFrom(src => src.Departments.Count));
        
        }
    }
}
