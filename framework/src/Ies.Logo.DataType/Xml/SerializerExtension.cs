using ExtendedXmlSerializer;
using Ies.Logo.DataType.BankVouchers;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.ItemCharacteristics;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

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

            var xml = Serializer.Serialize(new List<T> { data });
            return XmlStringHandlingSerialize<T>(xml);
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

            var xml = Serializer.Serialize(data);
            return XmlStringHandlingSerialize<T>(xml);
        }

        public static T Deserialize<T>(this string xml) where T : ILogoBase
        {
            xml = xml.Replace("ISO-8859-9", "utf-8");

            if (typeof(T).GetProperty("XmlRoot") == null)
            {
                var doc = XDocument.Parse(xml);
                return Serializer.Get<T>().Deserialize<T>(doc.Root.FirstNode.ToString());
            }

            xml = XmlStringHandlingDeserialize<T>(xml);

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

        /// <summary>
        /// CHARACTERISTIC_CODES xml'i içindeki VALUES tagının child'ı da VALUES olduğu için hata alıyoruz. Child VALUES'lar VALUE olarak düzeltilip get isteği atılıyor
        /// BankVoucherWithInvoice: BankVoucher içindeki TRANSACTION tagı ile Invoice içindeki TRANSACTION tagı karıştığı için,INVOICE_TRANSACTION olarak düzeltilip get isteği atılıyor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        private static string XmlStringHandlingDeserialize<T>(string xml)
        {
            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(CharacteristicCode))
            {
                var startIndex = xml.IndexOf("<VALUES>") + "<VALUES>".Length;
                var closedIndex = xml.LastIndexOf("</VALUES>");
                var str = xml.Substring(startIndex, closedIndex - startIndex).Replace("<VALUES>", "<VALUE>").Replace("</VALUES>", "</VALUE>");
                xml = string.Concat(xml.Substring(0, startIndex), str, xml.Substring(closedIndex));
            }

            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(BankVoucherWithInvoice))
            {
                var openValue = "<ATTACHMENT_INVOICE>";
                var closeValue = "</ATTACHMENT_INVOICE>";
                var startIndex = xml.IndexOf(openValue) + openValue.Length;
                var closedIndex = xml.LastIndexOf(closeValue);
                var str = xml.Substring(startIndex, closedIndex - startIndex);
                str = str.Replace("<TRANSACTION>", "<INVOICE_TRANSACTION>").Replace("</TRANSACTION>", "</INVOICE_TRANSACTION>");

                xml = string.Concat(xml.Substring(0, startIndex), str, xml.Substring(closedIndex));
            }

            return xml;
        }

        /// <summary>
        /// CHARACTERISTIC_CODES xml'i içindeki VALUES tagının child'ı da VALUES olduğu için hata alıyoruz. Child VALUE'lar VALUES olarak düzeltilip addorupdate isteği atılıyor
        /// BankVoucherWithInvoice: BankVoucher içindeki TRANSACTION tagı ile Invoice içindeki TRANSACTION tagı karıştığı için,INVOICE_TRANSACTION olarak düzeltilip addorupdate isteği atılıyor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="autoSet"></param>
        /// <returns></returns>
        private static string XmlStringHandlingSerialize<T>(string xml)
        {
            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(CharacteristicCode))
                xml = xml.Replace("<VALUE>", "<VALUES>").Replace("</VALUE>", "</VALUES>");

            if (typeof(T).GetProperty("XmlRoot").DeclaringType.Name == nameof(BankVoucherWithInvoice))
                xml = xml.Replace("<INVOICE_TRANSACTION>", "<TRANSACTION>").Replace("</INVOICE_TRANSACTION>", "</TRANSACTION>");

            return xml;
        }
    }
}
