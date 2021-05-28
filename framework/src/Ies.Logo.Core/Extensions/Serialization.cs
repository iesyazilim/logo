using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Ies.Logo.Core.Extensions
{
    public static class Serialization
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null) return string.Empty;
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    xmlSerializer.Serialize(xmlWriter, value, ns);
                    return stringWriter.ToString();
                }
            }
        }

        public static T Deserialize<T>(this string xmlText)
        {
            var stringReader = new StringReader(xmlText);
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(stringReader);
        }
    }
}
