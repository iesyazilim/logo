using Ies.Logo.Core.Configuration;

namespace Ies.Logo.Manager
{
    public class LogoManager : ILogoService
    {
        protected ILogoConnectionConfiguration Configuration { get; }

        public LogoManager(ILogoConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
