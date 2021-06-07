using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.DataType.Items;
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
        [Route("get-by-id/{id=}")]
        public async Task<Item> GetById(int id) => await _itemService.GetAsync(id);

        [HttpGet]
        [Route("list")]
        public async Task<List<GetItemListDto>> GetListAsync() => await _itemService.GetListAsync();

        [HttpPost]
        [Route("add-or-update")]
        public async Task<int> AddOrUpdate(Item item) => await _itemService.AddOrUpdateAsync(item);

        [HttpDelete]
        [Route("{id=}")]
        public async Task Delete(int id) => await _itemService.DeleteAsync(id);
    }
}
