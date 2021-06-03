using System;
using System.Threading.Tasks;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceConsole : LogoObjectServiceBase
    {
        public LogoObjectServiceConsole(ILogoObjectServiceConfiguration configuration) : base(configuration) { }

        public override Task<int> AppendDataObjectAsync(string xml, int dataType = -1)
        {
            CheckDataType(xml, ref dataType);
            Console.WriteLine($"AppendDataObject isteği DataType={dataType}\nXml={xml}");
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
            switch (dataType)
            {
                case 0:
                    return Task.FromResult(@"<?xml version=""1.0"" encoding=""ISO-8859-9""?>
<ITEMS>
  <ITEM DBOP=""INS"">
    <CODE>P-1</CODE>
    <NAME>Product-1</NAME>
    <CARD_TYPE>1</CARD_TYPE>
    <DATE_CREATED>25.03.2021</DATE_CREATED>
  </ITEM>
</ITEMS>");

                default:
                    return Task.FromResult(string.Empty);
            }
        }
    }
}
