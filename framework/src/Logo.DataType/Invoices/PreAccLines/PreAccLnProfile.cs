using System;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Invoices
{
    [Serializable]
    public class PreAccLnProfile : IConfigurationProfile
    {
        public static PreAccLnProfile Default { get; } = new PreAccLnProfile();

        private PreAccLnProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<PreAccLn>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : PreAccLn
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("PREACCLN");

            typeConfigurations
                .Member(m => m.LineNr).Name("LINENR")
                .Member(m => m.DistRate).Name("DISTRATE")
                .Member(m => m.LineExcType).Name("LINEEXCTYP")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Tsign).Name("TSIGN")
                .Member(m => m.WfStatus).Name("WFSTATUS")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.Month).Name("MONTH")
                .Member(m => m.Year).Name("YEAR")
                .Member(m => m.PrevLineType).Name("PREVLINETYPE")
                .Member(m => m.ModulNr).Name("MODULNR")
                .Member(m => m.CenterCode).Name("CENTERCODE")
                .Member(m => m.CenterName).Name("CENTERNAME")
                .Member(m => m.ProjectName).Name("PROJECTNAME")
                .Member(m => m.CredebNet).Name("CREDEBNET")
                .Member(m => m.EdtCredebNet).Name("EDTCREDEBNET")
                .Member(m => m.EmuCredebNet).Name("EMUCREDEBNET")
                ;
        }
    }
}
