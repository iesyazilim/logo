using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ies.Logo.Core;
using Ies.Logo.Core.Configuration;
using Ies.Logo.Core.Extensions;

namespace Ies.Logo.ServiceAdapter
{
    public abstract class LogoObjectServiceBase : ILogoObjectService
    {
        protected ILogoObjectServiceConfiguration Configuration { get; }
        protected IParameterConfiguration Parameter { get; }

        public LogoObjectServiceBase(ILogoObjectServiceConfiguration configuration, IParameterConfiguration parameter)
        {
            Configuration = configuration;
            Parameter = parameter;
        }

        public void CheckDataType(string xml, ref int dataType)
        {
            if (dataType == -1)
            {
                dataType = (int)(LogoObjectType)(Enum.Parse(typeof(LogoObjectType), XDocument.Parse(xml).Root.Name.LocalName));
            }
        }

        public string CheckParamterXml(Parameter parameter, string parameterXml) => parameter != null ? parameter.Serialize() : parameterXml;

        public abstract Task<int> AppendDataObjectAsync(string xml, int dataType = -1, Parameter parameter = null);
        public abstract Task DeleteDataObjectAsync(int dataType, int dataReference);
        public abstract Task<string> ReadDataObjectAsync(int dataType, int dataReference);
    }
}
