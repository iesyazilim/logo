using Ies.Logo.Core.Configuration;

namespace Ies.LogoApp
{
    public interface IDal
    {
        ILogoConnectionConfiguration Configuration { get; }
    }
}
