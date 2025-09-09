using HR_Management.Core.Identity;
using HR_Management.Core.ServiceContract;
using Microsoft.AspNetCore.Identity;
namespace HR_Management.Infrastructure.DataSeeding;
public static class EmployeeUserSeeder 
{
    public static async Task SeedUsersForEmployeesAsync(
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IUnitOfWork unitOfWork)
    {
        // Ensure "User" role exists
        if (!await roleManager.RoleExistsAsync("User"))
        {
            await roleManager.CreateAsync(new ApplicationRole { Name = "User" });
        }

        // Get all employees without UserId
        var employees = await unitOfWork.EmployeeRepository
            .GetAllAsync(e => e.userId == Guid.Empty || e.userId == null);

        foreach (var emp in employees)
        {
            if (string.IsNullOrWhiteSpace(emp.Email))
            {
                Console.WriteLine($"❌ Employee {emp.FullName} has no email, skipping...");
                continue;
            }

            // Skip if user already exists with this email
            if (await userManager.FindByEmailAsync(emp.Email) != null)
                continue;

            // Create new AspNetUser
            var user = new ApplicationUser
            {
                UserName = emp.Email,
                Email = emp.Email,
                EmailConfirmed = true
            };

            // Default password (you can change it later)
            var result = await userManager.CreateAsync(user, "P@ssword123");

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");

                // Link employee with created user
                emp.userId = user.Id;
                unitOfWork.EmployeeRepository.Update(emp);

                Console.WriteLine($"✅ Created user for {emp.FullName} ({emp.Email})");
            }
            else
            {
                Console.WriteLine($"❌ Failed for {emp.FullName}: {string.Join(",", result.Errors.Select(e => e.Description))}");
            }
        }

        await unitOfWork.SaveChangesAsync();
    }
}
