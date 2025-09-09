using HR_Management.Core.Entities.Leaves;
using HR_Management.Core.ServiceContract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HR_Management.Infrastructure.DataSeeding;
public static class LeaveBalanceSeeder
{
    public static async Task SeedLeaveBalances(IUnitOfWork unitOfWork)
    {
        var employees = await unitOfWork.EmployeeRepository.GetAllAsync();

        // Dictionary: LeaveTypeId => TotalDays
        var leaveTypesDict = new Dictionary<int, int>
        {
            { 1, 28 }, // Annual
            { 2, 7  }, // Sick
            { 3, 14 }  // Casual
        };

        foreach (var emp in employees)
        {
            foreach (var kvp in leaveTypesDict)
            {
                int leaveTypeId = kvp.Key;
                int totalDays = kvp.Value;

                // تحقق لو الرصيد موجود مسبقاً
                var existing = unitOfWork.LeaveBalanceRepository
                                .GetElement(lb => lb.EmployeeId == emp.Id && lb.LeaveTypeId == leaveTypeId);
                if (existing != null) continue;

                var leaveBalance = new LeaveBalance
                {
                    EmployeeId = emp.Id,
                    LeaveTypeId = leaveTypeId,
                    TotalDays = totalDays,
                    UsedDays = 0
                };

            await    unitOfWork.LeaveBalanceRepository.AddAsync(leaveBalance);
            }
        }

        await unitOfWork.SaveChangesAsync();
    }
}