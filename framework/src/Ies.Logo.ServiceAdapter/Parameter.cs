using Ies.Logo.Core.Configuration;
using System;
using System.Xml.Serialization;

namespace Ies.Logo.ServiceAdapter
{
    [Serializable]
    [XmlRoot("Parameters")]
    public class Parameter : ParameterConfiguration
    {
    }
}
