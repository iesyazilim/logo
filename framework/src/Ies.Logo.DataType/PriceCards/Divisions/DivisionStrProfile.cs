using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ies.Logo.DataType.PriceCards.Divisions
{
    public class DivisionStrProfile : IConfigurationProfile
    {
        public static DivisionStrProfile Default { get; } = new DivisionStrProfile();

        private DivisionStrProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DivisionStr>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DivisionStr
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DIVISION_STR");

            typeConfigurations.Member(m => m.DivisionCodes).Name("DIVCODES");
        }
    }
}
