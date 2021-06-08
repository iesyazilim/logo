using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using ExtendedXmlSerializer;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Xml
{
    public static class SerializerExtension
    {
        public static XmlWriterSettings XmlWriterSetting => Serializer.XmlWriterSetting;
        public static string Serialize<T>(this T data, bool autoSet = true) where T : ILogoBase
        {
            if (autoSet)
                data.Set();

            if (typeof(T).GetProperty("XmlRoot") == null)
            {
                return new XDocument(new XElement(data.GetRootElementName().ToString(), XDocument.Parse(Serializer.Serialize(data)).Root))
                                   .ToString()
                                   .Insert(0, "<?xml version=\"1.0\" encoding=\"ISO-8859-9\"?>\n");
            }

            return Serializer.Serialize(new List<T> { data });
        }
        public static string Serialize<T>(this List<T> data, bool autoSet = true) where T : ILogoBase
        {
            if (autoSet)
                data.Set();

            if (typeof(T).GetProperty("XmlRoot") == null)
            {
                var doc = XDocument.Parse(Serializer.Serialize(data));
                doc.Root.Name = data.FirstOrDefault().GetRootElementName().ToString();
                return doc.ToString().Insert(0, "<?xml version=\"1.0\" encoding=\"ISO-8859-9\"?>\n");
            }

            return Serializer.Serialize(data);
        }
        public static T Deserialize<T>(this string xml) where T : ILogoBase
        {
            xml = xml.Replace("ISO-8859-9", "utf-8");

            if (typeof(T).GetProperty("XmlRoot") == null)
            {
                var doc = XDocument.Parse(xml);
                return Serializer.Get<T>().Deserialize<T>(doc.Root.FirstNode.ToString());
            }

            return Serializer.Get<T>().Deserialize<List<T>>(xml).FirstOrDefault();
        }
        public static List<T> DeserializeList<T>(this string xml) where T : ILogoBase
        {
            xml = xml.Replace("ISO-8859-9", "utf-8");

            if (typeof(T).GetProperty("XmlRoot") == null)
            {
                var doc = XDocument.Parse(xml);
                doc.Root.Name = "ListOf" + typeof(T).Name;
                xml = doc.ToString();
            }

            return Serializer.Get<T>().Deserialize<List<T>>(xml);
        }
    }
}
