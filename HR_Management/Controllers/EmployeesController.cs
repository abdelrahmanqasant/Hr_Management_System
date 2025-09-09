
using Microsoft.AspNetCore.Mvc;
using HR_Management.Core.Entities.Leaves;   
using HR_Management.Core.Entities;
using HR_Management.Infrastructure.DatabaseContext;
using HR_Management.Core.ServiceContract;
using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.Employee;
using Microsoft.AspNetCore.Authorization;
using HR_Management.Core.Identity;
using Microsoft.AspNetCore.Identity;

namespace HR_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper,UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
           _userManager = userManager;
        }

        // GET: api/Employees
        [HttpGet]

    
        public async Task<ActionResult<IEnumerable<Employee>>>
            GetEmployees()
        {
            var employeesInDB = await _unitOfWork.EmployeeRepository.GetAllAsync(IncludeWord: "Department,Department.Company,leaveBalances,leaveBalances.LeaveType");

           
                var employeesDTO = _mapper.Map<IEnumerable<EmployeesListVM>>(employeesInDB);
            return Ok(employeesDTO);
        }
        [HttpGet("ByCompany/{CompanyId}")]
     
        public async Task<ActionResult<IEnumerable<EmployeesInDepartmentVM>>>
            GetEmployeesByCompany(int CompanyId)
        {
            var employeesInInDB = await _unitOfWork.EmployeeRepository.GetEmployeesByCompanyAsync(CompanyId);

         if(employeesInInDB == null || !employeesInInDB.Any())
            {
                return NotFound();
            }
            var employeesDTO = _mapper.Map<IEnumerable<EmployeesInDepartmentVM>>(employeesInInDB);
            return Ok(employeesDTO);
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
   
        public async Task<ActionResult<EmployeeVM>> GetEmployee(int id)
        {
            var employeeInDb = 
                await _unitOfWork.EmployeeRepository.GetElement(x => x.Id == id, IncludeWord: "Department,Department.Company");

            var employeeDTO = _mapper.Map<EmployeeVM>(employeeInDb);
            if (employeeDTO == null)
            {
                return NotFound();
            }
          
            return employeeDTO;
        }

        // PUT: api/Employees/5
    
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutEmployee(int id, EditEmployeeVM employeeVM)
        {
            if (id != employeeVM.Id)
            {
                return BadRequest();
            }
            Employee employeeInDB = await _unitOfWork.EmployeeRepository.GetElement(x => x.Id == id, IncludeWord: "Department,Department.Company");
            if (employeeInDB == null)
            {
                return NotFound();
            }
            
            _unitOfWork.EmployeeRepository.Update(employeeInDB);
            _mapper.Map(employeeVM, employeeInDB);
            await _unitOfWork.SaveChangesAsync();
            var updatedEmployee = await _unitOfWork.EmployeeRepository.GetElement(x => x.Id == employeeInDB.Id, IncludeWord: "Department,Department.Company");
            var EmployeeDTO = _mapper.Map<EditEmployeeVM>(updatedEmployee);
            return Ok(EmployeeDTO);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Employee>>
            PostEmployee(AddEmployeeVM employeeVM)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = new ApplicationUser()
            {
                UserName = employeeVM.Email,
                Email = employeeVM.Email,
            };
            var result = await _userManager.CreateAsync(user, employeeVM.Password);

            var AddEmployee = _mapper.Map<Employee>(employeeVM);
           await _unitOfWork.EmployeeRepository.AddAsync(AddEmployee);
            await _unitOfWork.SaveChangesAsync();
            var EmployeeWithDeptAndCom = await _unitOfWork.EmployeeRepository
                .GetElement(x => x.Id == AddEmployee.Id, IncludeWord: "Department,Department.Company");
            var EmployeeDTO = _mapper.Map<EmployeeVM>(EmployeeWithDeptAndCom);
            return Ok(EmployeeDTO);
        }
    
        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employeeInDB = await _unitOfWork.EmployeeRepository.GetElement(x => x.Id == id);
            
            if (employeeInDB == null)
            {
                return NotFound();
            }

            _unitOfWork.EmployeeRepository.Remove(employeeInDB);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

     
    }
}
