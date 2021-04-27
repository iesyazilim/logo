using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Invoices
{
    [Serializable]
    public class PreAccLn : ILogo, ICancelled, IDataSiteId, IXmlAttribute, IDataReference, IProjectCode
    {
        public virtual Nullable<int> LineNr { get; set; }
        public virtual Nullable<decimal> DistRate { get; set; }
        public virtual Nullable<int> LineExcType { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Tsign { get; set; }
        public virtual Nullable<int> WfStatus { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual Nullable<int> Month { get; set; }
        public virtual Nullable<int> Year { get; set; }
        public virtual Nullable<int> PrevLineType { get; set; }
        public virtual Nullable<int> ModulNr { get; set; }
        public virtual string CenterCode { get; set; }
        public virtual string CenterName { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual Nullable<decimal> CredebNet { get; set; }
        public virtual Nullable<decimal> EdtCredebNet { get; set; }
        public virtual Nullable<decimal> EmuCredebNet { get; set; }

        #region Implementation
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> XmlAttribute { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string ProjectCode { get; set; }
        #endregion
    }
}
