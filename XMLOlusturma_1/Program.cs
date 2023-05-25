using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLOlusturma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  <? xml version = "1.0" standalone = "yes" ?
                < VeriTabanim >
                < Personellerim >
                < Isim > Daniel </ Isim >
                < Soyisim > Perkins </ Soyisim >
                </ Personellerim >
                </ VeriTabanim >
            */

            XDocument XDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "Yes"),
                new XElement("VeriTabanim",
                new XComment("Personellerin bilgilerini taşır."),
                new XElement("Personellerim", new XAttribute("ID", "102"),
                new XElement("İsim", "Cengiz"),
                new XElement("Soyisim", "Atilla"),
                new XElement("EmailAdres", "cengiz.atilla@hotmail.com"))));
            XDoc.Save(@"D:\Udemy\Ornek1.xml");
        }
    }
}
