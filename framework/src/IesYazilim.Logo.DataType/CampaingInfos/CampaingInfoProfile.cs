using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.CampaingInfos
{
    public class CampaingInfoProfile : IConfigurationProfile
    {
        public static CampaingInfoProfile Default { get; } = new CampaingInfoProfile();

        private CampaingInfoProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<CampaingInfo>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : CampaingInfo
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CAMPAIGN_INFO");

            typeConfigurations
                .Member(m => m.Campcode1).Name("CAMPCODE1")
                .Member(m => m.Campcode2).Name("CAMPCODE2")
                .Member(m => m.Campcode3).Name("CAMPCODE3")
                .Member(m => m.Campcode4).Name("CAMPCODE4")
                .Member(m => m.Campcode5).Name("CAMPCODE5")
                .Member(m => m.Pcampcode).Name("PCAMPCODE")
                .Member(m => m.CampLnNo).Name("CAMP_LN_NO")
                ;
        }
    }
}
