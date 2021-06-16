using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ies.SampleApp.Items
{
    public interface IItemDal
    {
        Task<List<GetItemListDto>> GetListAsync();
    }
}
