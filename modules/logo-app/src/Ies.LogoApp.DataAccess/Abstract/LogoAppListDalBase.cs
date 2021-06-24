using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Dapper;
using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Entities;

namespace Ies.LogoApp.Abstract
{
    public abstract class LogoAppListDalBase<TGetListDto> : LogoAppDalBase, ILogoAppListDal<TGetListDto> where TGetListDto : IDto
    {
        protected virtual string QueryBase { get; set; }
        protected virtual string ListQuery { get; set; }
        protected virtual string CountQuery { get; set; }
        protected virtual Sort DefaultOrder { get; set; }

        public LogoAppListDalBase(ILogoConnectionConfiguration configuration) : base(configuration)
        {
            ListQuery = "SELECT * FROM List {where} {order} {offset}";
            CountQuery = "SELECT COUNT(*) FROM List {where}";
            DefaultOrder = new Sort("Id");
        }

        public virtual async Task<List<TGetListDto>> GetListAsync(IListRequestDto listRequest)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, ListQuery);

                query = query.Replace("{firm}", Configuration.FirmNumber)
                             .Replace("{period}", Configuration.FirmPeriod)
                             .Replace("{where}", listRequest.Conditions.GetFilterQuery<TGetListDto>(out IDictionary<string, object> parameters))
                             .Replace("{order}", listRequest.OrderBy.GetFilterQuery<TGetListDto>())
                             .Replace("{offset}", string.Empty);

                return (await connection.QueryAsync<TGetListDto>(query, parameters)).ToList();
            }
        }

        public virtual async Task<PagedResultDto<TGetListDto>> GetPageListAsync(IDetailedPagedRequestDto detailedPagedRequest)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, ListQuery);

                query = query.Replace("{firm}", Configuration.FirmNumber)
                             .Replace("{period}", Configuration.FirmPeriod)
                             .Replace("{where}", detailedPagedRequest.Conditions.GetFilterQuery<TGetListDto>(out IDictionary<string, object> parameters))
                             .Replace("{order}", detailedPagedRequest.OrderBy.GetFilterQuery<TGetListDto>()?? DefaultOrder.GetFilterQuery<TGetListDto>())
                             .Replace("{offset}", "OFFSET (@Page-1)*@PageSize ROWS FETCH NEXT @PageSize ROWS ONLY");

                parameters = parameters ?? new Dictionary<string, object>();
                parameters.Add("Page", detailedPagedRequest.Page);
                parameters.Add("PageSize", detailedPagedRequest.PageSize);

                var items = (await connection.QueryAsync<TGetListDto>(query, parameters)).ToList();
                
                var totalCount = await CountAsync(detailedPagedRequest);

                return new PagedResultDto<TGetListDto>(
                            detailedPagedRequest.Page,
                            (int)Math.Ceiling((decimal)totalCount / detailedPagedRequest.PageSize),
                            detailedPagedRequest.PageSize,
                            totalCount,
                            items);
            }
        }

        public virtual async Task<long> CountAsync(IFilterDto filter = null)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, CountQuery);

                query = query.Replace("{firm}", Configuration.FirmNumber)
                             .Replace("{period}", Configuration.FirmPeriod)
                             .Replace("{where}", filter.Conditions.GetFilterQuery<TGetListDto>(out IDictionary<string, object> parameters));

                return await connection.QueryFirstOrDefaultAsync<long>(query, parameters);
            }
        }
    }
}
