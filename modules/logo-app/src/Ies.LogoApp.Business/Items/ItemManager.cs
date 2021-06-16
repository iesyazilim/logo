using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Items;
using Ies.Logo.Repositories;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.Items
{
    public class ItemManager : ManagerBase<Item, GetItemListDto>, IItemService
    {
        protected IItemDal ItemDal { get; }

        public ItemManager(
           ILogoConnectionConfiguration configuration,
           ILogoRepository<Item> repository,
           IItemDal itemDal)
           : base(configuration, repository, itemDal)
        {
            ItemDal = itemDal;
        }
    }
}
