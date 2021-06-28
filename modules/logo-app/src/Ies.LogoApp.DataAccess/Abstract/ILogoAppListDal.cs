using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.LogoApp.Entities;

namespace Ies.LogoApp.Abstract
{
    public interface ILogoAppListDal<TGetListDto> : ILogoAppDal where TGetListDto : IDto
    {
        Task<List<TGetListDto>> GetListAsync(IListRequestDto listRequest);
        Task<PagedResultDto<TGetListDto>> GetPageListAsync(IDetailedPagedRequestDto detailedPagedRequest);
        Task<long> CountAsync(IFilterDto filter = null);
    }
}
