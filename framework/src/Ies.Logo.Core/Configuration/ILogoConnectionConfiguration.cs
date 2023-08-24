using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Ies.Logo.Core.Configuration
{
    public interface ILogoConnectionConfiguration : ILogoObjectServiceConfiguration
    {
        SqlConnection Create();

        T QueryFirst<T>(string query, string parameters = null);
        T QueryFirstOrDefault<T>(string query, string parameters = null);
        List<T> QueryList<T>(string query, string parameters = null);
        Task<T> QueryFirstAsync<T>(string query, string parameters = null);
        Task<T> QueryFirstOrDefaultAsync<T>(string query, string parameters = null);
        Task<List<T>> QueryListAsync<T>(string query, string parameters = null);

        T QueryScalar<T>(string query, string parameters = null);
        List<T> QueryListScalar<T>(string query, string parameters = null);
        Task<T> QueryScalarAsync<T>(string query, string parameters = null);
        Task<List<T>> QueryListScalarAsync<T>(string query, string parameters = null);

        PagedQueryResponse<T> QueryPagedRequest<T>(string query, string parameters = null);
        Task<PagedQueryResponse<T>> QueryPagedRequestAsync<T>(string query, string parameters = null);

        int Execute(string query, string parameters = null);
        Task<int> ExecuteAsync(string query, string parameters = null);
    }
}
