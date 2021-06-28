using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.Manager;
using Ies.LogoApp.Entities;

namespace Ies.LogoApp.Abstract
{
    public interface ILogoAppService<TEntity, TGetListDto> 
        : ILogoCrudService<TEntity> 
        where TEntity : ILogoBase, new()
        where TGetListDto : IDto
    {
        Task<List<TGetListDto>> GetListAsync(IListRequestDto listRequest);
        Task<PagedResultDto<TGetListDto>> GetPageListAsync(IDetailedPagedRequestDto detailedPagedRequest);
        Task<long> CountAsync(IFilterDto filter = null);
    }
}
