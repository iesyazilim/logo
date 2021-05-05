using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.DefinitionFields
{
    public class DefnFldProfile : IConfigurationProfile
    {
        public static DefnFldProfile Default { get; } = new DefnFldProfile();

        private DefnFldProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DefnFld>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DefnFld
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DEFNFLD");

            typeConfigurations
              .Member(m => m.ModuleNr).Name("MODULENR")
              .Member(m => m.Level).Name("LEVEL_")
              .Member(m => m.ParentRef).Name("PARENTREF")
              .Member(m => m.OwnerRef).Name("OWNERREF")
              .Member(m => m.TextFlds1).Name("TEXTFLDS1")
              .Member(m => m.TextFlds2).Name("TEXTFLDS2")
              .Member(m => m.TextFlds3).Name("TEXTFLDS3")
              .Member(m => m.TextFlds4).Name("TEXTFLDS4")
              .Member(m => m.TextFlds5).Name("TEXTFLDS5")
              .Member(m => m.TextFlds6).Name("TEXTFLDS6")
              .Member(m => m.TextFlds7).Name("TEXTFLDS7")
              .Member(m => m.TextFlds8).Name("TEXTFLDS8")
              .Member(m => m.TextFlds9).Name("TEXTFLDS9")
              .Member(m => m.TextFlds10).Name("TEXTFLDS10")
              .Member(m => m.TextFlds11).Name("TEXTFLDS11")
              .Member(m => m.TextFlds12).Name("TEXTFLDS12")
              .Member(m => m.TextFlds13).Name("TEXTFLDS13")
              .Member(m => m.TextFlds14).Name("TEXTFLDS14")
              .Member(m => m.TextFlds15).Name("TEXTFLDS15")
              .Member(m => m.TextFlds16).Name("TEXTFLDS16")
              .Member(m => m.TextFlds17).Name("TEXTFLDS17")
              .Member(m => m.TextFlds18).Name("TEXTFLDS18")
              .Member(m => m.TextFlds19).Name("TEXTFLDS19")
              .Member(m => m.TextFlds20).Name("TEXTFLDS20")
              .Member(m => m.TextFlds21).Name("TEXTFLDS21")
              .Member(m => m.TextFlds22).Name("TEXTFLDS22")
              .Member(m => m.TextFlds23).Name("TEXTFLDS23")
              .Member(m => m.TextFlds24).Name("TEXTFLDS24")
              .Member(m => m.TextFlds25).Name("TEXTFLDS25")
              .Member(m => m.TextFlds26).Name("TEXTFLDS26")
              .Member(m => m.TextFlds27).Name("TEXTFLDS27")
              .Member(m => m.TextFlds28).Name("TEXTFLDS28")
              .Member(m => m.TextFlds29).Name("TEXTFLDS29")
              .Member(m => m.TextFlds30).Name("TEXTFLDS30")
              .Member(m => m.TextFlds31).Name("TEXTFLDS31")
              .Member(m => m.TextFlds32).Name("TEXTFLDS32")
              .Member(m => m.TextFlds33).Name("TEXTFLDS33")
              .Member(m => m.TextFlds34).Name("TEXTFLDS34")
              .Member(m => m.TextFlds35).Name("TEXTFLDS35")
              .Member(m => m.TextFlds36).Name("TEXTFLDS36")
              .Member(m => m.TextFlds37).Name("TEXTFLDS37")
              .Member(m => m.TextFlds38).Name("TEXTFLDS38")
              .Member(m => m.TextFlds39).Name("TEXTFLDS39")
              .Member(m => m.TextFlds40).Name("TEXTFLDS40")
              .Member(m => m.TextFlds41).Name("TEXTFLDS41")
              .Member(m => m.TextFlds42).Name("TEXTFLDS42")
              .Member(m => m.TextFlds43).Name("TEXTFLDS43")
              .Member(m => m.TextFlds44).Name("TEXTFLDS44")
              .Member(m => m.TextFlds45).Name("TEXTFLDS45")
              .Member(m => m.TextFlds46).Name("TEXTFLDS46")
              .Member(m => m.TextFlds47).Name("TEXTFLDS47")
              .Member(m => m.TextFlds48).Name("TEXTFLDS48")
              .Member(m => m.TextFlds49).Name("TEXTFLDS49")
              .Member(m => m.TextFlds50).Name("TEXTFLDS50")
              .Member(m => m.NumFlds1).Name("NUMFLDS1")
              .Member(m => m.NumFlds2).Name("NUMFLDS2")
              .Member(m => m.NumFlds3).Name("NUMFLDS3")
              .Member(m => m.NumFlds4).Name("NUMFLDS4")
              .Member(m => m.NumFlds5).Name("NUMFLDS5")
              .Member(m => m.NumFlds6).Name("NUMFLDS6")
              .Member(m => m.NumFlds7).Name("NUMFLDS7")
              .Member(m => m.NumFlds8).Name("NUMFLDS8")
              .Member(m => m.NumFlds9).Name("NUMFLDS9")
              .Member(m => m.NumFlds10).Name("NUMFLDS10")
              .Member(m => m.NumFlds11).Name("NUMFLDS11")
              .Member(m => m.NumFlds12).Name("NUMFLDS12")
              .Member(m => m.NumFlds13).Name("NUMFLDS13")
              .Member(m => m.NumFlds14).Name("NUMFLDS14")
              .Member(m => m.NumFlds15).Name("NUMFLDS15")
              .Member(m => m.NumFlds16).Name("NUMFLDS16")
              .Member(m => m.NumFlds17).Name("NUMFLDS17")
              .Member(m => m.NumFlds18).Name("NUMFLDS18")
              .Member(m => m.NumFlds19).Name("NUMFLDS19")
              .Member(m => m.NumFlds20).Name("NUMFLDS20")
              .Member(m => m.NumFlds21).Name("NUMFLDS21")
              .Member(m => m.NumFlds22).Name("NUMFLDS22")
              .Member(m => m.NumFlds23).Name("NUMFLDS23")
              .Member(m => m.NumFlds24).Name("NUMFLDS24")
              .Member(m => m.NumFlds25).Name("NUMFLDS25")
              .Member(m => m.NumFlds26).Name("NUMFLDS26")
              .Member(m => m.NumFlds27).Name("NUMFLDS27")
              .Member(m => m.NumFlds28).Name("NUMFLDS28")
              .Member(m => m.NumFlds29).Name("NUMFLDS29")
              .Member(m => m.NumFlds30).Name("NUMFLDS30")
              .Member(m => m.NumFlds31).Name("NUMFLDS31")
              .Member(m => m.NumFlds32).Name("NUMFLDS32")
              .Member(m => m.NumFlds33).Name("NUMFLDS33")
              .Member(m => m.NumFlds34).Name("NUMFLDS34")
              .Member(m => m.NumFlds35).Name("NUMFLDS35")
              .Member(m => m.NumFlds36).Name("NUMFLDS36")
              .Member(m => m.NumFlds37).Name("NUMFLDS37")
              .Member(m => m.NumFlds38).Name("NUMFLDS38")
              .Member(m => m.NumFlds39).Name("NUMFLDS39")
              .Member(m => m.NumFlds40).Name("NUMFLDS40")
              .Member(m => m.NumFlds41).Name("NUMFLDS41")
              .Member(m => m.NumFlds42).Name("NUMFLDS42")
              .Member(m => m.NumFlds43).Name("NUMFLDS43")
              .Member(m => m.NumFlds44).Name("NUMFLDS44")
              .Member(m => m.NumFlds45).Name("NUMFLDS45")
              .Member(m => m.NumFlds46).Name("NUMFLDS46")
              .Member(m => m.NumFlds47).Name("NUMFLDS47")
              .Member(m => m.NumFlds48).Name("NUMFLDS48")
              .Member(m => m.NumFlds49).Name("NUMFLDS49")
              .Member(m => m.NumFlds50).Name("NUMFLDS50")
              ;
        }
    }
}
