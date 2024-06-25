using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.OhpAccounts
{
    public class OhpAccountProfile : IConfigurationProfile
    {
        public static OhpAccountProfile Default { get; } = new OhpAccountProfile();

        private OhpAccountProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<OhpAccount>();

            Configure(configuration);

            return configuration;
        }


        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : OhpAccount
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("OHP_ACCOUNT");

            typeConfigurations
                 .Member(m => m.Code).Name("CODE")
                 .Member(m => m.Description).Name("DESCRIPTION")
                 .Member(m => m.Unit).Name("UNIT")
                 .Member(m => m.DataSiteId).Name("DATA_SITEID");
        }
    }
}
