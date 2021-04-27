using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Items
{
    public class CompositeProfile : IConfigurationProfile
    {
        public static CompositeProfile Default { get; } = new CompositeProfile();

        private CompositeProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Composite>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Composite
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("COMPOSITE");

            typeConfigurations
               .Member(m => m.Code).Name("CODE")
               .Member(m => m.Quantity).Name("QUANTITY")
               .Member(m => m.Price).Name("PRICE")
               .Member(m => m.SharePerc).Name("SHARE_PERC")
               .Member(m => m.VariantCode).Name("VARIANTCODE")
               ;
        }
    }
}
