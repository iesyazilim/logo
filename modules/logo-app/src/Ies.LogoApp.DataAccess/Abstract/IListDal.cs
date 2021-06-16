using System.Collections.Generic;
using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Ies.LogoApp.Core.Entities;

namespace Ies.LogoApp.Abstract
{
    public interface IListDal<TGetListDto> : IDal 
    {
        Task<List<TGetListDto>> GetListAsync(ListRequestDto listRequest);
        Task<PagedResultDto<TGetListDto>> GetPageListAsync(DetailedPagedRequestDto detailedPagedRequest);
        Task<long> CountAsync(Condition conditions = null);
    }
}
