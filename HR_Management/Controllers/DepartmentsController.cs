using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.Company;
using HR_Management.Core.DTOs.WebApplication.Department;
using HR_Management.Core.Entities;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DepartmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentsController(IUnitOfWork unitOfWork,IMapper mapper)
        {
           
           _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/Departments
        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            var departments = await _unitOfWork.DepartmentRepository.GetAllAsync(IncludeWord: "Employees,Company");
            var DepartmentsDTO = _mapper.Map<IEnumerable<DepartmentVM>>(departments);
            return Ok(DepartmentsDTO);
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
     
        public async Task<ActionResult<DepartmentVM>> GetDepartment(int id)
        {
            var department = await _unitOfWork.DepartmentRepository.GetElement(x => x.Id == id,IncludeWord : "Employees,Company");
            var DepartentDTO = _mapper.Map<DepartmentVM>(department);

            if (DepartentDTO == null)
            {
                return NotFound();
            }

            return DepartentDTO;
        }

         [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutDepartment(int id, EditDepartmentVM departmentVM)
        {
            if (id != departmentVM.Id)
            {
                return BadRequest();
            }
            Department DepartmentInDb = await _unitOfWork.DepartmentRepository.GetElement(x => x.Id == id,IncludeWord: "Employees,Company");



            if (DepartmentInDb == null)
            {
                return NotFound();
            }
            _mapper.Map(departmentVM, DepartmentInDb);
            _unitOfWork.DepartmentRepository.Update(DepartmentInDb);
            await _unitOfWork.SaveChangesAsync();
            var updatedDepartment = await _unitOfWork.DepartmentRepository.GetElement(x => x.Id == DepartmentInDb.Id, IncludeWord: "Employees,Company");
            var DepartmentDTO = _mapper.Map<DepartmentVM>(updatedDepartment);
            return Ok(DepartmentDTO);
        }

       
        

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Department>> PostDepartment(CreateDepartmentVM department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var addDepartment = _mapper.Map<Department>(department);
          await  _unitOfWork.DepartmentRepository.AddAsync(addDepartment);
            await _unitOfWork.SaveChangesAsync();
            var DepartmentWithCompany = await _unitOfWork.DepartmentRepository.GetElement(x => x.Id == addDepartment.Id, IncludeWord: "Company");
            var departmentDTO = _mapper.Map<DepartmentVM>(DepartmentWithCompany);
            return Ok(departmentDTO);
          
        }

            
        

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            Department departmentInDB =
              await  _unitOfWork.DepartmentRepository.GetElement(x => x.Id == id);
            if(departmentInDB == null)
            {
                return NotFound();
            }
            _unitOfWork.DepartmentRepository.Remove(departmentInDB);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }

     
    }
}
