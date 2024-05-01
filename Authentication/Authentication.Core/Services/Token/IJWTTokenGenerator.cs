using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Authentication.Core.Services.Token
{
    public interface IJWTTokenGenerator
    {
        string GenerateToken(IdentityUser user, IList<string> roles, IList<Claim> claims);
    }
}
