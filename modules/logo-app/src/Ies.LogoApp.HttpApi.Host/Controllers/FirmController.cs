using Microsoft.AspNetCore.Mvc;

namespace Ies.LogoApp.Controllers
{
    [Route("api/firm")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        [HttpGet]
        [Route("get-principal")]
        public IActionResult GetPrincipal()
        {
            return Ok(new
            {
                FirmNumber = Request.Cookies["firm-number"],
                FirmPeriod = Request.Cookies["firm-period"],
                EndpointAddress = Request.Cookies["logo-endpoint-address"],
            });
        }

        [HttpPost]
        [Route("set-principal")]
        public IActionResult SetPrincipal(PrincipalInfo principalInfo)
        {
            Response.Cookies.Append("firm-number", principalInfo.FirmNumber);
            Response.Cookies.Append("firm-period", principalInfo.FirmPeriod);
            Response.Cookies.Append("logo-endpoint-address", principalInfo.EndpointAddress);
            return Ok();
        }
    }
    public class PrincipalInfo
    {
        public string FirmNumber { get; set; }
        public string FirmPeriod { get; set; }
        public string EndpointAddress { get; set; }
    }
}
