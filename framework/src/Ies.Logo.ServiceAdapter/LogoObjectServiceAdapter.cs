﻿using System;
using System.Threading.Tasks;
using LogoObjectService;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceAdapter : LogoObjectServiceBase
    {
        public LogoObjectServiceAdapter(Action<LogoObjectServiceOption> option) : base(option) { }

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

            var result = await client.AppendDataObjectAsync(new AppendDataObjectRequest
            {
                FirmNr = int.Parse(Option.FirmNumber),
                securityCode = Option.SecurityCode,
                dataXML = xml,
                dataType = dataType,
                LbsLoadPass = Option.Lbsloadpass,
                //paramXML=
            });

            if (result.status == 3)
                return result.dataReference;
            else
                throw new Exception(result.errorString);
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
                LbsLoadPass = Option.Lbsloadpass,
                //paramXML=
            });
            if (result.status != 3)
                throw new Exception(result.errorString);
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
                //paramXML=
            });

            if (result.status == 3)
                return result.dataXML;
            else
                throw new Exception(result.errorString);
        }
    }
}
