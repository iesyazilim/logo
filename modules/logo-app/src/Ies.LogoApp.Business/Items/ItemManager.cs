using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Items;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;

namespace Ies.LogoApp.Items
{
    public class ItemManager : LogoCrudManager<Item>
    {
        protected IItemDal ItemDal { get; }

        public ItemManager(
           ILogoConnectionConfiguration configuration,
           ILogoRepository<Item> repository,
           IItemDal itemDal)
           : base(configuration, repository)
        {
            ItemDal = itemDal;
        }
    }
}
