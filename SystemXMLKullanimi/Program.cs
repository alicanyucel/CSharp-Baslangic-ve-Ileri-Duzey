using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SystemXMLKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter XmlText = new XmlTextWriter(@"D:\Udemy\Personellerim.xml", System.Text.Encoding.UTF8);
            XmlText.WriteComment("Xml İşlemleri");
            XmlText.WriteStartElement("Personellerim");

            XmlText.WriteStartElement("Personel");
            XmlText.WriteAttributeString("ID", "1");
            XmlText.WriteElementString("İsim", "Cengiz");
            XmlText.WriteElementString("Soysim", "Atilla");
            XmlText.WriteElementString("Email", "cengizatilla@gmail.com");
            XmlText.WriteEndElement();

            XmlText.WriteStartElement("Personel");
            XmlText.WriteAttributeString("ID", "2");
            XmlText.WriteElementString("İsim", "Efrun");
            XmlText.WriteElementString("Soysim", "Evdi");
            XmlText.WriteElementString("Email", "efruncetkin@gmail.com");
            XmlText.WriteEndElement();

            XmlText.WriteEndElement();
            XmlText.Close();

            XmlReader XRead = XmlReader.Create(@"D:\Udemy\Personellerim.xml");

            while (XRead.Read())
            {
                Console.WriteLine($"{XRead.Name.ToString()} - {XRead.Value.ToString()}");
            }
            Console.Read();
        }
    }
}
