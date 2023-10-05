using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Ies.Logo.Core.Configuration;
using Ies.Logo.Core.Extensions;
using LogoObjectService;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceAdapter : LogoObjectServiceBase
    {
        private string _parameterXml;
        public LogoObjectServiceAdapter(ILogoObjectServiceConfiguration configuration, IParameterConfiguration parameter) : base(configuration, parameter)
        {
            if (parameter == null)
                parameter = new Parameter()
                {
                    ReplicMode = 1,
                    FillAccCodes = 1
                };

            var _parameter = new Parameter()
            {
                ApplyCampaign = parameter.ApplyCampaign,
                ApplyCondition = parameter.ApplyCondition,
                CheckParams = parameter.CheckParams,
                CheckRight = parameter.CheckRight,
                FillAccCodes = parameter.FillAccCodes,
                FormSeriLotLines = parameter.FormSeriLotLines,
                ReplicMode = parameter.ReplicMode,
                SetClientInfo = parameter.SetClientInfo
            };
            _parameterXml = _parameter.Serialize();
        }

        public SvcClient CreateClient()
        {
            var binding = new BasicHttpBinding
            {
                CloseTimeout = new TimeSpan(5, 0, 0),
                OpenTimeout = new TimeSpan(5, 0, 0),
                ReceiveTimeout = new TimeSpan(5, 0, 0),
                SendTimeout = new TimeSpan(5, 0, 0)
            };

            SvcClient client = new SvcClient();
            if (!string.IsNullOrEmpty(Configuration.EndpointAddress))
            {
                client.Endpoint.Address = new EndpointAddress(Configuration.EndpointAddress);
                binding.Security.Mode = Configuration.EndpointAddress.IndexOf("HTTPS", StringComparison.OrdinalIgnoreCase) >= 0
                    ? BasicHttpSecurityMode.Transport
                    : BasicHttpSecurityMode.None;
            }

            client.Endpoint.Binding = binding;
            return client;
        }

        public async override Task<int> AppendDataObjectAsync(string xml, int dataType = -1, Parameter parameter = null)
        {
            SvcClient client = CreateClient();
            CheckDataType(xml, ref dataType);

            var result = await client.AppendDataObjectAsync(new AppendDataObjectRequest
            {
                FirmNr = int.Parse(Configuration.FirmNumber),
                securityCode = Configuration.SecurityCode,
                dataXML = xml,
                dataType = dataType,
                LbsLoadPass = Configuration.Lbsloadpass,
                paramXML = CheckParamterXml(parameter, _parameterXml)
            });

            if (result.status == 3)
                return result.dataReference;
            else
                throw new LogoObjectServiceException(result.errorString, xml);
        }

        public async override Task DeleteDataObjectAsync(int dataType, int dataReference)
        {
            SvcClient client = CreateClient();
            var result = await client.DeleteDataObjectAsync(new DeleteDataObjectRequest
            {
                FirmNr = int.Parse(Configuration.FirmNumber),
                securityCode = Configuration.SecurityCode,
                dataType = dataType,
                dataReference = dataReference,
                LbsLoadPass = Configuration.Lbsloadpass
            });
            if (result.status != 3)
                throw new LogoObjectServiceException(result.errorString);
        }

        public async override Task<string> ReadDataObjectAsync(int dataType, int dataReference)
        {
            SvcClient client = CreateClient();

            var result = await client.ReadDataObjectAsync(new ReadDataObjectRequest
            {
                FirmNr = int.Parse(Configuration.FirmNumber),
                securityCode = Configuration.SecurityCode,
                dataType = dataType,
                dataReference = dataReference,
                LbsLoadPass = Configuration.Lbsloadpass,
                //paramXML = _parameterXml
            });

            if (result.status == 3)
                return result.dataXML;
            else
                throw new LogoObjectServiceException(result.errorString);
        }
    }
}
