using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.GlLinks;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Units;
using Ies.Logo.DataType.WhParams;

namespace Ies.Logo.DataType.Services
{
    [Serializable]
    public class Service : AuditedAggregateRoot, IRecordStatus, IDetailedAuxilCode, IAuthCode, IPaymentCode, IDataSiteId
    {
        public virtual ServiceCardType CardType { get; set; }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual string Description2 { get; set; }
        public virtual Nullable<decimal> VatPerc { get; set; }
        public virtual string UnitsetCode { get; set; }
        public virtual Nullable<decimal> Returnvat { get; set; }
        public virtual Nullable<short> ImportExpenses { get; set; }
        public virtual Nullable<decimal> AffectCost { get; set; }
        public virtual string AddTaxcode { get; set; }
        public virtual Nullable<short> DistType { get; set; }
        public virtual Nullable<short> Candeduct { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual Nullable<int> ExtAccessFlags { get; set; }
        public virtual Nullable<short> Currdif { get; set; }

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
        #endregion

        #region SubClasses
        public virtual List<ServiceWhParam> WhParams { get; set; }
        public virtual List<ServiceUnit> Units { get; set; }
        public virtual List<GlLink> GlLinks { get; set; }
        #endregion

        public override LogoObjectType GetRootElementName()
        {
            switch (CardType)
            {
                case ServiceCardType.Purchase:
                case ServiceCardType.PurchaseGroup:
                default:
                    return LogoObjectType.PURCHASE_SERVICES;

                case ServiceCardType.Sales:
                case ServiceCardType.SalesGroup:
                    return LogoObjectType.SALES_SERVICES;
            }
        }
    }
}
