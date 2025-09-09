using AutoMapper;
using HR_Management.Core.DTOs.WebApplication.Company;
using HR_Management.Core.Entities;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    
    public class CompaniesController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CompaniesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
           
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/Companies
        [HttpGet]
      
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            var companies = await _unitOfWork.CompanyRepository.GetAllAsync(IncludeWord: "Departments");
           
            var CompaniesDTO = _mapper.Map<IEnumerable<CompaniesListVM>>(companies);
            return Ok(CompaniesDTO);
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
    
        public async Task<ActionResult<CompanyVM>> GetCompany(int id)
        {
            var company = await _unitOfWork.CompanyRepository
                .GetElement(x => x.Id == id, IncludeWord: "Departments");
            var CompanyDTO = _mapper.Map<CompanyVM>(company);

            if (CompanyDTO == null)
            {
                return NotFound();
            }

            return CompanyDTO;
        }

           [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutCompany(int id, UpdateCompanyVM companyVM)
        {
            if (id != companyVM.Id)
            {
                return BadRequest();
            }
            Company CompanyInDb = await _unitOfWork.CompanyRepository.GetElement(x => x.Id == id);
           
            

           if(CompanyInDb == null)
            {
                return NotFound();
            }
            _mapper.Map(companyVM, CompanyInDb);
            _unitOfWork.CompanyRepository.Update(CompanyInDb);
            await _unitOfWork.SaveChangesAsync();
            return Ok(CompanyInDb);
        }

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Company>> PostCompany(CreateCompanyVM CreateCompany)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var AddCompany = _mapper.Map<Company>(CreateCompany);
            await _unitOfWork.CompanyRepository.AddAsync(AddCompany);
            await _unitOfWork.SaveChangesAsync();
            return Ok(AddCompany);

            
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company =
                await _unitOfWork.CompanyRepository.GetElement(x=>x.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            _unitOfWork.CompanyRepository.Remove(company);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }


    }
}
