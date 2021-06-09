using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Qproductions
{
    public class QProductionProfile : IConfigurationProfile
    {
        public static QProductionProfile Default { get; } = new QProductionProfile();

        private QProductionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<QProduction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : QProduction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("QPRODUCTION");

            typeConfigurations
                .Member(m => m.Ficheno).Name("FICHENO")
                .Member(m => m.Orderref).Name("ORDERREF")
                .Member(m => m.Orderfcno).Name("ORDERFCNO")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Ftime).Name("FTIME")
                .Member(m => m.ItemCode).Name("ITEM_CODE")
                .Member(m => m.Uedit).Name("UEDIT")
                .Member(m => m.Uunit).Name("UUNIT")
                .Member(m => m.Amount).Name("AMOUNT")
                .Member(m => m.Prodtype).Name("PRODTYPE")
                .Member(m => m.Lostfactor).Name("LOSTFACTOR")
                .Member(m => m.CalcOption).Name("CALC_OPTION")
                .Member(m => m.Def).Name("DEF")
                .Member(m => m.CreateStfiches).Name("CREATE_STFICHES")
                .Member(m => m.CreatorId).Name("CAPIBLOCK_CREATEDBY")
                .Member(m => m.CreationDate).Name("CAPIBLOCK_CREADEDDATE")
                .Member(m => m.CreationHour).Name("CAPIBLOCK_CREATEDHOUR")
                .Member(m => m.CreationMinute).Name("CAPIBLOCK_CREATEDMIN")
                .Member(m => m.CreationSecond).Name("CAPIBLOCK_CREATEDSEC")
                .Member(m => m.LastModifierId).Name("CAPIBLOCK_MODIFIEDBY")
                .Member(m => m.LastModificationDate).Name("CAPIBLOCK_MODIFIEDDATE")
                .Member(m => m.LastModificationHour).Name("CAPIBLOCK_MODIFIEDHOUR")
                .Member(m => m.LastModificationMinute).Name("CAPIBLOCK_MODIFIEDMIN")
                .Member(m => m.LastModificationSecond).Name("CAPIBLOCK_MODIFIEDSEC")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
