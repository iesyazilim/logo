using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.CqpnRolls
{
    public class TransactionProfile : IConfigurationProfile
    {
        public static TransactionProfile Default { get; } = new TransactionProfile();

        private TransactionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Transaction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Transaction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("TRANSACTION");

            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.CurrentStatus).Name("CURRENT_STATUS")
                .Member(m => m.BankCode).Name("BANK_CODE")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.SerialNumber).Name("SERIAL_NUMBER")
                .Member(m => m.BankTitle).Name("BANK_TITLE")
                .Member(m => m.City).Name("CITY")
                .Member(m => m.Owing).Name("OWING")
                .Member(m => m.Guarantor).Name("GUARANTOR")
                .Member(m => m.Guarantor2).Name("GUARANTOR2")
                .Member(m => m.Informant).Name("INFORMANT")
                .Member(m => m.DivisionNo).Name("DIVISION_NO")
                .Member(m => m.AccountNo).Name("ACCOUNT_NO")
                .Member(m => m.DueDate).Name("DUE_DATE")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.StampFee).Name("STAMP_FEE")
                .Member(m => m.Amount).Name("AMOUNT")
                .Member(m => m.CurrTrans).Name("CURR_TRANS")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcAmount).Name("TC_AMOUNT")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcAmount).Name("RC_AMOUNT")
                .Member(m => m.CreditFlag).Name("CREDIT_FLAG")
                .Member(m => m.Transferred).Name("TRANSFERRED")
                .Member(m => m.RcXrateColl).Name("RC_XRATE_COLL")
                .Member(m => m.TcXrateColl).Name("TC_XRATE_COLL")
                .Member(m => m.UseRaisedVal).Name("USE_RAISED_VAL")
                .Member(m => m.CurrselTrans).Name("CURRSEL_TRANS")
                .Member(m => m.StampFeeReq).Name("STAMP_FEE_REQ")
                .Member(m => m.TransStatus).Name("TRANS_STATUS")
                .Member(m => m.StatusOrder).Name("STATUS_ORDER")
                .Member(m => m.GlCode1).Name("GL_CODE1")
                .Member(m => m.OhpCode1).Name("OHP_CODE1")
                .Member(m => m.GlCode2).Name("GL_CODE2")
                .Member(m => m.OhpCode2).Name("OHP_CODE2")
                .Member(m => m.OpStatus).Name("OP_STATUS")
                .Member(m => m.SerialNr).Name("SERIAL_NR")
                .Member(m => m.ProjectRef).Name("PROJECTREF")
                .Member(m => m.DataSiteid1).Name("DATA_SITEID1")
                .Member(m => m.DataReference1).Name("DATA_REFERENCE1")
                .Member(m => m.XmlAttribute1).Name("XML_ATTRIBUTE1")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.CollatrlRollref).Name("COLLATRL_ROLLREF")
                .Member(m => m.CollatrlCardref).Name("COLLATRL_CARDREF")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.OrgLogoId).Name("ORGLOGOID")
                .Member(m => m.OrgLogoId1).Name("ORGLOGOID1")
                .Member(m => m.GiroRcXrate).Name("GIRO_RC_XRATE")
                .Member(m => m.GiroTcXrate).Name("GIRO_TC_XRATE")
                .Member(m => m.GiroAmount).Name("GIRO_AMOUNT")
                .Member(m => m.GiroRcAmount).Name("GIRO_RC_AMOUNT")
                .Member(m => m.UseGiroRate).Name("USE_GIRO_RATE")
                .Member(m => m.TaxNr).Name("TAX_NR")
                .Member(m => m.CsIban).Name("CS_IBAN")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.DeptAddress1).Name("DEPT_ADDRESS1")
                .Member(m => m.DeptAddress2).Name("DEPT_ADDRESS2")
                .Member(m => m.DeptCity).Name("DEPT_CITY")
                .Member(m => m.DeptCityCode).Name("DEPT_CITY_CODE")
                .Member(m => m.DeptCountry).Name("DEPT_COUNTRY")
                .Member(m => m.DeptCountryCode).Name("DEPT_COUNTRY_CODE")
                .Member(m => m.DeptPostCode).Name("DEPT_POST_CODE")
                .Member(m => m.DeptTelnr1).Name("DEPT_TELNR1")
                .Member(m => m.DeptTelnr2).Name("DEPT_TELNR2")
                .Member(m => m.DeptFaxnr).Name("DEPT_FAXNR")
                .Member(m => m.DeptTown).Name("DEPT_TOWN")
                .Member(m => m.DeptTownCode).Name("DEPT_TOWN_CODE")
                .Member(m => m.DeptDistrict).Name("DEPT_DISTRICT")
                .Member(m => m.DeptDistrictCode).Name("DEPT_DISTRICT_CODE")
                .Member(m => m.Subduration).Name("SUBDURATION")
                .Member(m => m.Ciro).Name("CIRO")
                .Member(m => m.GlCode3).Name("GL_CODE3")
                .Member(m => m.Claccref).Name("CLACCREF")
                .Member(m => m.OhpCode3).Name("OHP_CODE3")
                .Member(m => m.Clcostref).Name("CLCOSTREF")
                .Member(m => m.OfferReference).Name("OFFER_REFERENCE")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.StatusList).Name("STATUS_LIST")
                ;
        }
    }
}
