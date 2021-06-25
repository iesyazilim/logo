using BenchmarkDotNet.Running;

namespace Ies.Logo.ServiceAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<LogoObjectServiceBenchmarks>();
        }
    }
}
