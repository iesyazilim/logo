using System.Collections.Generic;
using System.Security.Claims;

namespace Ies.Logo.Core.Security
{
    public static class LogoClaimsHelper
    {
        public static ClaimsIdentity CreateIdentity(string firmNumber, string firmPeriod, string endpointAddress, short? userNumber = null)
        {
            var claims = new List<Claim>()
            {
                new Claim(LogoClaimTypes.FirmNumber, firmNumber),
                new Claim(LogoClaimTypes.FirmPeriod, firmPeriod),
                new Claim(LogoClaimTypes.EndpointAddress, endpointAddress),
            };

            if (userNumber.HasValue && userNumber.Value > 0)
                claims.Add(new Claim(LogoClaimTypes.UserNumber, userNumber.ToString()));

            var claimsIdentity = new ClaimsIdentity(claims);

            return claimsIdentity;
        }

        public static ClaimsPrincipal CreatePrincipal(string firmNumber, string firmPeriod, string endpointAddress, short? userNumber = null)
        {
            var identity = CreateIdentity(firmNumber, firmPeriod, endpointAddress, userNumber);

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            return claimsPrincipal;
        }
    }
}
