using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.DataType.ArAps;
using Ies.MultiFirm.ClCards;
using Microsoft.AspNetCore.Mvc;

namespace Ies.MultiFirm.HttpApi.Controllers
{
    [Route("api/clcard")]
    [ApiController]
    public class ClCardController : ControllerBase
    {
        private readonly IClCardService _clCardService;

        public ClCardController(IClCardService clCardService)
        {
            _clCardService = clCardService;
        }

        [HttpGet]
        [Route("get-by-id/{id=}")]
        public async Task<ArAp> GetById(int id) => await _clCardService.GetAsync(id);

        [HttpGet]
        [Route("list")]
        public async Task<List<GetClCardListDto>> GetListAsync() => await _clCardService.GetListAsync();

        [HttpPost]
        [Route("add-or-update")]
        public async Task<int> AddOrUpdate(ArAp arAp) => await _clCardService.AddOrUpdateAsync(arAp);

        [HttpDelete]
        [Route("{id=}")]
        public async Task Delete(int id) => await _clCardService.DeleteAsync(id);
    }
}
