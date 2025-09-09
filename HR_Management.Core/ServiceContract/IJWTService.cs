using HR_Management.Core.DTOs;
using HR_Management.Core.Identity;

namespace HR_Management.Core.ServiceContract
{
    public interface IJWTService
    {
       Task< AuthenticationResponse> CreateJWTToken(ApplicationUser user );
    }
}
