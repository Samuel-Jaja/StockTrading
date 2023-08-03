using StockTrading.Core.DTO;
using StockTrading.Core.Identity;
using System.Security.Claims;

namespace StockTrading.Core.ServiceContracts
{
    public interface IJwtService
    {
        AuthenticationResponse CreateJwtToken(ApplicationUser user);
        ClaimsPrincipal? GetPrincipalFromJwtToken(string? token);
    }
}
