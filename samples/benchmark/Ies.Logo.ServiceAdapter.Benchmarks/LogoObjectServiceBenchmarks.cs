using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Ies.Logo.ServiceAdapter
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [MemoryDiagnoser]
    public class LogoObjectServiceBenchmarks
    {

    }
}
