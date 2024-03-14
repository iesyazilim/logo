using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.ArpShipmentLocations
{
    [Serializable]
    public class ShipmentLoc : AuditedAggregateRoot, ISpecialCode, ITradingGroup, IDataSiteId, IRecordStatus, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.ARP_SHIPMENT_LOCATIONS;

        public virtual string ArpCode { get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
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
        public virtual string TaxNr { get; set; }
        public virtual string TaxOffice { get; set; }
        public virtual string VatNr { get; set; }
        public virtual Nullable<short> Textinc { get; set; }
        public virtual string Inchange { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string Latitude { get; set; }
        public virtual string CityId { get; set; }
        public virtual string TownId { get; set; }
        public virtual Nullable<int> ShipBegTime1 { get; set; }
        public virtual Nullable<int> ShipBegTime2 { get; set; }
        public virtual Nullable<int> ShipBegTime3 { get; set; }
        public virtual Nullable<int> ShipEndTime1 { get; set; }
        public virtual Nullable<int> ShipEndTime2 { get; set; }
        public virtual Nullable<int> ShipEndTime3 { get; set; }
        public virtual string EmailAddr { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<short> RecordStatus { get; set; }
        #endregion

        #region SubClasses

        #endregion
    }
}
