using Ies.Logo.Core.Configuration;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceConfiguration : LogoConfiguration, ILogoObjectServiceConfiguration
    {
        public string EndpointAddress { get; set; }
        public string SecurityCode { get; set; }
        public string Lbsloadpass { get; set; }
        public bool UseCompressedString { get; set; }

        public override string ToString() => $"{FirmNumber}.{FirmPeriod}.{EndpointAddress}";
    }
}
