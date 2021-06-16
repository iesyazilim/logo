using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.DataType.Items;
using Ies.Logo.Manager;

namespace Ies.SampleApp.Items
{
    public interface IItemService : ILogoCrudService<Item>
    {
        Task<List<GetItemListDto>> GetListAsync();
    }
}
