﻿namespace Ies.Logo.Core.Configuration
{
    public interface ILogoObjectServiceConfiguration : ILogoConfiguration
    {
        string EndpointAddress { get; set; }
        string GeneralEndpointAddress { get; set; }
        string ServiceKey { get; set; }
        string SecurityCode { get; set; }
        string Lbsloadpass { get; set; }
        bool UseCompressedString { get; set; }
    }
}
