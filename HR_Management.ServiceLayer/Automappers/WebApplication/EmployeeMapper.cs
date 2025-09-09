using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.Employee;
using HR_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.ServiceLayer.Automappers.WebApplication
{
    public class EmployeeMapper :Profile
    {
        public EmployeeMapper()
        {
            CreateMap<Employee, EmployeeVM>()
                .ForMember(d => d.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
                .ForMember(c => c.CompanyName, op => op.MapFrom(x => x.Department.Company.Name))
                .ForMember(z => z.Email, opt => opt.MapFrom(src => src.User.Email)) 
                ;
               
 
            CreateMap<Employee, AddEmployeeVM>().ReverseMap()
                               .ForMember(z => z.userId , opt=>opt.Ignore());
            CreateMap<Employee, EditEmployeeVM>().ReverseMap();
            CreateMap<Employee, EmployeesListVM>().ForMember(d => d.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
                .ForMember(c => c.CompanyName, op => op.MapFrom(x => x.Department.Company.Name))
                .ForMember(dest => dest.TotalLeaveRemaining , 
                opt =>opt.MapFrom
                (c=>c.leaveBalances != null ? c.leaveBalances
                .Sum(lb=>lb.RemainingDays) : 0));
            CreateMap<Employee, EmployeesInDepartmentVM>().ForMember(d => d.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
                .ForMember(c => c.CompanyName, op => op.MapFrom(x => x.Department.Company.Name)); 
         

        }
    }
}
