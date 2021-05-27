using System;
using System.Collections.Generic;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.DemandVouchers
{
    [Serializable]
    public class Transaction : ILogo, ISpecialCode, ISourceIndex, IDataReference, IProjectCode
    {
        public virtual Nullable<decimal> Amount { get; set; }
        public virtual Nullable<decimal> CancAmount{ get; set; }
        public virtual Nullable<decimal> Price{ get; set; }
        public virtual Nullable<decimal> MeetAmount{ get; set; }
        public virtual Nullable<decimal> UnitConv1{ get; set; }
        public virtual Nullable<decimal> UnitConv2{ get; set; }
        public virtual Nullable<decimal> MeetType{ get; set; }
        public virtual Nullable<DateTime> ProcureDate{ get; set; }
        public virtual Nullable<short> RealSrcIndex{ get; set; }
        public virtual Nullable<short> FactoryNr{ get; set; }
        public virtual string Description{ get; set; }
        public virtual Nullable<short> Status{ get; set; }
        public virtual Nullable<short> LineType{ get; set; }
        public virtual Nullable<int> LineNo{ get; set; }
        public virtual string UserName{ get; set; }
        public virtual Nullable<DateTime> FicheDate { get; set; }
        public virtual Nullable<int> MrpHeadType{ get; set; }
        public virtual string ArpCode{ get; set; }
        public virtual string ArpName{ get; set; }
        public virtual string ItemCode{ get; set; }
        public virtual string ItemName{ get; set; }
        public virtual string PayCode{ get; set; }
        public virtual Nullable<short> CardType{ get; set; }
        public virtual string UnitCode{ get; set; }
        public virtual Nullable<int> OrdPegUse{ get; set; }
        public virtual Nullable<int> CrossAccRef{ get; set; }
        public virtual string Guid{ get; set; }
        public virtual Nullable<short> PrCurr{ get; set; }
        public virtual Nullable<decimal> PrPrice{ get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> SourceIndex { get; set; }
        public virtual Nullable<int> DataReference{ get; set; }
        public virtual string ProjectCode{ get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFlds { get; set; }
        #endregion
    }
}
