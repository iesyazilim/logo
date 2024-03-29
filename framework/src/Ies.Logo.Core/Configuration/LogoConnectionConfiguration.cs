﻿using IesGatewayGeneral;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
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

        #region Query

        public T QueryFirst<T>(string query, string parameters = null)
        {
            var result = GetQuery(query, parameters);
            return JsonConvert.DeserializeObject<List<T>>(result).First();
        }
        public T QueryFirstOrDefault<T>(string query, string parameters = null)
        {
            var result = GetQuery(query, parameters);
            return JsonConvert.DeserializeObject<List<T>>(result).FirstOrDefault();
        }
        public List<T> QueryList<T>(string query, string parameters = null)
        {
            var result = GetQuery(query, parameters);
            return JsonConvert.DeserializeObject<List<T>>(result);
        }

        public async Task<T> QueryFirstAsync<T>(string query, string parameters = null)
        {
            var result = await GetQueryAsync(query, parameters);
            return JsonConvert.DeserializeObject<List<T>>(result).First();
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(string query, string parameters = null)
        {
            var result = await GetQueryAsync(query, parameters);
            return JsonConvert.DeserializeObject<List<T>>(result).FirstOrDefault();
        }
        public async Task<List<T>> QueryListAsync<T>(string query, string parameters = null)
        {
            var result = await GetQueryAsync(query, parameters);
            return JsonConvert.DeserializeObject<List<T>>(result);
        }

        #endregion

        #region QueryScalar
        public async Task<T> QueryScalarAsync<T>(string query, string parameters = null)
        {
            var result = await GetQueryAsync(query, parameters);

            var reponse = JsonConvert.DeserializeObject<List<JObject>>(result).ToList();

            if (reponse.Count <= 0)
            {
                return default(T);
            }

            return reponse.FirstOrDefault().Properties().FirstOrDefault().Value.ToObject<T>();
        }
        public T QueryScalar<T>(string query, string parameters = null)
        {
            var result = GetQuery(query, parameters);

            var reponse = JsonConvert.DeserializeObject<List<JObject>>(result).ToList();

            if (reponse.Count <= 0)
            {
                return default(T);
            }

            return reponse.FirstOrDefault().Properties().FirstOrDefault().Value.ToObject<T>();
        }

        public async Task<List<T>> QueryListScalarAsync<T>(string query, string parameters = null)
        {
            var result = await GetQueryAsync(query, parameters);

            var list = new List<T>();

            var reponse = JsonConvert.DeserializeObject<List<JObject>>(result).ToList();

            foreach (var item in reponse)
            {
                list.Add(item.Properties().FirstOrDefault().Value.ToObject<T>());
            }

            return list;
        }
        public List<T> QueryListScalar<T>(string query, string parameters = null)
        {
            var result = GetQuery(query, parameters);

            var list = new List<T>();

            var reponse = JsonConvert.DeserializeObject<List<JObject>>(result).ToList();

            foreach (var item in reponse)
            {
                list.Add(item.Properties().FirstOrDefault().Value.ToObject<T>());
            }

            return list;
        }

        #endregion

        #region QueryPaged

        public async Task<PagedQueryResponse<T>> QueryPagedRequestAsync<T>(string query, string parameters = null)
        {
            var results = await GetQueryMultipleAsync(query, parameters);
            var rows = JsonConvert.DeserializeObject<List<T>>(results.FirstOrDefault());
            return new PagedQueryResponse<T>()
            {
                Rows = rows,
                TotalCount = (int)(JArray.Parse(results.LastOrDefault())).FirstOrDefault()["TotalCount"]
            };
        }
        public PagedQueryResponse<T> QueryPagedRequest<T>(string query, string parameters = null)
        {
            var results = GetQueryMultiple(query, parameters);
            var rows = JsonConvert.DeserializeObject<List<T>>(results.FirstOrDefault());
            return new PagedQueryResponse<T>()
            {
                Rows = rows,
                TotalCount = (int)(JArray.Parse(results.LastOrDefault())).FirstOrDefault()["TotalCount"]
            };
        }

        #endregion

        #region Execute
        public int Execute(string query, string parameters = null)
        {
            return RunExecute(query, parameters);
        }
        public async Task<int> ExecuteAsync(string query, string parameters = null)
        {
            return await RunExecuteAsync(query, parameters);
        }
        #endregion

        #region GatewayRequest
        private GeneralSvcClient CreateClient()
        {
            var binding = new BasicHttpBinding
            {
                CloseTimeout = new TimeSpan(1, 0, 0),
                OpenTimeout = new TimeSpan(1, 0, 0),
                ReceiveTimeout = new TimeSpan(1, 0, 0),
                SendTimeout = new TimeSpan(1, 0, 0),
                MaxReceivedMessageSize = int.MaxValue
            };

            GeneralSvcClient client = new GeneralSvcClient();

            if (!string.IsNullOrEmpty(GeneralEndpointAddress))
            {
                client.Endpoint.Address = new EndpointAddress(GeneralEndpointAddress);
                binding.Security.Mode = GeneralEndpointAddress.IndexOf("HTTPS", StringComparison.OrdinalIgnoreCase) >= 0
                    ? BasicHttpSecurityMode.Transport
                    : BasicHttpSecurityMode.None;
            }

            client.Endpoint.Binding = binding;
            return client;
        }

        private async Task<string> GetQueryAsync(string query, string parameters = null)
        {
            var client = CreateClient();

            var result = await client.GetQueryAsync(query, parameters, ServiceKey);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }

        private string GetQuery(string query, string parameters = null)
        {
            var client = CreateClient();

            var result = client.GetQuery(query, parameters, ServiceKey);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }

        private async Task<List<string>> GetQueryMultipleAsync(string query, string parameters = null)
        {
            var client = CreateClient();

            var result = await client.GetMultipleQueryAsync(query, parameters, ServiceKey);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }

        private List<string> GetQueryMultiple(string query, string parameters = null)
        {
            var client = CreateClient();

            var result = client.GetMultipleQuery(query, parameters, ServiceKey);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }

        private async Task<int> RunExecuteAsync(string query, string parameters = null)
        {
            var client = CreateClient();

            var result = await client.ExecuteAsync(query, parameters, ServiceKey);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }

        private int RunExecute(string query, string parameters = null)
        {
            var client = CreateClient();

            var result = client.Execute(query, parameters, ServiceKey);

            if (!result.IsSuccess)
                throw new Exception(result.Error);

            return result.Value;
        }
        #endregion
    }
}
