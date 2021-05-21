using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.GlVouchers
{
    [Serializable]
    public class Transaction : ILogo, IAuxilCode, IDataSiteId, IDataReference, IDepartment
    {
        public virtual Nullable<int> Sign { get; set; }
        public virtual string GlCode{ get; set; }
        public virtual string OhpCode{ get; set; }
        public virtual string ParentGlcode{ get; set; }
        public virtual string AuxilCode2{ get; set; }
        public virtual Nullable<decimal> Debit{ get; set; }
        public virtual Nullable<decimal> Credit{ get; set; }
        public virtual Nullable<int> Lineno{ get; set; }
        public virtual string Description{ get; set; }
        public virtual Nullable<short> CurrTrans{ get; set; }
        public virtual Nullable<short> SourceXratediff{ get; set; }
        public virtual Nullable<decimal> RcXrate{ get; set; }
        public virtual Nullable<decimal> RcAmount{ get; set; }
        public virtual Nullable<decimal> TcXrate{ get; set; }
        public virtual Nullable<decimal> TcAmount{ get; set; }
        public virtual Nullable<decimal> Quantity{ get; set; }
        public virtual Nullable<decimal> EuroDebit{ get; set; }
        public virtual Nullable<decimal> EuroTrans{ get; set; }
        public virtual Nullable<int> CurrselTrans{ get; set; }
        public virtual Nullable<short> SafedepTrans{ get; set; }
        public virtual Nullable<decimal> InflationIdx{ get; set; }
        public virtual Nullable<short> InflationFlag { get; set; }
        public virtual Nullable<short> CalcFlagg{ get; set; }
        public virtual string CreditglCode{ get; set; }
        public virtual Nullable<int> FromWhere{ get; set; }
        public virtual Nullable<int> BdgtLineType{ get; set; }
        public virtual Nullable<int> Status{ get; set; }
        public virtual Nullable<int> BdgtFicType{ get; set; }
        public virtual Nullable<int> BdgtFicREf{ get; set; }
        public virtual Nullable<int> BdgtFicLnRef{ get; set; }
        public virtual Nullable<int> BdgtFicPrdRef{ get; set; }
        public virtual Nullable<int> FromDemType{ get; set; }
        public virtual Nullable<int> EmDemFicRef{ get; set; }
        public virtual Nullable<int> EmDemLineRef{ get; set; }
        public virtual Nullable<int> ParentLineRef{ get; set; }
        public virtual Nullable<int> AccBdgtAccRef{ get; set; }
        public virtual Nullable<int> AccBdrefLaccRef{ get; set; }
        public virtual Nullable<int> AccBdgtPayRef{ get; set; }
        public virtual Nullable<int> AccBdgtPayLnref{ get; set; }
        public virtual Nullable<int> Linetag{ get; set; }
        public virtual Nullable<short> CreateBdgtLn{ get; set; }
        public virtual Nullable<int> Month{ get; set; }
        public virtual Nullable<int> Year{ get; set; }
        public virtual Nullable<short> Grpfirmtrans{ get; set; }
        public virtual string InvoiceNo{ get; set; }
        public virtual string ClName{ get; set; }
        public virtual string TaxNr{ get; set; }
        public virtual Nullable<short> ForTaxDecl{ get; set; }
        public virtual Nullable<DateTime> DocDate{ get; set; }
        public virtual Nullable<int> GlobalLineNo{ get; set; }
        public virtual Nullable<int> LineType{ get; set; }
        public virtual Nullable<int> CodeRef{ get; set; }
        public virtual Nullable<DateTime> EbookDocdate{ get; set; }
        public virtual Nullable<short> EbookUndocumented{ get; set; }
        public virtual string EbookDocnr{ get; set; }
        public virtual Nullable<int> EbookDoctype{ get; set; }
        public virtual string EbookExplain{ get; set; }
        public virtual string EbookPaytype{ get; set; }
        public virtual Nullable<short> EbookNopay{ get; set; }

        #region Implementation
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<short> Department { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DistDetail> DetList { get; set; }
        #endregion
    }
}
