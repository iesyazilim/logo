using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Items
{
    public class ItemSubstituteProfile : IConfigurationProfile
    {
        public static ItemSubstituteProfile Default { get; } = new ItemSubstituteProfile();

        private ItemSubstituteProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ItemSubstitute>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ItemSubstitute
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ITEM_SUBSTITUTE");

            typeConfigurations
               .Member(m => m.LineNo).Name("LINE_NO")
               .Member(m => m.Priority).Name("PRIORITY")
               .Member(m => m.ConvFact1).Name("CONV_FACT1")
               .Member(m => m.ConvFact2).Name("CONV_FACT2")
               .Member(m => m.MinQuantity).Name("MIN_QUANTITY")
               .Member(m => m.MaxQuantity).Name("MAX_QUANTITY")
               .Member(m => m.BegDate).Name("BEG_DATE")
               .Member(m => m.EndDate).Name("END_DATE")
               .Member(m => m.SubsCode).Name("SUBS_CODE")
               .Member(m => m.MainCode).Name("MAIN_CODE")
               .Member(m => m.MainVrntCode).Name("MAIN_VRNTCODE")
               .Member(m => m.SubsVrntCode).Name("SUBS_VRNTCODE")
               ;
        }
    }
}
