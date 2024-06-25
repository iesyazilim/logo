using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.OhpAccounts
{
    [Serializable]
    public class OhpAccount : AuditedAggregateRoot, IDetailedAuxilCode, IAuthCode, IRecordStatus
    {
        public static LogoObjectType XmlRoot => LogoObjectType.OHP_ACCOUNTS;

        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual string Unit { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }

        #region Implementation
        public virtual string AuxilCode { get; set; }
        public virtual string AuxilCode2 { get; set; }
        public virtual string AuxilCode3 { get; set; }
        public virtual string AuxilCode4 { get; set; }
        public virtual string AuxilCode5 { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual Nullable<short> RecordStatus { get; set; }
        #endregion
    }
}
