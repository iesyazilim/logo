using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;
using Ies.LogoApp.Entities;

namespace Ies.LogoApp.Abstract
{
    public abstract class LogoAppManagerBase<TEntity,TGetListDto> 
        : LogoCrudManager<TEntity>, ILogoAppService<TEntity, TGetListDto>
        where TEntity : ILogoBase, new()
        where TGetListDto : IDto
    {
        private readonly ILogoAppListDal<TGetListDto> _dal;

        public LogoAppManagerBase(
            ILogoConnectionConfiguration configuration,
            ILogoRepository<TEntity> repository,
            ILogoAppListDal<TGetListDto> dal) 
            : base(configuration, repository)
        {
            _dal = dal;
        }

        public virtual async Task<long> CountAsync(IFilterDto filter = null) => await _dal.CountAsync(filter);

        public virtual async Task<List<TGetListDto>> GetListAsync(IListRequestDto listRequest) => await _dal.GetListAsync(listRequest);

        public virtual async Task<PagedResultDto<TGetListDto>> GetPageListAsync(IDetailedPagedRequestDto detailedPagedRequest) => await _dal.GetPageListAsync(detailedPagedRequest);
    }
}
