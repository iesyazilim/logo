using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.GlVouchers
{
    [Serializable]
    public class DistDetail : ILogo, IDataSiteId, IDataReference, IProjectCode, IDepartment
    {
        public virtual Nullable<int> LineNo{ get; set; }
        public virtual Nullable<int> Branch { get; set; }
        public virtual Nullable<decimal> Distrate{ get; set; }
        public virtual Nullable<decimal> Credebnet{ get; set; }
        public virtual Nullable<decimal> Emucredebnet{ get; set; }
        public virtual Nullable<short> CurrGl{ get; set; }
        public virtual Nullable<decimal> TcXrate{ get; set; }
        public virtual Nullable<decimal> TcNet{ get; set; }
        public virtual Nullable<decimal> RcXrate{ get; set; }
        public virtual Nullable<decimal> RcNet { get; set; }
        public virtual Nullable<int> CurrselTotals{ get; set; }
        public virtual Nullable<int> Type { get; set; }
        public virtual Nullable<DateTime> Date{ get; set; }
        public virtual Nullable<int> Tsign { get; set; }
        public virtual Nullable<int> Wfstatus { get; set; }
        public virtual string CenterCode { get; set; }
        public virtual Nullable<decimal> Edtcredebnet{ get; set; }
        public virtual Nullable<int> Status{ get; set; }
        public virtual Nullable<int> Month { get; set; }
        public virtual Nullable<int> Year { get; set; }

        #region Implementation 
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Department { get; set; }
        #endregion
    }
}
