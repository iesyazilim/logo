using IesGatewayGeneral;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ies.Logo.Core.Configuration
{
    public class LogoConnectionConfiguration : LogoObjectServiceConfiguration, ILogoConnectionConfiguration
    {
        public string ConnectionString { get; set; }

        public LogoConnectionConfiguration() { }

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

        public async Task<T> QueryFirstAsync<T>(string query, string paramaters)
        {
            var result = await GetQueryAsync(query, paramaters);
            return JsonConvert.DeserializeObject<List<T>>(result).FirstOrDefault();
        }

        public async Task<List<T>> QueryListAsync<T>(string query, string paramaters)
        {
            var result = await GetQueryAsync(query, paramaters);
            return JsonConvert.DeserializeObject<List<T>>(result);
        }

        public async Task<List<string>> GetQueryMultipleAsync(string query, string paramaters)
        {
            var client = CreateClient();

            var result = await client.GetMultipleQueryAsync(query, paramaters);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }

        public async Task<PagedQueryResponse<T>> QueryPagedRequestAsync<T>(string query, string paramaters)
        {
            var results = await GetQueryMultipleAsync(query, paramaters);
            var rows = JsonConvert.DeserializeObject<List<T>>(results.FirstOrDefault());
            return new PagedQueryResponse<T>()
            {
                Rows = rows,
                TotalCount = (int)(JArray.Parse(results.LastOrDefault())).FirstOrDefault()["TotalCount"]
            };
        }

        private GeneralSvcClient CreateClient()
        {
            GeneralSvcClient client = new GeneralSvcClient();
            if (!string.IsNullOrEmpty(GeneralEndpointAddress))
                client.Endpoint.Address = new System.ServiceModel.EndpointAddress(GeneralEndpointAddress);
            client.Endpoint.Binding.CloseTimeout = new TimeSpan(1, 0, 0);
            client.Endpoint.Binding.OpenTimeout = new TimeSpan(1, 0, 0);
            client.Endpoint.Binding.ReceiveTimeout = new TimeSpan(1, 0, 0);
            client.Endpoint.Binding.SendTimeout = new TimeSpan(1, 0, 0);
            return client;
        }

        private async Task<string> GetQueryAsync(string query, string paramaters)
        {
            var client = CreateClient();

            var result = await client.GetQueryAsync(query, paramaters);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }
    }
}
