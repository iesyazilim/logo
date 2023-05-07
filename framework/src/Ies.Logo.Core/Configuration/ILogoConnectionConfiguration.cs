using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Ies.Logo.Core.Configuration
{
    public interface ILogoConnectionConfiguration : ILogoObjectServiceConfiguration
    {
        SqlConnection Create();
        Task<T> QueryFirstAsync<T>(string query);
        Task<List<T>> QueryListAsync<T>(string query);
    }
}
