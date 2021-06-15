using Ies.Logo.Core.Configuration;

namespace Ies.LogoApp
{
    public abstract class DalBase : IDal
    {
        public ILogoConnectionConfiguration Configuration { get; }
        public DalBase(ILogoConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
