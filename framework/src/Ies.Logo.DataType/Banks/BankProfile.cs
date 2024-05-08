using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.Banks
{
    public class BankProfile : IConfigurationProfile
    {
        public static BankProfile Default { get; } = new BankProfile();

        private BankProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Bank>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Bank
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("BANK");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Title).Name("TITLE")
                .Member(m => m.Division).Name("DIVISION")
                .Member(m => m.DivisionId).Name("DIVISION_ID")
                .Member(m => m.Address1).Name("ADDRESS1")
                .Member(m => m.Address2).Name("ADDRESS2")
                .Member(m => m.District).Name("DISTRICT")
                .Member(m => m.Town).Name("TOWN")
                .Member(m => m.City).Name("CITY")
                .Member(m => m.Country).Name("COUNTRY")
                .Member(m => m.CountryCode).Name("COUNTRY_CODE")
                .Member(m => m.PostalCode).Name("POSTAL_CODE")
                .Member(m => m.Telephone1).Name("TELEPHONE1")
                .Member(m => m.Telephone2).Name("TELEPHONE2")
                .Member(m => m.Fax).Name("FAX")
                .Member(m => m.Contact).Name("CONTACT")
                .Member(m => m.Email).Name("E_MAIL")
                .Member(m => m.WebUrl).Name("WEB_URL")
                .Member(m => m.CorrpAcc).Name("CORRP_ACC")
                .Member(m => m.Voen).Name("VOEN");
        }
    }
}
