using System.Threading.Tasks;
using Ies.Logo.DataType.Items;
using Ies.Logo.ServiceAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ies.Logo.Repositories.Tests
{
    [TestClass]
    public class LogoRepositoryTests
    {
        ILogoRepository<Item> logoRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            logoRepository = new LogoRepository<Item>(
            new LogoObjectServiceConsole(o =>
            {
                o.FirmNumber = "001";
                o.FirmPeriod = "01";
                o.SecurityCode = "ac110bc3-7808-49c1-bc34-5007cf6b9024";
                o.EndpointAddress = "http://localhost/LogoObjectService/Service";
            }));
        }

        [TestMethod]
        public void Get()
        {
            Item item = logoRepository.Get(1);
        }

        [TestMethod]
        public void AddOrUpdate()
        {
            int dataReference = logoRepository.AddOrUpdate(new Item
            {
                Code = "~",
            });

            Assert.IsTrue(dataReference > 0);
        }

        [TestMethod]
        public void Delete()
        {
            logoRepository.Delete(2);
        }

        [TestMethod]
        public async Task GetAsync()
        {
            Item item = await logoRepository.GetAsync(1);
        }

        [TestMethod]
        public async Task AddOrUpdateAsync()
        {
            int dataReference = await logoRepository.AddOrUpdateAsync(new Item
            {
                Code = "~",
            });

            Assert.IsTrue(dataReference > 0);
        }

        [TestMethod]
        public async Task DeleteAsync()
        {
            await logoRepository.DeleteAsync(2);
        }
    }
}
