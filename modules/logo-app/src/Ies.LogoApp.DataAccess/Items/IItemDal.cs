using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Ies.LogoApp.Core.Entities;

namespace Ies.LogoApp.Items
{
    public interface IItemDal : IDal
    {
        Task<PagedResultDto<GetItemListDto>> GetListAsync(PagedRequestDto pagedRequest);
        Task<long> CountAsync(Condition conditions);
    }
}
