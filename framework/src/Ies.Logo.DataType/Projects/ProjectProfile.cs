using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Projects
{
    public class ProjectProfile : IConfigurationProfile
    {
        public static ProjectProfile Default { get; } = new ProjectProfile();

        private ProjectProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Project>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Project
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("PROJECT");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Name).Name("NAME")
                .Member(m => m.Wfstatus).Name("WFSTATUS")
                .Member(m => m.BeginDate).Name("BEGIN_DATE")
                .Member(m => m.EndDate).Name("END_DATE")
                .Member(m => m.ProjRespons).Name("PROJ_RESPONS")
                .Member(m => m.Active).Name("ACTIVE")
                .Member(m => m.RecordStatus).Ignore()
                ;
        }
    }
}
