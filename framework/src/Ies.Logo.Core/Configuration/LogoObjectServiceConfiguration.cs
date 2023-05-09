namespace Ies.Logo.Core.Configuration
{
    public class LogoObjectServiceConfiguration : LogoConfiguration, ILogoObjectServiceConfiguration
    {
        public string EndpointAddress { get; set; }
        public string GeneralEndpointAddress { get; set; }
        public string SecurityCode { get; set; }
        public string Lbsloadpass { get; set; }
        public bool UseCompressedString { get; set; }

        public override string ToString() => $"{FirmNumber}.{FirmPeriod}.{EndpointAddress}";
    }
}
