using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ies.Logo.DataType.Invoices
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void InvoiceSerialize()
        {
            string xml = @"<?xml version=""1.0"" encoding=""ISO-8859-9""?>
<PURCHASE_INVOICES>
  <INVOICE DBOP=""INS"">
    <NUMBER>Fiş no</NUMBER>
    <TYPE>1</TYPE>
    <DATE_CREATED>25.03.2021</DATE_CREATED>
  </INVOICE>
</PURCHASE_INVOICES>";

            Invoice invoice = new Invoice()
            {
                Dbop = Dbop.INS,
                Number = "Fiş no",
                Type = InvoiceType.Purchase,
                CreationDate = new DateTime(2021, 3, 25)
            };

            var invoiceXml = invoice.Serialize(false);

            Assert.AreEqual(xml.Replace("\r", string.Empty).Replace("\n", " "), invoiceXml.Replace("\r", string.Empty).Replace("\n", " "));
        }

        [TestMethod]
        public void InvoiceListSerialize()
        {
            Invoice invoice = new Invoice()
            {
                Dbop = Dbop.INS,
                Number = "Fiş no",
                CreationDate = new DateTime(2021, 3, 25)
            };

            List<Invoice> invoices = new List<Invoice> { invoice, invoice };

            var xml = invoices.Serialize();

            Assert.IsTrue(invoices.Count > 1);
        }

        [TestMethod]
        public void InvoiceDeserialize()
        {
            string xml = @"<?xml version=""1.0"" encoding=""ISO-8859-9""?>
<SALES_INVOICES>
  <INVOICE DBOP=""INS"">
    <NUMBER>Fiş no</NUMBER>
    <TYPE>8</TYPE>
    <DATE_CREATED>12.03.2021</DATE_CREATED>
  </INVOICE>
</SALES_INVOICES>";

            var invoice = xml.Deserialize<Invoice>();
            var invoiceXml = invoice.Serialize(false);

            Assert.AreEqual(xml.Replace("\r", string.Empty).Replace("\n", " "), invoiceXml.Replace("\r", string.Empty).Replace("\n", " "));
        }

        [TestMethod]
        public void InvoiceListDeserialize()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<SALES_INVOICES>
  <INVOICE DBOP=""INS"">
    <NUMBER>FIS-01</NUMBER>
    <TYPE>8</TYPE>
    <DATE_CREATED>12.03.2021</DATE_CREATED>
  </INVOICE>
  <INVOICE DBOP=""INS"">
    <NUMBER>FIS-02</NUMBER>
    <TYPE>8</TYPE>
    <DATE_CREATED>12.03.2021</DATE_CREATED>
  </INVOICE>
</SALES_INVOICES>";

            var invoices = xml.DeserializeList<Invoice>();

            Assert.IsTrue(invoices.Any(i => i.Number == "FIS-02"));
        }
    }
}
