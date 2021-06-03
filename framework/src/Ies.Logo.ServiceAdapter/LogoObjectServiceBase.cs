using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ies.Logo.Core;

namespace Ies.Logo.ServiceAdapter
{
    public abstract class LogoObjectServiceBase : ILogoObjectService
    {
        protected ILogoObjectServiceConfiguration Configuration { get; }

        public LogoObjectServiceBase(ILogoObjectServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void CheckDataType(string xml, ref int dataType)
        {
            if (dataType == -1)
            {
                dataType = (int)(LogoObjectType)(Enum.Parse(typeof(LogoObjectType), XDocument.Parse(xml).Root.Name.LocalName));
            }
        }

        public abstract Task<int> AppendDataObjectAsync(string xml, int dataType = -1);
        public abstract Task DeleteDataObjectAsync(int dataType, int dataReference);
        public abstract Task<string> ReadDataObjectAsync(int dataType, int dataReference);
    }
}
