using System;
using System.Threading.Tasks;

namespace Ies.Logo.ServiceAdapter
{
    public abstract class LogoObjectServiceBase
    {
        public LogoObjectServiceOption Option { get; }

        public LogoObjectServiceBase(Action<LogoObjectServiceOption> option)
        {
            Option = new LogoObjectServiceOption();
            option.Invoke(Option);
        }

        public abstract Task<int> AppendDataObjectAsync(string xml, int dataType = -1);
        public abstract Task DeleteDataObjectAsync(int dataType, int dataReference);
        public abstract Task<string> ReadDataObjectAsync(int dataType, int dataReference);
    }
}
