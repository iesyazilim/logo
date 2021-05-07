using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.QcList;

namespace Ies.Logo.DataType.SlDetails
{
    [Serializable]
    public class SerialLotTrn : ILogo, IDataSiteId, IDataReference, IConvFacts
    {
        public virtual Nullable<int> SourceMtSiteid { get; set; }
        public virtual Nullable<int> SourceMtReference { get; set; }
        public virtual Nullable<int> SourceSltSiteid { get; set; }
        public virtual Nullable<int> SourceSltReference { get; set; }
        public virtual Nullable<decimal> SourceQuantity { get; set; }
        public virtual Nullable<int> IoCode { get; set; }
        public virtual Nullable<short> SourceWh { get; set; }
        public virtual Nullable<int> SlType { get; set; }
        public virtual string SlCode { get; set; }
        public virtual string LocationCode { get; set; }
        public virtual string DestLocationCode { get; set; }
        public virtual Nullable<decimal> MuQuantity { get; set; }
        public virtual Nullable<decimal> Quantity { get; set; }
        public virtual Nullable<decimal> RemQuantity { get; set; }
        public virtual Nullable<decimal> LuRemQuantity { get; set; }
        public virtual Nullable<DateTime> DateExpired { get; set; }
        public virtual Nullable<int> RateScore { get; set; }
        public virtual Nullable<decimal> OutCost { get; set; }
        public virtual Nullable<decimal> TcOutCost { get; set; }
        public virtual Nullable<decimal> PrcdifCost { get; set; }
        public virtual Nullable<decimal> TcPrcdifCost  { get; set; }
        public virtual Nullable<short> SlQcOk { get; set; }
        public virtual Nullable<short> SourceType { get; set; }
        public virtual Nullable<int> WfStatus { get; set; }
        public virtual Nullable<int> SourceDistSlSiteid { get; set; }
        public virtual Nullable<int> SourceDistSlReference { get; set; }
        public virtual Nullable<decimal> GrossuInfo1 { get; set; }
        public virtual Nullable<decimal> GrossuInfo2 { get; set; }
        public virtual Nullable<decimal> AddTaxPrcost { get; set; }
        public virtual Nullable<decimal> AddTaxPrcostCurr { get; set; }
        public virtual Nullable<decimal> InflationIdx { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual Nullable<int> OrgLinkRef { get; set; }
        public virtual string LineExp { get; set; }
        public virtual string GrpBegCode { get; set; }
        public virtual string GrpEndCode { get; set; }
        public virtual string Guid { get; set; }

        #region Implementation
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string UnitCode { get; set; }
        public virtual Nullable<decimal> UnitConv1 { get; set; }
        public virtual Nullable<decimal> UnitConv2 { get; set; }
        public virtual Nullable<decimal> UnitConv3 { get; set; }
        public virtual Nullable<decimal> UnitConv4 { get; set; }
        public virtual Nullable<decimal> UnitConv5 { get; set; }
        public virtual Nullable<decimal> UnitConv6 { get; set; }
        public virtual Nullable<decimal> UnitConv7 { get; set; }
        public virtual Nullable<decimal> UnitConv8 { get; set; }
        #endregion

        #region SubClasses
        public virtual List<QccValueEntry> QcList { get; set; }
        #endregion
    }
}
