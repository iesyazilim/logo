using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Ies.LogoApp.Abstract
{
    public abstract class LogoAppControllerBase<TEntity, TGetListDto> 
        : ControllerBase
        where TEntity : ILogoBase, new()
        where TGetListDto : IDto
    {
        private readonly ILogoAppService<TEntity, TGetListDto> _logoAppService;

        public LogoAppControllerBase(ILogoAppService<TEntity, TGetListDto> logoAppService)
        {
            _logoAppService = logoAppService;
        }

        [HttpPost]
        public virtual async Task<IActionResult> AddOrUpdate(TEntity entity)
        {
            return Ok(await _logoAppService.AddOrUpdateAsync(entity));
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get(int dataReference)
        {
            return Ok(await _logoAppService.GetAsync(dataReference));
        }

    }
}
