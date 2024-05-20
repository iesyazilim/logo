using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.PriceCards.ItemSale
{
    public class ItemSalePriceProfile : IConfigurationProfile
    {
        public static ItemSalePriceProfile Default { get; } = new ItemSalePriceProfile();

        private ItemSalePriceProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ItemSalePrice>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ItemSalePrice
        {
            typeConfigurations.Configure();
            typeConfigurations.Name("PRICE_RECORD");

            typeConfigurations
                .Member(m => m.Code).Name("CARD_CODE")
                .Member(m => m.ItemCode).Name("OWNER_CODE")
                .Member(m => m.ClientCode).Name("ARP_CODE")
                .Member(m => m.Price).Name("PRICE")
                .Member(m => m.UnitCode).Name("UNIT_CODE")
                .Member(m => m.VatIncluded).Name("VAT_INCL")
                .Member(m => m.StartDate).Name("DATE_STARTED")
                .Member(m => m.EndDate).Name("DATE_ENDED")
                .Member(m => m.UnitConvert).Name("UNIT_CONVERT")
                .Member(m => m.StartTime).Name("BEG_TIME")
                .Member(m => m.EndTime).Name("END_TIME")
                .Member(m => m.Definition).Name("DEFINITION")
                .Member(m => m.Branch).Name("BRANCH")
                .Member(m => m.AllDivision).Name("ALL_DIVISIONS")
                .Member(m => m.Divisions).Name("DIVISION_LIST");
        }
    }
}
