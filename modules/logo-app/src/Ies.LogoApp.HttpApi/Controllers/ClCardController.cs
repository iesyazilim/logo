using Ies.Logo.DataType.ArAps;
using Ies.LogoApp.Abstract;
using Ies.LogoApp.ClCards;
using Microsoft.AspNetCore.Mvc;

namespace Ies.LogoApp.Controllers
{
    [Route("api/logo-app/clcard")]
    [ApiController]
    public class ClCardController : LogoAppControllerBase<ArAp, GetClCardListDto>
    {
        private readonly IClCardService _clCardService;

        public ClCardController(IClCardService clCardService) : base(clCardService)
        {
            _clCardService = clCardService;
        }
    }
}
