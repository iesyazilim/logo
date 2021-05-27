using System;
using System.Threading.Tasks;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceConsole : LogoObjectServiceBase
    {
        public LogoObjectServiceConsole(Action<LogoObjectServiceOption> option) : base(option) { }

        public override Task<int> AppendDataObjectAsync(string xml, int dataType = -1)
        {
            Console.WriteLine($"AppendDataObject isteği\nXml={xml}");
            return Task.FromResult(1);
        }

        public override Task DeleteDataObjectAsync(int dataType, int dataReference)
        {
            Console.WriteLine($"DeleteDataObject isteği DataType={dataType} DataReference={dataReference}");
            return Task.CompletedTask;
        }

        public override Task<string> ReadDataObjectAsync(int dataType, int dataReference)
        {
            Console.WriteLine($"ReadDataObject isteği DataType={dataType} DataReference={dataReference}");
            return Task.FromResult(string.Empty);
        }
    }
}
