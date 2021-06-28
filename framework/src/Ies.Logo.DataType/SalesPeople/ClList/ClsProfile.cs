using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.SalesPeople
{
    public class ClsProfile : IConfigurationProfile
    {
        public static ClsProfile Default { get; } = new ClsProfile();

        private ClsProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Cls>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Cls
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CLS");

            typeConfigurations
                .Member(m => m.LineNo).Name("LINE_NO")
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Name).Name("NAME")
                .Member(m => m.BegDate).Name("BEG_DATE")
                .Member(m => m.VisitDay).Name("VISIT_DAY")
                .Member(m => m.VisitPeriod).Name("VISIT_PERIOD")
                .Member(m => m.ShipCode).Name("SHIP_CODE")
                .Member(m => m.ClLineNo).Name("CL_LINE_NO")
                ;
        }
    }
}
