using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using ExtendedXmlSerializer;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.ItemCharacteristics;

namespace Ies.Logo.DataType.Xml
{
    public static class SerializerExtension
    {
        public static XmlWriterSettings XmlWriterSetting => Serializer.XmlWriterSetting;
        public static void EnableEagerLoading() => Serializer.Serializers = Serializer.CreateSerializers();

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


            /*
             * CHARACTERISTIC_CODES xml'i içindeki VALUES tagının child'ı da VALUES olduğu için hata alıyoruz.
             * Child VALUE'lar VALUES olarak düzeltilip addorupdate isteği atılıyor
             */
            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(CharacteristicCode))
                return Serializer.Serialize(new List<T> { data }).Replace("<VALUE>", "<VALUES>").Replace("</VALUE>", "</VALUES>");

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


            /*
             * CHARACTERISTIC_CODES xml'i içindeki VALUES tagının child'ı da VALUES olduğu için hata alıyoruz.
             * Child VALUE'lar VALUES olarak düzeltilip addorupdate isteği atılıyor
             */
            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(CharacteristicCode))
                return Serializer.Serialize(data).Replace("<VALUE>", "<VALUES>").Replace("</VALUE>", "</VALUES>");

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

            /*
             * CHARACTERISTIC_CODES xml'i içindeki VALUES tagının child'ı da VALUES olduğu için hata alıyoruz.
             * Child VALUES'lar VALUE olarak düzeltilip get isteği atılıyor
             */
            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(CharacteristicCode))
            {
                var startIndex = xml.IndexOf("<VALUES>") + "<VALUES>".Length;
                var closedIndex = xml.LastIndexOf("</VALUES>");
                var str = xml.Substring(startIndex, closedIndex - startIndex).Replace("<VALUES>", "<VALUE>").Replace("</VALUES>", "</VALUE>");
                xml = string.Concat(xml.Substring(0, startIndex), str, xml.Substring(closedIndex));
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
