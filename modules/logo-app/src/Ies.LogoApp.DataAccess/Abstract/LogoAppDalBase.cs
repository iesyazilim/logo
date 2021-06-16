using Ies.Logo.Core.Configuration;

namespace Ies.LogoApp.Abstract
{
    public abstract class LogoAppDalBase : ILogoAppDal
    {
        protected ILogoConnectionConfiguration Configuration { get; }
        public LogoAppDalBase(ILogoConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
