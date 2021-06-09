using Ies.Logo.Core.Configuration;

namespace Ies.MultiFirm.Configuration
{
    public interface ILogoExtendedConfiguration : ILogoConnectionConfiguration
    {
        string OldFirmNumber { get; set; }
        string OldFirmPeriod { get; set; }
    }
}
