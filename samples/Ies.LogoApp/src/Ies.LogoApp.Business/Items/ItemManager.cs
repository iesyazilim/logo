using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Items;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;

namespace Ies.LogoApp.Business.Items
{
    public class ItemManager : LogoCrudManager<Item>, IItemService
    {
        public ItemManager(ILogoConnectionConfiguration configuration, ILogoRepository<Item> repository) : base(configuration, repository)
        {

        }
    }
}
