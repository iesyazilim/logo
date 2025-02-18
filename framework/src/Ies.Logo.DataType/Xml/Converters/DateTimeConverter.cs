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

        public DateTime Parse(string data) 
        {
            if (DateTime.TryParseExact(data.Replace("/", "."), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
                return dt;
            else return new DateTime();
        }

        public string Format(DateTime instance) => instance.ToString("dd.MM.yyyy");
    }
}
