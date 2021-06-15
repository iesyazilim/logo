using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Ies.LogoApp.Core.Entities;

namespace Ies.LogoApp.Abstract
{
    public interface IListDal<TGetListDto> : IDal 
    {
        Task<PagedResultDto<TGetListDto>> GetListAsync(DetailedPagedRequestDto detailedPagedRequest);
        Task<long> CountAsync(Condition conditions = null);
    }
}
