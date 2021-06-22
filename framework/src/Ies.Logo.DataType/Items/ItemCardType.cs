using System.Xml.Serialization;

namespace Ies.Logo.DataType.Items
{
    public enum ItemCardType : short
    {
        [XmlEnum("1")]
        CommercialItem = 1,

        [XmlEnum("2")]
        CompositePack = 2,

        [XmlEnum("3")]
        ReturnableItem = 3,

        [XmlEnum("4")]
        FixedAsset = 4,

        [XmlEnum("10")]
        RawMaterial = 10,

        [XmlEnum("11")]
        SemiItem = 11,

        [XmlEnum("12")]
        EndItem = 12,

        [XmlEnum("13")]
        ConsumerItem = 13,

        [XmlEnum("20")]
        GeneralMaterialClass = 20,

        [XmlEnum("21")]
        TableMaterialClass = 21
    }
}
