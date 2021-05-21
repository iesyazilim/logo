using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.DemandPeggings
{
    [Serializable]
    public class DemandPegging : ILogo, IDataSiteId, IDataReference, ISpecialCode, ISourceIndex, IProjectCode
    {
        public virtual Nullable<int> DemandReference{ get; set; }
        public virtual Nullable<int> DemandSiteid{ get; set; }
        public virtual Nullable<int> Parenttype{ get; set; }
        public virtual Nullable<int> ChildType{ get; set; }
        public virtual Nullable<int> ChildReference{ get; set; }
        public virtual Nullable<int> FicheType{ get; set; }
        public virtual Nullable<short> ItemAlter{ get; set; }
        public virtual Nullable<decimal> MeetAmnt{ get; set; }
        public virtual Nullable<decimal> MainMeetAmnt{ get; set; }
        public virtual Nullable<int> OrdPeriod{ get; set; }
        public virtual Nullable<short> LineType{ get; set; }
        public virtual Nullable<short> DetLine{ get; set; }
        public virtual Nullable<int> PrevLineNo{ get; set; }
        public virtual Nullable<int> LineNo{ get; set; }
        public virtual string FicheNo{ get; set; }
        public virtual Nullable<DateTime> FicheDate{ get; set; }
        public virtual string ItemCode{ get; set; }
        public virtual string ItemName{ get; set; }
        public virtual Nullable<decimal> TrAmnt{ get; set; }
        public virtual string UEdit{ get; set; }
        public virtual string BomCode{ get; set; }
        public virtual string BomRevCode{ get; set; }
        public virtual string ArpCode{ get; set; }
        public virtual Nullable<int> Pegref{ get; set; }
        public virtual Nullable<short> Fcnocghd{ get; set; }
        public virtual Nullable<short> Proposal{ get; set; }
        public virtual Nullable<decimal> WaitAmnt{ get; set; }
        public virtual Nullable<int> FactoryNr{ get; set; }
        public virtual Nullable<decimal> Amntconvf { get; set; }
        public virtual string DoCode{ get; set; }
        public virtual string ArpName{ get; set; }
        public virtual Nullable<int> FicStatus{ get; set; }
        public virtual string MainItemCode{ get; set; }
        public virtual string MainItemName{ get; set; }
        public virtual string MainUEdit{ get; set; }
        public virtual Nullable<decimal> Price{ get; set; }
        public virtual string PayplanCode{ get; set; }
        public virtual Nullable<int> Projectref{ get; set; }
        public virtual string Variantcode{ get; set; }
        public virtual string Variantname{ get; set; }

        #region Implementation
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> SourceIndex { get; set; }
        public virtual string ProjectCode { get; set; }
        #endregion
    }
}
