using System;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.GlAccounts
{
    [Serializable]
    public class GlAccount : AuditedAggregateRoot, IRecordStatus, ISpecialCode, IGroupCode, IDataSiteId
    {
        public static string XmlRoot => "GL_ACCOUNTS";

        public virtual string Code { get; set; }
        public virtual string Description{ get; set; }
        public virtual string Description2{ get; set; }
        public virtual string Unit{ get; set; }
        public virtual string OhpCode{ get; set; }
        public virtual string DiffaccCode{ get; set; }
        public virtual Nullable<int> AccountType{ get; set; }
        public virtual Nullable<int> MndtryQuan{ get; set; }
        public virtual Nullable<int> MndtryOhp{ get; set; }
        public virtual Nullable<int> AccountChar{ get; set; }
        public virtual Nullable<int> InflationFlag{ get; set; }
        public virtual string DiffdebtaccCode{ get; set; }
        public virtual Nullable<int> Category{ get; set; }
        public virtual Nullable<int> ProjectControl{ get; set; }
        public virtual string InfDiffAcccode{ get; set; }
        public virtual Nullable<int> Ccurency{ get; set; }
        public virtual Nullable<int> Curratetype{ get; set; }
        public virtual Nullable<int> Fixedcurrtype{ get; set; }
        public virtual string ClName{ get; set; }
        public virtual string TaxNr{ get; set; }
        public virtual Nullable<int> FoxTaxDecl{ get; set; }
        public virtual Nullable<int> VatAcc{ get; set; }
        public virtual Nullable<int> IsBdgtLine{ get; set; }
        public virtual string BdgtAccCode{ get; set; }
        public virtual string BgdtReflAccCode{ get; set; }
        public virtual string BdgtPayAccCode{ get; set; }
        public virtual string BdgtPayReflAccCode{ get; set; }
        public virtual Nullable<int> Crbdgtaccln{ get; set; }
        public virtual Nullable<int> Crbdgtpayaln{ get; set; }
        public virtual string CorpCode1 { get; set; }
        public virtual string CorpCode2 { get; set; }
        public virtual string CorpCode3 { get; set; }
        public virtual string CorpCode4 { get; set; }
        public virtual string FuncCode1 { get; set; }
        public virtual string FuncCode2 { get; set; }
        public virtual string FuncCode3 { get; set; }
        public virtual string FuncCode4 { get; set; }
        public virtual string FinCode { get; set; }
        public virtual string EcoCode1 { get; set; }
        public virtual string EcoCode2 { get; set; }
        public virtual string EcoCode3 { get; set; }
        public virtual string EcoCode4 { get; set; }
        public virtual string VatReflAccCode{ get; set; }
        public virtual string VatReflOthAccCode{ get; set; }

        #region Implementation
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string GroupCode { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion
    }
}
