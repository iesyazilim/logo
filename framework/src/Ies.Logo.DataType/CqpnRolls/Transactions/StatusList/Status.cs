using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.CqpnRolls
{
    [Serializable]
    public class Status : ILogo, ICancelled, IDataSiteId, IXmlAttribute, IDataReference
    {
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Trcode { get; set; }
        public virtual Nullable<short> Accounted { get; set; }
        public virtual Nullable<short> Devir { get; set; }
        public virtual Nullable<short> STATUS { get; set; }
        public virtual Nullable<short> Cardmd{ get; set; }
        public virtual Nullable<int> Statno{ get; set; }
        public virtual Nullable<int> Lineno{ get; set; }
        public virtual Nullable<short> Fromcash{ get; set; }
        public virtual Nullable<int> Lineexctyp{ get; set; }
        public virtual Nullable<int> Opstat{ get; set; }
        public virtual Nullable<short> Affectcollatrl{ get; set; }
        public virtual Nullable<short> Affectrisk{ get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual Nullable<short> Usegirorate{ get; set; }
        public virtual Nullable<short> Frombank{ get; set; }
        public virtual string Statstr{ get; set; }
        public virtual string Accstr{ get; set; }
        public virtual string Fcnr{ get; set; }
        public virtual string Fctype{ get; set; }
        public virtual string Cashflag{ get; set; }
        public virtual string BankCode{ get; set; }
        public virtual string BankTitle{ get; set; }
        public virtual string BankBranch{ get; set; }
        public virtual string BankBranchNumber{ get; set; }
        public virtual string BankAccCode{ get; set; }
        public virtual string BankAccTitle{ get; set; }
        public virtual string BankAccNumber{ get; set; }
        public virtual string BankCreCode{ get; set; }

        #region Implementation
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> XmlAttribute { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
        #endregion

    }
}
