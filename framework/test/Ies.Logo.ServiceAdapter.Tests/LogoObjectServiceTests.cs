using System.Threading.Tasks;
using Ies.Logo.Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ies.Logo.ServiceAdapter
{
    [TestClass]
    public class LogoObjectServiceTests
    {
        LogoObjectServiceBase logoObjectService;

        [TestInitialize]
        public void TestInitialize()
        {
            logoObjectService = new LogoObjectServiceConsole(new LogoObjectServiceConfiguration
            {
                FirmNumber = "001",
                FirmPeriod = "01",
                SecurityCode = "ac110bc3-7808-49c1-bc34-5007cf6b9024",
                EndpointAddress = "http://localhost/LogoObjectService/Service"
            }, new ParameterConfiguration()
            {
                FillAccCodes = 1,
                ReplicMode = 1
            });
        }

        [TestMethod]
        public async Task AppendDataObject()
        {
            string xml = @"<?xml version=""1.0"" encoding=""ISO-8859-9""?>
<ITEMS>
  <ITEM DBOP=""INS"">
    <CODE>P-1</CODE>
    <NAME>Product-1</NAME>
    <CARD_TYPE>1</CARD_TYPE>
    <RECORD_STATUS>0</RECORD_STATUS>
    <DATE_CREATED>11.03.2021</DATE_CREATED>
  </ITEM>
</ITEMS>";
            int dataReference = await logoObjectService.AppendDataObjectAsync(xml);
        }

        [TestMethod]
        public async Task DeleteDataObject()
        {
            await logoObjectService.DeleteDataObjectAsync(0, 2);
        }

        [TestMethod]
        public async Task ReadDataObject()
        {
            var xml = await logoObjectService.ReadDataObjectAsync(0, 1);
        }
    }
}
