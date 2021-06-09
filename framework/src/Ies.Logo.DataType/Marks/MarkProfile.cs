using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Marks
{
    public class MarkProfile : IConfigurationProfile
    {
        public static MarkProfile Default { get; } = new MarkProfile();

        private MarkProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Mark>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Mark
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("MARK");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Descr).Name("DESCR")
                ;
        }
    }
}
