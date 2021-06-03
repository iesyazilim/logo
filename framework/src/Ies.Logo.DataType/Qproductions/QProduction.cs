using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Qproductions
{
    [Serializable]
    public class QProduction : AuditedAggregateRoot, ISpecialCode, IDepartment, ISourceIndex, IXmlAttribute, IProjectCode, INotes, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.QPRODUCTIONS;

        public virtual string Ficheno { get; set; }
        public virtual Nullable<int> Orderref { get; set; }
        public virtual string Orderfcno { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Ftime { get; set; }
        public virtual string ItemCode { get; set; }
        public virtual string Uedit { get; set; }
        public virtual string Uunit { get; set; }
        public virtual Nullable<decimal> Amount { get; set; }
        public virtual Nullable<short> Prodtype { get; set; }
        public virtual Nullable<decimal> Lostfactor { get; set; }
        public virtual Nullable<short> CalcOption { get; set; }
        public virtual string Def { get; set; }
        public virtual Nullable<short> CreateStfiches { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<short> SourceIndex { get; set; }
        public virtual Nullable<int> XmlAttribute { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
        public string DataNumber { get => Ficheno; set => Ficheno = value; }
        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
