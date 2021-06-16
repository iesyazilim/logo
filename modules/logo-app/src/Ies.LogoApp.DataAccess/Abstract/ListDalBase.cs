using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Dapper;
using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Core.Entities;

namespace Ies.LogoApp.Abstract
{
    public abstract class ListDalBase<TGetListDto> : DalBase, IListDal<TGetListDto>
    {
        protected virtual string QueryBase { get; set; }
        protected virtual string ListQuery { get; set; }
        protected virtual string CountQuery { get; set; }

        public ListDalBase(ILogoConnectionConfiguration configuration) : base(configuration)
        {
            ListQuery = "SELECT * FROM List {where} {order} {offset}";
            CountQuery = "SELECT COUNT(*) FROM List {where}";
        }

        public async Task<List<TGetListDto>> GetListAsync(ListRequestDto listRequest)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, ListQuery);

                query = query.Replace("{firm}", Configuration.FirmNumber)
                             .Replace("{period}", Configuration.FirmPeriod)
                             .Replace("{where}", listRequest.Conditions.GetFilterQuery(out IDictionary<string, object> parameters))
                             .Replace("{order}", string.IsNullOrEmpty(listRequest.OrderBy) ? string.Empty : "ORDER BY " + listRequest.OrderBy)
                             .Replace("{offset}", string.Empty);

                return (await connection.QueryAsync<TGetListDto>(query, parameters)).ToList();
            }
        }

        public async Task<PagedResultDto<TGetListDto>> GetPageListAsync(DetailedPagedRequestDto detailedPagedRequest)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, ListQuery);

                query = query.Replace("{firm}", Configuration.FirmNumber)
                             .Replace("{period}", Configuration.FirmPeriod)
                             .Replace("{where}", detailedPagedRequest.Conditions.GetFilterQuery(out IDictionary<string, object> parameters))
                             .Replace("{order}", "ORDER BY " + (string.IsNullOrEmpty(detailedPagedRequest.OrderBy) ? "Id" : detailedPagedRequest.OrderBy))
                             .Replace("{offset}", "OFFSET (@Page-1)*@PageSize ROWS FETCH NEXT @PageSize ROWS ONLY");

                parameters = parameters ?? new Dictionary<string, object>();
                parameters.Add("Page", detailedPagedRequest.Page);
                parameters.Add("PageSize", detailedPagedRequest.PageSize);

                var items = (await connection.QueryAsync<TGetListDto>(query, parameters)).ToList();

                var totalCount = await CountAsync(detailedPagedRequest.Conditions);

                return new PagedResultDto<TGetListDto>(
                            detailedPagedRequest.Page,
                            (int)Math.Ceiling((decimal)totalCount / detailedPagedRequest.PageSize),
                            detailedPagedRequest.PageSize,
                            totalCount,
                            items);
            }
        }

        public async Task<long> CountAsync(Condition conditions = null)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, CountQuery);

                query = query.Replace("{firm}", Configuration.FirmNumber)
                             .Replace("{period}", Configuration.FirmPeriod)
                             .Replace("{where}", conditions.GetFilterQuery(out IDictionary<string, object> parameters));

                return await connection.QueryFirstOrDefaultAsync<long>(query, parameters);
            }
        }
    }
}
