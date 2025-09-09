using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.LeaveRequest;
using HR_Management.Core.Entities.Leaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.ServiceLayer.Automappers.WebApplication
{
    public class LeaveRequestMapper :Profile
    {
        public LeaveRequestMapper()
        {
            CreateMap<LeaveRequest, AddLeaveRequestVM>().ReverseMap();
            CreateMap<LeaveRequest, EditLeaveRequestVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVM>()
                .ForMember(c=>c.StartDate,op=>op.MapFrom(e=>e.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(c => c.EndDate, op => op.MapFrom(e => e.EndDate.ToString("yyyy-MM-dd")))
                .ForMember(x => x.EmployeeName, opt => opt.MapFrom(e => e.Employee.FullName))
                .ForMember(y => y.LeaveTypeName, op => op.MapFrom(d => d.LeaveType.Name))
                .ForMember(a => a.LeaveDuration, o => o.MapFrom(w => (w.EndDate - w.StartDate).Days + 1));
            CreateMap<LeaveRequest, UpdateLeaveRequestStatus>().ReverseMap();
        }
    }
}
