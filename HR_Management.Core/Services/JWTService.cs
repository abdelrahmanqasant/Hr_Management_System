

using HR_Management.Core.DTOs;
using HR_Management.Core.Identity;
using HR_Management.Core.ServiceContract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Core.Services
{
    public class JWTService : IJWTService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public JWTService(UserManager<ApplicationUser> userManager,IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }
        public async Task<AuthenticationResponse>  CreateJWTToken 
            (ApplicationUser user)
        {
            DateTime expiration = DateTime.UtcNow.AddMinutes(Convert.ToDouble
                (_configuration["JWT:EXPIRATION_MINUTES"]));
            List<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti ,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat , DateTimeOffset.UtcNow
                .ToUnixTimeSeconds().ToString()),
                new Claim(ClaimTypes.NameIdentifier , user.Email) , 
                new Claim(ClaimTypes.Name,user.UserName) ,
                
            };
            if (user.EmployeeId != null)
            {
                claims.Add(new Claim("EmployeeId", user.EmployeeId.ToString()));
            }
            var roles = await _userManager.GetRolesAsync(user);
            foreach(var role in roles)
            {
              claims.Add(new Claim(ClaimTypes.Role,role));
            }
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey
              ( Encoding.UTF8.GetBytes (_configuration["JWT:Key"]));


            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken TokenGenerator = new JwtSecurityToken(
                _configuration["JWT:Issuer"],
                _configuration["JWT:Audience"],
                claims,
                expires  : expiration,
                signingCredentials : signingCredentials

                );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
           string token =  tokenHandler.WriteToken(TokenGenerator);
            return new AuthenticationResponse()
            {
                Token = token,
                Email = user.Email,
                Expiration = expiration,
                PersonName = user.PersonName ,
                RefreshToken = GenerateRefreshToken(),
                RefrehTokenExpirationDateTime = DateTime.Now
                .AddMinutes(Convert.ToInt32(_configuration["RefreshToken:EXPIRATION_MINUTES"]))
            };
            
        }
        public string GenerateRefreshToken()
        {
            Byte[] bytes = new byte[64];
            var randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(bytes);
           return Convert.ToBase64String(bytes);
        }
    }
    
}
