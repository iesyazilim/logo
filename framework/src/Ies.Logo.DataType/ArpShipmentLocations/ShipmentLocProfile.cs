using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.ArpShipmentLocations
{
    public class ShipmentLocProfile : IConfigurationProfile
    {
        public static ShipmentLocProfile Default { get; } = new ShipmentLocProfile();

        private ShipmentLocProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ShipmentLoc>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ShipmentLoc
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SHIPMENT_LOC");

            typeConfigurations
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Description).Name("TITLE")
                .Member(m => m.Address1).Name("ADDRESS1")
                .Member(m => m.Address2).Name("ADDRESS2")
                .Member(m => m.DistrictCode).Name("DISTRICT_CODE")
                .Member(m => m.District).Name("DISTRICT")
                .Member(m => m.TownCode).Name("TOWN_CODE")
                .Member(m => m.Town).Name("TOWN")
                .Member(m => m.CityCode).Name("CITY_CODE")
                .Member(m => m.City).Name("CITY")
                .Member(m => m.CountryCode).Name("COUNTRY_CODE")
                .Member(m => m.Country).Name("COUNTRY")
                .Member(m => m.PostalCode).Name("POSTAL_CODE")
                .Member(m => m.Telephone1).Name("TELEPHONE1")
                .Member(m => m.Telephone1Code).Name("TELEPHONE1_CODE")
                .Member(m => m.Telephone2).Name("TELEPHONE2")
                .Member(m => m.Telephone2Code).Name("TELEPHONE2_CODE")
                .Member(m => m.Fax).Name("FAX")
                .Member(m => m.FaxCode).Name("FAX_CODE")
                .Member(m => m.TaxNr).Name("TAX_NR")
                .Member(m => m.TaxOffice).Name("TAX_OFFICE")
                .Member(m => m.VatNr).Name("VAT_NR")
                .Member(m => m.Textinc).Name("TEXTINC")
                .Member(m => m.Inchange).Name("INCHANGE")
                .Member(m => m.Longitude).Name("LONGITUDE")
                .Member(m => m.Latitude).Name("LATITUDE")
                .Member(m => m.CityId).Name("CITY_ID")
                .Member(m => m.TownId).Name("TOWN_ID")
                .Member(m => m.ShipBegTime1).Name("SHIP_BEG_TIME1")
                .Member(m => m.ShipBegTime2).Name("SHIP_BEG_TIME2")
                .Member(m => m.ShipBegTime3).Name("SHIP_BEG_TIME3")
                .Member(m => m.ShipEndTime1).Name("SHIP_END_TIME1")
                .Member(m => m.ShipEndTime2).Name("SHIP_END_TIME2")
                .Member(m => m.ShipEndTime3).Name("SHIP_END_TIME3")
                .Member(m => m.EmailAddr).Name("EMAIL_ADDR")
                ;
        }
    }
}
