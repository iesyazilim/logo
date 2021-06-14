using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.SalesPeople
{
    public class Salesman : AuditedAggregateRoot, IDataNo, IAuxilCode, IAuthCode, IRecordStatus
    {
        public string DataNumber { get => Code; set => Code = value; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Position { get; set; }
        public virtual int FirmNo { get; set; }
        public virtual int Targets { get; set; }
        public virtual Nullable<int> Type { get; set; }

        #region Implementation
        public virtual string AuxilCode { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual Nullable<short> RecordStatus { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Cls> ClList { get; }
        #endregion

        public override LogoObjectType GetRootElementName()
        {
            switch (Type)
            {
                case 0:
                default:
                    return LogoObjectType.NOXMLCLASS_15;

                case 1:
                    return LogoObjectType.NOXMLCLASS_65;
            }
        }
    }
}
