using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.QcList
{
    public class ValueProfile : IConfigurationProfile
    {
        public static ValueProfile Default { get; } = new ValueProfile();

        private ValueProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Value>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Value
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("VALUE");

            typeConfigurations
                .Member(m => m.AsgnType).Name("ASGNTYPE")
                .Member(m => m.QcRevNo).Name("QCREVNO")
                .Member(m => m.Qtype).Name("QTYPE")
                .Member(m => m.LineNr).Name("LINENR")
                .Member(m => m.Amount).Name("AMOUNT")
                .Member(m => m.Qvalue).Name("QVALUE")
                .Member(m => m.Confirmed).Name("CONFIRMED")
                .Member(m => m.Qdate).Name("QDATE")
                .Member(m => m.Qcode).Name("QCODE")
                .Member(m => m.Qname).Name("QNAME")
                .Member(m => m.ValCode).Name("VALCODE")
                .Member(m => m.ValName).Name("VALNAME")
                .Member(m => m.NomValue).Name("NOMVALUE")
                .Member(m => m.MinValue).Name("MINVALUE")
                .Member(m => m.MaxValue).Name("MAXVALUE")
                .Member(m => m.Munit).Name("MUNIT")
                .Member(m => m.Qunit).Name("QUNIT")
                .Member(m => m.Frequency).Name("FREQUENCY")
                .Member(m => m.Counter).Name("COUNTER")
                .Member(m => m.SampleSize).Name("SAMPLESIZE")
                ;
        }
    }
}
