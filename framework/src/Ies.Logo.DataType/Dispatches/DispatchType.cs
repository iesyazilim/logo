using System.Xml.Serialization;

namespace Ies.Logo.DataType.Dispatches
{
    public enum DispatchType : byte
    {
        #region Purchase

        [XmlEnum("1")]
        Purchase = 1,

        [XmlEnum("5")]
        ConsignmentInDispatch = 5,

        [XmlEnum("6")]
        PurchaseReturn = 6,

        [XmlEnum("10")]
        ConsignmentInReturnDispatch = 10,

        #endregion

        #region Sales

        [XmlEnum("2")]
        SalesRetailReturn = 2,

        [XmlEnum("3")]
        SalesWholesaleReturn = 3,

        [XmlEnum("4")]
        ConsignmentOutReturnDispatch = 4,

        [XmlEnum("7")]
        SalesRetail = 7,

        [XmlEnum("8")]
        SalesWholesale = 8,

        [XmlEnum("9")]
        ConsignmentOutDispatch = 9,

        #endregion
    }
}
