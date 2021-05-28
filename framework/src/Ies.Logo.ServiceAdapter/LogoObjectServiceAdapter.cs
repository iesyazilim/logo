using System;
using System.Threading.Tasks;
using Ies.Logo.Core.Extensions;
using LogoObjectService;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceAdapter : LogoObjectServiceBase
    {
        private Parameter _parameter;
        private string _parameterXml;
        public LogoObjectServiceAdapter(Action<LogoObjectServiceOption> option) : base(option)
        {
            _parameter = new Parameter();
            _parameter.Period = short.Parse(Option.FirmPeriod);
            _parameterXml = _parameter.Serialize();
        }

        public SvcClient CreateClient()
        {
            SvcClient client = new SvcClient();
            if (!string.IsNullOrEmpty(Option.EndpointAddress))
                client.Endpoint.Address = new System.ServiceModel.EndpointAddress(Option.EndpointAddress);
            return client;
        }

        public async override Task<int> AppendDataObjectAsync(string xml, int dataType = -1)
        {
            SvcClient client = CreateClient();
            CheckDataType(xml, ref dataType);

            var result = await client.AppendDataObjectAsync(new AppendDataObjectRequest
            {
                FirmNr = int.Parse(Option.FirmNumber),
                securityCode = Option.SecurityCode,
                dataXML = xml,
                dataType = dataType,
                LbsLoadPass = Option.Lbsloadpass,
                paramXML = _parameterXml
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
                FirmNr = int.Parse(Option.FirmNumber),
                securityCode = Option.SecurityCode,
                dataType = dataType,
                dataReference = dataReference,
                LbsLoadPass = Option.Lbsloadpass
            });
            if (result.status != 3)
                throw new LogoObjectServiceException(result.errorString);
        }

        public async override Task<string> ReadDataObjectAsync(int dataType, int dataReference)
        {
            SvcClient client = CreateClient();

            var result = await client.ReadDataObjectAsync(new ReadDataObjectRequest
            {
                FirmNr = int.Parse(Option.FirmNumber),
                securityCode = Option.SecurityCode,
                dataType = dataType,
                dataReference = dataReference,
                LbsLoadPass = Option.Lbsloadpass,
                paramXML = _parameterXml
            });

            if (result.status == 3)
                return result.dataXML;
            else
                throw new LogoObjectServiceException(result.errorString);
        }
    }
}
