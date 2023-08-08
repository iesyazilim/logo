using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Ies.Logo.Core.Configuration
{
    public interface ILogoConnectionConfiguration : ILogoObjectServiceConfiguration
    {
        SqlConnection Create();

        Task<T> QueryFirstAsync<T>(string query, string parameters = null);
        Task<List<T>> QueryListAsync<T>(string query, string parameters = null);

        Task<T> QueryScalarAsync<T>(string query, string parameters = null);
        Task<List<T>> QueryListScalarAsync<T>(string query, string parameters = null);

        Task<PagedQueryResponse<T>> QueryPagedRequestAsync<T>(string query, string parameters = null);
        Task<List<string>> GetQueryMultipleAsync(string query, string parameters = null);
    }
}
