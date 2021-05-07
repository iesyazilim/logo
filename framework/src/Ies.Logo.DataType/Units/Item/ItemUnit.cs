using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Units
{
    [Serializable]
    public class ItemUnit : Unit, IDataReference, IGlobalId, IDataSiteId
    {
        public virtual string Barcode { get; set; }
        public virtual string Barcode2 { get; set; }
        public virtual string Barcode3 { get; set; }
        public virtual Nullable<int> UsefMtrlclass { get; set; }
        public virtual Nullable<int> UsefPurchclas { get; set; }
        public virtual Nullable<int> UsefSalesclas { get; set; }
        public virtual Nullable<int> MtrlPriority { get; set; }
        public virtual Nullable<int> PurchPriority { get; set; }
        public virtual Nullable<int> SalesPriority { get; set; }
        public virtual Nullable<decimal> Width{ get; set; }
        public virtual Nullable<decimal> Lenght { get; set; }
        public virtual Nullable<decimal> Height { get; set; }
        public virtual Nullable<decimal> Area { get; set; }
        public virtual Nullable<decimal> Volume { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual Nullable<decimal> GrossVolume { get; set; }
        public virtual Nullable<decimal> GrossWeight { get; set; }
        public virtual Nullable<decimal> ConvFact1 { get; set; }
        public virtual Nullable<decimal> ConvFact2 { get; set; }
        public virtual Nullable<int> ExtAccFlags { get; set; }
        public virtual string WidthCode { get; set; }
        public virtual string LenghtCode { get; set; }
        public virtual string HeightCode { get; set; }
        public virtual string AreaCode { get; set; }
        public virtual string VolumeCode { get; set; }
        public virtual string WeightCode { get; set; }
        public virtual string GrossVolCode { get; set; }
        public virtual string WithUnitBarcode { get; set; }
        public virtual Nullable<short> WbarcodeShift { get; set; }

        #region Implementation
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string GlobalId { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Barcode> BarcodeList { get; set; }
        #endregion
    }
}
