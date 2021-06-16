using System.Collections.Generic;
using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.Manager;
using Ies.LogoApp.Core;
using Ies.LogoApp.Core.Entities;

namespace Ies.LogoApp.Abstract
{
    public interface ILogoAppService<TEntity, TGetListDto> 
        : ILogoCrudService<TEntity> 
        where TEntity : ILogoBase, new()
        where TGetListDto : IDto
    {
        Task<List<TGetListDto>> GetListAsync(ListRequestDto listRequest);
        Task<PagedResultDto<TGetListDto>> GetPageListAsync(DetailedPagedRequestDto detailedPagedRequest);
        Task<long> CountAsync(Condition conditions = null);
    }
}
