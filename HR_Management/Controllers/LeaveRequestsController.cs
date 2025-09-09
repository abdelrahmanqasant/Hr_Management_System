using AutoMapper;
using Azure.Core;
using HR_Management.Core.DTOs.WebApplication.LeaveRequest;
using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
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

    public class LeaveRequestsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LeaveRequestsController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/LeaveRequests
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<IEnumerable<LeaveRequestVM>>>
            GetLeaveRequests()
        {
            var RequestsInDb = await _unitOfWork.LeaveRequestRepository.GetAllAsync(IncludeWord: "Employee,LeaveType");
            if (RequestsInDb == null)
                return NotFound();

            var RequestsDTO = _mapper.Map<IEnumerable<LeaveRequestVM>>(RequestsInDb);
            return  Ok(RequestsDTO);
        }
        [HttpGet("MyRequests")]
        [Authorize(Roles = "User,Admin")]
       public async Task<ActionResult<IEnumerable<LeaveRequestVM>>> GetMyRequests()
        {
            var userId = User.FindFirst("EmployeeId")?.Value;
            if(string.IsNullOrEmpty(userId) )
            { 
                return Unauthorized(); 
            }
            int EmployeeId = int.Parse(userId);
            var requests = await _unitOfWork.LeaveRequestRepository.GetRequestsByEmployeeAsync(e => e.Id == EmployeeId,
                IncludeWord : "Employee,LeaveType");
            var dto = _mapper.Map<IEnumerable<LeaveRequestVM>>(requests);
            return Ok(dto);
        }
        // GET: api/LeaveRequests/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<ActionResult<LeaveRequestVM>> GetLeaveRequestById(int id)
        {
            var RequestInDb = await _unitOfWork.LeaveRequestRepository.GetElement(x => x.Id == id, IncludeWord: "Employee,LeaveType");


            if (RequestInDb == null)
            {
                return NotFound();
            }
            var RequestDTO = _mapper.Map<LeaveRequestVM>(RequestInDb);

            return Ok(RequestDTO);
        }

        // PUT: api/LeaveRequests/5
    [HttpPut("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> PutLeaveRequest(int id,[FromBody] EditLeaveRequestVM EditleaveRequestVM)
        {
            var requestInDb = await _unitOfWork.LeaveRequestRepository.GetElement(x => x.Id == id, IncludeWord: "Employee,LeaveType");
            if(requestInDb == null)
            {
                return NotFound();
            }
          
            if(requestInDb.Status != LeaveRequestStatus.Pending)
            {
                return BadRequest("Cannot Change Request Already Took Action");
            }
            var currentUserEmail = User.Identity?.Name;
            if(requestInDb.Employee?.Email != currentUserEmail)
            {
                return Forbid();
            }
             _mapper.Map(EditleaveRequestVM, requestInDb);
             _unitOfWork.LeaveRequestRepository.UpdateLeaveRequest(requestInDb);
            await _unitOfWork.SaveChangesAsync();
            var savedRequest = await _unitOfWork.LeaveRequestRepository.GetElement(r => r.Id == id, IncludeWord: "Employee,LeaveType");
            var result = _mapper.Map<LeaveRequestVM>(savedRequest);

            return Ok(result);
        }
        [HttpPut("{id}/status")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult>
            UpdateStatus(int id,[FromBody]  UpdateLeaveRequestStatus statusVM)
        {
            var request = await _unitOfWork.LeaveRequestRepository.GetElement(x => x.Id == id);
            if(request == null)
            {
                return NotFound();
            }
            if(request.Status != LeaveRequestStatus.Pending)
            {
                return BadRequest("Cannot Change Status For Request Already Took An Action");
            }
            request.Status = statusVM.Status;
            var requestEntity = _mapper.Map<LeaveRequest>(request);
             _unitOfWork.LeaveRequestRepository.UpdateLeaveRequest(requestEntity);
       await     _unitOfWork.SaveChangesAsync();
            return Ok(request);

        }

        // POST: api/LeaveRequests
    [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<LeaveRequest>> PostLeaveRequest([FromBody] AddLeaveRequestVM leaveRequestVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var request = _mapper.Map<LeaveRequest>(leaveRequestVM);
            request.Status = LeaveRequestStatus.Pending;
            await _unitOfWork.LeaveRequestRepository.AddAsync(request);
            await _unitOfWork.SaveChangesAsync();
            var savedRequest = await _unitOfWork.LeaveRequestRepository.GetElement(r => r.Id == request.Id, IncludeWord: "Employee,LeaveType");
            var result = _mapper.Map<LeaveRequestVM>(savedRequest);

            return Ok(result);
        }
        [HttpGet("Employee/{EmployeeId}/summary")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult>
          GetLeaveRequestsSummary(int EmployeeId)
        {
            var requests = await _unitOfWork.LeaveRequestRepository.GetRequestsByEmployeeAsync(x=>x.Id == EmployeeId , IncludeWord: "Employee,LeaveType");
            if (requests == null || !requests.Any())
            {
                return NotFound();
            }
            var summary = new LeaveRequestSummaryVM()
            {
                EmployeeName = requests.First().Employee?.FullName!,
                TotalRequests = requests.Count(),

                ApprovedRequests = requests.Count(a => a.Status == LeaveRequestStatus.Approved),
                PendingRequests = requests.Count(r => r.Status == LeaveRequestStatus.Pending),
                RejectedRequests = requests.Count(r => r.Status == LeaveRequestStatus.Rejected)
            };
            return Ok(summary);
        }


        // DELETE: api/LeaveRequests/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteLeaveRequest(int id)
        {
            var leaveRequest = await _unitOfWork.LeaveRequestRepository.GetElement(x=>x.Id ==id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            _unitOfWork.LeaveRequestRepository.Remove(leaveRequest);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

      
    }
}
