
using HR_Management.Infrastructure.DataSeeding;
using HR_Management.Core.Entities;
using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text.Json;

namespace HR_Management.Infrastructure.DatabaseContext
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveBalance> LeaveBalances { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            var companies = DataSeed.companies;
            var employees = DataSeed.Employees;
            builder.Entity<Employee>().HasData(employees);
            builder.Entity<Employee>().HasOne(e=>e.User).WithOne().HasForeignKey<Employee>(e=>e.userId);
            var companiesSeed = companies.Select(c => new Company
            {
                Id = c.Id,
                Name = c.Name,

                Address = c.Address,
                Industry = c.Industry,

            }).ToList();
            builder.Entity<Company>().HasData(companiesSeed);

            var departments = companies.SelectMany(c => c.Departments.Select(d => new Department
            {
                Id = d.Id,
                Name = d.Name,
                CreatedAt = new DateTime(2025, 9, 9),
                Description = d.Description,
                CompanyId = c.Id
            })).ToList();
            builder.Entity<Department>().HasData(departments);


            List<LeaveType> leaveTypes = new List<LeaveType>()
            {
                new LeaveType(){Id = 1 , Name = "Annual" , DefaultDaysPerYear = 28 , isPaid = true   },
                new LeaveType(){Id = 2 , Name = "Sick" , DefaultDaysPerYear = 7 , isPaid = true   },
                new LeaveType(){Id = 3 , Name = "Casual" , DefaultDaysPerYear = 14 , isPaid = true   },
            };

            builder.Entity<LeaveType>().HasData(leaveTypes);
        }




                
        }
    }

                
  


     