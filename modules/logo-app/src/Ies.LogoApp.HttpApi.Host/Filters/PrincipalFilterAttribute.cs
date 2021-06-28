using System.Threading;
using Ies.Logo.Core.Security;
using Ies.LogoApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ies.LogoApp.Filters
{
    public class PrincipalFilterAttribute : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (typeof(FirmController) == (context.ActionDescriptor as ControllerActionDescriptor).ControllerTypeInfo) return;

            var firmNumber = context.HttpContext.Request.Cookies["firm-number"];
            var firmPeriod = context.HttpContext.Request.Cookies["firm-period"];
            var endpoint = context.HttpContext.Request.Cookies["logo-endpoint-address"];

            if (string.IsNullOrWhiteSpace(firmNumber) || string.IsNullOrWhiteSpace(firmPeriod) || string.IsNullOrWhiteSpace(endpoint))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            Thread.CurrentPrincipal = LogoClaimsHelper.CreatePrincipal(firmNumber, firmPeriod, endpoint);
        }
    }
}
