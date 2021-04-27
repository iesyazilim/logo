using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Items
{
    public class VrntExceptionProfile : IConfigurationProfile
    {
        public static VrntExceptionProfile Default { get; } = new VrntExceptionProfile();

        private VrntExceptionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<VrntException>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : VrntException
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("EXCEPTION");

            typeConfigurations
               .Member(m => m.CharCode).Name("CHAR_CODE")
               .Member(m => m.ValRefsList).Name("VALREFSLIST")
               ;
        }
    }
}
