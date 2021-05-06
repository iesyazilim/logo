using System;
using System.Collections.Generic;
using System.Linq;
using IesYazilim.Logo.DataType.Infrastructure;
using IesYazilim.Logo.DataType.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IesYazilim.Logo.DataType.Items
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ItemSerialize()
        {
            string xml = @"<?xml version=""1.0"" encoding=""ISO-8859-9""?>
<ITEMS>
  <ITEM DBOP=""INS"">
    <CODE>P-1</CODE>
    <NAME>Product-1</NAME>
    <CARD_TYPE>1</CARD_TYPE>
    <DATE_CREATED>25.03.2021</DATE_CREATED>
  </ITEM>
</ITEMS>";

            Item item = new Item()
            {
                Dbop = Dbop.INS,
                Code = "P-1",
                Name = "Product-1",
                CardType = ItemCardType.CommercialItem,
                CreationDate = new DateTime(2021, 3, 25)
            };

            var itemXml = item.Serialize();

            Assert.AreEqual(xml.Replace("\r", string.Empty).Replace("\n", " "), itemXml.Replace("\r", string.Empty).Replace("\n", " "));
        }

        [TestMethod]
        public void ItemListSerialize()
        {
            Item item = new Item()
            {
                Dbop = Dbop.INS,
                Code = "P-1",
                Name = "Product-1",
                CreationDate = new DateTime(2021, 3, 25)
            };

            List<Item> items = new List<Item> { item, item };

            var xml = items.Serialize();

            Assert.IsTrue(items.Count > 1);
        }

        [TestMethod]
        public void ItemDeserialize()
        {
            string xml = @"<?xml version=""1.0"" encoding=""ISO-8859-9""?>
<ITEMS>
  <ITEM DBOP=""INS"">
    <CODE>P-1</CODE>
    <NAME>Product-1</NAME>
    <CARD_TYPE>1</CARD_TYPE>
    <RECORD_STATUS>0</RECORD_STATUS>
    <DATE_CREATED>11.03.2021</DATE_CREATED>
  </ITEM>
</ITEMS>";
            var item = xml.Deserialize<Item>();
            string itemXml = item.Serialize();

            Assert.AreEqual(xml.Replace("\r", string.Empty).Replace("\n", " "), itemXml.Replace("\r", string.Empty).Replace("\n", " "));
        }

        [TestMethod]
        public void ItemListDeserialize()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<ITEMS>
  <ITEM DBOP=""INS"">
    <CODE>P-1</CODE>
    <NAME>Product-1</NAME>
    <DATE_CREATED>11.03.2021</DATE_CREATED>
    <RECORD_STATUS>0</RECORD_STATUS>
  </ITEM>
  <ITEM DBOP=""UPD"">
    <CODE>P-2</CODE>
    <NAME>Product-2</NAME>
    <DATE_CREATED>11.03.2021</DATE_CREATED>
    <RECORD_STATUS>0</RECORD_STATUS>
  </ITEM>
</ITEMS>";
            var items = xml.DeserializeList<Item>();

            Assert.IsTrue(items.Any(i => i.Code == "P-2"));
        }
    }
}
