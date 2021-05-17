using System;
using System.Globalization;
using System.Reflection;
using ExtendedXmlSerializer.ContentModel.Conversion;

namespace Ies.Logo.DataType.Xml.Converters
{
    public class DateTimeConverter : IConverter<DateTime>
    {
        public static readonly DateTimeConverter Default = new DateTimeConverter();

        public bool IsSatisfiedBy(TypeInfo parameter)
        {
            if (parameter.AsType() == typeof(DateTime))
                return true;
            return false;
        }

        public DateTime Parse(string data) => DateTime.Parse(data); 

        public string Format(DateTime instance)=> instance.ToString("dd.MM.yyyy");
    }
}
