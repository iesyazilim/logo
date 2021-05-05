using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Items
{
    public class ClassProfile : IConfigurationProfile
    {
        public static ClassProfile Default { get; } = new ClassProfile();

        private ClassProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Class>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Class
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CLASS");

            typeConfigurations
               .Member(m => m.DomType).Name("DOM_TYPE")
               .Member(m => m.ClassCode).Name("CLASS_CODE")
               ;
        }
    }
}
