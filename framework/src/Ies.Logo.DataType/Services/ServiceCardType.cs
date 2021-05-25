using System.Xml.Serialization;

namespace Ies.Logo.DataType.Services
{
    public enum ServiceCardType : short
    {
        [XmlEnum("1")]
        Purchase = 1,

        [XmlEnum("3")]
        PurchaseGroup = 3,

        
        [XmlEnum("2")]
        Sales = 2,

        [XmlEnum("4")]
        SalesGroup = 4,
    }
}
