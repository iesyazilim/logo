using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Items
{
    public class VrntCodeTempProfile : IConfigurationProfile
    {
        public static VrntCodeTempProfile Default { get; } = new VrntCodeTempProfile();

        private VrntCodeTempProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<VrntCodeTemp>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : VrntCodeTemp
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("VRNTCODETEMP");

            typeConfigurations
               .Member(m => m.Typ).Name("TYP")
               .Member(m => m.Increment).Name("INCREMENT")
               .Member(m => m.Lenght).Name("LENGTH")
               .Member(m => m.Sstart).Name("SSTART")
               .Member(m => m.Send).Name("SEND")
               .Member(m => m.CharAbbrev).Name("CHARABBREV")
               .Member(m => m.LineNr).Name("LINENR")
               .Member(m => m.CharCode).Name("CHARCODE")
               .Member(m => m.IncCode).Name("INCCODE")
               .Member(m => m.TillCode).Name("TILLCODE")
               .Member(m => m.FirstTime).Name("FIRSTTIME")
               .Member(m => m.Visited).Name("VISITED")
               .Member(m => m.Vcount).Name("VCOUNT")
               .Member(m => m.Count).Name("COUNT")
               .Member(m => m.TempVals).Name("TEMPVALS")
               ;
        }
    }
}
