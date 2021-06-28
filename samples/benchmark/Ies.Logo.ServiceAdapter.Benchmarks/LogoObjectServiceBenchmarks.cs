using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Ies.Logo.Core.Configuration;

namespace Ies.Logo.ServiceAdapter
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [MemoryDiagnoser]
    public class LogoObjectServiceBenchmarks
    {
        private LogoObjectServiceBase logoObjectService;

        [GlobalSetup]
        public void Setup()
        {
            logoObjectService = new LogoObjectServiceAdapter(new LogoObjectServiceConfiguration
            {
                FirmNumber = "001",
                FirmPeriod = "01",
                SecurityCode = "ac110bc3-7808-49c1-bc34-5007cf6b9024",
                EndpointAddress = "http://localhost/LogoObjectService/Service"
            });
        }

        [Benchmark]
        public async Task ReadDataObjectAsync()
        {
            await logoObjectService.ReadDataObjectAsync(0, 1);
        }
    }
}
