using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.ImpoprFiche
{
    public class ImpoprProfile : IConfigurationProfile
    {
        public static ImpoprProfile Default { get; } = new ImpoprProfile();
        
        private ImpoprProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Impopr>();
            
            Configure(configuration);

            return configuration;
        }

        private void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Impopr
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("EXIMFICHE");


            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.EximLines).Name("EXIMLINES")
                .Member(m => m.PaymentList).Name("PAYMENT_LIST")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Dispatches).Name("DISPATCHES")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.GlPosted).Name("GL_POSTED")
                .Member(m => m.PostFlags).Name("POST_FLAGS")
                .Member(m => m.TotalDiscounted).Name("TOTAL_DISCOUNTED")
                .Member(m => m.TotalGross).Name("TOTAL_GROSS")
                .Member(m => m.TotalNet).Name("TOTAL_NET")
                .Member(m => m.CurrInvoice).Name("CURR_INVOICE")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcNet).Name("TC_NET")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcNet).Name("RC_NET")
                .Member(m => m.PaymentCode).Name("PAYMENT_CODE")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.AccountedCnt).Name("ACCOUNTED_CNT")
                .Member(m => m.EximFicheType).Name("EXIM_FICHE_TYPE")
                .Member(m => m.EximGrpType).Name("EXIM_GRPTYPE")
                .Member(m => m.EximFcType).Name("EXIM_FCTYPE")
                .Member(m => m.EximFileCode).Name("EXIM_FILECODE")
                .Member(m => m.EximFileName).Name("EXIM_FILENAME")
                .Member(m => m.EximCountryType).Name("EXIMINFO_COUNTRYTYPE")
                .Member(m => m.EximCountryCode).Name("EXIM_COUNTRYCODE")
                .Member(m => m.EximCustomDocNo).Name("EXIM_CUSTOMDOCNO")
                .Member(m => m.EximCustomDocDate).Name("EXIM_CUSTOMDOCDATE")
                .Member(m => m.EximFileLineNr).Name("EXIM_FILELINENR")
                .Member(m => m.EximDueDate).Name("EXIM_DUE_DATE")
                .Member(m => m.DeductionPart1).Name("DEDUCTIONPART1")
                .Member(m => m.DeductionPart2).Name("DEDUCTIONPART2")
                .Member(m => m.TotalNetStr).Name("TOTAL_NET_STR")
                .Member(m => m.TrNetStr).Name("TR_NET_STR")
                .Member(m => m.ProfileId).Name("PROFILE_ID")
                .Member(m => m.Estatus).Name("ESTATUS")
                .Member(m => m.DocDate).Name("DOC_DATE")
                ;
        }
    }
}
