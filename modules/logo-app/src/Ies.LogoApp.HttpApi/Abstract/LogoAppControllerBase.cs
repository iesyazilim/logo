﻿using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;
using Ies.LogoApp.Entities;
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

        [HttpGet]
        public virtual async Task<IActionResult> Get(int id)
        {
            return Ok(await _logoAppService.GetAsync(id));
        }

        [HttpPost]
        public virtual async Task<IActionResult> AddOrUpdate(TEntity entity)
        {
            return Ok(await _logoAppService.AddOrUpdateAsync(entity));
        }

        [HttpDelete]
        public virtual async Task<IActionResult> Delete(int id)
        {
            await _logoAppService.DeleteAsync(id);
            return Ok();
        }

        [HttpPost]
        [Route("list")]
        public virtual async Task<IActionResult> List(ListRequestDto listRequestDto)
        {
            return Ok(await _logoAppService.GetListAsync(listRequestDto));
        }

        [HttpPost]
        [Route("page-list")]
        public virtual async Task<IActionResult> PageList(DetailedPagedRequestDto detailedPagedListRequestDto)
        {
            return Ok(await _logoAppService.GetPageListAsync(detailedPagedListRequestDto));
        }

        [HttpPost]
        [Route("count")]
        public virtual async Task<IActionResult> Count(FilterDto filter)
        {
            return Ok(await _logoAppService.CountAsync(filter));
        }
    }
}
