using Ies.Logo.DataType.Items;
using Ies.LogoApp.Abstract;
using Ies.LogoApp.Items;
using Microsoft.AspNetCore.Mvc;

namespace Ies.LogoApp.Controllers
{
    [Route("api/logo-app/item")]
    [ApiController]
    public class ItemController : LogoAppControllerBase<Item, GetItemListDto>
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService) : base(itemService)
        {
            _itemService = itemService;
        }

    }
}
