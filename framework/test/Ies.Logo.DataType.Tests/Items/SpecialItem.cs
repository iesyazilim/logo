using System;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.Core;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class SpecialItem : Item
    {
        public static new LogoObjectType XmlRoot => Item.XmlRoot;

        public int CustomField1 { get; set; }

        private string _code;
        public override string Code 
        { 
            get => _code; 
            set 
            {
                if (!value.ToLower().StartsWith("p"))
                    throw new ArgumentException("Malzeme kodu p ile başlamalı");
                _code = value;            
            } 
        }
    }

    public class SpecialItemProfile : IConfigurationProfile
    {
        public static SpecialItemProfile Default { get; } = new SpecialItemProfile();
        private SpecialItemProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SpecialItem>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SpecialItem
        {
            ItemProfile.Configure(typeConfigurations);

            typeConfigurations
                .Member(m => m.Code).Name("MalzemeKodu")
                .Member(m => m.CustomField1).Name("ÖzelALAN")
                ;
        }
    }
}
