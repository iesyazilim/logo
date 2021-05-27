using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ies.Logo.ServiceAdapter.Tests
{
    [TestClass]
    public class LogoObjectServiceTests
    {
        LogoObjectServiceBase logoObjectService;

        [TestInitialize]
        public void TestInitialize()
        {
            logoObjectService = new LogoObjectServiceConsole(o =>
            {
                o.FirmNumber = "001";
                o.FirmPeriod = "01";
                o.SecurityCode = "ac110bc3-7808-49c1-bc34-5007cf6b9024";
                //o.EndpointAddress = "http://localhost/logoobjectservice";
            });
        }

        [TestMethod]
        public async Task AppendDataObject()
        {
            int dataReference = await logoObjectService.AppendDataObjectAsync("xml örneði");
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
