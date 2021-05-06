using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace IesYazilim.Logo.DataType.QcList
{
    public class QccValueEntryProfile : IConfigurationProfile
    {
        public static QccValueEntryProfile Default { get; } = new QccValueEntryProfile();

        private QccValueEntryProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<QccValueEntry>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : QccValueEntry
        {
            ValueProfile.Configure(typeConfigurations);
            typeConfigurations.Name<T>("QCC_VALUE_ENTRY");

            typeConfigurations
                .Member(m => m.ValList).Name("VALLIST")
                ;
        }
    }
}
