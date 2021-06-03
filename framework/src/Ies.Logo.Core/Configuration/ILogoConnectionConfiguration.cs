using System.Data.SqlClient;

namespace Ies.Logo.Core.Configuration
{
    public interface ILogoConnectionConfiguration : ILogoObjectServiceConfiguration
    {
        SqlConnection Create();
    }
}
