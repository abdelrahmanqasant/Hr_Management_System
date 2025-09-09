using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.Department;
using HR_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.ServiceLayer.Automappers.WebApplication
{
    public class DepartmentMapper :Profile
    {
        public DepartmentMapper()
        {
            CreateMap<Department ,DepartmentVM>().ForMember(x => x.CompanyName, opt => opt.MapFrom(c => c.Company.Name));
            CreateMap<Department ,DepartmentsListVM>().ForMember(x=>x.CompanyName,opt=>opt.MapFrom(c=>c.Company.Name));
            CreateMap<Department ,CreateDepartmentVM>().ReverseMap(); ;
            CreateMap<Department ,EditDepartmentVM>().ReverseMap();
        }
    }
}
