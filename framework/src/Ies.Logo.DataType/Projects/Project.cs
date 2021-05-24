using System;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Projects
{
    public class Project : AuditedAggregateRoot, ISpecialCode, IRecordStatus, IDataSiteId
    {
        public static string XmlRoot => "PROJECTS";

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProjRespons { get; set; }
        public virtual Nullable<DateTime> BeginDate { get; set; }
        public virtual Nullable<DateTime> EndDate { get; set; }
        public virtual Nullable<int> Wfstatus { get; set; }
        public virtual Nullable<short> Active { get => RecordStatus; set => RecordStatus = value; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion
    }
}
