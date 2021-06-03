using System.Data.SqlClient;

namespace Ies.Logo.Core.Configuration
{
    public class LogoConnectionConfiguration : LogoObjectServiceConfiguration, ILogoConnectionConfiguration
    {
		protected string ConnectionString { get; }

		public LogoConnectionConfiguration(string connectionString)
		{
			ConnectionString = connectionString;
		}

		public SqlConnection Create()
		{
			SqlConnection connection = new SqlConnection(ConnectionString);
			connection.Open();
			return connection;
		}
	}
}
