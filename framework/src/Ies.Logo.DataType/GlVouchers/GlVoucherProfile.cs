using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.GlVouchers
{
    public class GlVoucherProfile
    {
        public static GlVoucherProfile Default { get; } = new GlVoucherProfile();

        private GlVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<GlVoucher>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : GlVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("GL_VOUCHER");

            typeConfigurations
                .Member(m => m.).Name("")
                ;
        }
    }
}
