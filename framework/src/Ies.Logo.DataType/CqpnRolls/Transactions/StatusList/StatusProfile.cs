using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.CqpnRolls
{
    public class StatusProfile : IConfigurationProfile
    {
        public static StatusProfile Default { get; } = new StatusProfile();

        private StatusProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Status>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Status
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("STATUS");

            typeConfigurations
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Trcode).Name("TRCODE")
                .Member(m => m.Accounted).Name("ACCOUNTED")
                .Member(m => m.Devir).Name("DEVIR")
                .Member(m => m.STATUS).Name("STATUS")
                .Member(m => m.Cardmd).Name("CARDMD")
                .Member(m => m.Statno).Name("STATNO")
                .Member(m => m.Lineno).Name("LINENO")
                .Member(m => m.Fromcash).Name("FROMCASH")
                .Member(m => m.Lineexctyp).Name("LINEEXCTYP")
                .Member(m => m.Opstat).Name("OPSTAT")
                .Member(m => m.Affectcollatrl).Name("AFFECTCOLLATRL")
                .Member(m => m.Affectrisk).Name("AFFECTRISK")
                .Member(m => m.OrgLogoId).Name("ORGLOGOID")
                .Member(m => m.Usegirorate).Name("USEGIRORATE")
                .Member(m => m.Frombank).Name("FROMBANK")
                .Member(m => m.Statstr).Name("STATSTR")
                .Member(m => m.Accstr).Name("ACCSTR")
                .Member(m => m.Fcnr).Name("FCNR")
                .Member(m => m.Fctype).Name("FCTYPE")
                .Member(m => m.Cashflag).Name("CASHFLAG")
                .Member(m => m.BankCode).Name("BANK_CODE")
                .Member(m => m.BankTitle).Name("BANK_TITLE")
                .Member(m => m.BankBranch).Name("BANK_BRANCH")
                .Member(m => m.BankBranchNumber).Name("BANK_BRANCH_NUMBER")
                .Member(m => m.BankAccCode).Name("BANK_ACC_CODE")
                .Member(m => m.BankAccTitle).Name("BANK_ACC_TITLE")
                .Member(m => m.BankAccNumber).Name("BANK_ACC_NUMBER")
                .Member(m => m.BankCreCode).Name("BANK_CRE_CODE")
                ;
        }
    }
}
