using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Items;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;
using Ies.LogoApp.DataAccess.Items;

namespace Ies.LogoApp.Business.Items
{
    public class ItemManager : LogoCrudManager<Item>, IItemService
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
