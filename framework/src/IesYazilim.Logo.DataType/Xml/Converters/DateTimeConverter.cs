using System;
using System.Globalization;
using System.Reflection;
using ExtendedXmlSerializer.ContentModel.Conversion;

namespace IesYazilim.Logo.DataType.Xml.Converters
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

        public DateTime Parse(string data)=> DateTime.ParseExact(data, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        public string Format(DateTime instance)=> instance.ToString("dd.MM.yyyy");
    }
}
