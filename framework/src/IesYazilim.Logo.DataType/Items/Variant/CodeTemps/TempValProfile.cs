using System;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Items
{
    [Serializable]
    public class TempValProfile : IConfigurationProfile
    {
        public static TempValProfile Default { get; } = new TempValProfile();

        private TempValProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<TempVal>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : TempVal
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("TEMPVAL");

            typeConfigurations
               .Member(m => m.CharValCode).Name("CHARVALCODE")
               .Member(m => m.CharAbbrev).Name("CHARABBREV")
               .Member(m => m.ValChecked).Name("VALCHECKED")
               ;
        }
    }
}
