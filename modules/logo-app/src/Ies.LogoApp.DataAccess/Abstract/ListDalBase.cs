using System.Collections.Generic;
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
            ListQuery = "SELECT * FROM List";
            CountQuery = "SELECT COUNT(*) FROM List";
        }

        public async Task<long> CountAsync(Condition conditions = null)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, CountQuery);
                query = string.Format(query, Configuration.FirmNumber, Configuration.FirmPeriod, conditions.GetFilterQuery(out IDictionary<string, object> parameters));

                return await connection.QueryFirstOrDefaultAsync<long>(query, parameters);
            }
        }

        public Task<PagedResultDto<TGetListDto>> GetListAsync(DetailedPagedRequestDto detailedPagedRequest)
        {
            using (var connection = Configuration.Create())
            {
                string query = string.Concat(QueryBase, ListQuery);
                query = string.Format(query, 
                                      Configuration.FirmNumber,
                                      Configuration.FirmPeriod,
                                      detailedPagedRequest.Conditions.GetFilterQuery(out IDictionary<string, object> parameters));


                //return await connection.QueryFirstOrDefaultAsync<long>(query, parameters);
            }

            throw new System.NotImplementedException();
        }
    }
}
