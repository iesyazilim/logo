using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Items;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;

namespace Ies.SampleApp.Items
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

        public async Task<List<GetItemListDto>> GetListAsync() => await ItemDal.GetListAsync();
    }
}
