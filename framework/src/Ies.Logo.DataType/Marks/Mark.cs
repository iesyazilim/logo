using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Marks
{
    [Serializable]
    public class Mark : AuditedAggregateRoot, ISpecialCode, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.MARKS;

        public virtual string Code { get; set; }
        public virtual string Descr { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        #endregion
    }
}
