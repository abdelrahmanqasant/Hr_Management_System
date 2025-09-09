using HR_Management.Core.Entities;
using System.Collections.Generic;

namespace HR_Management.Infrastructure.DataSeeding
{
    public static class DataSeed
    {
        public static List<Employee> Employees = new List<Employee>()


            {
                new Employee { Id = 1, FullName = "Ahmed Ali",DateOfBirth = new DateTime(1996,5,25),PhoneNumber = "011111111111", Title = "Software Engineer",Address = "Castle Rd", Salary = 15000, DepartmentId = 1, HireDate = new DateTime(2020, 1, 15), Email = "ahmed.ali@example.com" },
                new Employee { Id = 2, FullName = "Mona Hassan", Title = "HR Manager",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1997,7,21),Address = "Pear St",Salary = 18000, DepartmentId = 2, HireDate = new DateTime(2018, 5, 20), Email = "mona.hassan@example.com" },
                new Employee { Id = 3, FullName = "Omar Khaled", Title = "Frontend Developer",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1998,5,25),Address = "Cedar St", Salary = 14000, DepartmentId = 3, HireDate = new DateTime(2021, 3, 10), Email = "omar.khaled@example.com" },
                new Employee { Id = 4, FullName = "Sara Ibrahim", Title = "Backend Developer",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1991,5,25),Address = "Castle Rd", Salary = 15500, DepartmentId =4, HireDate = new DateTime(2019, 7, 5), Email = "sara.ibrahim@example.com" },
                new Employee { Id = 5, FullName = "Youssef Mohamed",Title = "Team Lead",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1992,5,25),Address = "Castle Rd", Salary = 22000, DepartmentId = 5, HireDate = new DateTime(2016, 11, 1), Email = "youssef.mohamed@example.com" },
                new Employee { Id = 6, FullName = "Nadia Fathy", Title = "Recruiter",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1988,5,25),Address = "Birch St", Salary = 12000, DepartmentId = 5, HireDate = new DateTime(2021, 9, 18), Email = "nadia.fathy@example.com" },
                new Employee { Id = 7, FullName = "Karim Adel",Title = "QA Engineer",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1989,5,25),Address = "Peach St",Salary = 13500, DepartmentId = 6, HireDate = new DateTime(2020, 6, 25), Email = "karim.adel@example.com" },
                new Employee { Id = 8, FullName = "Laila Samir", Title = "UI/UX Designer",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1987,5,25),Address = "Castle Rd", Salary = 16000, DepartmentId = 7, HireDate = new DateTime(2019, 4, 15), Email = "laila.samir@example.com" },
                new Employee { Id = 9, FullName = "Hossam Ezzat", Title = "Project Manager",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1995,5,25),Address = "Plum St", Salary = 25000, DepartmentId = 8, HireDate = new DateTime(2015, 2, 10), Email = "hossam.ezzat@example.com" },
                new Employee { Id = 10, FullName = "Mai Tarek", Title = "Intern",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1994,5,25),Address = "Berry St", Salary = 5000, DepartmentId = 9, HireDate = new DateTime(2023, 6, 1), Email = "mai.tarek@example.com" },
                new Employee { Id = 11, FullName = "Adel Magdy",Title = "System Administrator",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1999,5,25),Address = "Stone Rd", Salary = 14500, DepartmentId = 10, HireDate = new DateTime(2019, 8, 12), Email = "adel.magdy@example.com" },
                new Employee { Id = 12, FullName = "Nourhan Ahmed", Title = "Marketing Specialist",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1996,5,25),Address = "Bridge Rd", Salary = 13000, DepartmentId = 11, HireDate = new DateTime(2020, 3, 7), Email = "nourhan.ahmed@example.com" },
                new Employee { Id = 13, FullName = "Mohamed Reda", Title = "Senior Developer",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1991,5,25),Address = "Tower St", Salary = 20000, DepartmentId = 12, HireDate = new DateTime(2017, 10, 19), Email = "mohamed.reda@example.com" },
                new Employee { Id = 14, FullName = "Aya Gamal", Title = "Content Writer",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1993,5,25),Address = "Castle Rd", Salary = 11000, DepartmentId = 13, HireDate = new DateTime(2021, 1, 22), Email = "aya.gamal@example.com" },
                new Employee { Id = 15, FullName = "Tamer Saad", Title = "Finance Manager",PhoneNumber = "011111111111",DateOfBirth = new DateTime(1998,5,25),Address = "Castle Rd", Salary = 24000, DepartmentId = 14, HireDate = new DateTime(2014, 12, 3), Email = "tamer.saad@example.com" },



        };
            



        public static List<Company> companies = new List<Company>()
        {
            new Company { Id = 1, Name = "Tech Solutions Ltd", Industry = "Technology", Address = "123 Silicon Ave, San Francisco, CA", Departments = new List<Department> {
                new Department { Id = 1, Name = "Software", CompanyId = 1 },
                new Department { Id = 2, Name = "Hardware", CompanyId = 1 },
                new Department { Id = 3, Name = "AI Research", CompanyId = 1 }
            }},
            new Company { Id = 2, Name = "PharmaLife Inc", Industry = "Pharmaceuticals", Address = "456 Health St, Boston, MA", Departments = new List<Department> {
                new Department { Id = 4, Name = "Research", CompanyId = 2 },
                new Department { Id = 5, Name = "Manufacturing", CompanyId = 2 },
                new Department { Id = 6, Name = "Distribution", CompanyId = 2 }
            }},
            new Company { Id = 3, Name = "LabGear Corp", Industry = "Laboratory Equipment", Address = "789 Lab Rd, Chicago, IL", Departments = new List<Department> {
                new Department { Id = 7, Name = "Microscopes", CompanyId = 3 },
                new Department { Id = 8, Name = "Testing Kits", CompanyId = 3 },
                new Department { Id = 9, Name = "Protective Gear", CompanyId = 3 }
            }},
            new Company { Id = 4, Name = "Real Estate Group", Industry = "Real Estate", Address = "101 Property Ln, New York, NY", Departments = new List<Department> {
                new Department { Id = 10, Name = "Residential", CompanyId = 4 },
                new Department { Id = 11, Name = "Commercial", CompanyId = 4 },
                new Department { Id = 12, Name = "Industrial", CompanyId = 4 }
            }},
            new Company { Id = 5, Name = "GreenTech Solutions", Industry = "Technology", Address = "202 Eco Blvd, Seattle, WA", Departments = new List<Department> {
                new Department { Id = 13, Name = "Software", CompanyId = 5 },
                new Department { Id = 14, Name = "Hardware", CompanyId = 5 },
                new Department { Id = 15, Name = "AI Research", CompanyId = 5 }
            }},
            new Company { Id = 6, Name = "MediCare Pharma", Industry = "Pharmaceuticals", Address = "303 Wellness St, Austin, TX", Departments = new List<Department> {
                new Department { Id = 16, Name = "Research", CompanyId = 6 },
                new Department { Id = 17, Name = "Manufacturing", CompanyId = 6 },
                new Department { Id = 18, Name = "Distribution", CompanyId = 6 }
            }},
            new Company { Id = 7, Name = "LabTech Inc", Industry = "Laboratory Equipment", Address = "404 Science Pkwy, San Diego, CA", Departments = new List<Department> {
                new Department { Id = 19, Name = "Microscopes", CompanyId = 7 },
                new Department { Id = 20, Name = "Testing Kits", CompanyId = 7 },
                new Department { Id = 21, Name = "Protective Gear", CompanyId = 7 }
            }},
            new Company { Id = 8, Name = "Urban Realty", Industry = "Real Estate", Address = "505 City St, Miami, FL", Departments = new List<Department> {
                new Department { Id = 22, Name = "Residential", CompanyId = 8 },
                new Department { Id = 23, Name = "Commercial", CompanyId = 8 },
                new Department { Id = 24, Name = "Industrial", CompanyId = 8 }
            }},
            new Company { Id = 9, Name = "NextGen Tech", Industry = "Technology", Address = "606 Innovation Rd, Austin, TX", Departments = new List<Department> {
                new Department { Id = 25, Name = "Software", CompanyId = 9 },
                new Department { Id = 26, Name = "Hardware", CompanyId = 9 },
                new Department { Id = 27, Name = "AI Research", CompanyId = 9 }
            }},
            new Company { Id = 10, Name = "HealthPlus Pharma", Industry = "Pharmaceuticals", Address = "707 Cure Ave, Chicago, IL", Departments = new List<Department> {
                new Department { Id = 28, Name = "Research", CompanyId = 10 },
                new Department { Id = 29, Name = "Manufacturing", CompanyId = 10 },
                new Department { Id = 30, Name = "Distribution", CompanyId = 10 }
            }},
            new Company { Id = 11, Name = "BioLab Corp", Industry = "Laboratory Equipment", Address = "808 Lab St, Boston, MA", Departments = new List<Department> {
                new Department { Id = 31, Name = "Microscopes", CompanyId = 11 },
                new Department { Id = 32, Name = "Testing Kits", CompanyId = 11 },
                new Department { Id = 33, Name = "Protective Gear", CompanyId = 11 }
            }},
            new Company { Id = 12, Name = "Skyline Realty", Industry = "Real Estate", Address = "909 Urban Ave, Los Angeles, CA", Departments = new List<Department> {
                new Department { Id = 34, Name = "Residential", CompanyId = 12 },
                new Department { Id = 35, Name = "Commercial", CompanyId = 12 },
                new Department { Id = 36, Name = "Industrial", CompanyId = 12 }
            }},
            new Company { Id = 13, Name = "Innovatech Solutions", Industry = "Technology", Address = "111 Tech Blvd, San Jose, CA", Departments = new List<Department> {
                new Department { Id = 37, Name = "Software", CompanyId = 13 },
                new Department { Id = 38, Name = "Hardware", CompanyId = 13 },
                new Department { Id = 39, Name = "AI Research", CompanyId = 13 }
            }},
            new Company { Id = 14, Name = "Wellness Pharma", Industry = "Pharmaceuticals", Address = "222 Care St, Houston, TX", Departments = new List<Department> {
                new Department { Id = 40, Name = "Research", CompanyId = 14 },
                new Department { Id = 41, Name = "Manufacturing", CompanyId = 14 },
                new Department { Id = 42, Name = "Distribution", CompanyId = 14 }
            }},
            new Company { Id = 15, Name = "Precision Labs", Industry = "Laboratory Equipment", Address = "333 Science Rd, Philadelphia, PA", Departments = new List<Department> {
                new Department { Id = 43, Name = "Microscopes", CompanyId = 15 },
                new Department { Id = 44, Name = "Testing Kits", CompanyId = 15 },
                new Department { Id = 45, Name = "Protective Gear", CompanyId = 15 }
            }},
            new Company { Id = 16, Name = "Metro Realty", Industry = "Real Estate", Address = "444 Property Ln, Denver, CO", Departments = new List<Department> {
                new Department { Id = 46, Name = "Residential", CompanyId = 16 },
                new Department { Id = 47, Name = "Commercial", CompanyId = 16 },
                new Department { Id = 48, Name = "Industrial", CompanyId = 16 }
            }},
            new Company { Id = 17, Name = "FutureTech Ltd", Industry = "Technology", Address = "555 Innovation Dr, Austin, TX", Departments = new List<Department> {
                new Department { Id = 49, Name = "Software", CompanyId = 17 },
                new Department { Id = 50, Name = "Hardware", CompanyId = 17 },
                new Department { Id = 51, Name = "AI Research", CompanyId = 17 }
            }},
            new Company { Id = 18, Name = "CureAll Pharma", Industry = "Pharmaceuticals", Address = "666 Wellness Blvd, Miami, FL", Departments = new List<Department> {
                new Department { Id = 52, Name = "Research", CompanyId = 18 },
                new Department { Id = 53, Name = "Manufacturing", CompanyId = 18 },
                new Department { Id = 54, Name = "Distribution", CompanyId = 18 }
            }},
            new Company { Id = 19, Name = "LabWorks Inc", Industry = "Laboratory Equipment", Address = "777 Science Ave, Seattle, WA", Departments = new List<Department> {
                new Department { Id = 55, Name = "Microscopes", CompanyId = 19 },
                new Department { Id = 56, Name = "Testing Kits", CompanyId = 19 },
                new Department { Id = 57, Name = "Protective Gear", CompanyId = 19 }
            }},
            new Company { Id = 20, Name = "Prime Realty", Industry = "Real Estate", Address = "888 Urban St, New York, NY", Departments = new List<Department> {
                new Department { Id = 58, Name = "Residential", CompanyId = 20 },
                new Department { Id = 59, Name = "Commercial", CompanyId = 20 },
                new Department { Id = 60, Name = "Industrial", CompanyId = 20 }
            }},
        };
    }
}
