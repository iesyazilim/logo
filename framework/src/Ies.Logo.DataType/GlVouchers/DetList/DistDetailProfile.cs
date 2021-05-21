using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.GlVouchers
{
    public class DistDetailProfile : IConfigurationProfile
    {
        public static DistDetailProfile Default { get; } = new DistDetailProfile();

        private DistDetailProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DistDetail>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DistDetail
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DISTDETAIL");

            typeConfigurations
                .Member(m => m.LineNo).Name("LINE_NO")
                .Member(m => m.Branch).Name("BRANCH")
                .Member(m => m.Distrate).Name("DISTRATE")
                .Member(m => m.Credebnet).Name("CREDEBNET")
                .Member(m => m.Emucredebnet).Name("EMUCREDEBNET")
                .Member(m => m.CurrGl).Name("CURR_GL")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcNet).Name("TC_NET")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcNet).Name("RC_NET")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Tsign).Name("TSIGN")
                .Member(m => m.Wfstatus).Name("WFSTATUS")
                .Member(m => m.CenterCode).Name("CENTERCODE")
                .Member(m => m.Edtcredebnet).Name("EDTCREDEBNET")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.Month).Name("MONTH")
                .Member(m => m.Year).Name("YEAR")
                ;
        }
    }
}
