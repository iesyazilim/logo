using Ies.Logo.Core.Configuration;

namespace Ies.Logo.ServiceAdapter
{
    public interface ILogoObjectServiceConfiguration : ILogoConfiguration
    {
        string EndpointAddress { get; set; }
        string SecurityCode { get; set; }
        string Lbsloadpass { get; set; }
        bool UseCompressedString { get; set; }
    }
}
