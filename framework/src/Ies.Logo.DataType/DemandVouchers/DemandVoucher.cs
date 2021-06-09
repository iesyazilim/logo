using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.DemandVouchers
{
    [Serializable]
    public class DemandVoucher : AuditedAggregateRoot, ISpecialCode, ISourceIndex, IDepartment, IProjectCode, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.DEMAND_FICHES;

        public string DataNumber { get => Number; set => Number = value; }
        public virtual string Number { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string DoCode { get; set; }
        public virtual Nullable<short> FactoryNr { get; set; }
        public virtual Nullable<short> Branch { get; set; }
        public virtual Nullable<short> Status { get; set; }
        public virtual Nullable<short> UserNo { get; set; }
        public virtual string MpsCode { get; set; }
        public virtual Nullable<short> LineCnt { get; set; }
        public virtual string Itext { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> SourceIndex { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual string ProjectCode { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
