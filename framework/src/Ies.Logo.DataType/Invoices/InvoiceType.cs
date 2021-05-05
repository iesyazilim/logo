using System;
using System.Xml.Serialization;

namespace Ies.Logo.DataType.Invoices
{
    [Serializable]
    public enum InvoiceType : byte
    {
        #region Purchase

        [XmlEnum("1")]
        Purchase = 1,

        [XmlEnum("4")]
        PurchaseService = 4,

        [XmlEnum("5")]
        PurchaseProforma = 5,

        [XmlEnum("6")]
        PurchaseReturn = 6,

        [XmlEnum("13")]
        PurchasePriceDifference = 13,

        #endregion

        #region Sales

        [XmlEnum("2")]
        SalesRetailReturn = 2,

        [XmlEnum("3")]
        SalesWholesaleReturn = 3,

        [XmlEnum("7")]
        SalesRetail = 7,

        [XmlEnum("8")]
        SalesWholesale = 8,

        [XmlEnum("9")]
        SalesService = 9,

        [XmlEnum("10")]
        SalesProforma = 10,

        [XmlEnum("14")]
        SalesPriceDifference = 14
        #endregion
    }
}
