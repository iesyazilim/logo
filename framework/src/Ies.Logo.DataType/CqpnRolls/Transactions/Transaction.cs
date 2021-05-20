using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Auditing;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.CqpnRolls
{
    [Serializable]
    public class Transaction : ILogo, ISpecialCode, IDivision, IAuditedObject, ICancelled, IDataSiteId, IDataReference, IProjectCode
    {
        public virtual Nullable<int> Type { get; set; }
        public virtual Nullable<short> CurrentStatus { get; set; }
        public virtual string BankCode { get; set; }
        public virtual string Number { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual string BankTitle { get; set; }
        public virtual string City { get; set; }
        public virtual string Owing { get; set; }
        public virtual string Guarantor { get; set; }
        public virtual string Guarantor2 { get; set; }
        public virtual string Informant { get; set; }
        public virtual string DivisionNo { get; set; }
        public virtual string AccountNo { get; set; }
        public virtual Nullable<DateTime> DueDate { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<decimal> StampFee { get; set; }
        public virtual Nullable<decimal> Amount { get; set; }
        public virtual Nullable<short> CurrTrans { get; set; }
        public virtual Nullable<decimal> TcXrate { get; set; }
        public virtual Nullable<decimal> TcAmount { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> RcAmount { get; set; }
        public virtual Nullable<short> CreditFlag { get; set; }
        public virtual Nullable<short> Transferred { get; set; }
        public virtual Nullable<decimal> RcXrateColl { get; set; }
        public virtual Nullable<decimal> TcXrateColl { get; set; }
        public virtual Nullable<short> UseRaisedVal { get; set; }
        public virtual Nullable<int> CurrselTrans { get; set; }
        public virtual Nullable<decimal> StampFeeReq { get; set; }
        public virtual Nullable<short> TransStatus { get; set; }
        public virtual Nullable<int> StatusOrder { get; set; }
        public virtual string GlCode1 { get; set; }
        public virtual string OhpCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual string GlCode3 { get; set; }
        public virtual string OhpCode3 { get; set; }
        public virtual Nullable<int> OpStatus { get; set; }
        public virtual string SerialNr { get; set; }
        public virtual Nullable<int> ProjectRef { get; set; }
        public virtual Nullable<int> DataSiteid1 { get; set; }
        public virtual Nullable<int> DataReference1 { get; set; }
        public virtual Nullable<int> XmlAttribute1 { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<int> CollatrlRollref { get; set; }
        public virtual Nullable<int> CollatrlCardref { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual string OrgLogoId1 { get; set; }
        public virtual Nullable<decimal> GiroRcXrate { get; set; }
        public virtual Nullable<decimal> GiroTcXrate { get; set; }
        public virtual Nullable<decimal> GiroAmount { get; set; }
        public virtual Nullable<decimal> GiroRcAmount { get; set; }
        public virtual Nullable<short> UseGiroRate { get; set; }
        public virtual string TaxNr { get; set; }
        public virtual string CsIban { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual string DeptAddress1 { get; set; }
        public virtual string DeptAddress2 { get; set; }
        public virtual string DeptCity { get; set; }
        public virtual string DeptCityCode { get; set; }
        public virtual string DeptCountry { get; set; }
        public virtual string DeptCountryCode { get; set; }
        public virtual string DeptPostCode { get; set; }
        public virtual string DeptTelnr1 { get; set; }
        public virtual string DeptTelnr2 { get; set; }
        public virtual string DeptFaxnr { get; set; }
        public virtual string DeptTown { get; set; }
        public virtual string DeptTownCode { get; set; }
        public virtual string DeptDistrict { get; set; }
        public virtual string DeptDistrictCode { get; set; }
        public virtual Nullable<int> Subduration { get; set; }
        public virtual Nullable<short> Ciro { get; set; }
        public virtual Nullable<int> Claccref { get; set; }
        public virtual Nullable<int> Clcostref { get; set; }
        public virtual Nullable<int> OfferReference { get; set; }
        public virtual string TradingGrp { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> CreationHour { get; set; }
        public virtual Nullable<short> CreationMinute { get; set; }
        public virtual Nullable<short> CreationSecond { get; set; }
        public virtual Nullable<DateTime> CreationDate { get; set; }
        public virtual Nullable<short> CreatorId { get; set; }
        public virtual Nullable<short> LastModifierId { get; set; }
        public virtual Nullable<short> LastModificationHour { get; set; }
        public virtual Nullable<short> LastModificationMinute { get; set; }
        public virtual Nullable<short> LastModificationSecond { get; set; }
        public virtual Nullable<DateTime> LastModificationDate { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string ProjectCode { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Status> StatusList { get; set; }
        #endregion
    }
}
