using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApplication2
{
    class XMLReader
    {
        public static void LoadFile(string file)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(file);

            var accountingJorunal = xml.DocumentElement.SelectSingleNode("/accounting_journal");
            var accountingEntries = new List<AccountingEntry>();

            foreach(XmlNode element in accountingJorunal.SelectNodes("accounting_entry"))
            {
                var entry = new AccountingEntry()
                {
                    EntryId = Convert.ToInt32(element.SelectSingleNode("entry_id")?.InnerText),
                    Description = element.SelectSingleNode("description")?.InnerText,
                    Date = Convert.ToDateTime(element.SelectSingleNode("date").InnerText),
                    AccountingAccount = element.SelectSingleNode("accounting_account")?.InnerText,
                    AmountOfMovement = Convert.ToDecimal(element.SelectSingleNode("amount_of_movement")?.InnerText),
                    MovementType = element.Attributes["type_of_movement"].InnerText == "DR" ? MovementType.Debit : MovementType.Creidt               
                };

                accountingEntries.Add(entry);
            }

            var db = new Practice3Db();
            db.AccountingEntries.AddRange(accountingEntries);
            db.SaveChanges();
        }

        public static void WriteFile(string path)
        {
            var db = new Practice3Db();
            XmlDocument xml = new XmlDocument();

            XmlDeclaration xmlDeclaration = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xml.DocumentElement;
            xml.InsertBefore(xmlDeclaration, root);

            var accountingJournal = xml.CreateElement("accounting_journal");
            xml.AppendChild(accountingJournal);

            var accountingEntries = db.AccountingEntries.ToList();

            foreach(var entry in accountingEntries)
            {
                XmlElement entryElement = xml.CreateElement("accounting_entry");
                entryElement.AppendChild(CreateXMLElement(xml, "entry_id", entry.EntryId));
                entryElement.AppendChild(CreateXMLElement(xml, "description", entry.Description));
                entryElement.AppendChild(CreateXMLElement(xml, "date", entry.Date.ToString("yyyy-MM-dd")));
                entryElement.AppendChild(CreateXMLElement(xml, "accounting_account", entry.AccountingAccount));
                entryElement.AppendChild(CreateXMLElement(xml, "amount_of_movement", entry.AmountOfMovement.ToString("0.00")));
                entryElement.SetAttribute("type_of_movement", entry.MovementType == MovementType.Creidt ? "CR" : "DB");

                accountingJournal.AppendChild(entryElement);
            }
            xml.Save(path);
        }

        private static XmlElement CreateXMLElement(XmlDocument xml, string elementName, object elementContent)
        {
            var element = xml.CreateElement(elementName);
            element.InnerText = elementContent.ToString();
            return element;
        }
    }
}