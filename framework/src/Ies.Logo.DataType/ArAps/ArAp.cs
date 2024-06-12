﻿using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.ArAps
{
    [Serializable]
    public class ArAp : AuditedAggregateRoot, IRecordStatus, IDetailedAuxilCode, IAuthCode, IPaymentCode, IDataSiteId, ITradingGroup, IProjectCode, IGlobalId, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.AR_APS;

        public virtual Nullable<short> AccountType { get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        public virtual string Code { get; set; }
        public virtual string Title { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string DistrictCode { get; set; }
        public virtual string District { get; set; }
        public virtual string TownCode { get; set; }
        public virtual string Town { get; set; }
        public virtual string CityCode { get; set; }
        public virtual string City { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Telephone1 { get; set; }
        public virtual string Telephone1Code { get; set; }
        public virtual string Telephone2 { get; set; }
        public virtual string Telephone2Code { get; set; }
        public virtual string Fax { get; set; }
        public virtual string FaxCode { get; set; }
        public virtual string TaxId { get; set; }
        public virtual string TaxOffice { get; set; }
        public virtual string TaxOfficeCode { get; set; }
        public virtual string Contact { get; set; }
        public virtual string Contact2 { get; set; }
        public virtual string Contact3 { get; set; }
        public virtual Nullable<decimal> DiscountRate { get; set; }
        public virtual string Email { get; set; }
        public virtual string Email2 { get; set; }
        public virtual string Email3 { get; set; }
        public virtual string WebUrl { get; set; }
        public virtual Nullable<short> ReminderType { get; set; }
        public virtual string ReminderEmail { get; set; }
        public virtual string ReminderFax { get; set; }
        public virtual Nullable<short> CorrespLang { get; set; }
        public virtual string VatId { get; set; }
        public virtual Nullable<short> Blocked { get; set; }
        public virtual string BankId1 { get; set; }
        public virtual string BankId2 { get; set; }
        public virtual string BankId3 { get; set; }
        public virtual string BankId4 { get; set; }
        public virtual string BankId5 { get; set; }
        public virtual string BankId6 { get; set; }
        public virtual string BankId7 { get; set; }
        public virtual string BankName1 { get; set; }
        public virtual string BankName2 { get; set; }
        public virtual string BankName3 { get; set; }
        public virtual string BankName4 { get; set; }
        public virtual string BankName5 { get; set; }
        public virtual string BankName6 { get; set; }
        public virtual string BankName7 { get; set; }
        public virtual string BankAccount1 { get; set; }
        public virtual string BankAccount2 { get; set; }
        public virtual string BankAccount3 { get; set; }
        public virtual string BankAccount4 { get; set; }
        public virtual string BankAccount5 { get; set; }
        public virtual string BankAccount6 { get; set; }
        public virtual string BankAccount7 { get; set; }
        public virtual Nullable<int> DbsCurr1 { get; set; }
        public virtual Nullable<int> DbsCurr2 { get; set; }
        public virtual Nullable<int> DbsCurr3 { get; set; }
        public virtual Nullable<int> DbsCurr4 { get; set; }
        public virtual Nullable<int> DbsCurr5 { get; set; }
        public virtual Nullable<int> DbsCurr6 { get; set; }
        public virtual Nullable<int> DbsCurr7 { get; set; }
        public virtual string DeliveryMethod { get; set; }
        public virtual string ShipmentAgent { get; set; }
        public virtual Nullable<short> Currency { get; set; }
        public virtual string EcommId { get; set; }
        public virtual Nullable<short> DebtTrckType { get; set; }
        public virtual Nullable<short> XrtdifType { get; set; }
        public virtual Nullable<short> CreditType { get; set; }
        public virtual Nullable<decimal> CreditLimit { get; set; }
        public virtual Nullable<decimal> CreditBalanced { get; set; }
        public virtual Nullable<decimal> RiskFactChq { get; set; }
        public virtual Nullable<decimal> RiskFactPromnt { get; set; }
        public virtual Nullable<short> ActionCredhold { get; set; }
        public virtual string GlCode { get; set; }
        public virtual string OhpCode { get; set; }
        public virtual string PpGroupCode { get; set; }
        public virtual Nullable<short> UseRepRisk { get; set; }
        public virtual Nullable<decimal> RiskLimit { get; set; }
        public virtual Nullable<decimal> RiskBalanced { get; set; }
        public virtual Nullable<short> OrdSendMethod { get; set; }
        public virtual string OrdSendEmail { get; set; }
        public virtual string OrdSendFax { get; set; }
        public virtual Nullable<short> DspSendMethod { get; set; }
        public virtual string DspSendEmail { get; set; }
        public virtual string DspSendFax { get; set; }
        public virtual Nullable<short> InvSendMethod { get; set; }
        public virtual string InvSendEmail { get; set; }
        public virtual string InvSendFax { get; set; }
        public virtual Nullable<short> SubscriberStatus { get; set; }
        public virtual string SubscriberExt { get; set; }
        public virtual string AutoPaidBank { get; set; }
        public virtual Nullable<short> PaymentType { get; set; }
        public virtual Nullable<int> LastSendRemLev { get; set; }
        public virtual Nullable<int> ExtAccFlags { get; set; }
        public virtual Nullable<short> OrdSendFormat { get; set; }
        public virtual Nullable<short> DspSendFormat { get; set; }
        public virtual Nullable<short> InvSendFormat { get; set; }
        public virtual Nullable<short> RemSendFormat { get; set; }
        public virtual string StoreCreditCardNo { get; set; }
        public virtual Nullable<short> ClOrdFreq { get; set; }
        public virtual Nullable<short> OrdDay { get; set; }
        public virtual Nullable<short> LidConfirmed { get; set; }
        public virtual Nullable<int> EbsnsSendType { get; set; }
        public virtual Nullable<int> LdxDefOrderStat { get; set; }
        public virtual Nullable<int> LdxDefOrderPrc { get; set; }
        public virtual Nullable<int> ItrSendMethod { get; set; }
        public virtual string ItrSendMailAdr { get; set; }
        public virtual string ItrSendFax { get; set; }
        public virtual Nullable<int> ItrSendFormat { get; set; }
        public virtual Nullable<short> Img2Inc { get; set; }
        public virtual string CellPhone { get; set; }
        public virtual string Itext { get; set; }
        public virtual Nullable<short> InvoicePrntCnt { get; set; }
        public virtual Nullable<int> WfLowCardRef { get; set; }
        public virtual string ParentClCode { get; set; }
        public virtual Nullable<short> CodeChanged { get; set; }
        public virtual Nullable<short> CollectInv { get; set; }
        public virtual Nullable<short> PieceOrdInflict { get; set; }
        public virtual Nullable<short> PurchBrws { get; set; }
        public virtual Nullable<short> SalesBrws { get; set; }
        public virtual Nullable<short> ImpBrws { get; set; }
        public virtual Nullable<short> ExpBrws { get; set; }
        public virtual Nullable<short> FinBrws { get; set; }
        public virtual Nullable<short> CollatrlRiskType { get; set; }
        public virtual Nullable<short> CollRiskOver { get; set; }
        public virtual Nullable<short> CollRiskOrdRiskOver { get; set; }
        public virtual Nullable<short> CollRiskDespRiskOver { get; set; }
        public virtual Nullable<short> CollRiskUseRepRisk { get; set; }
        public virtual Nullable<decimal> CollRiskPcollatrlTotal { get; set; }
        public virtual Nullable<decimal> CollRiskRepPcollatrlTot { get; set; }
        public virtual Nullable<decimal> CollRiskScollatrlTotal { get; set; }
        public virtual Nullable<decimal> CollRiskTotal { get; set; }
        public virtual Nullable<decimal> CollRiskRepRiskTotal { get; set; }
        public virtual Nullable<decimal> CollRiskDespTotal { get; set; }
        public virtual Nullable<decimal> CollRiskRepDespRiskTot { get; set; }
        public virtual Nullable<decimal> CollRiskLimit { get; set; }
        public virtual Nullable<decimal> CollRiskRepLimit { get; set; }
        public virtual Nullable<decimal> CollRiskBalanced { get; set; }
        public virtual Nullable<decimal> CollRiskRepBalanced { get; set; }
        public virtual Nullable<decimal> CollRiskOrdRiskTotal { get; set; }
        public virtual Nullable<decimal> CollRiskRepOrdRiskTot { get; set; }
        public virtual Nullable<decimal> CollRiskOrdRiskTotSugg { get; set; }
        public virtual Nullable<decimal> CollRiskRepOrdRiskTotSug { get; set; }
        public virtual Nullable<int> GrpFirmNr { get; set; }
        public virtual string ConsCode { get; set; }
        public virtual string EbankCode { get; set; }
        public virtual Nullable<short> OffSendMethod { get; set; }
        public virtual string OffSendMailAddr { get; set; }
        public virtual string OffSendFax { get; set; }
        public virtual Nullable<short> OffSendFormat { get; set; }
        public virtual Nullable<short> RiskType1 { get; set; }
        public virtual Nullable<short> RiskType2 { get; set; }
        public virtual Nullable<short> RiskType3 { get; set; }
        public virtual Nullable<short> RiskGrpControl { get; set; }
        public virtual Nullable<short> ActionCredHoldOrd { get; set; }
        public virtual Nullable<short> ActionCredHoldDesp { get; set; }
        public virtual Nullable<short> ActionCredHoldAcc { get; set; }
        public virtual Nullable<short> ActionCredHoldMyCs { get; set; }
        public virtual Nullable<short> RiskCtrlType { get; set; }
        public virtual Nullable<decimal> AccRiskTotal { get; set; }
        public virtual Nullable<decimal> RepAccRiskTotal { get; set; }
        public virtual Nullable<decimal> CstCsRiskTotal { get; set; }
        public virtual Nullable<decimal> RepCstCsRiskTotal { get; set; }
        public virtual Nullable<decimal> MyCsRiskTotal { get; set; }
        public virtual Nullable<decimal> RepMyCsRiskTotal { get; set; }
        public virtual Nullable<decimal> OrdRiskTotal { get; set; }
        public virtual Nullable<decimal> RepOrdRiskTotal { get; set; }
        public virtual Nullable<decimal> OrdRiskTotalSugg { get; set; }
        public virtual Nullable<decimal> RepOrdRiskTotalSugg { get; set; }
        public virtual Nullable<decimal> DespRiskTotal { get; set; }
        public virtual Nullable<decimal> RepDespRiskTotal { get; set; }
        public virtual Nullable<decimal> AccRiskLimit { get; set; }
        public virtual Nullable<decimal> RepAccRiskLimit { get; set; }
        public virtual Nullable<decimal> CstCsRiskLimit { get; set; }
        public virtual Nullable<decimal> RepCstCsRiskLimit { get; set; }
        public virtual Nullable<decimal> MyCsRiskLimit { get; set; }
        public virtual Nullable<decimal> RepMyCsRiskLimit { get; set; }
        public virtual Nullable<decimal> DespRiskLimit { get; set; }
        public virtual Nullable<decimal> RepDespRiskLimit { get; set; }
        public virtual Nullable<decimal> OrdRiskLimit { get; set; }
        public virtual Nullable<decimal> RepOrdRiskLimit { get; set; }
        public virtual Nullable<decimal> OrdRiskLimitSugg { get; set; }
        public virtual Nullable<decimal> RepOrdSirkLimitSugg { get; set; }
        public virtual Nullable<decimal> AccRiskBalanced { get; set; }
        public virtual Nullable<decimal> RepAccRiskBalanced { get; set; }
        public virtual Nullable<decimal> CstCsRiskBalanced { get; set; }
        public virtual Nullable<decimal> RepCstCsRiskBalanced { get; set; }
        public virtual Nullable<decimal> MyCsRiskBalanced { get; set; }
        public virtual Nullable<decimal> RepMyCsRiskBalanced { get; set; }
        public virtual Nullable<decimal> DespRiskBalanced { get; set; }
        public virtual Nullable<decimal> RepDespRiskBalanced { get; set; }
        public virtual Nullable<decimal> OrdRiskBalanced { get; set; }
        public virtual Nullable<decimal> RepOrdRiskBalanced { get; set; }
        public virtual Nullable<decimal> OrdRiskBalancedSugg { get; set; }
        public virtual Nullable<decimal> RepOrdRiskBalancedSugg { get; set; }
        public virtual Nullable<short> LoanGrpCtrl { get; set; }
        public virtual Nullable<short> EbusDataSendType { get; set; }
        public virtual Nullable<int> IniStatusFlags { get; set; }
        public virtual Nullable<short> SlsOrderStatus { get; set; }
        public virtual Nullable<short> SlsOrderPrice { get; set; }
        public virtual Nullable<short> SameItemCodeUse { get; set; }
        public virtual Nullable<int> ImageSize { get; set; }
        public virtual string MapId { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string Latitude { get; set; }
        public virtual string CityId { get; set; }
        public virtual string TownId { get; set; }
        public virtual string BankIban1 { get; set; }
        public virtual string BankIban2 { get; set; }
        public virtual string BankIban3 { get; set; }
        public virtual string BankIban4 { get; set; }
        public virtual string BankIban5 { get; set; }
        public virtual string BankIban6 { get; set; }
        public virtual string BankIban7 { get; set; }
        public virtual string BankBic1 { get; set; }
        public virtual string BankBic2 { get; set; }
        public virtual string BankBic3 { get; set; }
        public virtual string BankBic4 { get; set; }
        public virtual string BankBic5 { get; set; }
        public virtual string BankBic6 { get; set; }
        public virtual string BankBic7 { get; set; }
        public virtual Nullable<short> PersCompany { get; set; }
        public virtual string Tckno { get; set; }
        public virtual Nullable<short> ExtSendMethod { get; set; }
        public virtual string ExtSendEmail { get; set; }
        public virtual string ExtSendFax { get; set; }
        public virtual Nullable<short> ExtSendFormat { get; set; }
        public virtual Nullable<short> AddTorefList { get; set; }
        public virtual Nullable<short> OrdRiskOverSugg { get; set; }
        public virtual string CashCode { get; set; }
        public virtual Nullable<short> UsedInPeriods { get; set; }
        public virtual Nullable<short> RsklimCntrl { get; set; }
        public virtual Nullable<short> DueDateCntrl { get; set; }
        public virtual Nullable<short> AgingCntrl { get; set; }
        public virtual Nullable<short> AgingDay { get; set; }
        public virtual Nullable<short> AcceptEinvy { get; set; }
        public virtual string EinvoiceId { get; set; }
        public virtual Nullable<short> ProfileId { get; set; }
        public virtual Nullable<short> PurchOrderStatus { get; set; }
        public virtual Nullable<short> PurcOrderPrice { get; set; }
        public virtual Nullable<short> EinvoiceType { get; set; }
        public virtual string Title2 { get; set; }
        public virtual string TelephoneExtension1 { get; set; }
        public virtual string TelephoneExtension2 { get; set; }
        public virtual string FaxExtension { get; set; }
        public virtual Nullable<short> IsForeign { get; set; }
        public virtual string PostLabel { get; set; }
        public virtual string SenderLabel { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual Nullable<short> LabelInfo { get; set; }
        public virtual Nullable<short> InsteadOfDispatch { get; set; }
        public virtual Nullable<short> EArchiveSendeMode { get; set; }

        #region Implementation
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string AuxilCode2 { get; set; }
        public virtual string AuxilCode3 { get; set; }
        public virtual string AuxilCode4 { get; set; }
        public virtual string AuxilCode5 { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion

        #region SubClasses

        #endregion
    }
}
