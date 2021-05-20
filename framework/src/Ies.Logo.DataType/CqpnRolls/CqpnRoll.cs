using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.CqpnRolls
{
    [Serializable]
    public class CqpnRoll : AuditedAggregateRoot, ISpecialCode, IDivision, IDepartment, INotes, ICancelled, ITradingGroup, IDataSiteId, IProjectCode, IApprove
    {
        public static string XmlRoot => "CQPN_ROLLS";

        public virtual Nullable<int> Type { get; set; }
        public virtual string Number { get; set; }
        public virtual string DocNumber{ get; set; }
        public virtual Nullable<short> MasterModule{ get; set; }
        public virtual string MasterCode{ get; set; }
        public virtual string OhpCode{ get; set; }
        public virtual Nullable<DateTime> Date{ get; set; }
        public virtual Nullable<int> DestDivision{ get; set; }
        public virtual Nullable<int> DestDepartment{ get; set; }
        public virtual Nullable<short> ProcType{ get; set; }
        public virtual Nullable<short> SinglePayment{ get; set; }
        public virtual Nullable<short> GlPosted{ get; set; }
        public virtual Nullable<int> AverageAge{ get; set; }
        public virtual Nullable<int> DocumentCount{ get; set; }
        public virtual Nullable<int> PrintCounter{ get; set; }
        public virtual Nullable<DateTime> PrintDate{ get; set; }
        public virtual Nullable<decimal> Total{ get; set; }
        public virtual Nullable<short> CurrTrans{ get; set; }
        public virtual Nullable<decimal> TcXrate{ get; set; }
        public virtual Nullable<decimal> TcTotal{ get; set; }
        public virtual Nullable<decimal> RcXrate{ get; set; }
        public virtual Nullable<decimal> RcTotal{ get; set; }
        public virtual Nullable<int> Accficheref{ get; set; }
        public virtual string GlCode{ get; set; }
        public virtual Nullable<int> CurrselTotals{ get; set; }
        public virtual Nullable<int> CurrselDetails{ get; set; }
        public virtual Nullable<int> OpStatus{ get; set; }
        public virtual Nullable<decimal> InflationIdx{ get; set; }
        public virtual string CashTranGrpNo{ get; set; }
        public virtual Nullable<int> CashTranGrplineNo{ get; set; }
        public virtual Nullable<decimal> CashInfldx{ get; set; }
        public virtual string CashOrglogoid{ get; set; }
        public virtual Nullable<short> FromCash{ get; set; }
        public virtual Nullable<int> CollatrlRollref{ get; set; }
        public virtual Nullable<short> AffectCollatrl{ get; set; }
        public virtual Nullable<short> Grpfirmtrans{ get; set; }
        public virtual Nullable<short> AffectRisk{ get; set; }
        public virtual Nullable<int> Bncreref{ get; set; }
        public virtual string BankCreditCode{ get; set; }
        public virtual Nullable<decimal> BnkCreCtrlTot{ get; set; }
        public virtual Nullable<short> FromBank{ get; set; }
        public virtual Nullable<short> DegActive{ get; set; }
        public virtual Nullable<short> DegCurr{ get; set; }
        public virtual Nullable<decimal> DegCurrRate{ get; set; }
        public virtual Nullable<int> AccFicheSiteid{ get; set; }
        public virtual string SalesmanCode{ get; set; }
        public virtual Nullable<short> CancelAutoGlProc{ get; set; }
        public virtual Nullable<DateTime> EbookDocdate{ get; set; }
        public virtual Nullable<short> EbookNodocument{ get; set; }
        public virtual string EbookDocnr{ get; set; }
        public virtual Nullable<int> EbookDocType{ get; set; }
        public virtual string EbookExplain{ get; set; }
        public virtual string EbookPaytype{ get; set; }
        public virtual Nullable<short> EbookNopay{ get; set; }
        public virtual Nullable<DateTime> DocDate{ get; set; }

        #region Implementation
        public string AuthCode { get; set; }
        public string AuxilCode { get; set; }
        public Nullable<short> Division { get; set; }
        public Nullable<short> Department { get; set; }
        public string Notes1 { get; set; }
        public string Notes2 { get; set; }
        public string Notes3 { get; set; }
        public string Notes4 { get; set; }
        public Nullable<short> Cancelled { get; set; }
        public string TradingGrp { get; set; }
        public Nullable<int> DataSiteId { get; set; }
        public string ProjectCode { get; set; }
        public Nullable<short> Approve { get; set; }
        public Nullable<DateTime> ApproveDate { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
