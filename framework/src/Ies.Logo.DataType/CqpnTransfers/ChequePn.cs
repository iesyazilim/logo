using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.CqpnTransfers
{
    [Serializable]
    public class ChequePn : AuditedAggregateRoot, IAuxilCode, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.CQPN_TRANSFERS;

        public virtual Nullable<int> Type { get; set; }
        public virtual Nullable<short> CurrentStatus{ get; set; }
        public string DataNumber { get => Number; set => Number = value; }
        public virtual string Number{ get; set; }
        public virtual string Owing{ get; set; }
        public virtual Nullable<DateTime> DueDate{ get; set; }
        public virtual Nullable<decimal> Amount{ get; set; }
        public virtual Nullable<decimal> TcXrate{ get; set; }
        public virtual Nullable<decimal> TcAmount{ get; set; }
        public virtual Nullable<short> Transferred{ get; set; }
        public virtual string OwnaccCode{ get; set; }
        public virtual string ArpCode{ get; set; }
        public virtual string NewSerialNo{ get; set; }
        public virtual Nullable<short> AffectRisk{ get; set; }
        public virtual string BankTitle{ get; set; }
        public virtual string City{ get; set; }
        public virtual Nullable<short> Currency{ get; set; }
        public virtual Nullable<short> CurrTrans{ get; set; }
        public virtual string BankCode { get; set; }

        #region Implementation
        public virtual string AuxilCode { get; set; }
        #endregion
    }
}
