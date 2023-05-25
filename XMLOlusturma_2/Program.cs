using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLOlusturma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> Ogrencilerim = new List<Ogrenci>();

            for (int i = 0; i < 100; i++)
            {
                Ogrenci Temp = new Ogrenci();
                Temp.ID = Guid.NewGuid();
                Temp.Isim = FakeData.NameData.GetFirstName();
                Temp.Soyisim = FakeData.NameData.GetSurname();
                Temp.Numara = FakeData.NumberData.GetNumber(100, 500);

                Ogrencilerim.Add(Temp);
            }

            XDocument Doc = new XDocument(
                new XDeclaration("1.1", "UTF-8", "Yes"),
                new XElement("Öğrencilerim",
                Ogrencilerim.Select(I => new XElement("Öğrenci",
                new XElement("ID", I.ID),
                new XElement("İsim", I.Isim),
                new XElement("Soyisim", I.Soyisim),
                new XElement("Numara", I.Numara)))));

            Doc.Save(@"D:\Udemy\Ogrencilerim.xml");

            List<Ogrenci> OkunanData = new List<Ogrenci>();

            XDocument DocOku = XDocument.Load(@"D:\Udemy\Ogrencilerim.xml");
            List<XElement> OkunanXElement = DocOku.Descendants("Öğrenci").ToList();

            foreach (var item in OkunanXElement)
            {
                Ogrenci Temp = new Ogrenci();
                Temp.ID = Guid.Parse(item.Element("ID").Value);
                Temp.Isim = item.Element("İsim").Value;
                Temp.Soyisim = item.Element("Soyisim").Value;
                Temp.Numara = int.Parse(item.Element("Numara").Value);

                OkunanData.Add(Temp);
            }

            Console.ReadLine();
        }
    }
}
