using System.Linq;
using System.Security.Claims;
using Ies.Logo.Core.Security;

namespace System.Security.Principal
{
    public static class LogoClaimsIdentityExtensions
    {
        public static string FindFirmNumber(this ClaimsPrincipal principal)
        {
            var firmNumber = principal.Claims?.FirstOrDefault(c => c.Type == LogoClaimTypes.FirmNumber);
            if (firmNumber == null || string.IsNullOrEmpty(firmNumber.Value))
            {
                return null;
            }

            return firmNumber.Value;
        }

        public static string FindFirmPeriod(this ClaimsPrincipal principal)
        {
            var firmPeriod = principal.Claims?.FirstOrDefault(c => c.Type == LogoClaimTypes.FirmPeriod);
            if (firmPeriod == null || string.IsNullOrEmpty(firmPeriod.Value))
            {
                return null;
            }

            return firmPeriod.Value;
        }

        public static string FindEndpointAddress(this ClaimsPrincipal principal)
        {
            var endpointAddress = principal.Claims?.FirstOrDefault(c => c.Type == LogoClaimTypes.EndpointAddress);
            if (endpointAddress == null || string.IsNullOrEmpty(endpointAddress.Value))
            {
                return null;
            }

            return endpointAddress.Value;
        }

        public static short? FindUserNumber(this ClaimsPrincipal principal)
        {
            var userNumber = principal.Claims?.FirstOrDefault(c => c.Type == LogoClaimTypes.UserNumber);

            if (userNumber == null || string.IsNullOrEmpty(userNumber.Value))
            {
                return null;
            }

            if (short.TryParse(userNumber.Value, out short result))
            {
                return result;
            }

            return null;
        }
    }
}
