using Ies.Logo.Core.Configuration;

namespace Ies.LogoApp.Abstract
{
    public interface IDal
    {
        ILogoConnectionConfiguration Configuration { get; }
    }
}
