using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.SampleApp.Items;
using Microsoft.AspNetCore.Mvc;

namespace Ies.SampleApp.HttpApi.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<GetItemListDto>> GetListAsync() => await _itemService.GetListAsync();
    }
}
