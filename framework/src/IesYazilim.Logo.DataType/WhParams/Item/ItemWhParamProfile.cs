using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace IesYazilim.Logo.DataType.WhParams
{
    public class ItemWhParamProfile : IConfigurationProfile
    {
        public static ItemWhParamProfile Default { get; } = new ItemWhParamProfile();
        private ItemWhParamProfile() { }
        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ItemWhParam>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ItemWhParam
        {
            WhParamProfile.Configure(typeConfigurations);

            typeConfigurations
              .Member(m => m.MinLevel).Name("MIN_LEVEL")
              .Member(m => m.MaxLevel).Name("MAX_LEVEL")
              .Member(m => m.SafetyLevel).Name("SAFETY_LEVEL")
              .Member(m => m.LocationCode).Name("LOCATION_CODE")
              .Member(m => m.PeriodCloseDate).Name("PERIOD_CLOSE_DATE")
              .Member(m => m.AbcCode).Name("ABC_CODE")
              .Member(m => m.IOFlag).Name("IO_FLAG")
              .Member(m => m.MinLevelFlag).Name("MIN_LEVEL_FLAG")
              .Member(m => m.MaxLevelFlag).Name("MAX_LEVEL_FLAG")
              .Member(m => m.SafetyLevelFlag).Name("SAFETY_LEVEL_FLAG")
              .Member(m => m.BackOrderFlag).Name("BACKORDER_FLAG")
              .Member(m => m.OutFlag).Name("OUT_FLAG")
              .Member(m => m.Clas).Name("CLAS")
              .Member(m => m.DominantCode).Name("DOMINANTCODE")
              .Member(m => m.DominantFlag).Name("DOMINANTFLAG")
              .Member(m => m.ProcureInven).Name("PROCURE_INVEN")
              ;
        }
    }
}
