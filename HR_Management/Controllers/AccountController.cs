
using HR_Management.Core.DTOs;
using HR_Management.Core.Identity;
using HR_Management.Core.ServiceContract;
using HR_Management.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace HR_Management.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        private readonly IJWTService _jwt;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AccountController(
            IJWTService jwt,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager
        )
        {
            _jwt = jwt;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
    

     
        [HttpPost("register")]
        public async Task<ActionResult<ApplicationUser>> PostRegister(RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                var errorMsg = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return Problem(detail: errorMsg, statusCode: 400, title: "Validation Error");
            }

            ApplicationUser user = new ApplicationUser()
            {
                Email = registerDTO.Email,
                PhoneNumber = registerDTO.PhoneNumber,
                UserName = registerDTO.Email,
                PersonName = registerDTO.PersonName
            };

            IdentityResult result = await _userManager.CreateAsync(user, registerDTO.Password);
            if (result.Succeeded)
            {
                var hasAdmin = await _userManager.GetUsersInRoleAsync("Admin");

                if (!hasAdmin.Any())
                    {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }
                {

                }
                await _signInManager.SignInAsync(user, isPersistent: false);
            var authenticationResponse= await   _jwt.CreateJWTToken(user);
                user.RefreshToken = authenticationResponse.RefreshToken;
                user.RefrehTokenExpirationDateTime = authenticationResponse.RefrehTokenExpirationDateTime;
                await _userManager.UpdateAsync(user);
                return Ok(authenticationResponse);
            }
            else
            {
                string errorMsg = string.Join(" | ", result.Errors.Select(e => e.Description));
                return Problem(detail: errorMsg, statusCode: 400, title: "Validation Error");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> PostLogin(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                var errorMsg = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return Problem(detail: errorMsg, statusCode: 403, title: "Validation Error");
            }
           var result = await _signInManager.PasswordSignInAsync(loginDTO.Email, loginDTO.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                ApplicationUser? user = await _userManager.FindByEmailAsync(loginDTO.Email);
                if (user == null)
                {
                    return NoContent();
                }
              
                    var authenticationResponse = await _jwt.CreateJWTToken(user);
                user.RefreshToken = authenticationResponse.RefreshToken;
                user.RefrehTokenExpirationDateTime = authenticationResponse.RefrehTokenExpirationDateTime;
                await _userManager.UpdateAsync(user);
                return Ok(authenticationResponse);
                   
                
            }
            else
            {
                return Problem("Invalid Email Or Password");
            }
        }

       
        
        [HttpGet("logout")]
        [Authorize]
        public async Task<IActionResult> GetLogOut()
        {
            await _signInManager.SignOutAsync();
            return NoContent();
       
        
        }

        [HttpPost("ChangePassword")]
        [Authorize]
        public async Task<IActionResult> PostChangePassword (ChangePasswordDTO passwordDTO)
        {
            if (!ModelState.IsValid)
            {
                var errorMsg = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return Problem(detail: errorMsg, statusCode: 400, title: "Validation Error");
            }

          

        

            var user = await _userManager.GetUserAsync(User);
            if(user == null)
            {
                return Unauthorized("User Not Found");
            }
            var result = await _userManager.ChangePasswordAsync(user, passwordDTO.CurrentPassword, passwordDTO.NewPassword);

            if(result .Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);
                var authenticationResponse = await _jwt.CreateJWTToken(user);
                user.RefreshToken = authenticationResponse.RefreshToken;
                user.RefrehTokenExpirationDateTime = authenticationResponse.RefrehTokenExpirationDateTime;
                await _userManager.UpdateAsync(user);
                return Ok(authenticationResponse);
            }
            else
            {
                string ErrorMsg = string.Join(" | ", result.Errors.Select(e => e.Description));
                return Problem(detail: ErrorMsg, statusCode: 403, title: "Validation Error");
            }



        }
    } 
}
