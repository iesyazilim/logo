using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.DemandPeggings
{
    public class DemandPeggingProfile : IConfigurationProfile
    {
        public static DemandPeggingProfile Default { get; } = new DemandPeggingProfile();

        private DemandPeggingProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DemandPegging>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DemandPegging
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DEMAND_PEGGING");

            typeConfigurations
                .Member(m => m.DemandReference).Name("DEMAND_REFERENCE")
                .Member(m => m.DemandSiteid).Name("DEMAND_SITEID")
                .Member(m => m.Parenttype).Name("PARENTTYPE")
                .Member(m => m.ChildType).Name("CHILD_TYPE")
                .Member(m => m.ChildReference).Name("CHILD_REFERENCE")
                .Member(m => m.FicheType).Name("FICHE_TYPE")
                .Member(m => m.ItemAlter).Name("ITEM_ALTER")
                .Member(m => m.MeetAmnt).Name("MEET_AMNT")
                .Member(m => m.MainMeetAmnt).Name("MAIN_MEET_AMNT")
                .Member(m => m.OrdPeriod).Name("ORD_PERIOD")
                .Member(m => m.LineType).Name("LINE_TYPE")
                .Member(m => m.DetLine).Name("DET_LINE")
                .Member(m => m.PrevLineNo).Name("PREV_LINE_NO")
                .Member(m => m.LineNo).Name("LINE_NO")
                .Member(m => m.FicheNo).Name("FICHE_NO")
                .Member(m => m.FicheDate).Name("FICHE_DATE")
                .Member(m => m.ItemCode).Name("ITEM_CODE")
                .Member(m => m.ItemName).Name("ITEM_NAME")
                .Member(m => m.TrAmnt).Name("TR_AMNT")
                .Member(m => m.UEdit).Name("U_EDIT")
                .Member(m => m.BomCode).Name("BOM_CODE")
                .Member(m => m.BomRevCode).Name("BOM_REV_CODE")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.Pegref).Name("PEGREF")
                .Member(m => m.Fcnocghd).Name("FCNOCGHD")
                .Member(m => m.Proposal).Name("PROPOSAL")
                .Member(m => m.WaitAmnt).Name("WAIT_AMNT")
                .Member(m => m.FactoryNr).Name("FACTORY_NR")
                .Member(m => m.Amntconvf).Name("AMNTCONVF")
                .Member(m => m.DoCode).Name("DO_CODE")
                .Member(m => m.ArpName).Name("ARP_NAME")
                .Member(m => m.FicStatus).Name("FIC_STATUS")
                .Member(m => m.MainItemCode).Name("MAIN_ITEM_CODE")
                .Member(m => m.MainItemName).Name("MAIN_ITEM_NAME")
                .Member(m => m.MainUEdit).Name("MAIN_U_EDIT")
                .Member(m => m.Price).Name("PRICE")
                .Member(m => m.PayplanCode).Name("PAYPLAN_CODE")
                .Member(m => m.Projectref).Name("PROJECTREF")
                .Member(m => m.Variantcode).Name("VARIANTCODE")
                .Member(m => m.Variantname).Name("VARIANTNAME")
                ;
        }
    }
}
