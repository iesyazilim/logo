using Ies.Logo.Core.Configuration;

namespace Ies.LogoApp
{
    public class DalBase : IDal
    {
        protected ILogoConnectionConfiguration Configuration { get; }
        public DalBase(ILogoConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
